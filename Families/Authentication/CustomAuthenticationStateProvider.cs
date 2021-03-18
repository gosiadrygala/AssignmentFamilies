﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Families;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using Models;


namespace WebFamilies_Assignment.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime jsRuntime;
        private readonly InterfaceUserService userService;

        private User cachedUser;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, InterfaceUserService userService)
        {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (cachedUser == null)
            {
                string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    User tmp = JsonSerializer.Deserialize<User>(userAsJson);
                    ValidateLogin(tmp.Username, tmp.Password);
                }
                
            }
            else
            {
                identity = SetupClaimsForUser(cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }

        public void ValidateLogin(string username, string password)
        {
            Console.WriteLine("Validating log in...");
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Enter username");

            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                User user = userService.ValidateUserLogin(username, password);
                identity = SetupClaimsForUser(user);
                string serialisedData = JsonSerializer.Serialize(user);
                jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                cachedUser = user;
            }
            catch (Exception e)
            {
                throw e;
            }
            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));

        }

        public void Logout()
        {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            claims.Add(new Claim("BirthYear", user.BirthYear.ToString()));
            claims.Add(new Claim("Role", user.Role));
            claims.Add(new Claim("SecurityLevel", user.SecurityLevel.ToString()));

            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}