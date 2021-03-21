﻿function GeneratePieChart(pieChartData){
    am4core.useTheme(am4themes_animated);
    var chart = am4core.create("chartdiv", am4charts.PieChart3D);
    chart.hiddenState.properties.opacity = 0;
    chart.legend = new am4charts.Legend();

    chart.data = pieChartData;

    var series = chart.series.push(new am4charts.PieSeries3D());
    series.dataFields.value = "totalPercentage";
    series.dataFields.category = "hairColor";
    
}