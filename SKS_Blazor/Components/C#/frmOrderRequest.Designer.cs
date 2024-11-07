using static System.Net.Mime.MediaTypeNames;
using Gap.Blazor;

namespace SKS_Blazor.Components
{
    public partial class frmOrderRequest
    {
        #region "Upgrade Support "
        private static frmOrderRequest m_vb6FormDefInstance;
        private static bool m_InitializingDefInstance;
        public static frmOrderRequest DefInstance
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
        public static frmOrderRequest CreateInstance()
        {
            frmOrderRequest theInstance = new frmOrderRequest();
            theInstance.Form_Load();
            return theInstance;
        }
        private string[] visualControls = new string[] { "components", "ToolTipMain", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "dtRequired", "cmdSave", "cmdAddProducts", "cmdClose", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "lvCustomers_ColumnHeader_1_", "lvCustomers_ColumnHeader_2_", "lvCustomers_ColumnHeader_3_", "lvCustomers_ColumnHeader_4_", "lvCustomers_ColumnHeader_5_", "lvCustomers_ColumnHeader_6_", "lvCustomers_ColumnHeader_7_", "lvCustomers", "Label3", "Label4", "Label2", "Frame1", "txtCustomerContact", "txtCustomerCompany", "Label5", "Label1", "Frame2", "dtPromised", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label7", "Label6", "listViewHelper1", "commandButtonHelper1" };
        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        //public ToolTip ToolTipMain;
        public TextBox txtSubTotal;
        public TextBox txtTotal;
        public TextBox txtTotalTax;
        public TextBox txtFreightCharge;
        public TextBox txtSalesTax;
        public TextBox txtEntry;
        //public UpgradeHelpers.DataGridViewFlex fgProducts;
        public DataGridView fgProducts;
        public ToolStripStatusLabel sbStatusBar_Panels_Panel1;
        public StatusStrip sbStatusBar;
        public DateTimePicker dtRequired;
        public Button cmdSave;
        public Button cmdAddProducts;
        public Button cmdClose;
        public TextBox txtContactLastName;
        public TextBox txtContactName;
        public Button cmdCustomers;
        public TextBox txtCompanyName;
        public ColumnHeader lvCustomers_ColumnHeader_1_;
        public ColumnHeader lvCustomers_ColumnHeader_2_;
        public ColumnHeader lvCustomers_ColumnHeader_3_;
        public ColumnHeader lvCustomers_ColumnHeader_4_;
        public ColumnHeader lvCustomers_ColumnHeader_5_;
        public ColumnHeader lvCustomers_ColumnHeader_6_;
        public ColumnHeader lvCustomers_ColumnHeader_7_;
        public ListView lvCustomers;
        public Label Label3;
        public Label Label4;
        public Label Label2;
        public GroupBox Frame1;
        public TextBox txtCustomerContact;
        public TextBox txtCustomerCompany;
        public Label Label5;
        public Label Label1;
        public GroupBox Frame2;
        public DateTimePicker dtPromised;
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label9;
        public Label Label8;
        public Label Label7;
        public Label Label6;
        public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
        public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderRequest));
            //ToolTipMain = new ToolTip(components);
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            txtTotalTax = new TextBox();
            txtFreightCharge = new TextBox();
            txtSalesTax = new TextBox();
            txtEntry = new TextBox();
            //fgProducts = new UpgradeHelpers.DataGridViewFlex(components);
            fgProducts = new DataGridView();
            sbStatusBar = new StatusStrip();
            sbStatusBar_Panels_Panel1 = new ToolStripStatusLabel();
            dtRequired = new DateTimePicker();
            cmdSave = new Button();
            cmdAddProducts = new Button();
            cmdClose = new Button();
            Frame1 = new GroupBox();
            txtContactLastName = new TextBox();
            txtContactName = new TextBox();
            cmdCustomers = new Button();
            txtCompanyName = new TextBox();
            lvCustomers = new ListView();
            lvCustomers_ColumnHeader_1_ = new ColumnHeader();
            lvCustomers_ColumnHeader_2_ = new ColumnHeader();
            lvCustomers_ColumnHeader_3_ = new ColumnHeader();
            lvCustomers_ColumnHeader_4_ = new ColumnHeader();
            lvCustomers_ColumnHeader_5_ = new ColumnHeader();
            lvCustomers_ColumnHeader_6_ = new ColumnHeader();
            lvCustomers_ColumnHeader_7_ = new ColumnHeader();
            Label3 = new Label();
            Label4 = new Label();
            Label2 = new Label();
            Frame2 = new GroupBox();
            txtCustomerContact = new TextBox();
            txtCustomerCompany = new TextBox();
            Label5 = new Label();
            Label1 = new Label();
            dtPromised = new DateTimePicker();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            sbStatusBar.SuspendLayout();
            Frame1.SuspendLayout();
            lvCustomers.SuspendLayout();
            Frame2.SuspendLayout();
            SuspendLayout();
            listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
            //((System.ComponentModel.ISupportInitialize)listViewHelper1).BeginInit();
            commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
            //((System.ComponentModel.ISupportInitialize)fgProducts).BeginInit();
            // 
            // txtSubTotal
            // 
            txtSubTotal.AcceptsReturn = true;
            txtSubTotal.AllowDrop = true;
            txtSubTotal.BackColor = System.Drawing.SystemColors.Menu;
            txtSubTotal.BorderStyle = BorderStyle.Fixed3D;
            //txtSubTotal.Cursor = Cursors.IBeam;
            txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            txtSubTotal.Location = new System.Drawing.Point(352, 616);
            txtSubTotal.MaxLength = 0;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.RightToLeft = RightToLeft.No;
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
            // txtTotal.Cursor = Cursors.IBeam;
            txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTotal.Location = new System.Drawing.Point(96, 616);
            txtTotal.MaxLength = 0;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.RightToLeft = RightToLeft.No;
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
            //txtTotalTax.Cursor = Cursors.IBeam;
            txtTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTotalTax.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTotalTax.Location = new System.Drawing.Point(352, 592);
            txtTotalTax.MaxLength = 0;
            txtTotalTax.Name = "txtTotalTax";
            txtTotalTax.ReadOnly = true;
            txtTotalTax.RightToLeft = RightToLeft.No;
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
            //txtFreightCharge.Cursor = Cursors.IBeam;
            txtFreightCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText;
            txtFreightCharge.Location = new System.Drawing.Point(96, 592);
            txtFreightCharge.MaxLength = 0;
            txtFreightCharge.Name = "txtFreightCharge";
            txtFreightCharge.RightToLeft = RightToLeft.No;
            txtFreightCharge.Size = new System.Drawing.Size(145, 20);
            txtFreightCharge.TabIndex = 8;
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
            //txtSalesTax.Cursor = Cursors.IBeam;
            txtSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText;
            txtSalesTax.Location = new System.Drawing.Point(96, 568);
            txtSalesTax.MaxLength = 0;
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.RightToLeft = RightToLeft.No;
            txtSalesTax.Size = new System.Drawing.Size(145, 20);
            txtSalesTax.TabIndex = 7;
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
            //txtEntry.Cursor = Cursors.IBeam;
            txtEntry.Enabled = false;
            txtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtEntry.ForeColor = System.Drawing.SystemColors.WindowText;
            txtEntry.Location = new System.Drawing.Point(96, 544);
            txtEntry.MaxLength = 0;
            txtEntry.Name = "txtEntry";
            txtEntry.RightToLeft = RightToLeft.No;
            txtEntry.Size = new System.Drawing.Size(145, 19);
            txtEntry.TabIndex = 24;
            txtEntry.Leave += new System.EventHandler(txtEntry_Leave);
            // 
            // fgProducts
            // 
            fgProducts.AllowDrop = true;
            fgProducts.AllowUserToAddRows = false;
            fgProducts.AllowUserToDeleteRows = false;
            //fgProducts.AllowUserToResizeColumns = false;
            //fgProducts.AllowUserToResizeRows = false;
            fgProducts.BorderStyle = BorderStyle.None;
            fgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //fgProducts.ColumnsCount = 0;
            //fgProducts.FixedColumns = 0;
            //fgProducts.FixedRows = 0;
            fgProducts.Location = new System.Drawing.Point(8, 360);
            fgProducts.Name = "fgProducts";
            fgProducts.ReadOnly = true;
            //fgProducts.RowsCount = 2;
            fgProducts.SelectionMode = DataGridViewSelectionMode.CellSelect;
            // fgProducts.ShowCellToolTips = false;
            fgProducts.Size = new System.Drawing.Size(505, 177);
            //fgProducts.StandardTab = true;
            fgProducts.TabIndex = 6;
            fgProducts.CellLeave += new DataGridViewCellEventHandler(fgProducts_CellLeave);
            fgProducts.Click += new System.EventHandler(fgProducts_Click);
            fgProducts.KeyPress += new KeyPressEventHandler(fgProducts_KeyPress);
            // 
            // sbStatusBar
            // 
            sbStatusBar.AllowDrop = true;
            sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
            sbStatusBar.Dock = DockStyle.Bottom;
            sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            sbStatusBar.Location = new System.Drawing.Point(0, 678);
            sbStatusBar.Name = "sbStatusBar";
            sbStatusBar.ShowItemToolTips = true;
            sbStatusBar.Size = new System.Drawing.Size(523, 25);
            sbStatusBar.TabIndex = 23;
            sbStatusBar.Items.AddRange(new ToolStripItem[] { sbStatusBar_Panels_Panel1 });
            // 
            // sbStatusBar_Panels_Panel1
            // 
            sbStatusBar_Panels_Panel1.BorderSides = (ToolStripStatusLabelBorderSides)(ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom);
            //sbStatusBar_Panels_Panel1.BorderStyle = Border3DStyle.SunkenOuter;
            sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
            sbStatusBar_Panels_Panel1.Margin = new Padding(0);
            sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(523, 25);
            sbStatusBar_Panels_Panel1.Spring = true;
            sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sbStatusBar_Panels_Panel1.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // dtRequired
            // 
            dtRequired.AllowDrop = true;
            dtRequired.Checked = false;
            dtRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtRequired.Format = DateTimePickerFormat.Short;
            dtRequired.Location = new System.Drawing.Point(120, 320);
            dtRequired.Name = "dtRequired";
            dtRequired.Size = new System.Drawing.Size(97, 20);
            dtRequired.TabIndex = 4;
            dtRequired.ValueChanged += new System.EventHandler(dtRequired_ValueChanged);
            // 
            // cmdSave
            // 
            cmdSave.AllowDrop = true;
            cmdSave.BackColor = System.Drawing.SystemColors.Control;
            cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdSave.Location = new System.Drawing.Point(320, 648);
            cmdSave.Name = "cmdSave";
            cmdSave.RightToLeft = RightToLeft.No;
            cmdSave.Size = new System.Drawing.Size(89, 25);
            cmdSave.TabIndex = 9;
            cmdSave.Text = "&Save";
            cmdSave.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdSave.UseVisualStyleBackColor = false;
            cmdSave.Click += new System.EventHandler(cmdSave_Click);
            // 
            // cmdAddProducts
            // 
            cmdAddProducts.AllowDrop = true;
            cmdAddProducts.BackColor = System.Drawing.SystemColors.Control;
            cmdAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmdAddProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdAddProducts.Location = new System.Drawing.Point(488, 336);
            cmdAddProducts.Name = "cmdAddProducts";
            cmdAddProducts.RightToLeft = RightToLeft.No;
            cmdAddProducts.Size = new System.Drawing.Size(25, 21);
            cmdAddProducts.TabIndex = 21;
            cmdAddProducts.TabStop = false;
            cmdAddProducts.Text = "...";
            cmdAddProducts.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdAddProducts.UseVisualStyleBackColor = false;
            cmdAddProducts.Click += new System.EventHandler(cmdAddProducts_Click);
            // 
            // cmdClose
            // 
            cmdClose.AllowDrop = true;
            cmdClose.BackColor = System.Drawing.SystemColors.Control;
            cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdClose.Location = new System.Drawing.Point(416, 648);
            cmdClose.Name = "cmdClose";
            cmdClose.RightToLeft = RightToLeft.No;
            cmdClose.Size = new System.Drawing.Size(89, 25);
            cmdClose.TabIndex = 10;
            cmdClose.Text = "&Close";
            cmdClose.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdClose.UseVisualStyleBackColor = false;
            cmdClose.Click += new System.EventHandler(cmdClose_Click);
            // 
            // Frame1
            // 
            Frame1.AllowDrop = true;
            Frame1.BackColor = System.Drawing.SystemColors.Control;
            Frame1.Controls.Add(txtContactLastName);
            Frame1.Controls.Add(txtContactName);
            Frame1.Controls.Add(cmdCustomers);
            Frame1.Controls.Add(txtCompanyName);
            Frame1.Controls.Add(lvCustomers);
            Frame1.Controls.Add(Label3);
            Frame1.Controls.Add(Label4);
            Frame1.Controls.Add(Label2);
            //Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
            Frame1.Enabled = true;
            Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            Frame1.Location = new System.Drawing.Point(8, 8);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new System.Drawing.Size(505, 249);
            Frame1.TabIndex = 12;
            Frame1.Text = "Search customer";
            Frame1.Visible = true;
            // 
            // txtContactLastName
            // 
            txtContactLastName.AcceptsReturn = true;
            txtContactLastName.AllowDrop = true;
            txtContactLastName.BackColor = System.Drawing.SystemColors.Window;
            txtContactLastName.BorderStyle = BorderStyle.Fixed3D;
            //txtContactLastName.Cursor = Cursors.IBeam;
            txtContactLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
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
            //txtContactName.Cursor = Cursors.IBeam;
            txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtContactName.ForeColor = System.Drawing.SystemColors.WindowText;
            txtContactName.Location = new System.Drawing.Point(88, 48);
            txtContactName.MaxLength = 0;
            txtContactName.Name = "txtContactName";
            txtContactName.RightToLeft = RightToLeft.No;
            txtContactName.Size = new System.Drawing.Size(145, 20);
            txtContactName.TabIndex = 1;
            txtContactName.TextChanged += new System.EventHandler(txtContactName_TextChanged);
            // 
            // cmdCustomers
            // 
            cmdCustomers.AllowDrop = true;
            cmdCustomers.BackColor = System.Drawing.SystemColors.Control;
            cmdCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmdCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdCustomers.Location = new System.Drawing.Point(456, 16);
            cmdCustomers.Name = "cmdCustomers";
            cmdCustomers.RightToLeft = RightToLeft.No;
            cmdCustomers.Size = new System.Drawing.Size(25, 21);
            cmdCustomers.TabIndex = 13;
            cmdCustomers.TabStop = false;
            cmdCustomers.Text = "...";
            cmdCustomers.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdCustomers.UseVisualStyleBackColor = false;
            cmdCustomers.Click += new System.EventHandler(cmdCustomers_Click);
            // 
            // txtCompanyName
            // 
            txtCompanyName.AcceptsReturn = true;
            txtCompanyName.AllowDrop = true;
            txtCompanyName.BackColor = System.Drawing.SystemColors.Window;
            txtCompanyName.BorderStyle = BorderStyle.Fixed3D;
            //txtCompanyName.Cursor = Cursors.IBeam;
            txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            txtCompanyName.Location = new System.Drawing.Point(88, 16);
            txtCompanyName.MaxLength = 0;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.RightToLeft = RightToLeft.No;
            txtCompanyName.Size = new System.Drawing.Size(145, 20);
            txtCompanyName.TabIndex = 0;
            txtCompanyName.TextChanged += new System.EventHandler(txtCompanyName_TextChanged);
            // 
            // lvCustomers
            // 
            lvCustomers.AllowDrop = true;
            lvCustomers.BackColor = System.Drawing.SystemColors.Window;
            lvCustomers.BorderStyle = BorderStyle.Fixed3D;
            lvCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lvCustomers.ForeColor = System.Drawing.SystemColors.WindowText;
            lvCustomers.FullRowSelect = true;
            lvCustomers.GridLines = true;
            lvCustomers.HideSelection = false;
            // lvCustomers.HotTracking = true;
            lvCustomers.LabelEdit = false;
            lvCustomers.Location = new System.Drawing.Point(8, 80);
            lvCustomers.MultiSelect = false;
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new System.Drawing.Size(489, 161);
            lvCustomers.TabIndex = 3;
            lvCustomers.View = ListViewMode.Details;
            lvCustomers.Columns.Add(lvCustomers_ColumnHeader_1_);
            lvCustomers.Columns.Add(lvCustomers_ColumnHeader_2_);
            lvCustomers.Columns.Add(lvCustomers_ColumnHeader_3_);
            lvCustomers.Columns.Add(lvCustomers_ColumnHeader_4_);
            lvCustomers.Columns.Add(lvCustomers_ColumnHeader_5_);
            lvCustomers.Columns.Add(lvCustomers_ColumnHeader_6_);
            lvCustomers.Columns.Add(lvCustomers_ColumnHeader_7_);
            // 
            // lvCustomers_ColumnHeader_1_
            // 
            lvCustomers_ColumnHeader_1_.Text = "Customer ID";
            lvCustomers_ColumnHeader_1_.Width = 97;
            // 
            // lvCustomers_ColumnHeader_2_
            // 
            lvCustomers_ColumnHeader_2_.Text = "Company Name";
            lvCustomers_ColumnHeader_2_.Width = 97;
            // 
            // lvCustomers_ColumnHeader_3_
            // 
            lvCustomers_ColumnHeader_3_.Text = "Contact Name";
            lvCustomers_ColumnHeader_3_.Width = 97;
            // 
            // lvCustomers_ColumnHeader_4_
            // 
            lvCustomers_ColumnHeader_4_.Text = "Contact Last Name";
            lvCustomers_ColumnHeader_4_.Width = 97;
            // 
            // lvCustomers_ColumnHeader_5_
            // 
            lvCustomers_ColumnHeader_5_.Text = "City";
            lvCustomers_ColumnHeader_5_.Width = 97;
            // 
            // lvCustomers_ColumnHeader_6_
            // 
            lvCustomers_ColumnHeader_6_.Text = "State";
            lvCustomers_ColumnHeader_6_.Width = 97;
            // 
            // lvCustomers_ColumnHeader_7_
            // 
            lvCustomers_ColumnHeader_7_.Text = "Country";
            lvCustomers_ColumnHeader_7_.Width = 97;
            // 
            // Label3
            // 
            Label3.AllowDrop = true;
            Label3.BackColor = System.Drawing.SystemColors.Control;
            //Label3.BorderStyle = BorderStyle.None;
            Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            Label3.Location = new System.Drawing.Point(240, 48);
            Label3.MinimumSize = new System.Drawing.Size(97, 17);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new System.Drawing.Size(97, 17);
            Label3.TabIndex = 16;
            Label3.Text = "Contact last name:";
            // 
            // Label4
            // 
            Label4.AllowDrop = true;
            Label4.BackColor = System.Drawing.SystemColors.Control;
            //Label4.BorderStyle = BorderStyle.None;
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            Label4.Location = new System.Drawing.Point(8, 16);
            Label4.MinimumSize = new System.Drawing.Size(89, 17);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new System.Drawing.Size(89, 17);
            Label4.TabIndex = 15;
            Label4.Text = "Company name:";
            // 
            // Label2
            // 
            Label2.AllowDrop = true;
            Label2.BackColor = System.Drawing.SystemColors.Control;
            //Label2.BorderStyle = BorderStyle.None;
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            Label2.Location = new System.Drawing.Point(8, 48);
            Label2.MinimumSize = new System.Drawing.Size(89, 17);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new System.Drawing.Size(89, 17);
            Label2.TabIndex = 14;
            Label2.Text = "Contact name:";
            // 
            // Frame2
            // 
            Frame2.AllowDrop = true;
            Frame2.BackColor = System.Drawing.SystemColors.Control;
            Frame2.Controls.Add(txtCustomerContact);
            Frame2.Controls.Add(txtCustomerCompany);
            Frame2.Controls.Add(Label5);
            Frame2.Controls.Add(Label1);
            //Frame2.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
            Frame2.Enabled = true;
            Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            Frame2.Location = new System.Drawing.Point(8, 256);
            Frame2.Name = "Frame2";
            Frame2.RightToLeft = RightToLeft.No;
            Frame2.Size = new System.Drawing.Size(505, 49);
            Frame2.TabIndex = 11;
            Frame2.Text = "Customer";
            Frame2.Visible = true;
            // 
            // txtCustomerContact
            // 
            txtCustomerContact.AcceptsReturn = true;
            txtCustomerContact.AllowDrop = true;
            txtCustomerContact.BackColor = System.Drawing.SystemColors.Menu;
            txtCustomerContact.BorderStyle = BorderStyle.Fixed3D;
            //txtCustomerContact.Cursor = Cursors.IBeam;
            txtCustomerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCustomerContact.ForeColor = System.Drawing.SystemColors.WindowText;
            txtCustomerContact.Location = new System.Drawing.Point(288, 16);
            txtCustomerContact.MaxLength = 0;
            txtCustomerContact.Name = "txtCustomerContact";
            txtCustomerContact.ReadOnly = true;
            txtCustomerContact.RightToLeft = RightToLeft.No;
            txtCustomerContact.Size = new System.Drawing.Size(209, 20);
            txtCustomerContact.TabIndex = 20;
            txtCustomerContact.TabStop = false;
            // 
            // txtCustomerCompany
            // 
            txtCustomerCompany.AcceptsReturn = true;
            txtCustomerCompany.AllowDrop = true;
            txtCustomerCompany.BackColor = System.Drawing.SystemColors.Menu;
            txtCustomerCompany.BorderStyle = BorderStyle.Fixed3D;
            //txtCustomerCompany.Cursor = Cursors.IBeam;
            txtCustomerCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCustomerCompany.ForeColor = System.Drawing.SystemColors.WindowText;
            txtCustomerCompany.Location = new System.Drawing.Point(72, 16);
            txtCustomerCompany.MaxLength = 0;
            txtCustomerCompany.Name = "txtCustomerCompany";
            txtCustomerCompany.ReadOnly = true;
            txtCustomerCompany.RightToLeft = RightToLeft.No;
            txtCustomerCompany.Size = new System.Drawing.Size(145, 20);
            txtCustomerCompany.TabIndex = 19;
            txtCustomerCompany.TabStop = false;
            // 
            // Label5
            // 
            Label5.AllowDrop = true;
            Label5.BackColor = System.Drawing.SystemColors.Control;
            //Label5.BorderStyle = BorderStyle.None;
            Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            Label5.Location = new System.Drawing.Point(8, 16);
            Label5.MinimumSize = new System.Drawing.Size(57, 17);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new System.Drawing.Size(57, 17);
            Label5.TabIndex = 18;
            Label5.Text = "Company:";
            // 
            // Label1
            // 
            Label1.AllowDrop = true;
            Label1.BackColor = System.Drawing.SystemColors.Control;
            //Label1.BorderStyle = BorderStyle.None;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            Label1.Location = new System.Drawing.Point(232, 16);
            Label1.MinimumSize = new System.Drawing.Size(57, 17);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new System.Drawing.Size(57, 17);
            Label1.TabIndex = 17;
            Label1.Text = "Contact:";
            // 
            // dtPromised
            // 
            dtPromised.AllowDrop = true;
            dtPromised.Checked = false;
            dtPromised.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtPromised.Format = DateTimePickerFormat.Short;
            dtPromised.Location = new System.Drawing.Point(352, 320);
            dtPromised.Name = "dtPromised";
            dtPromised.Size = new System.Drawing.Size(97, 20);
            dtPromised.TabIndex = 5;
            dtPromised.ValueChanged += new System.EventHandler(dtPromised_ValueChanged);
            // 
            // Label13
            // 
            Label13.AllowDrop = true;
            Label13.BackColor = System.Drawing.SystemColors.Control;
            //Label13.BorderStyle = BorderStyle.None;
            Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            Label13.Location = new System.Drawing.Point(8, 544);
            Label13.MinimumSize = new System.Drawing.Size(89, 17);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new System.Drawing.Size(89, 17);
            Label13.TabIndex = 33;
            Label13.Text = "Line quantity:";
            // 
            // Label12
            // 
            Label12.AllowDrop = true;
            Label12.BackColor = System.Drawing.SystemColors.Control;
            //Label12.BorderStyle = BorderStyle.None;
            Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            Label12.Location = new System.Drawing.Point(8, 592);
            Label12.MinimumSize = new System.Drawing.Size(89, 17);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new System.Drawing.Size(89, 17);
            Label12.TabIndex = 32;
            Label12.Text = "Freight Charge:";
            // 
            // Label11
            // 
            Label11.AllowDrop = true;
            Label11.BackColor = System.Drawing.SystemColors.Control;
            //Label11.BorderStyle = BorderStyle.None;
            Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            Label11.Location = new System.Drawing.Point(8, 616);
            Label11.MinimumSize = new System.Drawing.Size(89, 17);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new System.Drawing.Size(89, 17);
            Label11.TabIndex = 30;
            Label11.Text = "Total:";
            // 
            // Label10
            // 
            Label10.AllowDrop = true;
            Label10.BackColor = System.Drawing.SystemColors.Control;
            //Label10.BorderStyle = BorderStyle.None;
            Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            Label10.Location = new System.Drawing.Point(272, 592);
            Label10.MinimumSize = new System.Drawing.Size(89, 17);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new System.Drawing.Size(89, 17);
            Label10.TabIndex = 28;
            Label10.Text = "Total Tax:";
            // 
            // Label9
            // 
            Label9.AllowDrop = true;
            Label9.BackColor = System.Drawing.SystemColors.Control;
            //Label9.BorderStyle = BorderStyle.None;
            Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            Label9.Location = new System.Drawing.Point(272, 616);
            Label9.MinimumSize = new System.Drawing.Size(89, 17);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new System.Drawing.Size(89, 17);
            Label9.TabIndex = 26;
            Label9.Text = "Sub Total:";
            // 
            // Label8
            // 
            Label8.AllowDrop = true;
            Label8.BackColor = System.Drawing.SystemColors.Control;
            //Label8.BorderStyle = BorderStyle.None;
            Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            Label8.Location = new System.Drawing.Point(8, 568);
            Label8.MinimumSize = new System.Drawing.Size(89, 17);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new System.Drawing.Size(89, 17);
            Label8.TabIndex = 25;
            Label8.Text = "Sales Tax:";
            // 
            // Label7
            // 
            Label7.AllowDrop = true;
            Label7.BackColor = System.Drawing.SystemColors.Control;
            //Label7.BorderStyle = BorderStyle.None;
            Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            Label7.Location = new System.Drawing.Point(256, 320);
            Label7.MinimumSize = new System.Drawing.Size(105, 17);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new System.Drawing.Size(105, 17);
            Label7.TabIndex = 22;
            Label7.Text = "Promised by date:";
            // 
            // Label6
            // 
            Label6.AllowDrop = true;
            Label6.BackColor = System.Drawing.SystemColors.Control;
            //Label6.BorderStyle = BorderStyle.None;
            Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            Label6.Location = new System.Drawing.Point(8, 320);
            Label6.MinimumSize = new System.Drawing.Size(105, 17);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new System.Drawing.Size(105, 17);
            Label6.TabIndex = 34;
            Label6.Text = "Required by date:";
            // 
            // frmOrderRequest
            // 
            AllowDrop = true;
            //AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
            //AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(523, 703);
            Controls.Add(txtSubTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtTotalTax);
            Controls.Add(txtFreightCharge);
            Controls.Add(txtSalesTax);
            Controls.Add(txtEntry);
            Controls.Add(fgProducts);
            Controls.Add(sbStatusBar);
            Controls.Add(dtRequired);
            Controls.Add(cmdSave);
            Controls.Add(cmdAddProducts);
            Controls.Add(cmdClose);
            Controls.Add(Frame1);
            Controls.Add(Frame2);
            Controls.Add(dtPromised);
            Controls.Add(Label13);
            Controls.Add(Label12);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(3, 25);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderRequest";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Create Order";
            //commandButtonHelper1.SetStyle(cmdSave, 0);
            //commandButtonHelper1.SetStyle(cmdAddProducts, 0);
            //commandButtonHelper1.SetStyle(cmdClose, 0);
            //commandButtonHelper1.SetStyle(cmdCustomers, 0);
            Activated += new System.EventHandler(frmOrderRequest_Activated);
            Closed += new System.EventHandler(Form_Closed);
            FormClosing += new FormClosingEventHandler(Form_FormClosing);
            //((System.ComponentModel.ISupportInitialize)fgProducts).EndInit();
            //listViewHelper1.SetItemClickMethod(lvCustomers, "lvCustomers_ItemClick");
            //listViewHelper1.SetCorrectEventsBehavior(lvCustomers, true);
            //((System.ComponentModel.ISupportInitialize)listViewHelper1).EndInit();
            sbStatusBar.ResumeLayout(false);
            Frame1.ResumeLayout(false);
            lvCustomers.ResumeLayout(false);
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
            //MdiParent = frmMain.DefInstance;
            //frmMain.DefInstance.Show();
        }
        #endregion
    }
}
