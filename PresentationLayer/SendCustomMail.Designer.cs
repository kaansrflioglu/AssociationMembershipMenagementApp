namespace PresentationLayer
{
    partial class SendCustomMail
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
            btn_send = new Button();
            txt_mailAddress = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txt_body = new TextBox();
            groupBox3 = new GroupBox();
            txt_subject = new TextBox();
            btn_back = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_send
            // 
            btn_send.Location = new Point(630, 24);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(74, 41);
            btn_send.TabIndex = 3;
            btn_send.Text = "Gönder";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // txt_mailAddress
            // 
            txt_mailAddress.Location = new Point(16, 22);
            txt_mailAddress.Name = "txt_mailAddress";
            txt_mailAddress.ReadOnly = true;
            txt_mailAddress.Size = new Size(206, 23);
            txt_mailAddress.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_mailAddress);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 61);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlgili Kişi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_body);
            groupBox2.Location = new Point(12, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(772, 350);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mesaj İçeriği";
            // 
            // txt_body
            // 
            txt_body.Location = new Point(16, 22);
            txt_body.Multiline = true;
            txt_body.Name = "txt_body";
            txt_body.Size = new Size(736, 311);
            txt_body.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_subject);
            groupBox3.Location = new Point(257, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(354, 61);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Konu";
            // 
            // txt_subject
            // 
            txt_subject.Location = new Point(15, 22);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(324, 23);
            txt_subject.TabIndex = 1;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(710, 24);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(74, 41);
            btn_back.TabIndex = 4;
            btn_back.Text = "Geri Dön";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // SendCustomMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_send);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SendCustomMail";
            Text = "SendMail";
            Load += SendMail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_send;
        private TextBox txt_mailAddress;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txt_body;
        private TextBox txt_subject;
        private Button btn_back;
    }
}