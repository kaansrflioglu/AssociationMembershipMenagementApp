using System;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using DataAccessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer
{
    public partial class ListMembers : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccessLayer;
        private BusinessLayer.BusinessLayer businessLayer;
        ShowDues showDues = new ShowDues();
        UpdateMember updateMember = new UpdateMember();
        SendCustomMail sendMail = new SendCustomMail();
        public ListMembers()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
            businessLayer = new BusinessLayer.BusinessLayer();
            sendMail = new SendCustomMail();
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            string query;
            string tc = txt_tc.Text;
            string city = cbx_city.Text;
            string bloodType = cbx_bloodType.Text;
            string status = "";
            string gender = "";
            if (radio_active.Checked) { status = "Aktif"; }
            if (radio_passive.Checked) { status = "Pasif"; }
            if (radio_male.Checked) { gender = "Erkek"; }
            if (radio_female.Checked) { gender = "Kadın"; }
            query = businessLayer.ListMember(tc, bloodType, city, status, gender);
            dg_members.DataSource = dataAccessLayer.ExecuteQuery(query);
        }
        private void ListMembers_Load(object sender, EventArgs e)
        {
            string query = businessLayer.LoadMembers();
            dg_members.DataSource = dataAccessLayer.ExecuteQuery(query);
            cbx_bloodType.Items.AddRange(BusinessLayer.BusinessLayer.bloodTypes);
            cbx_city.Items.AddRange(BusinessLayer.BusinessLayer.cities);
            cbx_bloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_city.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_members.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dg_members.SelectedRows[0].Index;
                string memberID = dg_members.Rows[selectedRowIndex].Cells["TCKimlik"].Value.ToString();
                DialogResult result = MessageBox.Show("Seçilen üyeyi silmek istediğinizden emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query2 = businessLayer.DeleteDues(memberID);
                    string query1 = businessLayer.DeleteMember(memberID);
                    dataAccessLayer.ExecuteNonQuery(query2);
                    dataAccessLayer.ExecuteNonQuery(query1);
                    string query = businessLayer.LoadMembers();
                    dg_members.DataSource = dataAccessLayer.ExecuteQuery(query);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }
        private void btn_dueslist_Click(object sender, EventArgs e)
        {
            if (dg_members.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dg_members.SelectedRows[0].Index;
                string memberID = dg_members.Rows[selectedRowIndex].Cells["TCKimlik"].Value.ToString();
                showDues.MemberID = memberID;
                showDues.FormClosed += (s, args) =>
                {
                    showDues = new ShowDues();
                    this.Show();
                };
                showDues.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dg_members.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dg_members.SelectedRows[0].Index;
                string memberID = dg_members.Rows[selectedRowIndex].Cells["TCKimlik"].Value.ToString();
                updateMember.MemberIDToUpdate = memberID;
                updateMember.MemberUpdated += UpdateMemberForm_MemberUpdated;
                updateMember.FormClosed += (s, args) =>
                {
                    updateMember = new UpdateMember();
                    this.Show();
                };
                //this.Hide();
                updateMember.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }
        private void UpdateMemberForm_MemberUpdated(object sender, EventArgs e)
        {
            string query = businessLayer.LoadMembers();
            dg_members.DataSource = dataAccessLayer.ExecuteQuery(query);
        }

        private void dg_members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dg_members.Rows[e.RowIndex];

                string tc = selectedRow.Cells["TCKimlik"].Value.ToString();
                string city = selectedRow.Cells["Sehir"].Value.ToString();
                string bloodType = selectedRow.Cells["KanGrubu"].Value.ToString();
                string status = selectedRow.Cells["UyeDurumu"].Value.ToString();
                string gender = selectedRow.Cells["Cinsiyet"].Value.ToString();

                txt_tc.Text = tc;
                cbx_city.Text = city;
                cbx_bloodType.Text = bloodType;

                if (status == "Aktif")
                    radio_active.Checked = true;
                else
                    radio_passive.Checked = true;

                if (gender == "Erkek")
                    radio_male.Checked = true;
                else
                    radio_female.Checked = true;
            }
        }

        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            string query = businessLayer.LoadMembers();
            dg_members.DataSource = dataAccessLayer.ExecuteQuery(query);
            txt_tc.Text = "";
            cbx_bloodType.SelectedIndex = -1;
            cbx_city.SelectedIndex = -1;
            radio_active.Checked = false;
            radio_passive.Checked = false;
            radio_male.Checked = false;
            radio_female.Checked = false;
        }

        private void btn_sendmail_Click(object sender, EventArgs e)
        {
            if (dg_members.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dg_members.SelectedRows[0].Index;
                string email = dg_members.Rows[selectedRowIndex].Cells["EpostaAdresi"].Value.ToString();
                string name = dg_members.Rows[selectedRowIndex].Cells["Ad"].Value.ToString();
                string surname = dg_members.Rows[selectedRowIndex].Cells["Soyad"].Value.ToString();
                string tc = dg_members.Rows[selectedRowIndex].Cells["TCKimlik"].Value.ToString();
                sendMail.MailAddress = email;
                sendMail.Name = name;
                sendMail.Surname = surname;
                sendMail.TC = tc;
                sendMail.FormClosed += (s, args) =>
                {
                    sendMail = new SendCustomMail();
                    this.Show();
                };
                //this.Hide();
                sendMail.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }
    }
}