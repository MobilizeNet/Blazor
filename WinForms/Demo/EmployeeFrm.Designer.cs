namespace Demo
{
    partial class EmployeeFrm
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
            OKBtn = new Button();
            cnlBtn = new Button();
            IDLbl = new Label();
            fnameLBL = new Label();
            lnameLbl = new Label();
            genLbl = new Label();
            emailLbl = new Label();
            buLbl = new Label();
            cntLbl = new Label();
            empGrb = new GroupBox();
            ctryCmb = new ComboBox();
            genderCmb = new ComboBox();
            buTxt = new TextBox();
            emailTxt = new TextBox();
            fnameTxt = new TextBox();
            lnameTxt = new TextBox();
            IDTxt = new TextBox();
            saveProcessLbl = new Label();
            empGrb.SuspendLayout();
            SuspendLayout();
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(41, 337);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(126, 45);
            OKBtn.TabIndex = 0;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // cnlBtn
            // 
            cnlBtn.Location = new Point(254, 337);
            cnlBtn.Name = "cnlBtn";
            cnlBtn.Size = new Size(126, 45);
            cnlBtn.TabIndex = 1;
            cnlBtn.Text = "Cancel";
            cnlBtn.UseVisualStyleBackColor = true;
            cnlBtn.Click += cnlBtn_Click;
            // 
            // IDLbl
            // 
            IDLbl.AutoSize = true;
            IDLbl.Location = new Point(11, 39);
            IDLbl.Name = "IDLbl";
            IDLbl.Size = new Size(24, 20);
            IDLbl.TabIndex = 2;
            IDLbl.Text = "ID";
            // 
            // fnameLBL
            // 
            fnameLBL.AutoSize = true;
            fnameLBL.Location = new Point(11, 79);
            fnameLBL.Name = "fnameLBL";
            fnameLBL.Size = new Size(80, 20);
            fnameLBL.TabIndex = 3;
            fnameLBL.Text = "First Name";
            // 
            // lnameLbl
            // 
            lnameLbl.AutoSize = true;
            lnameLbl.Location = new Point(11, 116);
            lnameLbl.Name = "lnameLbl";
            lnameLbl.Size = new Size(79, 20);
            lnameLbl.TabIndex = 4;
            lnameLbl.Text = "Last Name";
            // 
            // genLbl
            // 
            genLbl.AutoSize = true;
            genLbl.Location = new Point(12, 158);
            genLbl.Name = "genLbl";
            genLbl.Size = new Size(57, 20);
            genLbl.TabIndex = 5;
            genLbl.Text = "Gender";
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(12, 192);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(46, 20);
            emailLbl.TabIndex = 6;
            emailLbl.Text = "Email";
            // 
            // buLbl
            // 
            buLbl.AutoSize = true;
            buLbl.Location = new Point(12, 229);
            buLbl.Name = "buLbl";
            buLbl.Size = new Size(95, 20);
            buLbl.TabIndex = 7;
            buLbl.Text = "Business Unit";
            // 
            // cntLbl
            // 
            cntLbl.AutoSize = true;
            cntLbl.Location = new Point(12, 265);
            cntLbl.Name = "cntLbl";
            cntLbl.Size = new Size(60, 20);
            cntLbl.TabIndex = 8;
            cntLbl.Text = "Country";
            // 
            // empGrb
            // 
            empGrb.Controls.Add(ctryCmb);
            empGrb.Controls.Add(genderCmb);
            empGrb.Controls.Add(buTxt);
            empGrb.Controls.Add(emailTxt);
            empGrb.Controls.Add(fnameTxt);
            empGrb.Controls.Add(lnameTxt);
            empGrb.Controls.Add(IDTxt);
            empGrb.Controls.Add(lnameLbl);
            empGrb.Controls.Add(cntLbl);
            empGrb.Controls.Add(IDLbl);
            empGrb.Controls.Add(buLbl);
            empGrb.Controls.Add(fnameLBL);
            empGrb.Controls.Add(emailLbl);
            empGrb.Controls.Add(genLbl);
            empGrb.Location = new Point(12, 12);
            empGrb.Name = "empGrb";
            empGrb.Size = new Size(401, 319);
            empGrb.TabIndex = 9;
            empGrb.TabStop = false;
            empGrb.Text = "Employee";
            // 
            // ctryCmb
            // 
            ctryCmb.FormattingEnabled = true;
            ctryCmb.Location = new Point(125, 257);
            ctryCmb.Name = "ctryCmb";
            ctryCmb.Size = new Size(151, 28);
            ctryCmb.TabIndex = 15;
            // 
            // genderCmb
            // 
            genderCmb.FormattingEnabled = true;
            genderCmb.Location = new Point(125, 150);
            genderCmb.Name = "genderCmb";
            genderCmb.Size = new Size(151, 28);
            genderCmb.TabIndex = 14;
            // 
            // buTxt
            // 
            buTxt.Location = new Point(125, 222);
            buTxt.Name = "buTxt";
            buTxt.Size = new Size(150, 27);
            buTxt.TabIndex = 13;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(125, 185);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(270, 27);
            emailTxt.TabIndex = 12;
            // 
            // fnameTxt
            // 
            fnameTxt.Location = new Point(125, 109);
            fnameTxt.Name = "fnameTxt";
            fnameTxt.Size = new Size(150, 27);
            fnameTxt.TabIndex = 11;
            // 
            // lnameTxt
            // 
            lnameTxt.Location = new Point(125, 72);
            lnameTxt.Name = "lnameTxt";
            lnameTxt.Size = new Size(150, 27);
            lnameTxt.TabIndex = 10;
            // 
            // IDTxt
            // 
            IDTxt.Location = new Point(125, 36);
            IDTxt.Name = "IDTxt";
            IDTxt.Size = new Size(38, 27);
            IDTxt.TabIndex = 9;
            // 
            // saveProcessLbl
            // 
            saveProcessLbl.BackColor = Color.Red;
            saveProcessLbl.Location = new Point(109, 389);
            saveProcessLbl.Name = "saveProcessLbl";
            saveProcessLbl.Size = new Size(188, 20);
            saveProcessLbl.TabIndex = 16;
            saveProcessLbl.Text = "";
            saveProcessLbl.TextAlign = ContentAlignment.TopCenter;
            saveProcessLbl.Visible = false;
            // 
            // EmployeeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 418);
            ControlBox = false;
            Controls.Add(saveProcessLbl);
            Controls.Add(empGrb);
            Controls.Add(cnlBtn);
            Controls.Add(OKBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EmployeeFrm";
            Text = "EmployeeFrm";
            Load += EmployeeFrm_Load;
            empGrb.ResumeLayout(false);
            empGrb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OKBtn;
        private Button cnlBtn;
        private Label IDLbl;
        private Label fnameLBL;
        private Label lnameLbl;
        private Label genLbl;
        private Label emailLbl;
        private Label buLbl;
        private Label cntLbl;
        private GroupBox empGrb;
        private TextBox buTxt;
        private TextBox emailTxt;
        private TextBox fnameTxt;
        private TextBox lnameTxt;
        private TextBox IDTxt;
        private ComboBox ctryCmb;
        private ComboBox genderCmb;
        private Label saveProcessLbl;
    }
}