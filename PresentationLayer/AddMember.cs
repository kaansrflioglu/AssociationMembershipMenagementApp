using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{

    public partial class AddMember : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccessLayer;
        private BusinessLayer.BusinessLayer businessLayer;

        public AddMember()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
            businessLayer = new BusinessLayer.BusinessLayer();
        }



        private void Clear()
        {
            txt_tc.Clear();
            txt_name.Clear();
            txt_surname.Clear();
            radio_male.Checked = false;
            radio_female.Checked = false;
            cbx_city.SelectedIndex = -1;
            dtp_birthTime.Value = DateTime.Now;
            txt_address.Clear();
            txt_tel.Clear();
            cbx_bloodType.SelectedIndex = -1;
            txt_email.Clear();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tc.Text) ||
                string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_surname.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(cbx_city.Text) ||
                string.IsNullOrWhiteSpace(cbx_bloodType.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text) ||
                string.IsNullOrWhiteSpace(txt_tel.Text) ||
                (!radio_male.Checked && !radio_female.Checked))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (txt_tc.TextLength != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneden oluşmak zorundadır!");
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
            string gender = (radio_male.Checked) ? "Erkek" : "Kadın";
            string city = cbx_city.Text;
            DateTime birthTime = dtp_birthTime.Value;
            string bloodType = cbx_bloodType.Text;
            string address = txt_address.Text;
            string tel = txt_tel.Text;

            string query = businessLayer.AddMember(tc, name, surname, birthTime, bloodType, gender, city, address, tel,
                email);

            int affectedRows = dataAccessLayer.ExecuteNonQuery(query);

            if (affectedRows > 0)
            {
                MessageBox.Show("Üye eklendi!");
                Clear();
            }
            else
            {
                MessageBox.Show("Üye eklenirken bir hata oluştu!");
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            cbx_bloodType.Items.AddRange(BusinessLayer.BusinessLayer.bloodTypes);
            cbx_city.Items.AddRange(BusinessLayer.BusinessLayer.cities);
            cbx_bloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_city.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ControlBox = false;
        }

        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || txt_tc.Text.Length >= 11)
            {
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

        private void txt_tc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txt_tc.Text.Length > 0)
                {
                    int selectionStart = txt_tc.SelectionStart;

                    if (selectionStart > 0)
                    {
                        txt_tc.Text = txt_tc.Text.Remove(selectionStart - 1, 1);
                        txt_tc.SelectionStart = selectionStart - 1;
                    }
                }
                e.Handled = true;
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

    }

}
