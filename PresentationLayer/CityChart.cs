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
    public partial class CityChart : Form
    {
        private readonly DataAccessLayer.DataAccessLayer dataAccessLayer;
        public CityChart()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
        }
        private void DrawCityGraph()
        {
            try
            {
                string query = "SELECT Sehir AS Şehir, COUNT(Sehir) AS Miktar FROM Uyeler GROUP BY Sehir;";
                DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
                GraphPane graphPane = zedGraphControl1.GraphPane;
                graphPane.CurveList.Clear();
                graphPane.GraphObjList.Clear();
                BarItem bar = graphPane.AddBar("Uyeler", null, dataTable.AsEnumerable().Select(row => Convert.ToDouble(row["Miktar"])).ToArray(), System.Drawing.Color.Blue);
                bar.Bar.Fill = new Fill(Color.Blue);
                bar.Bar.Fill.Type = FillType.Solid;
                string[] labels = dataTable.AsEnumerable().Select(row => row["Şehir"].ToString()).ToArray();
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
        private void CityChart_Load(object sender, EventArgs e)
        {
            DrawCityGraph();
            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.Title.Text = "Üyelerin Şehirlere Göre Dağılımı";
            graphPane.XAxis.Title.Text = "Şehir İsmi";
            graphPane.YAxis.Title.Text = "Kullanıcı Sayısı";
        }
    }
}
