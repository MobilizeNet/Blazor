using static System.Net.Mime.MediaTypeNames;
using Gap.Blazor;
using Telerik.Blazor;

namespace SKS_Blazor.Components
{
	public partial class frmMain
	{
		#region "Upgrade Support "
		private static frmMain m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmMain DefInstance
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
		public static frmMain CreateInstance()
		{
			frmMain theInstance = new frmMain();
			theInstance.MDIForm_Load();
			return theInstance;
		}
		private string[] visualControls = new string[] { "components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar" };
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public ToolTip ToolTipMain;
		public ToolStripMenuItem mnuCustomer;
		public ToolStripMenuItem mnuProviders;
		public ToolStripMenuItem mnuExit;
		public ToolStripMenuItem mnuFile;
		public ToolStripMenuItem mnuCreateOrderRequest;
		public ToolStripMenuItem mnuOrderRequestsApproval;
		public ToolStripSeparator lExit2;
		public ToolStripMenuItem mnuCreateOrderReception;
		public ToolStripMenuItem mnuOrderReceptionsApproval;
		public ToolStripMenuItem mnuOrders;
		public ToolStripMenuItem mnuAddStockManually;
		public ToolStripMenuItem mnuAdjustStockManually;
		public ToolStripMenuItem mnuMainInventory;
		public ToolStripMenuItem mnuProducts;
		public ToolStripMenuItem mnuSecurity;
		public ToolStripMenuItem mnuAccounts;
		public ToolStripMenuItem mnuAbout;
		public ToolStripMenuItem mnuHelp;
		public MenuStrip MainMenu1;
		public ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public ToolStripStatusLabel sbStatusBar_Panels_Panel2;
		public ToolStripStatusLabel sbStatusBar_Panels_Panel3;
		public StatusStrip sbStatusBar;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			ToolTipMain = new ToolTip(components);
			MainMenu1 = new MenuStrip();
			mnuFile = new ToolStripMenuItem();
			mnuCustomer = new ToolStripMenuItem();
			mnuProviders = new ToolStripMenuItem();
			mnuExit = new ToolStripMenuItem();
			mnuOrders = new ToolStripMenuItem();
			mnuCreateOrderRequest = new ToolStripMenuItem();
			mnuOrderRequestsApproval = new ToolStripMenuItem();
			lExit2 = new ToolStripSeparator();
			mnuCreateOrderReception = new ToolStripMenuItem();
			mnuOrderReceptionsApproval = new ToolStripMenuItem();
			mnuMainInventory = new ToolStripMenuItem();
			mnuAddStockManually = new ToolStripMenuItem();
			mnuAdjustStockManually = new ToolStripMenuItem();
			mnuAccounts = new ToolStripMenuItem();
			mnuProducts = new ToolStripMenuItem();
			mnuSecurity = new ToolStripMenuItem();
			mnuHelp = new ToolStripMenuItem();
			mnuAbout = new ToolStripMenuItem();
			sbStatusBar = new StatusStrip();
			sbStatusBar_Panels_Panel1 = new ToolStripStatusLabel();
			sbStatusBar_Panels_Panel2 = new ToolStripStatusLabel();
			sbStatusBar_Panels_Panel3 = new ToolStripStatusLabel();
			sbStatusBar.SuspendLayout();
			SuspendLayout();
			// 
			// MainMenu1
			// 
			MainMenu1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuOrders, mnuMainInventory, mnuAccounts, mnuHelp });
			// 
			// mnuFile
			// 
			mnuFile.Available = true;
			mnuFile.Checked = false;
			mnuFile.Enabled = true;
			//mnuFile.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuFile.Name = "mnuFile";
			mnuFile.Text = "File"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuCustomer, mnuProviders, mnuExit });
			// 
			// mnuCustomer
			// 
			mnuCustomer.Available = true;
			mnuCustomer.Checked = false;
			mnuCustomer.Enabled = true;
			mnuCustomer.Name = "mnuCustomer";
			mnuCustomer.Text = "Manage Customers"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuCustomer.Click += new System.EventHandler(mnuCustomer_Click);
			// 
			// mnuProviders
			// 
			mnuProviders.Available = true;
			mnuProviders.Checked = false;
			mnuProviders.Enabled = true;
			mnuProviders.Name = "mnuProviders";
			mnuProviders.Text = "Manage Suppliers "; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuProviders.Click += new System.EventHandler(mnuProviders_Click);
			// 
			// mnuExit
			// 
			mnuExit.Available = true;
			mnuExit.Checked = false;
			mnuExit.Enabled = true;
			mnuExit.Name = "mnuExit";
			mnuExit.Text = "Exit"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuExit.Click += new System.EventHandler(mnuExit_Click);
			// 
			// mnuOrders
			// 
			mnuOrders.Available = true;
			mnuOrders.Checked = false;
			mnuOrders.Enabled = true;
			//mnuOrders.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuOrders.Name = "mnuOrders";
			mnuOrders.Text = "Orders"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			// Pending Add LExit2
			mnuOrders.DropDownItems.AddRange(new ToolStripItem[] { mnuCreateOrderRequest, mnuOrderRequestsApproval, mnuCreateOrderReception, mnuOrderReceptionsApproval });
			// 
			// mnuCreateOrderRequest
			// 
			mnuCreateOrderRequest.Available = true;
			mnuCreateOrderRequest.Checked = false;
			mnuCreateOrderRequest.Enabled = true;
			mnuCreateOrderRequest.Name = "mnuCreateOrderRequest";
			mnuCreateOrderRequest.Text = "Create Order";
			mnuCreateOrderRequest.Click += new System.EventHandler(mnuCreateOrderRequest_Click);
			// 
			// mnuOrderRequestsApproval
			// 
			mnuOrderRequestsApproval.Available = true;
			mnuOrderRequestsApproval.Checked = false;
			mnuOrderRequestsApproval.Enabled = true;
			mnuOrderRequestsApproval.Name = "mnuOrderRequestsApproval";
			mnuOrderRequestsApproval.Text = "Create Invoice";
			mnuOrderRequestsApproval.Click += new System.EventHandler(mnuOrderRequestsApproval_Click);
			// 
			// lExit2
			// 
			lExit2.AllowDrop = true;
			lExit2.Available = true;
			lExit2.Enabled = true;
			lExit2.Name = "lExit2";
			// 
			// mnuCreateOrderReception
			// 
			mnuCreateOrderReception.Available = true;
			mnuCreateOrderReception.Checked = false;
			mnuCreateOrderReception.Enabled = true;
			mnuCreateOrderReception.Name = "mnuCreateOrderReception";
			mnuCreateOrderReception.Text = "Add Stock Order";
			mnuCreateOrderReception.Click += new System.EventHandler(mnuCreateOrderReception_Click);
			// 
			// mnuOrderReceptionsApproval
			// 
			mnuOrderReceptionsApproval.Available = true;
			mnuOrderReceptionsApproval.Checked = false;
			mnuOrderReceptionsApproval.Enabled = true;
			mnuOrderReceptionsApproval.Name = "mnuOrderReceptionsApproval";
			mnuOrderReceptionsApproval.Text = "Add Stock to Inventory";
			mnuOrderReceptionsApproval.Click += new System.EventHandler(mnuOrderReceptionsApproval_Click);
			// 
			// mnuMainInventory
			// 
			mnuMainInventory.Available = true;
			mnuMainInventory.Checked = false;
			mnuMainInventory.Enabled = true;
			//mnuMainInventory.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuMainInventory.Name = "mnuMainInventory";
			mnuMainInventory.Text = "Inventory"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuMainInventory.DropDownItems.AddRange(new ToolStripItem[] { mnuAddStockManually, mnuAdjustStockManually });
			// 
			// mnuAddStockManually
			// 
			mnuAddStockManually.Available = true;
			mnuAddStockManually.Checked = false;
			mnuAddStockManually.Enabled = true;
			mnuAddStockManually.Name = "mnuAddStockManually";
			mnuAddStockManually.Text = "Inventory Update";
			mnuAddStockManually.Click += new System.EventHandler(mnuAddStockManually_Click);
			// 
			// mnuAdjustStockManually
			// 
			mnuAdjustStockManually.Available = true;
			mnuAdjustStockManually.Checked = false;
			mnuAdjustStockManually.Enabled = true;
			mnuAdjustStockManually.Name = "mnuAdjustStockManually";
			mnuAdjustStockManually.Text = "Inventory Adjust";
			mnuAdjustStockManually.Click += new System.EventHandler(mnuAdjustStockManually_Click);
			// 
			// mnuAccounts
			// 
			mnuAccounts.Available = true;
			mnuAccounts.Checked = false;
			mnuAccounts.Enabled = true;
			// mnuAccounts.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuAccounts.Name = "mnuAccounts";
			mnuAccounts.Text = "Maintenance"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuAccounts.DropDownItems.AddRange(new ToolStripItem[] { mnuProducts, mnuSecurity });
			// 
			// mnuProducts
			// 
			mnuProducts.Available = true;
			mnuProducts.Checked = false;
			mnuProducts.Enabled = true;
			mnuProducts.Name = "mnuProducts";
			mnuProducts.Text = "Manage Products";
			mnuProducts.Click += new System.EventHandler(mnuProducts_Click);
			// 
			// mnuSecurity
			// 
			mnuSecurity.Available = true;
			mnuSecurity.Checked = false;
			mnuSecurity.Enabled = true;
			mnuSecurity.Name = "mnuSecurity";
			mnuSecurity.Text = "Manage Users";
			mnuSecurity.Click += new System.EventHandler(mnuSecurity_Click);
			// 
			// mnuHelp
			// 
			mnuHelp.Available = true;
			mnuHelp.Checked = false;
			mnuHelp.Enabled = true;
			//mnuHelp.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuHelp.Name = "mnuHelp";
			mnuHelp.Text = "Help"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
			// 
			// mnuAbout
			// 
			mnuAbout.Available = true;
			mnuAbout.Checked = false;
			mnuAbout.Enabled = true;
			mnuAbout.Name = "mnuAbout";
			mnuAbout.Text = "About"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
			mnuAbout.Click += new System.EventHandler(mnuAbout_Click);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = DockStyle.Bottom;
			sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 683);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(1113, 25);
			sbStatusBar.TabIndex = 0;
			sbStatusBar.Items.AddRange(new ToolStripItem[] { sbStatusBar_Panels_Panel1 });
			sbStatusBar.Items.AddRange(new ToolStripItem[] { sbStatusBar_Panels_Panel2 });
			sbStatusBar.Items.AddRange(new ToolStripItem[] { sbStatusBar_Panels_Panel3 });
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = (ToolStripStatusLabelBorderSides)(ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel1.BorderStyle = Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel1.Margin = new Padding(0);
            sbStatusBar_Panels_Panel1.Name = "sbStatusBar_Panels_Panel1";
            sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(901, 25);
			sbStatusBar_Panels_Panel1.Spring = true;
			sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel1.TextImageRelation = TextImageRelation.ImageBeforeText;
			// 
			// sbStatusBar_Panels_Panel2
			// 
			sbStatusBar_Panels_Panel2.AutoSize = false;
			sbStatusBar_Panels_Panel2.BorderSides = (ToolStripStatusLabelBorderSides)(ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel2.BorderStyle = Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel2.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel2.Margin = new Padding(0);
            sbStatusBar_Panels_Panel2.Name = "sbStatusBar_Panels_Panel2";
            sbStatusBar_Panels_Panel2.Size = new System.Drawing.Size(96, 25);
			sbStatusBar_Panels_Panel2.Text = "1:25 PM";
			sbStatusBar_Panels_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel2.TextImageRelation = TextImageRelation.ImageBeforeText;
			// 
			// sbStatusBar_Panels_Panel3
			// 
			sbStatusBar_Panels_Panel3.AutoSize = false;
			sbStatusBar_Panels_Panel3.BorderSides = (ToolStripStatusLabelBorderSides)(ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel3.BorderStyle = Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel3.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel3.Margin = new Padding(0);
            sbStatusBar_Panels_Panel3.Name = "sbStatusBar_Panels_Panel3";
            sbStatusBar_Panels_Panel3.Size = new System.Drawing.Size(96, 25);
			sbStatusBar_Panels_Panel3.Text = "2/21/2018";
			sbStatusBar_Panels_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel3.TextImageRelation = TextImageRelation.ImageBeforeText;
			// 
			// frmMain
			// 
			AllowDrop = true;
			BackColor = System.Drawing.SystemColors.AppWorkspace;
			ClientSize = new System.Drawing.Size(1113, 708);
			Controls.Add(sbStatusBar);
			Controls.Add(MainMenu1);
			Enabled = true;
			Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
			IsMdiContainer = true;
			Location = new System.Drawing.Point(0, 0);
			Name = "frmMain";
			RightToLeft = RightToLeft.No;
			Text = "Sales Agent";
			WindowState = FormWindowState.Maximized;
			Activated += new System.EventHandler(frmMain_Activated);
			sbStatusBar.ResumeLayout(false);
			ResumeLayout(false);
		}
		#endregion
	}
}
