namespace PresentationLayer
{
    partial class ShowPayments
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
            dg_debt = new DataGridView();
            btn_sendmail = new Button();
            btn_printPDF = new Button();
            groupBox2 = new GroupBox();
            txt_end = new TextBox();
            txt_start = new TextBox();
            cbox_paid = new CheckBox();
            btn_filter = new Button();
            groupBox1 = new GroupBox();
            cbox_date = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dg_debt).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dg_debt
            // 
            dg_debt.AllowUserToAddRows = false;
            dg_debt.AllowUserToDeleteRows = false;
            dg_debt.AllowUserToResizeColumns = false;
            dg_debt.AllowUserToResizeRows = false;
            dg_debt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_debt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_debt.Location = new Point(12, 12);
            dg_debt.Name = "dg_debt";
            dg_debt.ReadOnly = true;
            dg_debt.RowTemplate.Height = 25;
            dg_debt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_debt.Size = new Size(776, 381);
            dg_debt.TabIndex = 0;
            // 
            // btn_sendmail
            // 
            btn_sendmail.Location = new Point(693, 408);
            btn_sendmail.Name = "btn_sendmail";
            btn_sendmail.Size = new Size(84, 87);
            btn_sendmail.TabIndex = 2;
            btn_sendmail.Text = "Toplu Mail Gönder";
            btn_sendmail.UseVisualStyleBackColor = true;
            btn_sendmail.Click += btn_sendmail_Click;
            // 
            // btn_printPDF
            // 
            btn_printPDF.Location = new Point(603, 408);
            btn_printPDF.Name = "btn_printPDF";
            btn_printPDF.Size = new Size(84, 87);
            btn_printPDF.TabIndex = 3;
            btn_printPDF.Text = "PDF Çıktı Al";
            btn_printPDF.UseVisualStyleBackColor = true;
            btn_printPDF.Click += btn_printPDF_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_end);
            groupBox2.Controls.Add(txt_start);
            groupBox2.Location = new Point(12, 421);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 59);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tarih Aralığı";
            // 
            // txt_end
            // 
            txt_end.Location = new Point(164, 22);
            txt_end.Name = "txt_end";
            txt_end.Size = new Size(139, 23);
            txt_end.TabIndex = 2;
            // 
            // txt_start
            // 
            txt_start.Location = new Point(16, 22);
            txt_start.Name = "txt_start";
            txt_start.Size = new Size(139, 23);
            txt_start.TabIndex = 1;
            // 
            // cbox_paid
            // 
            cbox_paid.AutoSize = true;
            cbox_paid.Location = new Point(15, 24);
            cbox_paid.Name = "cbox_paid";
            cbox_paid.Size = new Size(65, 19);
            cbox_paid.TabIndex = 44;
            cbox_paid.Text = "Ödendi";
            cbox_paid.UseVisualStyleBackColor = true;
            // 
            // btn_filter
            // 
            btn_filter.Location = new Point(513, 409);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(84, 86);
            btn_filter.TabIndex = 45;
            btn_filter.Text = "Filtrele";
            btn_filter.UseVisualStyleBackColor = true;
            btn_filter.Click += btn_filter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbox_date);
            groupBox1.Controls.Add(cbox_paid);
            groupBox1.Location = new Point(339, 421);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 59);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreler";
            // 
            // cbox_date
            // 
            cbox_date.AutoSize = true;
            cbox_date.Location = new Point(95, 24);
            cbox_date.Name = "cbox_date";
            cbox_date.Size = new Size(51, 19);
            cbox_date.TabIndex = 45;
            cbox_date.Text = "Tarih";
            cbox_date.UseVisualStyleBackColor = true;
            cbox_date.CheckedChanged += cbox_date_CheckedChanged;
            // 
            // ShowPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(802, 507);
            Controls.Add(groupBox1);
            Controls.Add(btn_filter);
            Controls.Add(groupBox2);
            Controls.Add(btn_printPDF);
            Controls.Add(btn_sendmail);
            Controls.Add(dg_debt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowPayments";
            Text = "ShowDebt";
            Load += ShowDebt_Load;
            ((System.ComponentModel.ISupportInitialize)dg_debt).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_debt;
        private Button btn_sendmail;
        private Button btn_printPDF;
        private GroupBox groupBox2;
        private TextBox txt_end;
        private TextBox txt_start;
        private CheckBox cbox_paid;
        private Button btn_filter;
        private GroupBox groupBox1;
        private CheckBox cbox_date;
    }
}