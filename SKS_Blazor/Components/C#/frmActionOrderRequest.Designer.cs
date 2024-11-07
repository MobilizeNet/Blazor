using Gap.Blazor;

namespace SKS_Blazor.Components
{
	partial class frmActionOrderRequest
	{
		#region "Upgrade Support "
		private static frmActionOrderRequest m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmActionOrderRequest DefInstance
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
		public static frmActionOrderRequest CreateInstance()
		{
			frmActionOrderRequest theInstance = new frmActionOrderRequest();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[] { "components", "ToolTipMain", "txtPromisedBy", "txtRequiredBy", "txtReceivedBy", "cmdApprove", "txtStatus", "txtReceived", "txtChangedBy", "txtChanged", "txtOrderID", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgDetails", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "txtCustomerContact", "txtCustomerCompany", "Label5", "Label1", "Frame2", "Label13", "Label2", "Label7", "Label3", "Label19", "lblChangedBy", "Label4", "lblChanged", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "commandButtonHelper1" };
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public ToolTip ToolTipMain;
		public TextBox txtPromisedBy;
		public TextBox txtRequiredBy;
		public TextBox txtReceivedBy;
		public Button cmdApprove;
		public TextBox txtStatus;
		public TextBox txtReceived;
		public TextBox txtChangedBy;
		public TextBox txtChanged;
		public TextBox txtOrderID;
		public TextBox txtNotes;
		public TextBox txtSubTotal;
		public TextBox txtTotal;
		public TextBox txtTotalTax;
		public TextBox txtFreightCharge;
		public TextBox txtSalesTax;
		public TextBox txtEntry;
		public DataGridViewFlex fgDetails;
		public ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public StatusStrip sbStatusBar;
		public Button cmdCancel;
		public Button cmdClose;
		public TextBox txtCustomerContact;
		public TextBox txtCustomerCompany;
		public Label Label5;
		public Label Label1;
		public GroupBox Frame2;
		public Label Label13;
		public Label Label2;
		public Label Label7;
		public Label Label3;
		public Label Label19;
		public Label lblChangedBy;
		public Label Label4;
		public Label lblChanged;
		public Label Label12;
		public Label Label11;
		public Label Label10;
		public Label Label9;
		public Label Label8;
		public Label Label6;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionOrderRequest));
			ToolTipMain = new ToolTip(components);
			txtPromisedBy = new TextBox();
			txtRequiredBy = new TextBox();
			txtReceivedBy = new TextBox();
			cmdApprove = new Button();
			txtStatus = new TextBox();
			txtReceived = new TextBox();
			txtChangedBy = new TextBox();
			txtChanged = new TextBox();
			txtOrderID = new TextBox();
			txtNotes = new TextBox();
			txtSubTotal = new TextBox();
			txtTotal = new TextBox();
			txtTotalTax = new TextBox();
			txtFreightCharge = new TextBox();
			txtSalesTax = new TextBox();
			txtEntry = new TextBox();
			// gap-todo: Bug 749104. DataGridView constructor does not take the container as an argument as the DataGridViewFlex.
			fgDetails = new DataGridViewFlex(); //new DataGridView(components);
			sbStatusBar = new StatusStrip();
			sbStatusBar_Panels_Panel1 = new ToolStripStatusLabel();
			cmdCancel = new Button();
			cmdClose = new Button();
			Frame2 = new GroupBox();
			txtCustomerContact = new TextBox();
			txtCustomerCompany = new TextBox();
			Label5 = new Label();
			Label1 = new Label();
			Label13 = new Label();
			Label2 = new Label();
			Label7 = new Label();
			Label3 = new Label();
			Label19 = new Label();
			lblChangedBy = new Label();
			Label4 = new Label();
			lblChanged = new Label();
			Label12 = new Label();
			Label11 = new Label();
			Label10 = new Label();
			Label9 = new Label();
			Label8 = new Label();
			Label6 = new Label();
			sbStatusBar.SuspendLayout();
			Frame2.SuspendLayout();
			SuspendLayout();
			// gap-note: This is generated as a stub.
			//commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// gap-todo: PBI 749102. DataGridView implement ISupportInitialize interface and add equivalent support for DataGridViewFlex methods.
			//((System.ComponentModel.ISupportInitialize) fgDetails).BeginInit();
			// 
			// txtPromisedBy
			// 
			txtPromisedBy.AcceptsReturn = true;
			txtPromisedBy.AllowDrop = true;
			txtPromisedBy.BackColor = System.Drawing.SystemColors.Menu;
			txtPromisedBy.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtPromisedBy.Cursor = Cursors.IBeam;
			txtPromisedBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtPromisedBy.ForeColor = Gap.Blazor.SystemColors.WindowText;
			txtPromisedBy.Location = new System.Drawing.Point(368, 200);
			txtPromisedBy.MaxLength = 0;
			txtPromisedBy.Name = "txtPromisedBy";
			txtPromisedBy.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtPromisedBy.RightToLeft = RightToLeft.No;
			txtPromisedBy.Size = new System.Drawing.Size(105, 20);
			txtPromisedBy.TabIndex = 38;
			txtPromisedBy.TabStop = false;
			// 
			// txtRequiredBy
			// 
			txtRequiredBy.AcceptsReturn = true;
			txtRequiredBy.AllowDrop = true;
			txtRequiredBy.BackColor = Gap.Blazor.SystemColors.Menu;
			txtRequiredBy.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtRequiredBy.Cursor = Cursors.IBeam;
			txtRequiredBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtRequiredBy.ForeColor = System.Drawing.SystemColors.WindowText;
			txtRequiredBy.Location = new System.Drawing.Point(120, 200);
			txtRequiredBy.MaxLength = 0;
			txtRequiredBy.Name = "txtRequiredBy";
			txtRequiredBy.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtRequiredBy.RightToLeft = RightToLeft.No;
			txtRequiredBy.Size = new System.Drawing.Size(105, 20);
			txtRequiredBy.TabIndex = 37;
			txtRequiredBy.TabStop = false;
			// 
			// txtReceivedBy
			// 
			txtReceivedBy.AcceptsReturn = true;
			txtReceivedBy.AllowDrop = true;
			txtReceivedBy.BackColor = System.Drawing.SystemColors.Menu;
			txtReceivedBy.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtReceivedBy.Cursor = Cursors.IBeam;
			txtReceivedBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtReceivedBy.ForeColor = System.Drawing.SystemColors.WindowText;
			txtReceivedBy.Location = new System.Drawing.Point(96, 64);
			txtReceivedBy.MaxLength = 0;
			txtReceivedBy.Name = "txtReceivedBy";
			txtReceivedBy.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtReceivedBy.RightToLeft = RightToLeft.No;
			txtReceivedBy.Size = new System.Drawing.Size(105, 20);
			txtReceivedBy.TabIndex = 33;
			txtReceivedBy.TabStop = false;
			// 
			// cmdApprove
			// 
			cmdApprove.AllowDrop = true;
			cmdApprove.BackColor = System.Drawing.SystemColors.Control;
			cmdApprove.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdApprove.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdApprove.Location = new System.Drawing.Point(232, 480);
			cmdApprove.Name = "cmdApprove";
			// gap-todo: PBI 745898. Property RightToLeft is not supported in the button component.
			//cmdApprove.RightToLeft = RightToLeft.No;
			cmdApprove.Size = new System.Drawing.Size(89, 25);
			cmdApprove.TabIndex = 0;
			cmdApprove.Text = "Create"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdApprove.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdApprove.UseVisualStyleBackColor = false;
			cmdApprove.Click += new System.EventHandler(cmdApprove_Click);
			// 
			// txtStatus
			// 
			txtStatus.AcceptsReturn = true;
			txtStatus.AllowDrop = true;
			txtStatus.BackColor = System.Drawing.SystemColors.Menu;
			txtStatus.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtStatus.Cursor = Cursors.IBeam;
			txtStatus.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtStatus.ForeColor = System.Drawing.SystemColors.WindowText;
			txtStatus.Location = new System.Drawing.Point(408, 8);
			txtStatus.MaxLength = 0;
			txtStatus.Name = "txtStatus";
			txtStatus.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtStatus.RightToLeft = RightToLeft.No;
			txtStatus.Size = new System.Drawing.Size(105, 20);
			txtStatus.TabIndex = 31;
			txtStatus.TabStop = false;
			// 
			// txtReceived
			// 
			txtReceived.AcceptsReturn = true;
			txtReceived.AllowDrop = true;
			txtReceived.BackColor = System.Drawing.SystemColors.Menu;
			txtReceived.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtReceived.Cursor = Cursors.IBeam;
			txtReceived.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtReceived.ForeColor = System.Drawing.SystemColors.WindowText;
			txtReceived.Location = new System.Drawing.Point(96, 36);
			txtReceived.MaxLength = 0;
			txtReceived.Name = "txtReceived";
			txtReceived.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtReceived.RightToLeft = RightToLeft.No;
			txtReceived.Size = new System.Drawing.Size(105, 20);
			txtReceived.TabIndex = 29;
			txtReceived.TabStop = false;
			// 
			// txtChangedBy
			// 
			txtChangedBy.AcceptsReturn = true;
			txtChangedBy.AllowDrop = true;
			txtChangedBy.BackColor = System.Drawing.SystemColors.Menu;
			txtChangedBy.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtChangedBy.Cursor = Cursors.IBeam;
			txtChangedBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtChangedBy.ForeColor = System.Drawing.SystemColors.WindowText;
			txtChangedBy.Location = new System.Drawing.Point(408, 64);
			txtChangedBy.MaxLength = 0;
			txtChangedBy.Name = "txtChangedBy";
			txtChangedBy.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtChangedBy.RightToLeft = RightToLeft.No;
			txtChangedBy.Size = new System.Drawing.Size(105, 20);
			txtChangedBy.TabIndex = 25;
			txtChangedBy.TabStop = false;
			// 
			// txtChanged
			// 
			txtChanged.AcceptsReturn = true;
			txtChanged.AllowDrop = true;
			txtChanged.BackColor = System.Drawing.SystemColors.Menu;
			txtChanged.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtChanged.Cursor = Cursors.IBeam;
			txtChanged.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtChanged.ForeColor = System.Drawing.SystemColors.WindowText;
			txtChanged.Location = new System.Drawing.Point(408, 36);
			txtChanged.MaxLength = 0;
			txtChanged.Name = "txtChanged";
			txtChanged.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtChanged.RightToLeft = RightToLeft.No;
			txtChanged.Size = new System.Drawing.Size(105, 20);
			txtChanged.TabIndex = 24;
			txtChanged.TabStop = false;
			// 
			// txtOrderID
			// 
			txtOrderID.AcceptsReturn = true;
			txtOrderID.AllowDrop = true;
			txtOrderID.BackColor = System.Drawing.SystemColors.Menu;
			txtOrderID.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtOrderID.Cursor = Cursors.IBeam;
			txtOrderID.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtOrderID.ForeColor = System.Drawing.SystemColors.WindowText;
			txtOrderID.Location = new System.Drawing.Point(96, 8);
			txtOrderID.MaxLength = 0;
			txtOrderID.Name = "txtOrderID";
			txtOrderID.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtOrderID.RightToLeft = RightToLeft.No;
			txtOrderID.Size = new System.Drawing.Size(105, 20);
			txtOrderID.TabIndex = 23;
			txtOrderID.TabStop = false;
			// 
			// txtNotes
			// 
			txtNotes.AcceptsReturn = true;
			txtNotes.AllowDrop = true;
			txtNotes.BackColor = System.Drawing.SystemColors.Menu;
			txtNotes.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtNotes.Cursor = Cursors.IBeam;
			txtNotes.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
			txtNotes.Location = new System.Drawing.Point(56, 152);
			txtNotes.MaxLength = 0;
			txtNotes.Multiline = true;
			txtNotes.Name = "txtNotes";
			txtNotes.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtNotes.RightToLeft = RightToLeft.No;
			txtNotes.Size = new System.Drawing.Size(457, 44);
			txtNotes.TabIndex = 3;
			txtNotes.TabStop = false;
			// 
			// txtSubTotal
			// 
			txtSubTotal.AcceptsReturn = true;
			txtSubTotal.AllowDrop = true;
			txtSubTotal.BackColor = System.Drawing.SystemColors.Menu;
			txtSubTotal.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtSubTotal.Cursor = Cursors.IBeam;
			txtSubTotal.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			txtSubTotal.Location = new System.Drawing.Point(368, 432);
			txtSubTotal.MaxLength = 0;
			txtSubTotal.Name = "txtSubTotal";
			txtSubTotal.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtSubTotal.RightToLeft = RightToLeft.No;
			txtSubTotal.Size = new System.Drawing.Size(145, 20);
			txtSubTotal.TabIndex = 21;
			txtSubTotal.TabStop = false;
			txtSubTotal.TextAlign = HorizontalAlignment.Right;
			// 
			// txtTotal
			// 
			txtTotal.AcceptsReturn = true;
			txtTotal.AllowDrop = true;
			txtTotal.BackColor = System.Drawing.SystemColors.Menu;
			txtTotal.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtTotal.Cursor = Cursors.IBeam;
			txtTotal.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			txtTotal.Location = new System.Drawing.Point(88, 456);
			txtTotal.MaxLength = 0;
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtTotal.RightToLeft = RightToLeft.No;
			txtTotal.Size = new System.Drawing.Size(145, 20);
			txtTotal.TabIndex = 19;
			txtTotal.TabStop = false;
			txtTotal.TextAlign = HorizontalAlignment.Right;
			// 
			// txtTotalTax
			// 
			txtTotalTax.AcceptsReturn = true;
			txtTotalTax.AllowDrop = true;
			txtTotalTax.BackColor = System.Drawing.SystemColors.Menu;
			txtTotalTax.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtTotalTax.Cursor = Cursors.IBeam;
			txtTotalTax.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtTotalTax.ForeColor = System.Drawing.SystemColors.WindowText;
			txtTotalTax.Location = new System.Drawing.Point(368, 408);
			txtTotalTax.MaxLength = 0;
			txtTotalTax.Name = "txtTotalTax";
			txtTotalTax.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtTotalTax.RightToLeft = RightToLeft.No;
			txtTotalTax.Size = new System.Drawing.Size(145, 20);
			txtTotalTax.TabIndex = 17;
			txtTotalTax.TabStop = false;
			txtTotalTax.TextAlign = HorizontalAlignment.Right;
			// 
			// txtFreightCharge
			// 
			txtFreightCharge.AcceptsReturn = true;
			txtFreightCharge.AllowDrop = true;
			txtFreightCharge.BackColor = System.Drawing.SystemColors.Menu;
			txtFreightCharge.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtFreightCharge.Cursor = Cursors.IBeam;
			txtFreightCharge.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText;
			txtFreightCharge.Location = new System.Drawing.Point(88, 432);
			txtFreightCharge.MaxLength = 0;
			txtFreightCharge.Name = "txtFreightCharge";
			txtFreightCharge.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtFreightCharge.RightToLeft = RightToLeft.No;
			txtFreightCharge.Size = new System.Drawing.Size(145, 20);
			txtFreightCharge.TabIndex = 6;
			txtFreightCharge.TabStop = false;
			txtFreightCharge.TextAlign = HorizontalAlignment.Right;
			// 
			// txtSalesTax
			// 
			txtSalesTax.AcceptsReturn = true;
			txtSalesTax.AllowDrop = true;
			txtSalesTax.BackColor = System.Drawing.SystemColors.Menu;
			txtSalesTax.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtSalesTax.Cursor = Cursors.IBeam;
			txtSalesTax.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText;
			txtSalesTax.Location = new System.Drawing.Point(88, 408);
			txtSalesTax.MaxLength = 0;
			txtSalesTax.Name = "txtSalesTax";
			txtSalesTax.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtSalesTax.RightToLeft = RightToLeft.No;
			txtSalesTax.Size = new System.Drawing.Size(145, 20);
			txtSalesTax.TabIndex = 5;
			txtSalesTax.TabStop = false;
			txtSalesTax.TextAlign = HorizontalAlignment.Right;
			// 
			// txtEntry
			// 
			txtEntry.AcceptsReturn = true;
			txtEntry.AllowDrop = true;
			txtEntry.BackColor = System.Drawing.SystemColors.Window;
			txtEntry.BorderStyle = BorderStyle.None;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtEntry.Cursor = Cursors.IBeam;
			txtEntry.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtEntry.ForeColor = System.Drawing.SystemColors.WindowText;
			txtEntry.Location = new System.Drawing.Point(416, 336);
			txtEntry.MaxLength = 0;
			txtEntry.Name = "txtEntry";
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtEntry.RightToLeft = RightToLeft.No;
			txtEntry.Size = new System.Drawing.Size(73, 19);
			txtEntry.TabIndex = 14;
			txtEntry.Visible = false;
			// 
			// fgDetails
			// 
			fgDetails.AllowDrop = true;
			fgDetails.AllowUserToAddRows = false;
			fgDetails.AllowUserToDeleteRows = false;
			// gap-todo: PBI 749072. DataGridView add support for AllowUserToResizeColumns property.
			//fgDetails.AllowUserToResizeColumns = false;
			// gap-todo: PBI 749073. DataGridView add support for AllowUserToResizeRows property.
			//fgDetails.AllowUserToResizeRows = false;
			fgDetails.BorderStyle = BorderStyle.None;
			fgDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			fgDetails.ColumnsCount = 0;
			fgDetails.FixedColumns = 0;
			fgDetails.FixedRows = 0;
			fgDetails.Location = new System.Drawing.Point(8, 224);
			fgDetails.Name = "fgDetails";
			fgDetails.ReadOnly = true;
			fgDetails.RowsCount = 2;
			fgDetails.SelectionMode = DataGridViewSelectionMode.CellSelect;
			// gap-todo: PBI 749071. DataGridView add support for ShowCellToolTips property.
			//fgDetails.ShowCellToolTips = false;
			fgDetails.Size = new System.Drawing.Size(505, 177);
			// gap-todo: PBI 749068. DataGridView add support for StandardTab property.
			//fgDetails.StandardTab = true;
			fgDetails.TabIndex = 4;
			fgDetails.TabStop = false;
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = DockStyle.Bottom;
			sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 509);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(523, 25);
			sbStatusBar.TabIndex = 13;
			sbStatusBar.Items.AddRange(new ToolStripItem[] { sbStatusBar_Panels_Panel1 });
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = (ToolStripStatusLabelBorderSides)(ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom);
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
			cmdCancel.Location = new System.Drawing.Point(328, 480);
			cmdCancel.Name = "cmdCancel";
			// gap-todo: PBI 745898. Property RightToLeft is not supported in the button component.
			//cmdCancel.RightToLeft = RightToLeft.No;
			cmdCancel.Size = new System.Drawing.Size(89, 25);
			cmdCancel.TabIndex = 1;
			cmdCancel.Text = "Cancel"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
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
			cmdClose.Location = new System.Drawing.Point(424, 480);
			cmdClose.Name = "cmdClose";
			// gap-todo: PBI 745898. Property RightToLeft is not supported in the button component.
			//cmdClose.RightToLeft = RightToLeft.No;
			cmdClose.Size = new System.Drawing.Size(89, 25);
			cmdClose.TabIndex = 2;
			cmdClose.Text = "Close"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdClose.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdClose.UseVisualStyleBackColor = false;
			cmdClose.Click += new System.EventHandler(cmdClose_Click);
			// 
			// Frame2
			// 
			Frame2.AllowDrop = true;
			Frame2.BackColor = System.Drawing.SystemColors.Control;
			Frame2.Controls.Add(txtCustomerContact);
			Frame2.Controls.Add(txtCustomerCompany);
			Frame2.Controls.Add(Label5);
			Frame2.Controls.Add(Label1);
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//Frame2.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame2.Enabled = true;
			Frame2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame2.Location = new System.Drawing.Point(8, 96);
			Frame2.Name = "Frame2";
			Frame2.RightToLeft = RightToLeft.No;
			Frame2.Size = new System.Drawing.Size(505, 49);
			Frame2.TabIndex = 7;
			Frame2.Text = "Customer";
			Frame2.Visible = true;
			// 
			// txtCustomerContact
			// 
			txtCustomerContact.AcceptsReturn = true;
			txtCustomerContact.AllowDrop = true;
			txtCustomerContact.BackColor = System.Drawing.SystemColors.Menu;
			txtCustomerContact.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtCustomerContact.Cursor = Cursors.IBeam;
			txtCustomerContact.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtCustomerContact.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCustomerContact.Location = new System.Drawing.Point(288, 16);
			txtCustomerContact.MaxLength = 0;
			txtCustomerContact.Name = "txtCustomerContact";
			txtCustomerContact.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtCustomerContact.RightToLeft = RightToLeft.No;
			txtCustomerContact.Size = new System.Drawing.Size(209, 20);
			txtCustomerContact.TabIndex = 11;
			txtCustomerContact.TabStop = false;
			// 
			// txtCustomerCompany
			// 
			txtCustomerCompany.AcceptsReturn = true;
			txtCustomerCompany.AllowDrop = true;
			txtCustomerCompany.BackColor = System.Drawing.SystemColors.Menu;
			txtCustomerCompany.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Control Cursor property is not supported.
			//txtCustomerCompany.Cursor = Cursors.IBeam;
			txtCustomerCompany.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtCustomerCompany.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCustomerCompany.Location = new System.Drawing.Point(72, 16);
			txtCustomerCompany.MaxLength = 0;
			txtCustomerCompany.Name = "txtCustomerCompany";
			txtCustomerCompany.ReadOnly = true;
			// gap-todo: PBI 745895. Property RightToLeft is not supported in the textbox component.
			//txtCustomerCompany.RightToLeft = RightToLeft.No;
			txtCustomerCompany.Size = new System.Drawing.Size(145, 20);
			txtCustomerCompany.TabIndex = 10;
			txtCustomerCompany.TabStop = false;
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = BorderStyle.None;
			Label5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(8, 16);
			Label5.MinimumSize = new System.Drawing.Size(57, 17);
			Label5.Name = "Label5";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label5.RightToLeft = RightToLeft.No;
			Label5.Size = new System.Drawing.Size(57, 17);
			Label5.TabIndex = 9;
			Label5.Text = "Name:";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = BorderStyle.None;
			Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(232, 16);
			Label1.MinimumSize = new System.Drawing.Size(57, 17);
			Label1.Name = "Label1";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label1.RightToLeft = RightToLeft.No;
			Label1.Size = new System.Drawing.Size(57, 17);
			Label1.TabIndex = 8;
			Label1.Text = "Contact:";
			// 
			// Label13
			// 
			Label13.AllowDrop = true;
			Label13.BackColor = System.Drawing.SystemColors.Control;
			Label13.BorderStyle = BorderStyle.None;
			Label13.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			Label13.Location = new System.Drawing.Point(16, 200);
			Label13.MinimumSize = new System.Drawing.Size(105, 17);
			Label13.Name = "Label13";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label13.RightToLeft = RightToLeft.No;
			Label13.Size = new System.Drawing.Size(105, 17);
			Label13.TabIndex = 36;
			Label13.Text = "Required";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = BorderStyle.None;
			Label2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(264, 200);
			Label2.MinimumSize = new System.Drawing.Size(105, 17);
			Label2.Name = "Label2";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label2.RightToLeft = RightToLeft.No;
			Label2.Size = new System.Drawing.Size(105, 17);
			Label2.TabIndex = 35;
			Label2.Text = "Promised";
			// 
			// Label7
			// 
			Label7.AllowDrop = true;
			Label7.BackColor = System.Drawing.SystemColors.Control;
			Label7.BorderStyle = BorderStyle.None;
			Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			Label7.Location = new System.Drawing.Point(8, 64);
			Label7.MinimumSize = new System.Drawing.Size(73, 17);
			Label7.Name = "Label7";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label7.RightToLeft = RightToLeft.No;
			Label7.Size = new System.Drawing.Size(73, 17);
			Label7.TabIndex = 34;
			Label7.Text = "By";
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = BorderStyle.None;
			Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(320, 8);
			Label3.MinimumSize = new System.Drawing.Size(49, 17);
			Label3.Name = "Label3";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label3.RightToLeft = RightToLeft.No;
			Label3.Size = new System.Drawing.Size(49, 17);
			Label3.TabIndex = 32;
			Label3.Text = "Status:";
			// 
			// Label19
			// 
			Label19.AllowDrop = true;
			Label19.BackColor = System.Drawing.SystemColors.Control;
			Label19.BorderStyle = BorderStyle.None;
			Label19.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label19.ForeColor = System.Drawing.SystemColors.ControlText;
			Label19.Location = new System.Drawing.Point(8, 32);
			Label19.MinimumSize = new System.Drawing.Size(57, 17);
			Label19.Name = "Label19";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label19.RightToLeft = RightToLeft.No;
			Label19.Size = new System.Drawing.Size(57, 17);
			Label19.TabIndex = 30;
			Label19.Text = "Requested:";
			// 
			// lblChangedBy
			// 
			lblChangedBy.AllowDrop = true;
			lblChangedBy.BackColor = System.Drawing.SystemColors.Control;
			lblChangedBy.BorderStyle = BorderStyle.None;
			lblChangedBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			lblChangedBy.ForeColor = System.Drawing.SystemColors.ControlText;
			lblChangedBy.Location = new System.Drawing.Point(320, 64);
			lblChangedBy.MinimumSize = new System.Drawing.Size(89, 17);
			lblChangedBy.Name = "lblChangedBy";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//lblChangedBy.RightToLeft = RightToLeft.No;
			lblChangedBy.Size = new System.Drawing.Size(89, 17);
			lblChangedBy.TabIndex = 28;
			lblChangedBy.Text = "By";
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = BorderStyle.None;
			Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(12, 8);
			Label4.MinimumSize = new System.Drawing.Size(49, 17);
			Label4.Name = "Label4";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label4.RightToLeft = RightToLeft.No;
			Label4.Size = new System.Drawing.Size(49, 17);
			Label4.TabIndex = 27;
			Label4.Text = "Order Id:";
			// 
			// lblChanged
			// 
			lblChanged.AllowDrop = true;
			lblChanged.BackColor = System.Drawing.SystemColors.Control;
			lblChanged.BorderStyle = BorderStyle.None;
			lblChanged.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			lblChanged.ForeColor = System.Drawing.SystemColors.ControlText;
			lblChanged.Location = new System.Drawing.Point(320, 36);
			lblChanged.MinimumSize = new System.Drawing.Size(89, 17);
			lblChanged.Name = "lblChanged";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//lblChanged.RightToLeft = RightToLeft.No;
			lblChanged.Size = new System.Drawing.Size(89, 17);
			lblChanged.TabIndex = 26;
			lblChanged.Text = "Changed:";
			// 
			// Label12
			// 
			Label12.AllowDrop = true;
			Label12.BackColor = System.Drawing.SystemColors.Control;
			Label12.BorderStyle = BorderStyle.None;
			Label12.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			Label12.Location = new System.Drawing.Point(8, 432);
			Label12.MinimumSize = new System.Drawing.Size(89, 17);
			Label12.Name = "Label12";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label12.RightToLeft = RightToLeft.No;
			Label12.Size = new System.Drawing.Size(89, 17);
			Label12.TabIndex = 22;
			Label12.Text = "Freight";
			// 
			// Label11
			// 
			Label11.AllowDrop = true;
			Label11.BackColor = System.Drawing.SystemColors.Control;
			Label11.BorderStyle = BorderStyle.None;
			Label11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			Label11.Location = new System.Drawing.Point(8, 456);
			Label11.MinimumSize = new System.Drawing.Size(89, 17);
			Label11.Name = "Label11";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label11.RightToLeft = RightToLeft.No;
			Label11.Size = new System.Drawing.Size(89, 17);
			Label11.TabIndex = 20;
			Label11.Text = "Total:";
			// 
			// Label10
			// 
			Label10.AllowDrop = true;
			Label10.BackColor = System.Drawing.SystemColors.Control;
			Label10.BorderStyle = BorderStyle.None;
			Label10.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			Label10.Location = new System.Drawing.Point(288, 408);
			Label10.MinimumSize = new System.Drawing.Size(89, 17);
			Label10.Name = "Label10";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label10.RightToLeft = RightToLeft.No;
			Label10.Size = new System.Drawing.Size(89, 17);
			Label10.TabIndex = 18;
			Label10.Text = "Total Tax:";
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = BorderStyle.None;
			Label9.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(288, 432);
			Label9.MinimumSize = new System.Drawing.Size(89, 17);
			Label9.Name = "Label9";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label9.RightToLeft = RightToLeft.No;
			Label9.Size = new System.Drawing.Size(89, 17);
			Label9.TabIndex = 16;
			Label9.Text = "Sub Total:";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = BorderStyle.None;
			Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(8, 408);
			Label8.MinimumSize = new System.Drawing.Size(89, 17);
			Label8.Name = "Label8";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label8.RightToLeft = RightToLeft.No;
			Label8.Size = new System.Drawing.Size(89, 17);
			Label8.TabIndex = 15;
			Label8.Text = "Sales Tax:";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = BorderStyle.None;
			Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(8, 160);
			Label6.MinimumSize = new System.Drawing.Size(33, 17);
			Label6.Name = "Label6";
			// gap-todo: PBI 745897. Property RightToLeft is not supported in the label component.
			//Label6.RightToLeft = RightToLeft.No;
			Label6.Size = new System.Drawing.Size(33, 17);
			Label6.TabIndex = 12;
			Label6.Text = "Notes:";
			// 
			// frmActionOrderRequest
			// 
			AllowDrop = true;
			//AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			//AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(523, 534);
			Controls.Add(txtPromisedBy);
			Controls.Add(txtRequiredBy);
			Controls.Add(txtReceivedBy);
			Controls.Add(cmdApprove);
			Controls.Add(txtStatus);
			Controls.Add(txtReceived);
			Controls.Add(txtChangedBy);
			Controls.Add(txtChanged);
			Controls.Add(txtOrderID);
			Controls.Add(txtNotes);
			Controls.Add(txtSubTotal);
			Controls.Add(txtTotal);
			Controls.Add(txtTotalTax);
			Controls.Add(txtFreightCharge);
			Controls.Add(txtSalesTax);
			Controls.Add(txtEntry);
			Controls.Add(fgDetails);
			Controls.Add(sbStatusBar);
			Controls.Add(cmdCancel);
			Controls.Add(cmdClose);
			Controls.Add(Frame2);
			Controls.Add(Label13);
			Controls.Add(Label2);
			Controls.Add(Label7);
			Controls.Add(Label3);
			Controls.Add(Label19);
			Controls.Add(lblChangedBy);
			Controls.Add(Label4);
			Controls.Add(lblChanged);
			Controls.Add(Label12);
			Controls.Add(Label11);
			Controls.Add(Label10);
			Controls.Add(Label9);
			Controls.Add(Label8);
			Controls.Add(Label6);
			Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(3, 25);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmActionOrderRequest";
			// gap-todo: PBI 745902. Property RightToLeft is not supported in the control component.
			//RightToLeft = RightToLeft.No;
			StartPosition = FormStartPosition.Manual;
			Text = "Create Invoice";
			// gap-note: This is generated as a stub.
			//commandButtonHelper1.SetStyle(cmdApprove, 0);
			//commandButtonHelper1.SetStyle(cmdCancel, 0);
			//commandButtonHelper1.SetStyle(cmdClose, 0);
			Activated += new System.EventHandler(frmActionOrderRequest_Activated);
			Closed += new System.EventHandler(Form_Closed);
			// gap-todo: PBI 749102. DataGridView implement ISupportInitialize interface and add equivalent support for DataGridViewFlex methods.
			//((System.ComponentModel.ISupportInitialize)fgDetails).EndInit();
			sbStatusBar.ResumeLayout(false);
			Frame2.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			//This form is an MDI child.
			//This code simulates the VB6 
			// functionality of automatically
			// loading and showing an MDI
			// child's parent.
			MdiParent = frmMain.DefInstance;
			frmMain.DefInstance.Show();
		}
		#endregion

	}
}
