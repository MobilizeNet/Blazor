using Gap.Blazor;

namespace SKS_Blazor.Components
{
	partial class frmOrderReception
	{

		#region "Upgrade Support "
		private static frmOrderReception m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmOrderReception DefInstance
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
		public static frmOrderReception CreateInstance()
		{
			frmOrderReception theInstance = new frmOrderReception();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdSave", "cmdClose", "cmdAddProducts", "txtProviderName", "txtContactLastName", "txtContactName", "cmdProviders", "lvProviders_ColumnHeader_1_", "lvProviders_ColumnHeader_2_", "lvProviders_ColumnHeader_3_", "lvProviders_ColumnHeader_4_", "lvProviders_ColumnHeader_5_", "lvProviders_ColumnHeader_6_", "lvProviders_ColumnHeader_7_", "lvProviders", "Label3", "Label4", "Label2", "Frame1", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public ToolTip ToolTipMain;
		public TextBox txtNotes;
		public TextBox txtSubTotal;
		public TextBox txtTotal;
		public TextBox txtTotalTax;
		public TextBox txtFreightCharge;
		public TextBox txtSalesTax;
		public TextBox txtEntry;
		public DataGridViewFlex fgProducts;
		public ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public StatusStrip sbStatusBar;
		public Button cmdSave;
		public Button cmdClose;
		public Button cmdAddProducts;
		public TextBox txtProviderName;
		public TextBox txtContactLastName;
		public TextBox txtContactName;
		public Button cmdProviders;
		public ColumnHeader lvProviders_ColumnHeader_1_;
		public ColumnHeader lvProviders_ColumnHeader_2_;
		public ColumnHeader lvProviders_ColumnHeader_3_;
		public ColumnHeader lvProviders_ColumnHeader_4_;
		public ColumnHeader lvProviders_ColumnHeader_5_;
		public ColumnHeader lvProviders_ColumnHeader_6_;
		public ColumnHeader lvProviders_ColumnHeader_7_;
		public ListView lvProviders;
		public Label Label3;
		public Label Label4;
		public Label Label2;
		public GroupBox Frame1;
		public TextBox txtProviderContact;
		public TextBox txtProviderCompany;
		public Label Label5;
		public Label Label1;
		public GroupBox Frame2;
		public Label Label7;
		public Label Label12;
		public Label Label11;
		public Label Label10;
		public Label Label9;
		public Label Label8;
		public Label Label6;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderReception));
			ToolTipMain = new ToolTip(components);
			txtNotes = new TextBox();
			txtSubTotal = new TextBox();
			txtTotal = new TextBox();
			txtTotalTax = new TextBox();
			txtFreightCharge = new TextBox();
			txtSalesTax = new TextBox();
			txtEntry = new TextBox();
			// gap-todo: Bug 749104. DataGridView constructor does not take the container as an argument as the DataGridViewFlex.
			fgProducts = new DataGridViewFlex(); //new DataGridView(components);
			sbStatusBar = new StatusStrip();
			sbStatusBar_Panels_Panel1 = new ToolStripStatusLabel();
			cmdSave = new Button();
			cmdClose = new Button();
			cmdAddProducts = new Button();
			Frame1 = new GroupBox();
			txtProviderName = new TextBox();
			txtContactLastName = new TextBox();
			txtContactName = new TextBox();
			cmdProviders = new Button();
			lvProviders = new ListView();
			lvProviders_ColumnHeader_1_ = new ColumnHeader();
			lvProviders_ColumnHeader_2_ = new ColumnHeader();
			lvProviders_ColumnHeader_3_ = new ColumnHeader();
			lvProviders_ColumnHeader_4_ = new ColumnHeader();
			lvProviders_ColumnHeader_5_ = new ColumnHeader();
			lvProviders_ColumnHeader_6_ = new ColumnHeader();
			lvProviders_ColumnHeader_7_ = new ColumnHeader();
			Label3 = new Label();
			Label4 = new Label();
			Label2 = new Label();
			Frame2 = new GroupBox();
			txtProviderContact = new TextBox();
			txtProviderCompany = new TextBox();
			Label5 = new Label();
			Label1 = new Label();
			Label7 = new Label();
			Label12 = new Label();
			Label11 = new Label();
			Label10 = new Label();
			Label9 = new Label();
			Label8 = new Label();
			Label6 = new Label();
			sbStatusBar.SuspendLayout();
			Frame1.SuspendLayout();
			lvProviders.SuspendLayout();
			Frame2.SuspendLayout();
			SuspendLayout();
			// gap-todo: PBI 746467. Add support for component UpgradeHelpers.Gui.Controls.ListViewHelper.
			//listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// gap-todo: PBI 749102. DataGridView implement ISupportInitialize interface and add equivalent support for DataGridViewFlex methods.
			//((System.ComponentModel.ISupportInitialize) fgProducts).BeginInit();
			// 
			// txtNotes
			// 
			txtNotes.AcceptsReturn = true;
			txtNotes.AllowDrop = true;
			txtNotes.BackColor = System.Drawing.SystemColors.Window;
			txtNotes.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtNotes.Cursor = Cursors.IBeam;
			txtNotes.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
			txtNotes.Location = new System.Drawing.Point(56, 240);
			txtNotes.MaxLength = 0;
			txtNotes.Multiline = true;
			txtNotes.Name = "txtNotes";
			// gap-todo: PBI 745895. Add support for TextBox RightToLeft property.
			//txtNotes.RightToLeft = RightToLeft.No;
			txtNotes.Size = new System.Drawing.Size(425, 44);
			txtNotes.TabIndex = 4;
			txtNotes.TextChanged += new System.EventHandler(txtNotes_TextChanged);
			// 
			// txtSubTotal
			// 
			txtSubTotal.AcceptsReturn = true;
			txtSubTotal.AllowDrop = true;
			txtSubTotal.BackColor = System.Drawing.SystemColors.Menu;
			txtSubTotal.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtSubTotal.Cursor = Cursors.IBeam;
			txtSubTotal.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			txtSubTotal.Location = new System.Drawing.Point(352, 536);
			txtSubTotal.MaxLength = 0;
			txtSubTotal.Name = "txtSubTotal";
			txtSubTotal.ReadOnly = true;
			// gap-todo: PBI 745895. Add support for TextBox RightToLeft property.
			//txtSubTotal.RightToLeft = RightToLeft.No;
			txtSubTotal.Size = new System.Drawing.Size(145, 20);
			txtSubTotal.TabIndex = 31;
			txtSubTotal.TabStop = false;
			txtSubTotal.TextAlign = HorizontalAlignment.Right;
			// 
			// txtTotal
			// 
			txtTotal.AcceptsReturn = true;
			txtTotal.AllowDrop = true;
			txtTotal.BackColor = System.Drawing.SystemColors.Menu;
			txtTotal.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtTotal.Cursor = Cursors.IBeam;
			txtTotal.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			txtTotal.Location = new System.Drawing.Point(88, 560);
			txtTotal.MaxLength = 0;
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			// gap-todo: PBI 745895. Add support for TextBox RightToLeft property.
			//txtTotal.RightToLeft = RightToLeft.No;
			txtTotal.Size = new System.Drawing.Size(145, 20);
			txtTotal.TabIndex = 29;
			txtTotal.TabStop = false;
			txtTotal.TextAlign = HorizontalAlignment.Right;
			// 
			// txtTotalTax
			// 
			txtTotalTax.AcceptsReturn = true;
			txtTotalTax.AllowDrop = true;
			txtTotalTax.BackColor = System.Drawing.SystemColors.Menu;
			txtTotalTax.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtTotalTax.Cursor = Cursors.IBeam;
			txtTotalTax.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtTotalTax.ForeColor = System.Drawing.SystemColors.WindowText;
			txtTotalTax.Location = new System.Drawing.Point(352, 512);
			txtTotalTax.MaxLength = 0;
			txtTotalTax.Name = "txtTotalTax";
			txtTotalTax.ReadOnly = true;
			// gap-todo: PBI 745895. Add support for TextBox RightToLeft property.
			//txtTotalTax.RightToLeft = RightToLeft.No;
			txtTotalTax.Size = new System.Drawing.Size(145, 20);
			txtTotalTax.TabIndex = 27;
			txtTotalTax.TabStop = false;
			txtTotalTax.TextAlign = HorizontalAlignment.Right;
			// 
			// txtFreightCharge
			// 
			txtFreightCharge.AcceptsReturn = true;
			txtFreightCharge.AllowDrop = true;
			txtFreightCharge.BackColor = System.Drawing.SystemColors.Window;
			txtFreightCharge.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtFreightCharge.Cursor = Cursors.IBeam;
			txtFreightCharge.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText;
			txtFreightCharge.Location = new System.Drawing.Point(88, 536);
			txtFreightCharge.MaxLength = 0;
			txtFreightCharge.Name = "txtFreightCharge";
			// gap-todo: PBI 745895. Add support for TextBox RightToLeft property.
			//txtFreightCharge.RightToLeft = RightToLeft.No;
			txtFreightCharge.Size = new System.Drawing.Size(145, 20);
			txtFreightCharge.TabIndex = 7;
			txtFreightCharge.TextAlign = HorizontalAlignment.Right;
			txtFreightCharge.KeyPress += new KeyPressEventHandler(txtFreightCharge_KeyPress);
			txtFreightCharge.TextChanged += new System.EventHandler(txtFreightCharge_TextChanged);
			// 
			// txtSalesTax
			// 
			txtSalesTax.AcceptsReturn = true;
			txtSalesTax.AllowDrop = true;
			txtSalesTax.BackColor = System.Drawing.SystemColors.Window;
			txtSalesTax.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtSalesTax.Cursor = Cursors.IBeam;
			txtSalesTax.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText;
			txtSalesTax.Location = new System.Drawing.Point(88, 512);
			txtSalesTax.MaxLength = 0;
			txtSalesTax.Name = "txtSalesTax";
			// gap-todo: PBI 745895. Add support for TextBox RightToLeft property.
			//txtSalesTax.RightToLeft = RightToLeft.No;
			txtSalesTax.Size = new System.Drawing.Size(145, 20);
			txtSalesTax.TabIndex = 6;
			txtSalesTax.TextAlign = HorizontalAlignment.Right;
			txtSalesTax.KeyPress += new KeyPressEventHandler(txtSalesTax_KeyPress);
			txtSalesTax.TextChanged += new System.EventHandler(txtSalesTax_TextChanged);
			// 
			// txtEntry
			// 
			txtEntry.AcceptsReturn = true;
			txtEntry.AllowDrop = true;
			txtEntry.BackColor = System.Drawing.SystemColors.Window;
			txtEntry.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtEntry.Cursor = Cursors.IBeam;
			txtEntry.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtEntry.ForeColor = System.Drawing.SystemColors.WindowText;
			txtEntry.Location = new System.Drawing.Point(88, 488);
			txtEntry.MaxLength = 0;
			txtEntry.Name = "txtEntry";
			// gap-todo: PBI 745895. Add support for TextBox RightToLeft property.
			//txtEntry.RightToLeft = RightToLeft.No;
			txtEntry.Size = new System.Drawing.Size(145, 19);
			txtEntry.TabIndex = 24;
			txtEntry.Visible = false;
			txtEntry.KeyDown += new KeyEventHandler(txtEntry_KeyDown);
			txtEntry.KeyPress += new KeyPressEventHandler(txtEntry_KeyPress);
			txtEntry.Leave += new System.EventHandler(txtEntry_Leave);
			// 
			// fgProducts
			// 
			fgProducts.AllowDrop = true;
			fgProducts.AllowUserToAddRows = false;
			fgProducts.AllowUserToDeleteRows = false;
			// gap-todo: PBI 749072. DataGridView add support for AllowUserToResizeColumns property.
			//fgProducts.AllowUserToResizeColumns = false;
			// gap-todo: PBI 749073. DataGridView add support for AllowUserToResizeRows property.
			//fgProducts.AllowUserToResizeRows = false;
			fgProducts.BorderStyle = BorderStyle.None;
            fgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			fgProducts.ColumnsCount = 0;
			fgProducts.FixedColumns = 0;
			fgProducts.FixedRows = 0;
			fgProducts.Location = new System.Drawing.Point(8, 288);
			fgProducts.Name = "fgProducts";
			fgProducts.ReadOnly = true;
			fgProducts.RowsCount = 2;
			fgProducts.SelectionMode = DataGridViewSelectionMode.CellSelect;
			// gap-todo: PBI 749071. DataGridView add support for ShowCellToolTips property.
			//fgProducts.ShowCellToolTips = false;
			fgProducts.Size = new System.Drawing.Size(505, 177);
			// gap-todo: PBI 749068. DataGridView add support for StandardTab property.
			//fgProducts.StandardTab = true;
			fgProducts.TabIndex = 5;
			fgProducts.CellLeave += new DataGridViewCellEventHandler(fgProducts_CellLeave);
			fgProducts.Click += new System.EventHandler(fgProducts_Click);
			fgProducts.KeyPress += new KeyPressEventHandler(fgProducts_KeyPress);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = DockStyle.Bottom;
			sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 623);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(521, 25);
			sbStatusBar.TabIndex = 23;
			sbStatusBar.Items.AddRange(new ToolStripItem[]{sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = ( ToolStripStatusLabelBorderSides) ( ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel1.BorderStyle = Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel1.Margin = new Padding(0);
			sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(521, 25);
			sbStatusBar_Panels_Panel1.Spring = true;
			sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel1.TextImageRelation = TextImageRelation.ImageBeforeText;
			// 
			// cmdSave
			// 
			cmdSave.AllowDrop = true;
			cmdSave.BackColor = System.Drawing.SystemColors.Control;
			cmdSave.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSave.Location = new System.Drawing.Point(320, 584);
			cmdSave.Name = "cmdSave";
			cmdSave.RightToLeft = RightToLeft.No;
			cmdSave.Size = new System.Drawing.Size(89, 25);
			cmdSave.TabIndex = 8;
			cmdSave.Text = "Save"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdSave.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdSave.UseVisualStyleBackColor = false;
			cmdSave.Click += new System.EventHandler(cmdSave_Click);
			// 
			// cmdClose
			// 
			cmdClose.AllowDrop = true;
			cmdClose.BackColor = System.Drawing.SystemColors.Control;
			cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdClose.Location = new System.Drawing.Point(424, 584);
			cmdClose.Name = "cmdClose";
			cmdClose.RightToLeft = RightToLeft.No;
			cmdClose.Size = new System.Drawing.Size(89, 25);
			cmdClose.TabIndex = 9;
			cmdClose.Text = "Close"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			cmdClose.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdClose.UseVisualStyleBackColor = false;
			cmdClose.Click += new System.EventHandler(cmdClose_Click);
			// 
			// cmdAddProducts
			// 
			cmdAddProducts.AllowDrop = true;
			cmdAddProducts.BackColor = System.Drawing.SystemColors.Control;
			cmdAddProducts.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdAddProducts.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdAddProducts.Location = new System.Drawing.Point(488, 264);
			cmdAddProducts.Name = "cmdAddProducts";
			// gap-todo: PBI 745898. Add support for Button RightToLeft property.
			//cmdAddProducts.RightToLeft = RightToLeft.No;
			cmdAddProducts.Size = new System.Drawing.Size(25, 21);
			cmdAddProducts.TabIndex = 21;
			cmdAddProducts.TabStop = false;
			cmdAddProducts.Text = "...";
			cmdAddProducts.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdAddProducts.UseVisualStyleBackColor = false;
			cmdAddProducts.Click += new System.EventHandler(cmdAddProducts_Click);
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(txtProviderName);
			Frame1.Controls.Add(txtContactLastName);
			Frame1.Controls.Add(txtContactName);
			Frame1.Controls.Add(cmdProviders);
			Frame1.Controls.Add(lvProviders);
			Frame1.Controls.Add(Label3);
			Frame1.Controls.Add(Label4);
			Frame1.Controls.Add(Label2);
			// gap-note: The following line is generated as a stub.
			//Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 8);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(505, 169);
			Frame1.TabIndex = 12;
			Frame1.Text = "Search supplier";
			Frame1.Visible = true;
			// 
			// txtProviderName
			// 
			txtProviderName.AcceptsReturn = true;
			txtProviderName.AllowDrop = true;
			txtProviderName.BackColor = System.Drawing.SystemColors.Window;
			txtProviderName.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			// txtProviderName.Cursor = Cursors.IBeam;
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
			// txtContactLastName
			// 
			txtContactLastName.AcceptsReturn = true;
			txtContactLastName.AllowDrop = true;
			txtContactLastName.BackColor = System.Drawing.SystemColors.Window;
			txtContactLastName.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtContactLastName.Cursor = Cursors.IBeam;
			txtContactLastName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtContactLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtContactLastName.Location = new System.Drawing.Point(336, 48);
			txtContactLastName.MaxLength = 0;
			txtContactLastName.Name = "txtContactLastName";
			txtContactLastName.RightToLeft = RightToLeft.No;
			txtContactLastName.Size = new System.Drawing.Size(145, 20);
			txtContactLastName.TabIndex = 2;
			txtContactLastName.TextChanged += new System.EventHandler(txtContactLastName_TextChanged);
			// 
			// txtContactName
			// 
			txtContactName.AcceptsReturn = true;
			txtContactName.AllowDrop = true;
			txtContactName.BackColor = System.Drawing.SystemColors.Window;
			txtContactName.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtContactName.Cursor = Cursors.IBeam;
			txtContactName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtContactName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtContactName.Location = new System.Drawing.Point(88, 48);
			txtContactName.MaxLength = 0;
			txtContactName.Name = "txtContactName";
			txtContactName.RightToLeft = RightToLeft.No;
			txtContactName.Size = new System.Drawing.Size(145, 20);
			txtContactName.TabIndex = 1;
			txtContactName.TextChanged += new System.EventHandler(txtContactName_TextChanged);
			// 
			// cmdProviders
			// 
			cmdProviders.AllowDrop = true;
			cmdProviders.BackColor = System.Drawing.SystemColors.Control;
			cmdProviders.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			cmdProviders.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdProviders.Location = new System.Drawing.Point(456, 16);
			cmdProviders.Name = "cmdProviders";
			cmdProviders.RightToLeft = RightToLeft.No;
			cmdProviders.Size = new System.Drawing.Size(25, 21);
			cmdProviders.TabIndex = 13;
			cmdProviders.TabStop = false;
			cmdProviders.Text = "...";
			cmdProviders.TextImageRelation = TextImageRelation.ImageAboveText;
			cmdProviders.UseVisualStyleBackColor = false;
			cmdProviders.Click += new System.EventHandler(cmdProviders_Click);
			// 
			// lvProviders
			// 
			lvProviders.AllowDrop = true;
			lvProviders.BackColor = System.Drawing.SystemColors.Window;
			lvProviders.BorderStyle = BorderStyle.Fixed3D;
			lvProviders.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			lvProviders.ForeColor = System.Drawing.SystemColors.WindowText;
			lvProviders.FullRowSelect = true;
			lvProviders.GridLines = true;
			lvProviders.HideSelection = false;
			// gap-todo: PBI 745867. Add support for ListView HotTracking property.
			//lvProviders.HotTracking = true;
			lvProviders.LabelEdit = false;
			lvProviders.Location = new System.Drawing.Point(8, 80);
			lvProviders.MultiSelect = false;
			lvProviders.Name = "lvProviders";
			lvProviders.Size = new System.Drawing.Size(489, 81);
			lvProviders.TabIndex = 3;
			lvProviders.View = ListViewMode.Details;
			lvProviders.Columns.Add(lvProviders_ColumnHeader_1_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_2_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_3_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_4_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_5_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_6_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_7_);
			// 
			// lvProviders_ColumnHeader_1_
			// 
			lvProviders_ColumnHeader_1_.Text = "Supplier ID";
			lvProviders_ColumnHeader_1_.Width = 97;
			// 
			// lvProviders_ColumnHeader_2_
			// 
			lvProviders_ColumnHeader_2_.Text = "Supplier Name";
			lvProviders_ColumnHeader_2_.Width = 97;
			// 
			// lvProviders_ColumnHeader_3_
			// 
			lvProviders_ColumnHeader_3_.Text = "Contact Name";
			lvProviders_ColumnHeader_3_.Width = 97;
			// 
			// lvProviders_ColumnHeader_4_
			// 
			lvProviders_ColumnHeader_4_.Text = "Contact Last Name";
			lvProviders_ColumnHeader_4_.Width = 97;
			// 
			// lvProviders_ColumnHeader_5_
			// 
			lvProviders_ColumnHeader_5_.Text = "City";
			lvProviders_ColumnHeader_5_.Width = 97;
			// 
			// lvProviders_ColumnHeader_6_
			// 
			lvProviders_ColumnHeader_6_.Text = "State";
			lvProviders_ColumnHeader_6_.Width = 97;
			// 
			// lvProviders_ColumnHeader_7_
			// 
			lvProviders_ColumnHeader_7_.Text = "Country";
			lvProviders_ColumnHeader_7_.Width = 97;
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = BorderStyle.None;
			Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(240, 48);
			Label3.MinimumSize = new System.Drawing.Size(97, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = RightToLeft.No;
			Label3.Size = new System.Drawing.Size(97, 17);
			Label3.TabIndex = 16;
			Label3.Text = "Last name";
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
			Label4.TabIndex = 15;
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
			Label2.TabIndex = 14;
			Label2.Text = "First Name";
			// 
			// Frame2
			// 
			Frame2.AllowDrop = true;
			Frame2.BackColor = System.Drawing.SystemColors.Control;
			Frame2.Controls.Add(txtProviderContact);
			Frame2.Controls.Add(txtProviderCompany);
			Frame2.Controls.Add(Label5);
			Frame2.Controls.Add(Label1);
			// gap-note: The following line is generated as a stub.
			//Frame2.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame2.Enabled = true;
			Frame2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame2.Location = new System.Drawing.Point(8, 184);
			Frame2.Name = "Frame2";
			Frame2.RightToLeft = RightToLeft.No;
			Frame2.Size = new System.Drawing.Size(505, 49);
			Frame2.TabIndex = 11;
			Frame2.Text = "Supplier";
			Frame2.Visible = true;
			// 
			// txtProviderContact
			// 
			txtProviderContact.AcceptsReturn = true;
			txtProviderContact.AllowDrop = true;
			txtProviderContact.BackColor = System.Drawing.SystemColors.Menu;
			txtProviderContact.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtProviderContact.Cursor = Cursors.IBeam;
			txtProviderContact.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtProviderContact.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProviderContact.Location = new System.Drawing.Point(288, 16);
			txtProviderContact.MaxLength = 0;
			txtProviderContact.Name = "txtProviderContact";
			txtProviderContact.ReadOnly = true;
			txtProviderContact.RightToLeft = RightToLeft.No;
			txtProviderContact.Size = new System.Drawing.Size(209, 20);
			txtProviderContact.TabIndex = 20;
			txtProviderContact.TabStop = false;
			// 
			// txtProviderCompany
			// 
			txtProviderCompany.AcceptsReturn = true;
			txtProviderCompany.AllowDrop = true;
			txtProviderCompany.BackColor = System.Drawing.SystemColors.Menu;
			txtProviderCompany.BorderStyle = BorderStyle.Fixed3D;
			// gap-todo: PBI 745731. Add support for Control Cursor property.
			//txtProviderCompany.Cursor = Cursors.IBeam;
			txtProviderCompany.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			txtProviderCompany.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProviderCompany.Location = new System.Drawing.Point(72, 16);
			txtProviderCompany.MaxLength = 0;
			txtProviderCompany.Name = "txtProviderCompany";
			txtProviderCompany.ReadOnly = true;
			txtProviderCompany.RightToLeft = RightToLeft.No;
			txtProviderCompany.Size = new System.Drawing.Size(145, 20);
			txtProviderCompany.TabIndex = 19;
			txtProviderCompany.TabStop = false;
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
			Label5.RightToLeft = RightToLeft.No;
			Label5.Size = new System.Drawing.Size(57, 17);
			Label5.TabIndex = 18;
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
			Label1.RightToLeft = RightToLeft.No;
			Label1.Size = new System.Drawing.Size(57, 17);
			Label1.TabIndex = 17;
			Label1.Text = "Contact:";
			// 
			// Label7
			// 
			Label7.AllowDrop = true;
			Label7.BackColor = System.Drawing.SystemColors.Control;
			Label7.BorderStyle = BorderStyle.None;
			Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			Label7.Location = new System.Drawing.Point(8, 488);
			Label7.MinimumSize = new System.Drawing.Size(81, 17);
			Label7.Name = "Label7";
			Label7.RightToLeft = RightToLeft.No;
			Label7.Size = new System.Drawing.Size(81, 17);
			Label7.TabIndex = 10;
			Label7.Text = "Quantity";
			// 
			// Label12
			// 
			Label12.AllowDrop = true;
			Label12.BackColor = System.Drawing.SystemColors.Control;
			Label12.BorderStyle = BorderStyle.None;
			Label12.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			Label12.Location = new System.Drawing.Point(8, 536);
			Label12.MinimumSize = new System.Drawing.Size(89, 17);
			Label12.Name = "Label12";
			Label12.RightToLeft = RightToLeft.No;
			Label12.Size = new System.Drawing.Size(89, 17);
			Label12.TabIndex = 32;
			Label12.Text = "Freight";
			// 
			// Label11
			// 
			Label11.AllowDrop = true;
			Label11.BackColor = System.Drawing.SystemColors.Control;
			Label11.BorderStyle = BorderStyle.None;
			Label11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			Label11.Location = new System.Drawing.Point(8, 560);
			Label11.MinimumSize = new System.Drawing.Size(89, 17);
			Label11.Name = "Label11";
			Label11.RightToLeft = RightToLeft.No;
			Label11.Size = new System.Drawing.Size(89, 17);
			Label11.TabIndex = 30;
			Label11.Text = "Total";
			// 
			// Label10
			// 
			Label10.AllowDrop = true;
			Label10.BackColor = System.Drawing.SystemColors.Control;
			Label10.BorderStyle = BorderStyle.None;
			Label10.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			Label10.Location = new System.Drawing.Point(272, 512);
			Label10.MinimumSize = new System.Drawing.Size(89, 17);
			Label10.Name = "Label10";
			Label10.RightToLeft = RightToLeft.No;
			Label10.Size = new System.Drawing.Size(89, 17);
			Label10.TabIndex = 28;
			Label10.Text = "Total Tax";
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = BorderStyle.None;
			Label9.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(272, 536);
			Label9.MinimumSize = new System.Drawing.Size(89, 17);
			Label9.Name = "Label9";
			Label9.RightToLeft = RightToLeft.No;
			Label9.Size = new System.Drawing.Size(89, 17);
			Label9.TabIndex = 26;
			Label9.Text = "Sub Total";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = BorderStyle.None;
			Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(8, 512);
			Label8.MinimumSize = new System.Drawing.Size(89, 17);
			Label8.Name = "Label8";
			Label8.RightToLeft = RightToLeft.No;
			Label8.Size = new System.Drawing.Size(89, 17);
			Label8.TabIndex = 25;
			Label8.Text = "Sales Tax";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = BorderStyle.None;
			Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(8, 248);
			Label6.MinimumSize = new System.Drawing.Size(33, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = RightToLeft.No;
			Label6.Size = new System.Drawing.Size(33, 17);
			Label6.TabIndex = 22;
			Label6.Text = "Notes:";
			// 
			// frmOrderReception
			// 
			AllowDrop = true;
			// gap-todo: PBI 745733. Add support for ContainerControl AutoScaleDimensions property.
			//AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			// gap - todo: PBI 745734.Add support for ContainerControl AutoScaleMode property.
			//AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(521, 648);
			Controls.Add(txtNotes);
			Controls.Add(txtSubTotal);
			Controls.Add(txtTotal);
			Controls.Add(txtTotalTax);
			Controls.Add(txtFreightCharge);
			Controls.Add(txtSalesTax);
			Controls.Add(txtEntry);
            Controls.Add(fgProducts);
            Controls.Add(sbStatusBar);
			Controls.Add(cmdSave);
			Controls.Add(cmdClose);
			Controls.Add(cmdAddProducts);
			Controls.Add(Frame1);
			Controls.Add(Frame2);
			Controls.Add(Label7);
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
			Name = "frmOrderReception";
			RightToLeft = RightToLeft.No;
			StartPosition = FormStartPosition.Manual;
			Text = "Add Stock Order";
			// gap-note: This is generated as a stub.
			//commandButtonHelper1.SetStyle(cmdSave, 0);
			//commandButtonHelper1.SetStyle(cmdClose, 0);
			//commandButtonHelper1.SetStyle(cmdAddProducts, 0);
			//commandButtonHelper1.SetStyle(cmdProviders, 0);
			Activated += new System.EventHandler(frmOrderReception_Activated);
			Closed += new System.EventHandler(Form_Closed);
			FormClosing += new FormClosingEventHandler(Form_FormClosing);
			// gap-todo: PBI 749102. DataGridView implement ISupportInitialize interface and add equivalent support for DataGridViewFlex methods.
			//((System.ComponentModel.ISupportInitialize) fgProducts).EndInit();
			lvProviders.ItemClick += new ListViewItemClickEventHandler(lvProviders_ItemClick);
			// gap-todo: PBI 746467. Add support for component UpgradeHelpers.Gui.Controls.ListViewHelper.
			//listViewHelper1.SetCorrectEventsBehavior(lvProviders, true);
			sbStatusBar.ResumeLayout(false);
			Frame1.ResumeLayout(false);
			lvProviders.ResumeLayout(false);
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
			SKS_Blazor.Components.frmMain.DefInstance.Show();
		}
		#endregion
	}
}