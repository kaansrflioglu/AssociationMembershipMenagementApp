namespace PresentationLayer
{
    partial class AddMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_surname = new TextBox();
            txt_name = new TextBox();
            txt_tc = new TextBox();
            dtp_birthTime = new DateTimePicker();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_add = new Button();
            label8 = new Label();
            txt_email = new TextBox();
            label9 = new Label();
            txt_tel = new TextBox();
            label10 = new Label();
            txt_address = new TextBox();
            cbx_bloodType = new ComboBox();
            cbx_city = new ComboBox();
            SuspendLayout();
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(155, 74);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(200, 23);
            txt_surname.TabIndex = 2;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(155, 45);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(200, 23);
            txt_name.TabIndex = 1;
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(155, 16);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(200, 23);
            txt_tc.TabIndex = 0;
            txt_tc.KeyDown += txt_tc_KeyDown;
            txt_tc.KeyPress += txt_tc_KeyPress;
            // 
            // dtp_birthTime
            // 
            dtp_birthTime.Location = new Point(155, 124);
            dtp_birthTime.Name = "dtp_birthTime";
            dtp_birthTime.Size = new Size(200, 23);
            dtp_birthTime.TabIndex = 5;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(269, 100);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(55, 19);
            radio_female.TabIndex = 4;
            radio_female.TabStop = true;
            radio_female.Text = "Kadın";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(179, 100);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(53, 19);
            radio_male.TabIndex = 3;
            radio_male.TabStop = true;
            radio_male.Text = "Erkek";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 154);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 27;
            label7.Text = "Kan Grubu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 232);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 28;
            label6.Text = "Şehir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 130);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 29;
            label5.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 103);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 30;
            label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 77);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 31;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 48);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 32;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 33;
            label1.Text = "TC Kimlik Numarası";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(269, 364);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(86, 29);
            btn_add.TabIndex = 11;
            btn_add.Text = "Ekle";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 180);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 31;
            label8.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(155, 177);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(200, 23);
            txt_email.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 206);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 28;
            label9.Text = "Telefon Numarası";
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(155, 203);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(200, 23);
            txt_tel.TabIndex = 8;
            txt_tel.KeyDown += txt_tel_KeyDown;
            txt_tel.KeyPress += txt_tel_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 259);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 28;
            label10.Text = "Adres";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(155, 256);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(200, 98);
            txt_address.TabIndex = 10;
            // 
            // cbx_bloodType
            // 
            cbx_bloodType.FormattingEnabled = true;
            cbx_bloodType.Location = new Point(155, 151);
            cbx_bloodType.Margin = new Padding(3, 2, 3, 2);
            cbx_bloodType.Name = "cbx_bloodType";
            cbx_bloodType.Size = new Size(200, 23);
            cbx_bloodType.TabIndex = 6;
            // 
            // cbx_city
            // 
            cbx_city.FormattingEnabled = true;
            cbx_city.Location = new Point(155, 230);
            cbx_city.Margin = new Padding(3, 2, 3, 2);
            cbx_city.Name = "cbx_city";
            cbx_city.Size = new Size(200, 23);
            cbx_city.TabIndex = 9;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 405);
            Controls.Add(cbx_city);
            Controls.Add(cbx_bloodType);
            Controls.Add(txt_tel);
            Controls.Add(txt_address);
            Controls.Add(txt_email);
            Controls.Add(txt_surname);
            Controls.Add(txt_name);
            Controls.Add(txt_tc);
            Controls.Add(dtp_birthTime);
            Controls.Add(radio_female);
            Controls.Add(radio_male);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ekle";
            Load += AddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_surname;
        private TextBox txt_name;
        private TextBox txt_tc;
        private DateTimePicker dtp_birthTime;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_add;
        private Label label8;
        private TextBox txt_email;
        private Label label9;
        private TextBox txt_tel;
        private Label label10;
        private TextBox txt_address;
        private ComboBox cbx_bloodType;
        private ComboBox cbx_city;
    }
}