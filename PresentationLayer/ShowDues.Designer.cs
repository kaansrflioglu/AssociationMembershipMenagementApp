namespace PresentationLayer
{
    partial class ShowDues
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
            dg_showdues = new DataGridView();
            btn_update = new Button();
            btn_add = new Button();
            btn_delete = new Button();
            radio_notpaid = new RadioButton();
            radio_paid = new RadioButton();
            label3 = new Label();
            label1 = new Label();
            txt_fee = new TextBox();
            cbx_year = new ComboBox();
            cbx_month = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dg_showdues).BeginInit();
            SuspendLayout();
            // 
            // dg_showdues
            // 
            dg_showdues.AllowUserToAddRows = false;
            dg_showdues.AllowUserToDeleteRows = false;
            dg_showdues.AllowUserToResizeColumns = false;
            dg_showdues.AllowUserToResizeRows = false;
            dg_showdues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_showdues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_showdues.Location = new Point(10, 9);
            dg_showdues.Margin = new Padding(3, 2, 3, 2);
            dg_showdues.Name = "dg_showdues";
            dg_showdues.ReadOnly = true;
            dg_showdues.RowHeadersWidth = 51;
            dg_showdues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_showdues.Size = new Size(521, 354);
            dg_showdues.TabIndex = 8;
            dg_showdues.SelectionChanged += dg_showdues_SelectionChanged;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(444, 449);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(78, 34);
            btn_update.TabIndex = 7;
            btn_update.Text = "Güncelle";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(443, 373);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(78, 34);
            btn_add.TabIndex = 5;
            btn_add.Text = "Ekle";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(443, 411);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(78, 34);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Sil";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // radio_notpaid
            // 
            radio_notpaid.AutoSize = true;
            radio_notpaid.Location = new Point(109, 381);
            radio_notpaid.Name = "radio_notpaid";
            radio_notpaid.Size = new Size(81, 19);
            radio_notpaid.TabIndex = 1;
            radio_notpaid.TabStop = true;
            radio_notpaid.Text = "Ödenmedi";
            radio_notpaid.UseVisualStyleBackColor = true;
            // 
            // radio_paid
            // 
            radio_paid.AutoSize = true;
            radio_paid.Location = new Point(25, 381);
            radio_paid.Name = "radio_paid";
            radio_paid.Size = new Size(64, 19);
            radio_paid.TabIndex = 0;
            radio_paid.TabStop = true;
            radio_paid.Text = "Ödendi";
            radio_paid.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 413);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 33;
            label3.Text = "Yıl/Ay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 442);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 33;
            label1.Text = "Ücret";
            // 
            // txt_fee
            // 
            txt_fee.Location = new Point(83, 439);
            txt_fee.Name = "txt_fee";
            txt_fee.Size = new Size(192, 23);
            txt_fee.TabIndex = 4;
            // 
            // cbx_year
            // 
            cbx_year.FormattingEnabled = true;
            cbx_year.Location = new Point(83, 410);
            cbx_year.Margin = new Padding(3, 2, 3, 2);
            cbx_year.Name = "cbx_year";
            cbx_year.Size = new Size(93, 23);
            cbx_year.TabIndex = 2;
            // 
            // cbx_month
            // 
            cbx_month.FormattingEnabled = true;
            cbx_month.Location = new Point(182, 410);
            cbx_month.Margin = new Padding(3, 2, 3, 2);
            cbx_month.Name = "cbx_month";
            cbx_month.Size = new Size(93, 23);
            cbx_month.TabIndex = 3;
            // 
            // ShowDues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 499);
            Controls.Add(cbx_month);
            Controls.Add(cbx_year);
            Controls.Add(txt_fee);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(radio_notpaid);
            Controls.Add(radio_paid);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(dg_showdues);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShowDues";
            Text = "Ödemeler";
            Load += ShowDues_Load;
            ((System.ComponentModel.ISupportInitialize)dg_showdues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg_showdues;
        private Button btn_update;
        private Button btn_add;
        private Button btn_delete;
        private RadioButton radio_notpaid;
        private RadioButton radio_paid;
        private Label label3;
        private Label label1;
        private TextBox txt_fee;
        private ComboBox cbx_year;
        private ComboBox cbx_month;
    }
}