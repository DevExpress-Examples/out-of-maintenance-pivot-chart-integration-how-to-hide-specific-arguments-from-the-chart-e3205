Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()

			chartControl1.SeriesTemplate.DataFilters.Add("Arguments", GetType(String).Name, DataFilterCondition.NotEqual, hideThisArgument)
		End Sub


		Private hideThisArgument As String = "HideThisArgument"
		Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventArgs) Handles pivotGridControl1.CustomChartDataSourceData
			If e.ItemDataMember = DevExpress.XtraPivotGrid.PivotChartItemDataMember.Argument AndAlso e.FieldValueInfo IsNot Nothing Then
				If (Not ShouldChartCurrentArgument(e.FieldValueInfo)) Then
					e.Value = hideThisArgument
				End If
			End If
		End Sub

		Private Function ShouldChartCurrentArgument(ByVal valueInfo As DevExpress.XtraPivotGrid.PivotFieldValueEventArgs) As Boolean
			If Equals(valueInfo.DataField, fieldValueP) Then
				Return False
			End If
			Return True
		End Function

		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today, 7 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(1), 4 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today, 12 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1), 14 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today, 11 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1), 10 })

			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1), 4 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddYears(1), 3 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddYears(1), 8 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 })
		End Sub

	End Class
End Namespace