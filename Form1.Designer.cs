namespace ATM
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtAccountNo = new TextBox();
            txtPIN = new TextBox();
            label1 = new Label();
            lblAccountNo = new Label();
            lblPIN = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(345, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtAccountNo
            // 
            txtAccountNo.Location = new Point(363, 148);
            txtAccountNo.Name = "txtAccountNo";
            txtAccountNo.Size = new Size(150, 31);
            txtAccountNo.TabIndex = 1;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(363, 232);
            txtPIN.Name = "txtPIN";
            txtPIN.PasswordChar = '*';
            txtPIN.Size = new Size(150, 31);
            txtPIN.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 36);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 3;
            label1.Text = "ATM Login";
            // 
            // lblAccountNo
            // 
            lblAccountNo.AutoSize = true;
            lblAccountNo.Location = new Point(151, 163);
            lblAccountNo.Name = "lblAccountNo";
            lblAccountNo.Size = new Size(69, 25);
            lblAccountNo.TabIndex = 4;
            lblAccountNo.Text = "Acc No";
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.Location = new Point(165, 236);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(36, 25);
            lblPIN.TabIndex = 5;
            lblPIN.Text = "Pin";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPIN);
            Controls.Add(lblAccountNo);
            Controls.Add(label1);
            Controls.Add(txtPIN);
            Controls.Add(txtAccountNo);
            Controls.Add(btnLogin);
            Name = "FrmLogin";
            Text = "ATM Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtAccountNo;
        private TextBox txtPIN;
        private Label label1;
        private Label lblAccountNo;
        private Label lblPIN;
    }
}
