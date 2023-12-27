namespace PresentationLayer
{
    partial class ListMembers
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
            btn_list = new Button();
            dg_members = new DataGridView();
            btn_delete = new Button();
            btn_dueslist = new Button();
            btn_update = new Button();
            gbox_gender = new GroupBox();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            gbox_status = new GroupBox();
            radio_passive = new RadioButton();
            radio_active = new RadioButton();
            cbx_city = new ComboBox();
            cbx_bloodType = new ComboBox();
            gbox_bloodType = new GroupBox();
            gbox_city = new GroupBox();
            groupBox1 = new GroupBox();
            txt_tc = new TextBox();
            btn_reflesh = new Button();
            btn_sendmail = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_members).BeginInit();
            gbox_gender.SuspendLayout();
            gbox_status.SuspendLayout();
            gbox_bloodType.SuspendLayout();
            gbox_city.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_list
            // 
            btn_list.Location = new Point(1204, 405);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(97, 40);
            btn_list.TabIndex = 0;
            btn_list.Text = "Listele";
            btn_list.UseVisualStyleBackColor = true;
            btn_list.Click += btn_list_Click;
            // 
            // dg_members
            // 
            dg_members.AllowUserToAddRows = false;
            dg_members.AllowUserToDeleteRows = false;
            dg_members.AllowUserToResizeColumns = false;
            dg_members.AllowUserToResizeRows = false;
            dg_members.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_members.Location = new Point(10, 12);
            dg_members.Name = "dg_members";
            dg_members.ReadOnly = true;
            dg_members.RowHeadersWidth = 51;
            dg_members.RowTemplate.Height = 25;
            dg_members.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_members.Size = new Size(1310, 362);
            dg_members.TabIndex = 1;
            dg_members.CellClick += dg_members_CellClick;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(996, 450);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(98, 40);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Üyeyi Sil";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_dueslist
            // 
            btn_dueslist.Location = new Point(1204, 450);
            btn_dueslist.Margin = new Padding(3, 2, 3, 2);
            btn_dueslist.Name = "btn_dueslist";
            btn_dueslist.Size = new Size(97, 40);
            btn_dueslist.TabIndex = 3;
            btn_dueslist.Text = "Kişi Ödemeleri";
            btn_dueslist.UseVisualStyleBackColor = true;
            btn_dueslist.Click += btn_dueslist_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(1100, 450);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(99, 40);
            btn_update.TabIndex = 12;
            btn_update.Text = "Üyeyi Güncelle";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // gbox_gender
            // 
            gbox_gender.Controls.Add(radio_female);
            gbox_gender.Controls.Add(radio_male);
            gbox_gender.Location = new Point(31, 382);
            gbox_gender.Name = "gbox_gender";
            gbox_gender.Size = new Size(170, 59);
            gbox_gender.TabIndex = 13;
            gbox_gender.TabStop = false;
            gbox_gender.Text = "Cinsiyet";
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(95, 24);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(55, 19);
            radio_female.TabIndex = 1;
            radio_female.TabStop = true;
            radio_female.Text = "Kadın";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(17, 24);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(53, 19);
            radio_male.TabIndex = 0;
            radio_male.TabStop = true;
            radio_male.Text = "Erkek";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // gbox_status
            // 
            gbox_status.Controls.Add(radio_passive);
            gbox_status.Controls.Add(radio_active);
            gbox_status.Location = new Point(31, 447);
            gbox_status.Name = "gbox_status";
            gbox_status.Size = new Size(170, 59);
            gbox_status.TabIndex = 14;
            gbox_status.TabStop = false;
            gbox_status.Text = "Üye Durumu";
            // 
            // radio_passive
            // 
            radio_passive.AutoSize = true;
            radio_passive.Location = new Point(95, 24);
            radio_passive.Name = "radio_passive";
            radio_passive.Size = new Size(50, 19);
            radio_passive.TabIndex = 16;
            radio_passive.TabStop = true;
            radio_passive.Text = "Pasif";
            radio_passive.UseVisualStyleBackColor = true;
            // 
            // radio_active
            // 
            radio_active.AutoSize = true;
            radio_active.Location = new Point(17, 24);
            radio_active.Name = "radio_active";
            radio_active.Size = new Size(50, 19);
            radio_active.TabIndex = 15;
            radio_active.TabStop = true;
            radio_active.Text = "Aktif";
            radio_active.UseVisualStyleBackColor = true;
            // 
            // cbx_city
            // 
            cbx_city.FormattingEnabled = true;
            cbx_city.Location = new Point(15, 24);
            cbx_city.Margin = new Padding(3, 2, 3, 2);
            cbx_city.Name = "cbx_city";
            cbx_city.Size = new Size(139, 23);
            cbx_city.TabIndex = 35;
            // 
            // cbx_bloodType
            // 
            cbx_bloodType.FormattingEnabled = true;
            cbx_bloodType.Location = new Point(15, 24);
            cbx_bloodType.Margin = new Padding(3, 2, 3, 2);
            cbx_bloodType.Name = "cbx_bloodType";
            cbx_bloodType.Size = new Size(139, 23);
            cbx_bloodType.TabIndex = 32;
            // 
            // gbox_bloodType
            // 
            gbox_bloodType.Controls.Add(cbx_bloodType);
            gbox_bloodType.Location = new Point(216, 382);
            gbox_bloodType.Name = "gbox_bloodType";
            gbox_bloodType.Size = new Size(170, 59);
            gbox_bloodType.TabIndex = 36;
            gbox_bloodType.TabStop = false;
            gbox_bloodType.Text = "Kan Grubu";
            // 
            // gbox_city
            // 
            gbox_city.Controls.Add(cbx_city);
            gbox_city.Location = new Point(216, 447);
            gbox_city.Name = "gbox_city";
            gbox_city.Size = new Size(170, 59);
            gbox_city.TabIndex = 37;
            gbox_city.TabStop = false;
            gbox_city.Text = "Şehir";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_tc);
            groupBox1.Location = new Point(402, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 59);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "TC Kimlik Numarası";
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(15, 23);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(139, 23);
            txt_tc.TabIndex = 39;
            // 
            // btn_reflesh
            // 
            btn_reflesh.Location = new Point(1100, 405);
            btn_reflesh.Name = "btn_reflesh";
            btn_reflesh.Size = new Size(98, 40);
            btn_reflesh.TabIndex = 40;
            btn_reflesh.Text = "Yenile";
            btn_reflesh.UseVisualStyleBackColor = true;
            btn_reflesh.Click += btn_reflesh_Click;
            // 
            // btn_sendmail
            // 
            btn_sendmail.Location = new Point(996, 405);
            btn_sendmail.Name = "btn_sendmail";
            btn_sendmail.Size = new Size(98, 40);
            btn_sendmail.TabIndex = 41;
            btn_sendmail.Text = "Mail Gönder";
            btn_sendmail.UseVisualStyleBackColor = true;
            btn_sendmail.Click += btn_sendmail_Click;
            // 
            // ListMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 560);
            Controls.Add(btn_sendmail);
            Controls.Add(btn_reflesh);
            Controls.Add(groupBox1);
            Controls.Add(gbox_city);
            Controls.Add(gbox_bloodType);
            Controls.Add(gbox_status);
            Controls.Add(gbox_gender);
            Controls.Add(btn_update);
            Controls.Add(btn_dueslist);
            Controls.Add(btn_delete);
            Controls.Add(dg_members);
            Controls.Add(btn_list);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListMembers";
            Text = "Üye Listesi";
            Load += ListMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dg_members).EndInit();
            gbox_gender.ResumeLayout(false);
            gbox_gender.PerformLayout();
            gbox_status.ResumeLayout(false);
            gbox_status.PerformLayout();
            gbox_bloodType.ResumeLayout(false);
            gbox_city.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_list;
        private DataGridView dg_members;
        private Button btn_delete;
        private Button btn_dueslist;
        private Button btn_update;
        private GroupBox gbox_gender;
        private GroupBox gbox_status;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private RadioButton radio_passive;
        private RadioButton radio_active;
        private ComboBox cbx_city;
        private ComboBox cbx_bloodType;
        private GroupBox gbox_bloodType;
        private GroupBox gbox_city;
        private GroupBox groupBox1;
        private TextBox txt_tc;
        private Button btn_reflesh;
        private Button btn_sendmail;
    }
}