using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace PresentationLayer
{

    public partial class MonthlyChart : Form
    {
        private readonly DataAccessLayer.DataAccessLayer dataAccessLayer;
        public MonthlyChart()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
        }

        private void DrawMonthlyGraph(string year)
        {
            try
            {
                string query = $"SELECT Mid([AyYil], 5) AS Ay, SUM(AidatTutari) AS Miktar FROM Aidatlar WHERE " +
                    $"AyYil Like '%{year}%' GROUP BY Mid([AyYil], 5) ORDER BY Mid([AyYil], 5);";
                DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
                GraphPane graphPane = zedGraphControl1.GraphPane;
                graphPane.CurveList.Clear();
                graphPane.GraphObjList.Clear();
                graphPane.Title.Text = $"{year} Yılı Aylık Aidat Gelirleri";
                graphPane.XAxis.Title.Text = "Aylar";
                graphPane.YAxis.Title.Text = "Toplam Aidat Tutarı";
                BarItem bar = graphPane.AddBar("Aidatlar", null, dataTable.AsEnumerable().Select(row => Convert.ToDouble(row["Miktar"])).ToArray(), System.Drawing.Color.Blue);
                bar.Bar.Fill = new Fill(Color.Blue);
                bar.Bar.Fill.Type = FillType.Solid;
                string[] labels = dataTable.AsEnumerable().Select(row => row["Ay"].ToString()).ToArray();
                graphPane.XAxis.Scale.TextLabels = labels;
                graphPane.XAxis.Type = AxisType.Text;
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_month_Click(object sender, EventArgs e)
        {
            DrawMonthlyGraph(cbx_year.Text);
        }

        private void MonthlyChart_Load(object sender, EventArgs e)
        {
            cbx_year.Items.AddRange(BusinessLayer.BusinessLayer.years);
            cbx_year.DropDownStyle = ComboBoxStyle.DropDownList;
            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.Title.Text = $"Aylık Aidat Gelirleri";
            graphPane.XAxis.Title.Text = "Aylar";
            graphPane.YAxis.Title.Text = "Toplam Aidat Tutarı";
        }
    }
}
