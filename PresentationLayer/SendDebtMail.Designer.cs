namespace PresentationLayer
{
    partial class SendDebtMail
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
            btn_back = new Button();
            groupBox3 = new GroupBox();
            txt_subject = new TextBox();
            groupBox2 = new GroupBox();
            txt_body = new TextBox();
            btn_send = new Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(712, 24);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(74, 41);
            btn_back.TabIndex = 4;
            btn_back.Text = "Geri Dön";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_subject);
            groupBox3.Location = new Point(14, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(599, 61);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Konu";
            // 
            // txt_subject
            // 
            txt_subject.Location = new Point(17, 22);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(565, 23);
            txt_subject.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_body);
            groupBox2.Location = new Point(14, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(772, 350);
            groupBox2.TabIndex = 9;
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
            // btn_send
            // 
            btn_send.Location = new Point(632, 24);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(74, 41);
            btn_send.TabIndex = 3;
            btn_send.Text = "Gönder";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // SendDebtMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btn_send);
            Name = "SendDebtMail";
            Text = "SendDebtMail";
            Load += SendDebtMail_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private GroupBox groupBox3;
        private TextBox txt_subject;
        private GroupBox groupBox2;
        private TextBox txt_body;
        private Button btn_send;
        private TextBox txt_email;
    }
}