
namespace Demo
{
    partial class EmployeesFrm
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
            empLst = new ListView();
            empID = new ColumnHeader();
            empFName = new ColumnHeader();
            emptLName = new ColumnHeader();
            empGender = new ColumnHeader();
            empEmail = new ColumnHeader();
            empBU = new ColumnHeader();
            empCountry = new ColumnHeader();
            addBtn = new Button();
            uptBtn = new Button();
            rmvBtn = new Button();
            cnlBtn = new Button();
            SuspendLayout();
            // 
            // empLst
            // 
            empLst.Columns.AddRange(new ColumnHeader[] { empID, empFName, emptLName, empGender, empEmail, empBU, empCountry });
            empLst.FullRowSelect = true;
            empLst.Location = new Point(30, 27);
            empLst.MultiSelect = false;
            empLst.Name = "empLst";
            empLst.Size = new Size(678, 250);
            empLst.TabIndex = 0;
            empLst.UseCompatibleStateImageBehavior = false;
            empLst.View = View.Details;
            empLst.SelectedIndexChanged += empLst_SelectedIndexChanged;
            // 
            // empID
            // 
            empID.Text = "ID";
            empID.Width = 30;
            // 
            // empFName
            // 
            empFName.Text = "First Name";
            empFName.Width = 100;
            // 
            // emptLName
            // 
            emptLName.Text = "Last Name";
            emptLName.Width = 100;
            // 
            // empGender
            // 
            empGender.Text = "Gender";
            // 
            // empEmail
            // 
            empEmail.Text = "Email";
            empEmail.Width = 200;
            // 
            // empBU
            // 
            empBU.Text = "Business Unit";
            empBU.Width = 98;
            // 
            // empCountry
            // 
            empCountry.Text = "Country";
            empCountry.Width = 85;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(739, 27);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(111, 36);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // uptBtn
            // 
            uptBtn.Location = new Point(739, 113);
            uptBtn.Name = "uptBtn";
            uptBtn.Size = new Size(111, 36);
            uptBtn.TabIndex = 2;
            uptBtn.Text = "Update";
            uptBtn.UseVisualStyleBackColor = true;
            uptBtn.Click += uptBtn_Click;
            // 
            // rmvBtn
            // 
            rmvBtn.Location = new Point(739, 71);
            rmvBtn.Name = "rmvBtn";
            rmvBtn.Size = new Size(111, 36);
            rmvBtn.TabIndex = 3;
            rmvBtn.Text = "Remove";
            rmvBtn.UseVisualStyleBackColor = true;
            rmvBtn.Click += rmvBtn_Click;
            // 
            // cnlBtn
            // 
            cnlBtn.Location = new Point(739, 241);
            cnlBtn.Name = "cnlBtn";
            cnlBtn.Size = new Size(111, 36);
            cnlBtn.TabIndex = 4;
            cnlBtn.Text = "Cancel";
            cnlBtn.UseVisualStyleBackColor = true;
            cnlBtn.Click += cnlBtn_Click;
            // 
            // EmployeesFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 303);
            Controls.Add(cnlBtn);
            Controls.Add(rmvBtn);
            Controls.Add(uptBtn);
            Controls.Add(addBtn);
            Controls.Add(empLst);
            Name = "EmployeesFrm";
            Text = "EmployeeFrm";
            Load += EmployeesFrm_Load;
            ResumeLayout(false);
        }
        #endregion

        private ListView empLst;
        private Button addBtn;
        private Button uptBtn;
        private Button rmvBtn;
        private Button cnlBtn;
        private ColumnHeader empID;
        private ColumnHeader empFName;
        private ColumnHeader emptLName;
        private ColumnHeader empGender;
        private ColumnHeader empBU;
        private ColumnHeader empCountry;
        private ColumnHeader empEmail;
    }
}