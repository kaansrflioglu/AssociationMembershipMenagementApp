namespace PresentationLayer
{
    partial class YearlyChart
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
            zedGraphControl1 = new ZedGraph.ZedGraphControl();
            SuspendLayout();
            // 
            // zedGraphControl1
            // 
            zedGraphControl1.Location = new Point(12, 12);
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
            zedGraphControl1.TabIndex = 5;
            // 
            // YearlyChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(zedGraphControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "YearlyChart";
            Text = "Yıllık Grafiksel Gösterim";
            Load += YearlyChart_Load;
            ResumeLayout(false);
        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}