namespace DoAn
{
    partial class frmCryReport
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
            this.rv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new DoAn.CrystalReport1();
            this.SuspendLayout();
            // 
            // rv
            // 
            this.rv.ActiveViewIndex = -1;
            this.rv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rv.Cursor = System.Windows.Forms.Cursors.Default;
            this.rv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(1332, 746);
            this.rv.TabIndex = 0;
            // 
            // fCryReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1332, 746);
            this.Controls.Add(this.rv);
            this.Name = "fCryReport";
            this.Text = "fCryReport";
            this.Load += new System.EventHandler(this.FCryReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rv;
        private CrystalReport1 CrystalReport11;
    }
}