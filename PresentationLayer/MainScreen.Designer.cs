namespace PresentationLayer
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            btn_memberAdd = new Button();
            btn_membersList = new Button();
            btn_debt = new Button();
            panel_Menu = new Panel();
            btn_exit = new Button();
            panel_Logo = new Panel();
            panel = new Panel();
            panel_Menu.SuspendLayout();
            panel_Logo.SuspendLayout();
            SuspendLayout();
            // 
            // btn_memberAdd
            // 
            btn_memberAdd.Dock = DockStyle.Top;
            btn_memberAdd.FlatAppearance.BorderSize = 0;
            btn_memberAdd.FlatStyle = FlatStyle.Flat;
            btn_memberAdd.ForeColor = Color.Black;
            btn_memberAdd.Image = Properties.Resources.user;
            btn_memberAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_memberAdd.Location = new Point(0, 322);
            btn_memberAdd.Name = "btn_memberAdd";
            btn_memberAdd.Size = new Size(256, 66);
            btn_memberAdd.TabIndex = 0;
            btn_memberAdd.Text = "Üye Ekle";
            btn_memberAdd.UseVisualStyleBackColor = true;
            btn_memberAdd.Click += btn_memberAdd_Click;
            // 
            // btn_membersList
            // 
            btn_membersList.Dock = DockStyle.Top;
            btn_membersList.FlatAppearance.BorderSize = 0;
            btn_membersList.FlatStyle = FlatStyle.Flat;
            btn_membersList.ForeColor = Color.Black;
            btn_membersList.Image = (Image)resources.GetObject("btn_membersList.Image");
            btn_membersList.ImageAlign = ContentAlignment.MiddleLeft;
            btn_membersList.Location = new Point(0, 256);
            btn_membersList.Name = "btn_membersList";
            btn_membersList.Size = new Size(256, 66);
            btn_membersList.TabIndex = 1;
            btn_membersList.Text = "Üye Listesi";
            btn_membersList.UseVisualStyleBackColor = true;
            btn_membersList.Click += btn_membersList_Click;
            // 
            // btn_debt
            // 
            btn_debt.Dock = DockStyle.Top;
            btn_debt.FlatAppearance.BorderSize = 0;
            btn_debt.FlatStyle = FlatStyle.Flat;
            btn_debt.ForeColor = Color.Black;
            btn_debt.Image = Properties.Resources.payment;
            btn_debt.ImageAlign = ContentAlignment.MiddleLeft;
            btn_debt.Location = new Point(0, 388);
            btn_debt.Name = "btn_debt";
            btn_debt.Size = new Size(256, 66);
            btn_debt.TabIndex = 2;
            btn_debt.Text = "Tüm Ödemeler";
            btn_debt.UseVisualStyleBackColor = true;
            btn_debt.Click += btn_debt_Click;
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = Color.White;
            panel_Menu.Controls.Add(btn_exit);
            panel_Menu.Controls.Add(btn_debt);
            panel_Menu.Controls.Add(btn_memberAdd);
            panel_Menu.Controls.Add(btn_membersList);
            panel_Menu.Controls.Add(panel_Logo);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(256, 521);
            panel_Menu.TabIndex = 7;
            // 
            // btn_exit
            // 
            btn_exit.Dock = DockStyle.Top;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.Black;
            btn_exit.Image = Properties.Resources.exit;
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(0, 454);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(256, 66);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Çıkış";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // panel_Logo
            // 
            panel_Logo.BackColor = Color.White;
            panel_Logo.BackgroundImage = Properties.Resources.logo2;
            panel_Logo.BackgroundImageLayout = ImageLayout.Center;
            panel_Logo.Controls.Add(panel);
            panel_Logo.Dock = DockStyle.Top;
            panel_Logo.Location = new Point(0, 0);
            panel_Logo.Name = "panel_Logo";
            panel_Logo.Size = new Size(256, 256);
            panel_Logo.TabIndex = 0;
            // 
            // panel
            // 
            panel.Location = new Point(257, 0);
            panel.Name = "panel";
            panel.Size = new Size(876, 518);
            panel.TabIndex = 8;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 521);
            Controls.Add(panel_Menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainScreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Genç Beşiktaşlılar Derneği";
            Load += MainScreen_Load;
            panel_Menu.ResumeLayout(false);
            panel_Logo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_memberAdd;
        private Button btn_membersList;
        private Button btn_debt;
        private Panel panel_Menu;
        private Panel panel_Logo;
        private Button btn_exit;
        private Panel panel;
    }
}