using System.Data;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using BusinessLayer;


namespace PresentationLayer
{
    public partial class ShowPayments : Form
    {
        private BusinessLayer.BusinessLayer businessLayer;
        private DataAccessLayer.DataAccessLayer dataAccessLayer;

        public ShowPayments()
        {
            InitializeComponent();
            businessLayer = new BusinessLayer.BusinessLayer();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
        }
        private void cbox_date_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbox_date.Checked)
            {
                txt_end.Enabled = false;
                txt_start.Enabled = false;
            }
            else
            {
                txt_end.Enabled = true;
                txt_start.Enabled = true;
            }
        }
        private void ShowDebt_Load(object sender, EventArgs e)
        {
            txt_end.Enabled = false;
            txt_start.Enabled = false;
            string query = businessLayer.ShowPayments();
            DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
            dg_debt.DataSource = dataTable;
        }
        private void btn_sendmail_Click(object sender, EventArgs e)
        {
            // E-posta adreslerini al ve güncelle
            List<string> emailAddresses = new List<string>();
            foreach (DataGridViewRow row in dg_debt.Rows)
            {
                string emailAddress = row.Cells["EpostaAdresi"].Value.ToString();
                if (!emailAddresses.Contains(emailAddress))
                {
                    emailAddresses.Add(emailAddress);
                }
            }

            SendDebtMail sendDebtMail = new SendDebtMail();
            sendDebtMail.UpdateRecipients(emailAddresses);
            sendDebtMail.Show();
        }
        private void btn_printPDF_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {

                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dg_debt.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dg_debt.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dg_debt.Rows)
                {
                    foreach (DataGridViewCell cell in satir.Cells)
                    {
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font(bf)));
                    }
                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                    {

                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTablosu);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        public string ListPaidMonth(string startMonth, string endMonth)
        {
            DateTime startDate, endDate;
            DateTime.TryParse(startMonth, out startDate);
            DateTime.TryParse(endMonth, out endDate);

            string result = businessLayer.ShowPaidMonths();

            while (startDate <= endDate)
            {
                result += $" '{startDate.ToString("yyyy MMMM")}',";
                startDate = startDate.AddMonths(1);
            }

            result += ")";
            return result;
        }
        public string ListDebtMonth(string startMonth, string endMonth)
        {
            DateTime startDate, endDate;
            DateTime.TryParse(startMonth, out startDate);
            DateTime.TryParse(endMonth, out endDate);

            string result = businessLayer.ShowDebtMonths();

            if (startDate <= endDate)
            {
                while (startDate <= endDate)
                {
                    result += $" '{startDate.ToString("yyyy MMMM")}',";
                    startDate = startDate.AddMonths(1);
                }
            }

            result += ")";
            return result;
        }
        private void btn_filter_Click(object sender, EventArgs e)
        {
            if (cbox_paid.Checked && cbox_date.Checked)
            {
                string query = ListPaidMonth(txt_start.Text, txt_end.Text);
                DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
                dg_debt.DataSource = dataTable;
            }

            if (cbox_paid.Checked && !cbox_date.Checked)
            {
                string query = businessLayer.ShowPaid();
                DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
                dg_debt.DataSource = dataTable;
            }

            if (!cbox_paid.Checked && cbox_date.Checked)
            {
                string query = ListDebtMonth(txt_start.Text, txt_end.Text);
                DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
                dg_debt.DataSource = dataTable;
            }
            if (!cbox_paid.Checked && !cbox_date.Checked)
            {
                string query = businessLayer.ShowDebt();
                DataTable dataTable = dataAccessLayer.ExecuteQuery(query);
                dg_debt.DataSource = dataTable;
            }
        }


        private void btn_graphsMonthly_Click(object sender, EventArgs e)
        {
            MonthlyChart monthlyChart = new MonthlyChart();
            monthlyChart.Show();
        }

        private void btn_graphsYearly_Click(object sender, EventArgs e)
        {
            YearlyChart yearlyChart = new YearlyChart();
            yearlyChart.Show();
        }

        private void btn_graphCity_Click(object sender, EventArgs e)
        {
            CityChart cityChart = new CityChart();
            cityChart.Show();
        }
    }
}

