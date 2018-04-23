# Pivot Chart Integration - How to hide specific arguments from the chart


<p><strong>Update:</strong></p><p>Starting from version 12.1, it is possible to hide unnecessary points by removing corresponding rows from the chart datasource via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CustomChartDataSourceRowstopic"><u>CustomChartDataSourceRows</u></a><u> </u>event.</p><p></p><p>This example demonstrates how to hide unnecessary arguments from a chart. It is necessary to replace automatically generated arguments corresponding to the unnecessary data to some dummy string ( "HideMe" ). You can use the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CustomChartDataSourceDatatopic"><u>PivotGridControl.CustomChartDataSourceData</u></a> event to customize the data source. To hide this unnecessary argument please use the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsSeriesBase_DataFilterstopic"><u>SeriesBase.DataFilters</u></a> property of the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsChartControl_SeriesTemplatetopic"><u>ChartControl.SeriesTemplate </u></a></p><para><code lang="cs"> <br />
ChartControl.SeriesTemplate.DataFilters.Add("Arguments", typeof(string).Name, DataFilterCondition.NotEqual, "HideMe");

<br/>


