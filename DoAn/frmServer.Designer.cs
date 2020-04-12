namespace DoAn
{
    partial class frmServer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDataName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoSv2 = new System.Windows.Forms.RadioButton();
            this.rdoSv1 = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDataName);
            this.panel1.Controls.Add(this.txtServerName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rdoSv2);
            this.panel1.Controls.Add(this.rdoSv1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnConn);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // txtDataName
            // 
            this.txtDataName.Location = new System.Drawing.Point(187, 124);
            this.txtDataName.Name = "txtDataName";
            this.txtDataName.Size = new System.Drawing.Size(405, 22);
            this.txtDataName.TabIndex = 2;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(187, 48);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(405, 22);
            this.txtServerName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên server";
            // 
            // rdoSv2
            // 
            this.rdoSv2.AutoSize = true;
            this.rdoSv2.Location = new System.Drawing.Point(438, 173);
            this.rdoSv2.Name = "rdoSv2";
            this.rdoSv2.Size = new System.Drawing.Size(197, 21);
            this.rdoSv2.TabIndex = 6;
            this.rdoSv2.TabStop = true;
            this.rdoSv2.Text = "SQL Server Authentication";
            this.rdoSv2.UseVisualStyleBackColor = true;
            this.rdoSv2.CheckedChanged += new System.EventHandler(this.RboSv2_CheckedChanged);
            // 
            // rdoSv1
            // 
            this.rdoSv1.AutoSize = true;
            this.rdoSv1.Location = new System.Drawing.Point(187, 173);
            this.rdoSv1.Name = "rdoSv1";
            this.rdoSv1.Size = new System.Drawing.Size(180, 21);
            this.rdoSv1.TabIndex = 5;
            this.rdoSv1.TabStop = true;
            this.rdoSv1.Text = "Windown Authentication";
            this.rdoSv1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(620, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(479, 333);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(113, 46);
            this.btnConn.TabIndex = 10;
            this.btnConn.Text = "Kết nối";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(187, 286);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(405, 22);
            this.txtPass.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(187, 225);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(405, 22);
            this.txtUser.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên database";
            // 
            // frmServer
            // 
            this.AcceptButton = this.btnConn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmServer";
            this.Text = "Kết nối server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSv1;
        private System.Windows.Forms.RadioButton rdoSv2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDataName;
    }
}