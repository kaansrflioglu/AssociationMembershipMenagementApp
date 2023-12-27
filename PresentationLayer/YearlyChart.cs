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
    public partial class YearlyChart : Form
    {
        private readonly DataAccessLayer.DataAccessLayer dataAccessLayer;
        public YearlyChart()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
        }

        private void DrawYearlyGraph()
        {
            try
            {
                string query = $"SELECT LEFT(AyYil, 4) AS Yıl, SUM(AidatTutari) AS Miktar FROM Aidatlar " +
                    $"GROUP BY LEFT(AyYil, 4) ORDER BY LEFT(AyYil, 4);";
                DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
                GraphPane graphPane = zedGraphControl1.GraphPane;
                graphPane.CurveList.Clear();
                graphPane.GraphObjList.Clear();
                BarItem bar = graphPane.AddBar("Aidatlar", null, dataTable.AsEnumerable().Select(row => Convert.ToDouble(row["Miktar"])).ToArray(), System.Drawing.Color.Blue);
                bar.Bar.Fill = new Fill(Color.Blue);
                bar.Bar.Fill.Type = FillType.Solid;
                string[] labels = dataTable.AsEnumerable().Select(row => row["Yıl"].ToString()).ToArray();
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

        private void YearlyChart_Load(object sender, EventArgs e)
        {
            DrawYearlyGraph();
            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.Title.Text = "Yıllık Aidat Gelirleri";
            graphPane.XAxis.Title.Text = "Miktar";
            graphPane.YAxis.Title.Text = "Yıllar";
        }
    }
}
