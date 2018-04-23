using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();

            chartControl1.SeriesTemplate.DataFilters.Add("Arguments", typeof(string).Name, DataFilterCondition.NotEqual, hideThisArgument);
        }


        string hideThisArgument = "HideThisArgument";
        private void pivotGridControl1_CustomChartDataSourceData(object sender, DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventArgs e)
        {
            if (e.ItemDataMember == DevExpress.XtraPivotGrid.PivotChartItemDataMember.Argument && e.FieldValueInfo != null)
            {
                if (!ShouldChartCurrentArgument(e.FieldValueInfo))
                    e.Value = hideThisArgument;
            }
        }

        private bool ShouldChartCurrentArgument(DevExpress.XtraPivotGrid.PivotFieldValueEventArgs valueInfo)
        {
            if (Equals(valueInfo.DataField, fieldValueP))
                return false;
            return true;
        }

        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today, 7 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 4 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 12 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 14 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 11 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 10 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 4 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 3 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), 8 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 });
        }
       
    }
}