
using Gap.Blazor;

namespace SKS_Blazor.Components
{
	partial class frmReceptionApproval
	{

		#region "Upgrade Support "
		private static frmReceptionApproval m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmReceptionApproval DefInstance
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
		public static frmReceptionApproval CreateInstance()
		{
			frmReceptionApproval theInstance = new frmReceptionApproval();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdApprove", "cmdInfo", "fgOrders", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "cmbStatus", "chkTo", "chkFrom", "txtProductID", "txtOrderID", "txtContactLastName", "txtContactName", "cmdProviders", "txtProviderName", "dtFrom", "dtTo", "Label5", "Label8", "Label1", "Label6", "Label3", "Label4", "Label2", "Frame1", "listBoxComboBoxHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
        public ToolTip ToolTipMain;
        public Button cmdApprove;
		public Button cmdInfo;
		public DataGridViewFlex fgOrders;
		public ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public StatusStrip sbStatusBar;
		public Button cmdCancel;
		public Button cmdClose;
		public ComboBox cmbStatus;
		public CheckBox chkTo;
		public CheckBox chkFrom;
		public TextBox txtProductID;
		public TextBox txtOrderID;
		public TextBox txtContactLastName;
		public TextBox txtContactName;
		public Button cmdProviders;
		public TextBox txtProviderName;
		public DateTimePicker dtFrom;
		public DateTimePicker dtTo;
		public Label Label5;
		public Label Label8;
		public Label Label1;
		public Label Label6;
		public Label Label3;
		public Label Label4;
		public Label Label2;
		public GroupBox Frame1;
        // gap-note: The ListControlHelper should be generated as a stub.
        //public UpgradeHelpers.Gui.Controls.ListControlHelper listBoxComboBoxHelper1;
        // gap-note: The CommandButtonHelper should be generated as a stub.
        //public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceptionApproval));
            ToolTipMain = new ToolTip(components);
			cmdApprove = new Button();
			cmdInfo = new Button();
			// gap-todo: Bug 749104. DataGridView constructor does not take the container as an argument as the DataGridViewFlex.
			fgOrders = new DataGridViewFlex(); //new DataGridView(components);
			sbStatusBar = new StatusStrip();
			sbStatusBar_Panels_Panel1 = new ToolStripStatusLabel();
			cmdCancel = new Button();
			cmdClose = new Button();
			Frame1 = new GroupBox();
			cmbStatus = new ComboBox();
			chkTo = new CheckBox();
			chkFrom = new CheckBox();
			txtProductID = new TextBox();
			txtOrderID = new TextBox();
			txtContactLastName = new TextBox();
			txtContactName = new TextBox();
			cmdProviders = new Button();
			txtProviderName = new TextBox();
			dtFrom = new DateTimePicker();
			dtTo = new DateTimePicker();
			Label5 = new Label();
			Label8 = new Label();
			Label1 = new Label();
			Label6 = new Label();
			Label3 = new Label();
			Label4 = new Label();
			Label2 = new Label();
			sbStatusBar.SuspendLayout();
			Frame1.SuspendLayout();
			SuspendLayout();
			// gap-note: The ListControlHelper should be generated as a stub.
			//listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.Controls.ListControlHelper(components);
			//((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).BeginInit();
			// gap-note: The CommandButtonHelper should be generated as a stub.
			//commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// gap-todo: PBI 749102. DataGridView implement ISupportInitialize interface and add equivalent support for DataGridViewFlex methods.
			//((System.ComponentModel.ISupportInitialize) fgOrders).BeginInit();
			// 
			// cmdApprove
			// 
			cmdApprove.AllowDrop = true;
			cmdApprove.BackColor = System.Drawing.SystemColors.Control;
			cmdApprove.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdApprove.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdApprove.Location = new System.Drawing.Point(232, 440);
			cmdApprove.Name = "cmdApprove";
			cmdApprove.RightToLeft = RightToLeft.No;
			cmdApprove.Size = new System.Drawing.Size(89, 25);
			cmdApprove.TabIndex = 10;
			cmdApprove.Text = "Approve"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdApprove.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdApprove.UseVisualStyleBackColor = false;
			cmdApprove.Click += new System.EventHandler(cmdApprove_Click);
			// 
			// cmdInfo
			// 
			cmdInfo.AllowDrop = true;
			cmdInfo.BackColor = System.Drawing.SystemColors.Control;
			cmdInfo.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdInfo.Location = new System.Drawing.Point(136, 440);
			cmdInfo.Name = "cmdInfo";
			cmdInfo.RightToLeft = RightToLeft.No;
			cmdInfo.Size = new System.Drawing.Size(89, 25);
			cmdInfo.TabIndex = 9;
			cmdInfo.Text = "Info"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdInfo.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdInfo.UseVisualStyleBackColor = false;
			cmdInfo.Click += new System.EventHandler(cmdInfo_Click);
			// 
			// fgOrders
			// 
			// gap-todo: PBI 749091. DataGridView add support for a property equivalent to AllowBigSelection of DataGridViewFlex.
			//fgOrders.AllowBigSelection = false;
			fgOrders.AllowDrop = true;
			fgOrders.AllowUserToAddRows = false;
			fgOrders.AllowUserToDeleteRows = false;
			// gap-todo: PBI 749072. DataGridView add support for AllowUserToResizeColumns property.
			//fgOrders.AllowUserToResizeColumns = false;
			// gap-todo: PBI 749073. DataGridView add support for AllowUserToResizeRows property.
			//fgOrders.AllowUserToResizeRows = false;
			fgOrders.BorderStyle = BorderStyle.None;
            fgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			fgOrders.ColumnsCount = 1;
			fgOrders.FixedColumns = 0;
			fgOrders.FixedRows = 0;
			fgOrders.Location = new System.Drawing.Point(8, 168);
			fgOrders.Name = "fgOrders";
			fgOrders.ReadOnly = true;
			fgOrders.RowsCount = 1;
			fgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			// gap-todo: PBI 749071. DataGridView add support for ShowCellToolTips property.
			//fgOrders.ShowCellToolTips = false;
			fgOrders.Size = new System.Drawing.Size(505, 265);
			// gap-todo: PBI 749068. DataGridView add support for StandardTab property.
			//fgOrders.StandardTab = true;
			fgOrders.TabIndex = 8;
			fgOrders.DoubleClick += new System.EventHandler(fgOrders_DoubleClick);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = DockStyle.Bottom;
			sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 471);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(523, 25);
			sbStatusBar.TabIndex = 18;
			sbStatusBar.Items.AddRange(new ToolStripItem[]{sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = (ToolStripStatusLabelBorderSides) (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom);
            sbStatusBar_Panels_Panel1.BorderStyle = Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel1.Margin = new Padding(0);
			sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(523, 25);
			sbStatusBar_Panels_Panel1.Spring = true;
			sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel1.TextImageRelation = TextImageRelation.ImageBeforeText;
			// 
			// cmdCancel
			// 
			cmdCancel.AllowDrop = true;
			cmdCancel.BackColor = System.Drawing.SystemColors.Control;
			cmdCancel.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdCancel.Location = new System.Drawing.Point(328, 440);
			cmdCancel.Name = "cmdCancel";
			cmdCancel.RightToLeft = RightToLeft.No;
			cmdCancel.Size = new System.Drawing.Size(89, 25);
			cmdCancel.TabIndex = 11;
			cmdCancel.Text = "Cancel "; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdCancel.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdCancel.UseVisualStyleBackColor = false;
			cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
			// 
			// cmdClose
			// 
			cmdClose.AllowDrop = true;
			cmdClose.BackColor = System.Drawing.SystemColors.Control;
			cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdClose.Location = new System.Drawing.Point(424, 440);
			cmdClose.Name = "cmdClose";
			cmdClose.RightToLeft = RightToLeft.No;
			cmdClose.Size = new System.Drawing.Size(89, 25);
			cmdClose.TabIndex = 12;
			cmdClose.Text = "Close"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdClose.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdClose.UseVisualStyleBackColor = false;
			cmdClose.Click += new System.EventHandler(cmdClose_Click);
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(cmbStatus);
			Frame1.Controls.Add(chkTo);
			Frame1.Controls.Add(chkFrom);
			Frame1.Controls.Add(txtProductID);
			Frame1.Controls.Add(txtOrderID);
			Frame1.Controls.Add(txtContactLastName);
			Frame1.Controls.Add(txtContactName);
			Frame1.Controls.Add(cmdProviders);
			Frame1.Controls.Add(txtProviderName);
			Frame1.Controls.Add(dtFrom);
			Frame1.Controls.Add(dtTo);
			Frame1.Controls.Add(Label5);
			Frame1.Controls.Add(Label8);
			Frame1.Controls.Add(Label1);
			Frame1.Controls.Add(Label6);
			Frame1.Controls.Add(Label3);
			Frame1.Controls.Add(Label4);
			Frame1.Controls.Add(Label2);
            // gap-todo: PBI 745731. Control Cursor property is not supported.
            //Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 8);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(505, 153);
			Frame1.TabIndex = 13;
			Frame1.Text = "Search supplier";
			Frame1.Visible = true;
			// 
			// cmbStatus
			// 
			cmbStatus.AllowDrop = true;
			cmbStatus.BackColor = System.Drawing.SystemColors.Window;
			cmbStatus.CausesValidation = true;
			cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbStatus.Enabled = true;
			cmbStatus.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbStatus.IntegralHeight = true;
			cmbStatus.Location = new System.Drawing.Point(336, 16);
			cmbStatus.Name = "cmbStatus";
			cmbStatus.RightToLeft = RightToLeft.No;
			cmbStatus.Size = new System.Drawing.Size(145, 21);
			cmbStatus.Sorted = false;
			cmbStatus.TabIndex = 1;
			cmbStatus.TabStop = true;
			cmbStatus.Visible = true;
			cmbStatus.Items.AddRange(new object[]{"All", "Received", "Cancelled", "Approved"});
			cmbStatus.SelectedIndexChanged += new System.EventHandler(cmbStatus_SelectedIndexChanged);
			// 
			// chkTo
			// 
			chkTo.AllowDrop = true;
			chkTo.Appearance = Appearance.Normal;
			chkTo.BackColor = System.Drawing.SystemColors.Control;
			chkTo.CausesValidation = true;
			chkTo.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkTo.CheckState = CheckState.Unchecked;
			chkTo.Enabled = true;
			chkTo.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			chkTo.ForeColor = System.Drawing.SystemColors.ControlText;
			chkTo.Location = new System.Drawing.Point(336, 80);
			chkTo.Name = "chkTo";
			chkTo.RightToLeft = RightToLeft.No;
			chkTo.Size = new System.Drawing.Size(41, 17);
			chkTo.TabIndex = 23;
			chkTo.TabStop = false;
			chkTo.Text = "To:";
			chkTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkTo.Visible = true;
			// 
			// chkFrom
			// 
			chkFrom.AllowDrop = true;
			chkFrom.Appearance = Appearance.Normal;
			chkFrom.BackColor = System.Drawing.SystemColors.Control;
			chkFrom.CausesValidation = true;
			chkFrom.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkFrom.CheckState = CheckState.Unchecked;
			chkFrom.Enabled = true;
			chkFrom.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			chkFrom.ForeColor = System.Drawing.SystemColors.ControlText;
			chkFrom.Location = new System.Drawing.Point(88, 80);
			chkFrom.Name = "chkFrom";
			chkFrom.RightToLeft = RightToLeft.No;
			chkFrom.Size = new System.Drawing.Size(47, 17);
			chkFrom.TabIndex = 22;
			chkFrom.TabStop = false;
			chkFrom.Text = "From:";
			chkFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkFrom.Visible = true;
			// 
			// txtProductID
			// 
			txtProductID.AcceptsReturn = true;
			txtProductID.AllowDrop = true;
			txtProductID.BackColor = System.Drawing.SystemColors.Window;
			txtProductID.BorderStyle = BorderStyle.Fixed3D;
            // gap-todo: PBI 745731. Control Cursor property is not supported.
            //txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtProductID.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtProductID.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProductID.Location = new System.Drawing.Point(336, 112);
			txtProductID.MaxLength = 0;
			txtProductID.Name = "txtProductID";
			txtProductID.RightToLeft = RightToLeft.No;
			txtProductID.Size = new System.Drawing.Size(145, 20);
			txtProductID.TabIndex = 7;
			txtProductID.TextChanged += new System.EventHandler(txtProductID_TextChanged);
			// 
			// txtOrderID
			// 
			txtOrderID.AcceptsReturn = true;
			txtOrderID.AllowDrop = true;
			txtOrderID.BackColor = System.Drawing.SystemColors.Window;
			txtOrderID.BorderStyle = BorderStyle.Fixed3D;
            // gap-todo: PBI 745731. Control Cursor property is not supported.
            //txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderID.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtOrderID.ForeColor = System.Drawing.SystemColors.WindowText;
			txtOrderID.Location = new System.Drawing.Point(88, 112);
			txtOrderID.MaxLength = 0;
			txtOrderID.Name = "txtOrderID";
			txtOrderID.RightToLeft = RightToLeft.No;
			txtOrderID.Size = new System.Drawing.Size(145, 20);
			txtOrderID.TabIndex = 6;
			txtOrderID.TextChanged += new System.EventHandler(txtOrderID_TextChanged);
			// 
			// txtContactLastName
			// 
			txtContactLastName.AcceptsReturn = true;
			txtContactLastName.AllowDrop = true;
			txtContactLastName.BackColor = System.Drawing.SystemColors.Window;
			txtContactLastName.BorderStyle = BorderStyle.Fixed3D;
            // gap-todo: PBI 745731. Control Cursor property is not supported.
            //txtContactLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtContactLastName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtContactLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtContactLastName.Location = new System.Drawing.Point(336, 48);
			txtContactLastName.MaxLength = 0;
			txtContactLastName.Name = "txtContactLastName";
			txtContactLastName.RightToLeft = RightToLeft.No;
			txtContactLastName.Size = new System.Drawing.Size(145, 20);
			txtContactLastName.TabIndex = 3;
			txtContactLastName.TextChanged += new System.EventHandler(txtContactLastName_TextChanged);
			// 
			// txtContactName
			// 
			txtContactName.AcceptsReturn = true;
			txtContactName.AllowDrop = true;
			txtContactName.BackColor = System.Drawing.SystemColors.Window;
			txtContactName.BorderStyle = BorderStyle.Fixed3D;
            // gap-todo: PBI 745731. Control Cursor property is not supported.
            //txtContactName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtContactName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtContactName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtContactName.Location = new System.Drawing.Point(88, 48);
			txtContactName.MaxLength = 0;
			txtContactName.Name = "txtContactName";
			txtContactName.RightToLeft = RightToLeft.No;
			txtContactName.Size = new System.Drawing.Size(145, 20);
			txtContactName.TabIndex = 2;
			txtContactName.TextChanged += new System.EventHandler(txtContactName_TextChanged);
			// 
			// cmdProviders
			// 
			cmdProviders.AllowDrop = true;
			cmdProviders.BackColor = System.Drawing.SystemColors.Control;
			cmdProviders.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdProviders.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdProviders.Location = new System.Drawing.Point(240, 16);
			cmdProviders.Name = "cmdProviders";
			cmdProviders.RightToLeft = RightToLeft.No;
			cmdProviders.Size = new System.Drawing.Size(25, 21);
			cmdProviders.TabIndex = 14;
			cmdProviders.TabStop = false;
			cmdProviders.Text = "...";
			cmdProviders.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdProviders.UseVisualStyleBackColor = false;
			cmdProviders.Click += new System.EventHandler(cmdProviders_Click);
			// 
			// txtProviderName
			// 
			txtProviderName.AcceptsReturn = true;
			txtProviderName.AllowDrop = true;
			txtProviderName.BackColor = System.Drawing.SystemColors.Window;
			txtProviderName.BorderStyle = BorderStyle.Fixed3D;
            // gap-todo: PBI 745731. Control Cursor property is not supported.
            //txtProviderName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtProviderName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtProviderName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProviderName.Location = new System.Drawing.Point(88, 16);
			txtProviderName.MaxLength = 0;
			txtProviderName.Name = "txtProviderName";
			txtProviderName.RightToLeft = RightToLeft.No;
			txtProviderName.Size = new System.Drawing.Size(145, 20);
			txtProviderName.TabIndex = 0;
			txtProviderName.TextChanged += new System.EventHandler(txtProviderName_TextChanged);
			// 
			// dtFrom
			// 
			dtFrom.AllowDrop = true;
			dtFrom.Checked = false;
			dtFrom.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			dtFrom.Format = DateTimePickerFormat.Short;
			dtFrom.Location = new System.Drawing.Point(136, 80);
			dtFrom.Name = "dtFrom";
			dtFrom.Size = new System.Drawing.Size(97, 20);
			dtFrom.TabIndex = 4;
			dtFrom.ValueChanged += new System.EventHandler(dtFrom_ValueChanged);
			// 
			// dtTo
			// 
			dtTo.AllowDrop = true;
			dtTo.Checked = false;
			dtTo.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			dtTo.Format = DateTimePickerFormat.Short;
			dtTo.Location = new System.Drawing.Point(384, 80);
			dtTo.Name = "dtTo";
			dtTo.Size = new System.Drawing.Size(97, 20);
			dtTo.TabIndex = 5;
			dtTo.ValueChanged += new System.EventHandler(dtTo_ValueChanged);
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = BorderStyle.None;
			Label5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(288, 20);
			Label5.MinimumSize = new System.Drawing.Size(41, 17);
			Label5.Name = "Label5";
			Label5.RightToLeft = RightToLeft.No;
			Label5.Size = new System.Drawing.Size(41, 17);
			Label5.TabIndex = 24;
			Label5.Text = "Status";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = BorderStyle.None;
			Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(264, 112);
			Label8.MinimumSize = new System.Drawing.Size(65, 17);
			Label8.Name = "Label8";
			Label8.RightToLeft = RightToLeft.No;
			Label8.Size = new System.Drawing.Size(65, 17);
			Label8.TabIndex = 21;
			Label8.Text = "Product";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = BorderStyle.None;
			Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(8, 112);
			Label1.MinimumSize = new System.Drawing.Size(89, 17);
			Label1.Name = "Label1";
			Label1.RightToLeft = RightToLeft.No;
			Label1.Size = new System.Drawing.Size(89, 17);
			Label1.TabIndex = 20;
			Label1.Text = "Order";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = BorderStyle.None;
			Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(8, 80);
			Label6.MinimumSize = new System.Drawing.Size(65, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = RightToLeft.No;
			Label6.Size = new System.Drawing.Size(65, 17);
			Label6.TabIndex = 19;
			Label6.Text = "Dates";
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = BorderStyle.None;
			Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(264, 48);
			Label3.MinimumSize = new System.Drawing.Size(57, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = RightToLeft.No;
			Label3.Size = new System.Drawing.Size(57, 17);
			Label3.TabIndex = 17;
			Label3.Text = "Last Name";
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = BorderStyle.None;
			Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(8, 16);
			Label4.MinimumSize = new System.Drawing.Size(89, 17);
			Label4.Name = "Label4";
			Label4.RightToLeft = RightToLeft.No;
			Label4.Size = new System.Drawing.Size(89, 17);
			Label4.TabIndex = 16;
			Label4.Text = "Supplier";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = BorderStyle.None;
			Label2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(8, 48);
			Label2.MinimumSize = new System.Drawing.Size(89, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = RightToLeft.No;
			Label2.Size = new System.Drawing.Size(89, 17);
			Label2.TabIndex = 15;
			Label2.Text = "First Name";
			// 
			// frmReceptionApproval
			// 
			AllowDrop = true;
            // gap-todo: PBI 745733. AutoScaleDimensions property not supported.
            //AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
            // gap-todo: PBI 745734: AutoScaleMode property not supported.
            //AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(523, 496);
			Controls.Add(cmdApprove);
			Controls.Add(cmdInfo);
            Controls.Add(fgOrders);
            Controls.Add(sbStatusBar);
			Controls.Add(cmdCancel);
			Controls.Add(cmdClose);
			Controls.Add(Frame1);
			Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(3, 25);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmReceptionApproval";
			RightToLeft = RightToLeft.No;
			StartPosition = FormStartPosition.Manual;
			Text = "Add Stock to Inventory";
            // gap-note: The CommandButtonHelper should be generated as a stub.
            //commandButtonHelper1.SetStyle(cmdApprove, 0);
            //commandButtonHelper1.SetStyle(cmdInfo, 0);
            //commandButtonHelper1.SetStyle(cmdCancel, 0);
            //commandButtonHelper1.SetStyle(cmdClose, 0);
            //commandButtonHelper1.SetStyle(cmdProviders, 0);
            //listBoxComboBoxHelper1.SetItemData(cmbStatus, new int[]{0, 0, 0, 0});
			Activated += new System.EventHandler(frmReceptionApproval_Activated);
			Closed += new System.EventHandler(Form_Closed);
			// gap-todo: PBI 749102. DataGridView implement ISupportInitialize interface and add equivalent support for DataGridViewFlex methods.
			//((System.ComponentModel.ISupportInitialize) fgOrders).EndInit();
			//((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).EndInit();
			sbStatusBar.ResumeLayout(false);
			Frame1.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
            //This form is an MDI child.
            //This code simulates the VB6 
            // functionality of automatically
            // loading and showing an MDI
            // child's parent.
            // gap-todo: PBI 742816. Research and implement MDI mechanism for the Form Control.
            MdiParent = frmMain.DefInstance;
            SKS_Blazor.Components.frmMain.DefInstance.Show();
		}
		#endregion
	}
}