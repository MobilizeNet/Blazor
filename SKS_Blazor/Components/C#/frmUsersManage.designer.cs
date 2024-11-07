using static System.Net.Mime.MediaTypeNames;
using Gap.Blazor;
using Telerik.Blazor;

namespace SKS_Blazor.Components
{
    partial class frmUsersManage
    {

        #region "Upgrade Support "
        private static frmUsersManage m_vb6FormDefInstance;
        private static bool m_InitializingDefInstance;
        public static frmUsersManage DefInstance
        {
            get
            {
                if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
                {
                    m_InitializingDefInstance = true;
                    m_vb6FormDefInstance = CreateInstance();
                    m_InitializingDefInstance = false;
                }
                return m_vb6FormDefInstance;
            }
            set
            {
                m_vb6FormDefInstance = value;
            }
        }

        #endregion
        #region "Windows Form Designer generated code "
        public static frmUsersManage CreateInstance()
        {
            frmUsersManage theInstance = new frmUsersManage();
            theInstance.Form_Load();
            return theInstance;
        }
        private string[] visualControls = new string[] { "components", "ToolTipMain", "lstAccounts_ColumnHeader_1_", "lstAccounts_ColumnHeader_2_", "lstAccounts_ColumnHeader_3_", "lstAccounts", "cmdClear", "cmdSave", "ctrlLiner1", "txtFullname", "txtPassword", "txtUsername", "cboLevel", "_Label1_2", "_Label1_0", "_Label1_1", "_Label1_3", "lblId", "Frame1", "cmdClose", "cmdEdit", "cmdDelete", "_Label1_4", "Label19", "Label4", "Image1", "Label1", "listViewHelper1", "commandButtonHelper1" };
        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTipMain;
        public ColumnHeader lstAccounts_ColumnHeader_1_;
        public ColumnHeader lstAccounts_ColumnHeader_2_;
        public ColumnHeader lstAccounts_ColumnHeader_3_;
        public ListView lstAccounts;
        public Button cmdClear;
        public Button cmdSave;
        public PictureBox ctrlLiner1;
        public TextBox txtFullname;
        public TextBox txtPassword;
        public TextBox txtUsername;
        public ComboBox cboLevel;
        public Label _Label1_2;
        public Label _Label1_0;
        public Label _Label1_1;
        public Label _Label1_3;
        public  Label lblId;
        public  GroupBox Frame1;
        public  Button cmdClose;
        public  Button cmdEdit;
        public  Button cmdDelete;
        public Label _Label1_4;
        public Label Label19;
        public Label Label4;
        public PictureBox Image1;
        public Label[] Label1 = new Label[5];
		// gap-todo: PBI 746467. Add support for component UpgradeHelpers.Gui.Controls.ListViewHelper.
		//public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManage));
            lstAccounts = new ListView();
            ToolTipMain = new ToolTip(components);
            lstAccounts_ColumnHeader_1_ = new ColumnHeader();
            lstAccounts_ColumnHeader_2_ = new ColumnHeader();
            lstAccounts_ColumnHeader_3_ = new ColumnHeader();
            cmdClear = new Button();
            cmdSave = new Button();
            ctrlLiner1 = new PictureBox();
            Frame1 = new GroupBox();
            txtFullname = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cboLevel = new ComboBox();
            _Label1_2 = new Label();
            _Label1_0 = new Label();
            _Label1_1 = new Label();
            _Label1_3 = new Label();
            lblId = new Label();
            cmdClose = new Button();
            cmdEdit = new Button();
            cmdDelete = new Button();
            _Label1_4 = new Label();
            Label19 = new Label();
            Label4 = new Label();
            Image1 = new PictureBox();
            lstAccounts.SuspendLayout();
            Frame1.SuspendLayout();
            SuspendLayout();
			// gap-todo: PBI 746467. Add support for component UpgradeHelpers.Gui.Controls.ListViewHelper.
			//listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
            // 
            // lstAccounts
            // 
            lstAccounts.AllowDrop = true;
            lstAccounts.BackColor = System.Drawing.SystemColors.Window;
            lstAccounts.BorderStyle = BorderStyle.Fixed3D;
            lstAccounts.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            lstAccounts.ForeColor = System.Drawing.SystemColors.WindowText;
            lstAccounts.FullRowSelect = true;
            lstAccounts.HideSelection = true;
            lstAccounts.LabelEdit = true;
            lstAccounts.Location = new System.Drawing.Point(0, 264);
            lstAccounts.MultiSelect = false;
            lstAccounts.Name = "lstAccounts";
            lstAccounts.Size = new System.Drawing.Size(337, 113);
            lstAccounts.TabIndex = 7;
            lstAccounts.View = ListViewMode.Details;
            lstAccounts.Columns.Add(lstAccounts_ColumnHeader_1_);
            lstAccounts.Columns.Add(lstAccounts_ColumnHeader_2_);
            lstAccounts.Columns.Add(lstAccounts_ColumnHeader_3_);
            lstAccounts.DoubleClick += new System.EventHandler(lstAccounts_DoubleClick);
            // 
            // lstAccounts_ColumnHeader_1_
            // 
            lstAccounts_ColumnHeader_1_.Text = "UserId";
            lstAccounts_ColumnHeader_1_.Width = 97;
            // 
            // lstAccounts_ColumnHeader_2_
            // 
            lstAccounts_ColumnHeader_2_.Text = "Name";
            lstAccounts_ColumnHeader_2_.Width = 97;
            // 
            // lstAccounts_ColumnHeader_3_
            // 
            lstAccounts_ColumnHeader_3_.Text = "Level";
            lstAccounts_ColumnHeader_3_.Width = 97;
            // 
            // cmdClear
            // 
            cmdClear.AllowDrop = true;
            cmdClear.BackColor = System.Drawing.SystemColors.Control;
            cmdClear.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdClear.Location = new System.Drawing.Point(168, 232);
            cmdClear.Name = "cmdClear";
            cmdClear.RightToLeft = RightToLeft.No;
            cmdClear.Size = new System.Drawing.Size(81, 25);
            cmdClear.TabIndex = 5;
            cmdClear.Text = "New"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            cmdClear.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdClear.UseVisualStyleBackColor = false;
            cmdClear.Click += new System.EventHandler(cmdClear_Click);
            // 
            // cmdSave
            // 
            cmdSave.AllowDrop = true;
            cmdSave.BackColor = System.Drawing.SystemColors.Control;
            cmdSave.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdSave.Location = new System.Drawing.Point(80, 232);
            cmdSave.Name = "cmdSave";
            cmdSave.RightToLeft = RightToLeft.No;
            cmdSave.Size = new System.Drawing.Size(81, 25);
            cmdSave.TabIndex = 4;
            cmdSave.Text = "Save"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            cmdSave.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdSave.UseVisualStyleBackColor = false;
            cmdSave.Click += new System.EventHandler(cmdSave_Click);
            // 
            // ctrlLiner1
            // 
            ctrlLiner1.AllowDrop = true;
            ctrlLiner1.BackColor = System.Drawing.SystemColors.Control;
            ctrlLiner1.BorderStyle = BorderStyle.Fixed3D;
            ctrlLiner1.CausesValidation = true;
            ctrlLiner1.Dock = DockStyle.None;
            ctrlLiner1.Enabled = true;
            ctrlLiner1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            ctrlLiner1.Location = new System.Drawing.Point(0, 56);
            ctrlLiner1.Name = "ctrlLiner1";
            ctrlLiner1.Size = new System.Drawing.Size(313, 2);
            ctrlLiner1.SizeMode = PictureBoxSizeMode.Normal;
            ctrlLiner1.TabIndex = 15;
            ctrlLiner1.TabStop = true;
            ctrlLiner1.Visible = true;
            // 
            // Frame1
            // 
            Frame1.AllowDrop = true;
            Frame1.BackColor = System.Drawing.SystemColors.Control;
            Frame1.Controls.Add(txtFullname);
            Frame1.Controls.Add(txtPassword);
            Frame1.Controls.Add(txtUsername);
            Frame1.Controls.Add(cboLevel);
            Frame1.Controls.Add(_Label1_2);
            Frame1.Controls.Add(_Label1_0);
            Frame1.Controls.Add(_Label1_1);
            Frame1.Controls.Add(_Label1_3);
            Frame1.Controls.Add(lblId);
            //Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            Frame1.Enabled = true;
            Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            Frame1.Location = new System.Drawing.Point(8, 64);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new System.Drawing.Size(329, 153);
            Frame1.TabIndex = 10;
            Frame1.Text = "User information";
            Frame1.Visible = true;
            // 
            // txtFullname
            // 
            txtFullname.AcceptsReturn = true;
            txtFullname.AllowDrop = true;
            txtFullname.BackColor = System.Drawing.SystemColors.Window;
            txtFullname.BorderStyle = BorderStyle.Fixed3D;
            //txtFullname.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            txtFullname.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            txtFullname.ForeColor = System.Drawing.SystemColors.WindowText;
            //txtFullname.ImeMode = ImeMode.Disable; //gap-todo: PBI 745732: [Blazor][DemoConversion][Controls] Add support for Control ImeMode property
            txtFullname.Location = new System.Drawing.Point(120, 88);
            txtFullname.MaxLength = 50;
            txtFullname.Name = "txtFullname";
            txtFullname.RightToLeft = RightToLeft.No;
            txtFullname.Size = new System.Drawing.Size(193, 19);
            txtFullname.TabIndex = 2;
            txtFullname.Enter += new System.EventHandler(txtFullname_Enter);
            // 
            // txtPassword
            // 
            txtPassword.AcceptsReturn = true;
            txtPassword.AllowDrop = true;
            txtPassword.BackColor = System.Drawing.SystemColors.Window;
            txtPassword.BorderStyle = BorderStyle.Fixed3D;
            //txtPassword.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            txtPassword.Font = new Gap.Blazor.Font("Wingdings", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 2);
            txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            //txtPassword.ImeMode = ImeMode.Disable; //gap-todo: PBI 745732: [Blazor][DemoConversion][Controls] Add support for Control ImeMode property
            txtPassword.Location = new System.Drawing.Point(120, 56);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = (char)108;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new System.Drawing.Size(193, 19);
            txtPassword.TabIndex = 1;
            txtPassword.Enter += new System.EventHandler(txtPassword_Enter);
            // 
            // txtUsername
            // 
            txtUsername.AcceptsReturn = true;
            txtUsername.AllowDrop = true;
            txtUsername.BackColor = System.Drawing.SystemColors.Window;
            txtUsername.BorderStyle = BorderStyle.Fixed3D;
            //txtUsername.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            txtUsername.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            txtUsername.Location = new System.Drawing.Point(120, 24);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.Size = new System.Drawing.Size(193, 19);
            txtUsername.TabIndex = 0;
            txtUsername.Enter += new System.EventHandler(txtUsername_Enter);
            // 
            // cboLevel
            // 
            cboLevel.AllowDrop = true;
            cboLevel.BackColor = System.Drawing.SystemColors.Window;
            cboLevel.CausesValidation = true;
            cboLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLevel.Enabled = true;
            cboLevel.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cboLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            cboLevel.IntegralHeight = true;
            cboLevel.Location = new System.Drawing.Point(120, 120);
            cboLevel.Name = "cboLevel";
            cboLevel.RightToLeft = RightToLeft.No;
            cboLevel.Size = new System.Drawing.Size(193, 21);
            cboLevel.Sorted = false;
            cboLevel.TabIndex = 3;
            cboLevel.TabStop = true;
            cboLevel.Visible = true;
            // 
            // _Label1_2
            // 
            _Label1_2.AllowDrop = true;
            _Label1_2.AutoSize = true;
            _Label1_2.BackColor = System.Drawing.SystemColors.Control;
            _Label1_2.BorderStyle = BorderStyle.None;
            _Label1_2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _Label1_2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            _Label1_2.Location = new System.Drawing.Point(16, 88);
            _Label1_2.MinimumSize = new System.Drawing.Size(68, 13);
            _Label1_2.Name = "_Label1_2";
            _Label1_2.RightToLeft = RightToLeft.No;
            _Label1_2.Size = new System.Drawing.Size(68, 13);
            _Label1_2.TabIndex = 16;
            _Label1_2.Text = "Full name: *";
            // 
            // _Label1_0
            // 
            _Label1_0.AllowDrop = true;
            _Label1_0.AutoSize = true;
            _Label1_0.BackColor = System.Drawing.SystemColors.Control;
            _Label1_0.BorderStyle = BorderStyle.None;
            _Label1_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _Label1_0.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            _Label1_0.Location = new System.Drawing.Point(16, 32);
            _Label1_0.MinimumSize = new System.Drawing.Size(70, 13);
            _Label1_0.Name = "_Label1_0";
            _Label1_0.RightToLeft = RightToLeft.No;
            _Label1_0.Size = new System.Drawing.Size(70, 13);
            _Label1_0.TabIndex = 14;
            _Label1_0.Text = "Username: *";
            // 
            // _Label1_1
            // 
            _Label1_1.AllowDrop = true;
            _Label1_1.AutoSize = true;
            _Label1_1.BackColor = System.Drawing.SystemColors.Control;
            _Label1_1.BorderStyle = BorderStyle.None;
            _Label1_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _Label1_1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            _Label1_1.Location = new System.Drawing.Point(16, 56);
            _Label1_1.MinimumSize = new System.Drawing.Size(96, 13);
            _Label1_1.Name = "_Label1_1";
            _Label1_1.RightToLeft = RightToLeft.No;
            _Label1_1.Size = new System.Drawing.Size(96, 13);
            _Label1_1.TabIndex = 13;
            _Label1_1.Text = "New password: *";
            // 
            // _Label1_3
            // 
            _Label1_3.AllowDrop = true;
            _Label1_3.AutoSize = true;
            _Label1_3.BackColor = System.Drawing.SystemColors.Control;
            _Label1_3.BorderStyle = BorderStyle.None;
            _Label1_3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _Label1_3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            _Label1_3.Location = new System.Drawing.Point(16, 120);
            _Label1_3.MinimumSize = new System.Drawing.Size(71, 13);
            _Label1_3.Name = "_Label1_3";
            _Label1_3.RightToLeft = RightToLeft.No;
            _Label1_3.Size = new System.Drawing.Size(71, 13);
            _Label1_3.TabIndex = 12;
            _Label1_3.Text = "User level: *";
            // 
            // lblId
            // 
            lblId.AllowDrop = true;
            lblId.AutoSize = true;
            lblId.BackColor = System.Drawing.SystemColors.Control;
            lblId.BorderStyle = BorderStyle.None;
            lblId.Font = new Gap.Blazor.Font("Tahoma", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            lblId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblId.Location = new System.Drawing.Point(128, 24);
            lblId.MinimumSize = new System.Drawing.Size(3, 13);
            lblId.Name = "lblId";
            lblId.RightToLeft = RightToLeft.No;
            lblId.Size = new System.Drawing.Size(3, 13);
            lblId.TabIndex = 11;
            // 
            // cmdClose
            // 
            cmdClose.AllowDrop = true;
            cmdClose.BackColor = System.Drawing.SystemColors.Control;
            cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdClose.Location = new System.Drawing.Point(256, 232);
            cmdClose.Name = "cmdClose";
            cmdClose.RightToLeft = RightToLeft.No;
            cmdClose.Size = new System.Drawing.Size(81, 25);
            cmdClose.TabIndex = 6;
            cmdClose.Text = "Close"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            cmdClose.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdClose.UseVisualStyleBackColor = false;
            cmdClose.Click += new System.EventHandler(cmdClose_Click);
            // 
            // cmdEdit
            // 
            cmdEdit.AllowDrop = true;
            cmdEdit.BackColor = System.Drawing.SystemColors.Control;
            cmdEdit.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdEdit.Location = new System.Drawing.Point(168, 384);
            cmdEdit.Name = "cmdEdit";
            cmdEdit.RightToLeft = RightToLeft.No;
            cmdEdit.Size = new System.Drawing.Size(81, 25);
            cmdEdit.TabIndex = 8;
            cmdEdit.Text = "Edit"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            cmdEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdEdit.UseVisualStyleBackColor = false;
            cmdEdit.Click += new System.EventHandler(cmdEdit_Click);
            // 
            // cmdDelete
            // 
            cmdDelete.AllowDrop = true;
            cmdDelete.BackColor = System.Drawing.SystemColors.Control;
            cmdDelete.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdDelete.Location = new System.Drawing.Point(256, 384);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.RightToLeft = RightToLeft.No;
            cmdDelete.Size = new System.Drawing.Size(81, 25);
            cmdDelete.TabIndex = 9;
            cmdDelete.Text = "Delete"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            cmdDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdDelete.UseVisualStyleBackColor = false;
            cmdDelete.Click += new System.EventHandler(cmdDelete_Click);
            // 
            // _Label1_4
            // 
            _Label1_4.AllowDrop = true;
            _Label1_4.AutoSize = true;
            _Label1_4.BackColor = System.Drawing.SystemColors.Control;
            _Label1_4.BorderStyle = BorderStyle.None;
            _Label1_4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _Label1_4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            _Label1_4.Location = new System.Drawing.Point(8, 392);
            _Label1_4.MinimumSize = new System.Drawing.Size(95, 13);
            _Label1_4.Name = "_Label1_4";
            _Label1_4.RightToLeft = RightToLeft.No;
            _Label1_4.Size = new System.Drawing.Size(95, 13);
            _Label1_4.TabIndex = 19;
            _Label1_4.Text = "* Required fields";
            // 
            // Label19
            // 
            Label19.AllowDrop = true;
            Label19.AutoSize = true;
            Label19.BackColor = System.Drawing.Color.Transparent;
            Label19.BorderStyle = BorderStyle.None;
            Label19.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 9.75f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Label19.Location = new System.Drawing.Point(48, 8);
            Label19.MinimumSize = new System.Drawing.Size(34, 16);
            Label19.Name = "Label19";
            Label19.RightToLeft = RightToLeft.No;
            Label19.Size = new System.Drawing.Size(34, 16);
            Label19.TabIndex = 18;
            Label19.Text = "User";
            Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            Label4.AllowDrop = true;
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Transparent;
            Label4.BorderStyle = BorderStyle.None;
            Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Label4.Location = new System.Drawing.Point(48, 32);
            Label4.MinimumSize = new System.Drawing.Size(176, 13);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new System.Drawing.Size(176, 13);
            Label4.TabIndex = 17;
            Label4.Text = "Set user information and access level";
            // 
            // Image1
            // 
            Image1.AllowDrop = true;
            Image1.BorderStyle = BorderStyle.None;
            //Image1.Cursor = new Cursor((new System.Drawing.Bitmap((System.Drawing.Image)resources.GetObject("Image1.Cursor"))).GetHicon()); //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            Image1.Enabled = true;
            Image1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Image1.Image = (System.Drawing.Image)resources.GetObject("Image1.Image");
            Image1.Location = new System.Drawing.Point(8, 8);
            Image1.Name = "Image1";
            Image1.Size = new System.Drawing.Size(32, 32);
            Image1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image1.Visible = true;
            // 
            // frmUsersManage
            // 
            AllowDrop = true;
            //AutoScaleDimensions = new System.Drawing.SizeF(6, 13); //gap-todo: PBI 745733: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleDimensions property
            //AutoScaleMode = AutoScaleMode.Font; //gap-todo: PBI  745734: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleMode property
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(341, 414);
            Controls.Add(lstAccounts);
            Controls.Add(cmdClear);
            Controls.Add(cmdSave);
            Controls.Add(ctrlLiner1);
            Controls.Add(Frame1);
            Controls.Add(cmdClose);
            Controls.Add(cmdEdit);
            Controls.Add(cmdDelete);
            Controls.Add(_Label1_4);
            Controls.Add(Label19);
            Controls.Add(Label4);
            Controls.Add(Image1);
            Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("frmUsersManage.Icon"); 
            Location = new System.Drawing.Point(327, 144);
            MaximizeBox = false;
            MinimizeBox = true;
            Name = "frmUsersManage";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Users Management";
            //commandButtonHelper1.SetStyle(cmdClear, 0); //gap-todo
            //commandButtonHelper1.SetStyle(cmdSave, 0); //gap-todo
            //commandButtonHelper1.SetStyle(cmdClose, 0); //gap-todo
            //commandButtonHelper1.SetStyle(cmdEdit, 0); //gap-todo
            //commandButtonHelper1.SetStyle(cmdDelete, 0); //gap-todo
            ToolTipMain.SetToolTip(Image1, "View warnings");
            Activated += new System.EventHandler(frmUsersManage_Activated);
            Closed += new System.EventHandler(Form_Closed);
			// gap-todo: PBI 746467. Add support for component UpgradeHelpers.Gui.Controls.ListViewHelper.
			//listViewHelper1.SetCorrectEventsBehavior(lstAccounts, true);
			lstAccounts.ResumeLayout(false);
            Frame1.ResumeLayout(false);
            ResumeLayout(false);
        }
        void ReLoadForm(bool addEvents)
        {
            InitializeLabel1();
            //This form is an MDI child.
            //This code simulates the VB6 
            // functionality of automatically
            // loading and showing an MDI
            // child's parent.
            MdiParent = frmMain.DefInstance;
            frmMain.DefInstance.Show();
        }
        void InitializeLabel1()
        {
            Label1 = new Label[5];
            Label1[2] = _Label1_2;
            Label1[0] = _Label1_0;
            Label1[1] = _Label1_1;
            Label1[3] = _Label1_3;
            Label1[4] = _Label1_4;
        }
        #endregion
    }
}