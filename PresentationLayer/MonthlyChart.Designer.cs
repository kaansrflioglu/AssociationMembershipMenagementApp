namespace PresentationLayer
{
    partial class MonthlyChart
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
            components = new System.ComponentModel.Container();
            cbx_year = new ComboBox();
            btn_month = new Button();
            zedGraphControl1 = new ZedGraph.ZedGraphControl();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbx_year
            // 
            cbx_year.FormattingEnabled = true;
            cbx_year.Location = new Point(447, 459);
            cbx_year.Margin = new Padding(3, 2, 3, 2);
            cbx_year.Name = "cbx_year";
            cbx_year.Size = new Size(93, 23);
            cbx_year.TabIndex = 6;
            // 
            // btn_month
            // 
            btn_month.Location = new Point(555, 444);
            btn_month.Name = "btn_month";
            btn_month.Size = new Size(143, 50);
            btn_month.TabIndex = 5;
            btn_month.Text = "Aidat Gelirlerinin Aylık Bazda Gösterimi";
            btn_month.UseVisualStyleBackColor = true;
            btn_month.Click += btn_month_Click;
            // 
            // zedGraphControl1
            // 
            zedGraphControl1.Location = new Point(11, 12);
            zedGraphControl1.Margin = new Padding(4, 3, 4, 3);
            zedGraphControl1.Name = "zedGraphControl1";
            zedGraphControl1.ScrollGrace = 0D;
            zedGraphControl1.ScrollMaxX = 0D;
            zedGraphControl1.ScrollMaxY = 0D;
            zedGraphControl1.ScrollMaxY2 = 0D;
            zedGraphControl1.ScrollMinX = 0D;
            zedGraphControl1.ScrollMinY = 0D;
            zedGraphControl1.ScrollMinY2 = 0D;
            zedGraphControl1.Size = new Size(697, 426);
            zedGraphControl1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 462);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 7;
            label1.Text = "Yıl";
            // 
            // MonthlyChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 505);
            Controls.Add(label1);
            Controls.Add(cbx_year);
            Controls.Add(btn_month);
            Controls.Add(zedGraphControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "MonthlyChart";
            Text = "Aylık Grafiksel Gösterim";
            Load += MonthlyChart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_year;
        private Button btn_month;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private Label label1;
    }
}