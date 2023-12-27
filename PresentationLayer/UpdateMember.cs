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
using static System.Windows.Forms.DataFormats;

namespace PresentationLayer
{
    public partial class UpdateMember : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccessLayer;
        private BusinessLayer.BusinessLayer businessLayer;
        public event EventHandler MemberUpdated;
        public string MemberIDToUpdate { get; set; }
        string[] bloodTypes = BusinessLayer.BusinessLayer.bloodTypes;
        string[] cities = BusinessLayer.BusinessLayer.cities;

        public UpdateMember()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
            businessLayer = new BusinessLayer.BusinessLayer();
            this.Load += UpdateMember_Load;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            if (!string.IsNullOrEmpty(MemberIDToUpdate))
            {
                string query = $"SELECT * FROM Uyeler WHERE TCKimlik = '{MemberIDToUpdate}'";
                DataTable memberData = dataAccessLayer.ExecuteQuery(query);

                if (memberData.Rows.Count > 0)
                {
                    txt_tc.Text = memberData.Rows[0]["TCKimlik"].ToString();
                    txt_name.Text = memberData.Rows[0]["Ad"].ToString();
                    txt_surname.Text = memberData.Rows[0]["Soyad"].ToString();

                    if (DateTime.TryParse(memberData.Rows[0]["DogumTarihi"].ToString(), out DateTime birthTime))
                    {
                        dtp_birthTime.Value = birthTime;
                    }
                    else
                    {
                        dtp_birthTime.Value = DateTime.Now;
                        MessageBox.Show("Geçersiz tarih formatı!");
                    }
                    string bloodType = memberData.Rows[0]["KanGrubu"].ToString();
                    cbx_bloodType.SelectedItem = bloodType;
                    string gender = memberData.Rows[0]["Cinsiyet"].ToString();
                    if (gender == "Erkek")
                    {
                        radio_active.Checked = true;
                    }
                    else if (gender == "Kadın")
                    {
                        radio_passive.Checked = true;
                    }
                    string city = memberData.Rows[0]["Sehir"].ToString();
                    cbx_city.SelectedItem = city;
                    txt_address.Text = memberData.Rows[0]["Adres"].ToString();
                    txt_tel.Text = memberData.Rows[0]["TelefonNumarasi"].ToString();
                    txt_email.Text = memberData.Rows[0]["EpostaAdresi"].ToString();
                    string status = memberData.Rows[0]["UyeDurumu"].ToString();
                }

            }

            cbx_bloodType.Items.AddRange(BusinessLayer.BusinessLayer.bloodTypes);
            cbx_city.Items.AddRange(BusinessLayer.BusinessLayer.cities);
            cbx_bloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_city.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tc.Text) ||
                string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_surname.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(cbx_city.Text) ||
                string.IsNullOrWhiteSpace(cbx_bloodType.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text) ||
                string.IsNullOrWhiteSpace(txt_tel.Text) ||
                (!radio_active.Checked && !radio_passive.Checked))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            if (txt_tel.TextLength != 10)
            {
                MessageBox.Show("Telefon Numarası 10 haneden oluşmak zorundadır!");
                return;
            }
            string tc = txt_tc.Text;
            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string email = txt_email.Text;
            string status = (radio_active.Checked) ? "Aktif" : "Pasif";
            string city = cbx_city.Text;
            DateTime birthTime = dtp_birthTime.Value;
            string bloodType = cbx_bloodType.Text;
            string address = txt_address.Text;
            string tel = txt_tel.Text;


            string query = businessLayer.UpdateMember(tc, name, surname, birthTime, bloodType,
                city, address, tel, email, status);

            int affectedRows = dataAccessLayer.ExecuteNonQuery(query);

            if (affectedRows > 0)
            {
                MessageBox.Show("Üye güncellendi!");
                MemberUpdated?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Üye güncellenirken bir hata oluştu!");
            }
        }

        private void txt_tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txt_tel.Text.Length > 0)
                {
                    int selectionStart = txt_tel.SelectionStart;

                    if (selectionStart > 0)
                    {
                        txt_tel.Text = txt_tel.Text.Remove(selectionStart - 1, 1);
                        txt_tel.SelectionStart = selectionStart - 1;
                    }
                }
                e.Handled = true;
            }
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || txt_tel.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }
    }
}
