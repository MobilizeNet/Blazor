


namespace Demo
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            loginLogo = new PictureBox();
            usrLbl = new Label();
            passLbl = new Label();
            srvLbl = new Label();
            usrTxt = new TextBox();
            passwTxt = new TextBox();
            srvCbx = new ComboBox();
            OKBtn = new Button();
            cnclBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)loginLogo).BeginInit();
            SuspendLayout();
            // 
            // loginLogo
            // 
            loginLogo.Image = (Image)resources.GetObject("loginLogo.Image");
            loginLogo.Location = new Point(281, 20);
            loginLogo.Name = "loginLogo";
            loginLogo.Size = new Size(123, 37);
            loginLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            loginLogo.TabIndex = 0;
            loginLogo.TabStop = false;
            // 
            // usrLbl
            // 
            usrLbl.AutoSize = true;
            usrLbl.Location = new Point(29, 37);
            usrLbl.Name = "usrLbl";
            usrLbl.Size = new Size(75, 20);
            usrLbl.TabIndex = 1;
            usrLbl.Text = "Username";
            // 
            // passLbl
            // 
            passLbl.AutoSize = true;
            passLbl.Location = new Point(29, 79);
            passLbl.Name = "passLbl";
            passLbl.Size = new Size(70, 20);
            passLbl.TabIndex = 2;
            passLbl.Text = "Password";
            // 
            // srvLbl
            // 
            srvLbl.AutoSize = true;
            srvLbl.Location = new Point(29, 120);
            srvLbl.Name = "srvLbl";
            srvLbl.Size = new Size(50, 20);
            srvLbl.TabIndex = 3;
            srvLbl.Text = "Server";
            // 
            // usrTxt
            // 
            usrTxt.Location = new Point(110, 30);
            usrTxt.Name = "usrTxt";
            usrTxt.Size = new Size(125, 27);
            usrTxt.TabIndex = 4;
            // 
            // passwTxt
            // 
            passwTxt.Location = new Point(110, 72);
            passwTxt.Name = "passwTxt";
            passwTxt.PasswordChar = '*';
            passwTxt.Size = new Size(125, 27);
            passwTxt.TabIndex = 5;
            // 
            // srvCbx
            // 
            srvCbx.FormattingEnabled = true;
            srvCbx.Location = new Point(110, 108);
            srvCbx.Name = "srvCbx";
            srvCbx.Size = new Size(125, 28);
            srvCbx.TabIndex = 6;
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(281, 70);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(123, 32);
            OKBtn.TabIndex = 7;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += this.OKBtn_Click;
            // 
            // cnclBtn
            // 
            cnclBtn.Location = new Point(281, 114);
            cnclBtn.Name = "cnclBtn";
            cnclBtn.Size = new Size(123, 32);
            cnclBtn.TabIndex = 8;
            cnclBtn.Text = "Cancel";
            cnclBtn.UseVisualStyleBackColor = true;
            cnclBtn.Click += cnclBtn_Click;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 173);
            ControlBox = false;
            Controls.Add(cnclBtn);
            Controls.Add(OKBtn);
            Controls.Add(srvCbx);
            Controls.Add(passwTxt);
            Controls.Add(usrTxt);
            Controls.Add(srvLbl);
            Controls.Add(passLbl);
            Controls.Add(usrLbl);
            Controls.Add(loginLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginFrm";
            Text = "Login";
            Load += LoginFrm_Load;
            ((System.ComponentModel.ISupportInitialize)loginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private PictureBox loginLogo;
        private Label usrLbl;
        private Label passLbl;
        private Label srvLbl;
        private TextBox usrTxt;
        private TextBox passwTxt;
        private ComboBox srvCbx;
        private Button OKBtn;
        private Button cnclBtn;
    }
}
