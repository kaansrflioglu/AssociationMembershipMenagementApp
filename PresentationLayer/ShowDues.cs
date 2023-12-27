using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ShowDues : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccessLayer;
        private BusinessLayer.BusinessLayer businessLayer;
        private string _memberID;
        

        public string MemberID
        {
            get { return _memberID; }
            set { _memberID = value; }
        }

        public ShowDues()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
            businessLayer = new BusinessLayer.BusinessLayer();
        }

        private void ShowDues_Load(object sender, EventArgs e)
        {
            cbx_month.Items.AddRange(BusinessLayer.BusinessLayer.months);
            cbx_month.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_year.Items.AddRange(BusinessLayer.BusinessLayer.years);
            cbx_year.DropDownStyle = ComboBoxStyle.DropDownList;

            string query = businessLayer.ShowDues(MemberID);
            dg_showdues.DataSource = dataAccessLayer.ExecuteQuery(query);
            dg_showdues.Columns["AidatID"].Visible = false;

            dg_showdues.SelectionChanged += dg_showdues_SelectionChanged;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string date = cbx_year.Text + " " + cbx_month.Text;
            string fee = txt_fee.Text;
            string status = (radio_paid.Checked) ? "Ödendi" : "Ödenmedi";
            string query = businessLayer.AddDues(MemberID, date, fee, status);
            int affectedRows = dataAccessLayer.ExecuteNonQuery(query);
            if (affectedRows > 0)
            {
                MessageBox.Show("Ödeme eklendi!");
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Ödeme eklenirken bir hata oluştu!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_showdues.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dg_showdues.SelectedRows[0].Index;
                string DuesID = dg_showdues.Rows[selectedRowIndex].Cells["AidatID"].Value.ToString();
                string query1 = businessLayer.DeleteDuesID(DuesID);
                dataAccessLayer.ExecuteNonQuery(query1);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }

        private void RefreshDataGridView()
        {
            string query = businessLayer.ShowDues(MemberID);
            dg_showdues.DataSource = dataAccessLayer.ExecuteQuery(query);
        }

        private void dg_showdues_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_showdues.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dg_showdues.SelectedRows[0].Index;
                string selectedDateValue = dg_showdues.Rows[selectedRowIndex].Cells["AyYil"].Value.ToString();
                string selectedFee = dg_showdues.Rows[selectedRowIndex].Cells["AidatTutari"].Value.ToString();
                string selectedStatus = dg_showdues.Rows[selectedRowIndex].Cells["OdemeDurum"].Value.ToString();
                string[] dateParts = selectedDateValue.Split(' ');
                string selectedYear = dateParts[0];
                string selectedMonth = dateParts[1];
                cbx_month.SelectedItem = selectedMonth;
                cbx_year.SelectedItem = selectedYear;
                txt_fee.Text = selectedFee;
                if (selectedStatus == "Ödendi")
                {
                    radio_paid.Checked = true;
                    radio_notpaid.Checked = false;
                }
                else
                {
                    radio_paid.Checked = false;
                    radio_notpaid.Checked = true;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dg_showdues.SelectedRows[0].Index;
            string DuesID = dg_showdues.Rows[selectedRowIndex].Cells["AidatID"].Value.ToString();
            string date = cbx_year.Text + " " + cbx_month.Text;
            string fee = txt_fee.Text;
            string status = (radio_paid.Checked) ? "Ödendi" : "Ödenmedi";
            string query = businessLayer.UpdateDuesID(DuesID,date,fee,status);
            int affectedRows = dataAccessLayer.ExecuteNonQuery(query);
            if (affectedRows > 0)
            {
                MessageBox.Show("Ödeme güncellendi!");
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Ödeme güncellenirken bir hata oluştu!");
            }
        }
    }
}
