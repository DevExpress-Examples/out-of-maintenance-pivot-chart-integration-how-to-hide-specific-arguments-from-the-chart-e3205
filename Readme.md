<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579718/10.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3205)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->
# Pivot Chart Integration - How to hide specific arguments from the chart


<p><strong>Update:</strong></p><p>Starting from version 12.1, it is possible to hide unnecessary points by removing corresponding rows from the chart datasource via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CustomChartDataSourceRowstopic"><u>CustomChartDataSourceRows</u></a><u> </u>event.</p><p></p><p>This example demonstrates how to hide unnecessary arguments from a chart. It is necessary to replace automatically generated arguments corresponding to the unnecessary data to some dummy string ( "HideMe" ). You can use the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CustomChartDataSourceDatatopic"><u>PivotGridControl.CustomChartDataSourceData</u></a> event to customize the data source. To hide this unnecessary argument please use the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsSeriesBase_DataFilterstopic"><u>SeriesBase.DataFilters</u></a> property of the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsChartControl_SeriesTemplatetopic"><u>ChartControl.SeriesTemplate </u></a></p><para><code lang="cs"> <br />
ChartControl.SeriesTemplate.DataFilters.Add("Arguments", typeof(string).Name, DataFilterCondition.NotEqual, "HideMe");

<br/>


