using static System.Net.Mime.MediaTypeNames;
using Gap.Blazor;
using Telerik.Blazor;
namespace SKS_Blazor.Components
{
    partial class frmProducts 
    {

        #region "Upgrade Support "
        private static frmProducts m_vb6FormDefInstance;
        private static bool m_InitializingDefInstance;
        public static frmProducts DefInstance
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
        public static frmProducts CreateInstance()
        {
            frmProducts theInstance = new frmProducts();
            theInstance.Form_Load();
            return theInstance;
        }
        private string[] visualControls = new string[] { "components", "ToolTipMain", "_txtField_6", "_txtField_0", "_txtField_5", "cmbCategory", "_txtField_4", "_txtField_3", "_txtField_2", "_txtField_1", "Check1", "txtCategory", "Label7", "Label3", "Label2", "Label1", "Label4", "Label5", "Label6", "Label11", "Label15", "Frame1", "dcProducts", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField" };
        //Required by the Windows Form Designer
        public System.ComponentModel.IContainer components;
        public ToolTip ToolTipMain;
        public TextBox _txtField_6;
        public TextBox _txtField_0;
        public TextBox _txtField_5;
        public ComboBox cmbCategory;
        public TextBox _txtField_4;
        public TextBox _txtField_3;
        public TextBox _txtField_2;
        public TextBox _txtField_1;
        public CheckBox Check1;
        public TextBox txtCategory;
        public Label Label7;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        public Label Label4;
        public Label Label5;
        public Label Label6;
        public Label Label11;
        public Label Label15;
        public GroupBox Frame1;
        public Gap.Blazor.VBUC.ADODataControlHelper dcProducts;
        public ImageList ImageList1;
        public ToolStripButton Toolbar1_Buttons_Button1;
        public ToolStripButton Toolbar1_Buttons_Button2;
        public ToolStripButton Toolbar1_Buttons_Button3;
        public ToolStripButton Toolbar1_Buttons_Button4;
        public ToolStripButton Toolbar1_Buttons_Button5;
        public ToolStripButton Toolbar1_Buttons_Button6;
        public ToolStrip Toolbar1;
        public TextBox[] txtField = new TextBox[7];
		public Button buttonFirst;
		public Button buttonPrevious;
		public Button buttonNext;
		public Button buttonLast;
		public Label labelTable;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            ToolTipMain = new ToolTip(components);
            Frame1 = new GroupBox();
            _txtField_6 = new TextBox();
            _txtField_0 = new TextBox();
            _txtField_5 = new TextBox();
            cmbCategory = new ComboBox();
            _txtField_4 = new TextBox();
            _txtField_3 = new TextBox();
            _txtField_2 = new TextBox();
            _txtField_1 = new TextBox();
            Check1 = new CheckBox();
            txtCategory = new TextBox();
            Label7 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label11 = new Label();
            Label15 = new Label();
            dcProducts = new Gap.Blazor.VBUC.ADODataControlHelper(); 
            ImageList1 = new ImageList();
            Toolbar1 = new ToolStrip();
            Toolbar1_Buttons_Button1 = new ToolStripButton();
            Toolbar1_Buttons_Button2 = new ToolStripButton();
            Toolbar1_Buttons_Button3 = new ToolStripButton();
            Toolbar1_Buttons_Button4 = new ToolStripButton();
            Toolbar1_Buttons_Button5 = new ToolStripButton();
            Toolbar1_Buttons_Button6 = new ToolStripButton();
			this.buttonFirst = new Button();
			this.buttonPrevious = new Button();
			this.buttonNext = new Button();
			this.buttonLast = new Button();
			this.labelTable = new Label();
			//((System.ComponentModel.ISupportInitialize)dcProducts).BeginInit(); //gap-todo: PBI 746470. Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
			Frame1.SuspendLayout();
            Toolbar1.SuspendLayout();
            SuspendLayout();
            // 
            // Frame1
            // 
            Frame1.AllowDrop = true;
            Frame1.BackColor = System.Drawing.SystemColors.Control;
            Frame1.Controls.Add(_txtField_6);
            Frame1.Controls.Add(_txtField_0);
            Frame1.Controls.Add(_txtField_5);
            Frame1.Controls.Add(cmbCategory);
            Frame1.Controls.Add(_txtField_4);
            Frame1.Controls.Add(_txtField_3);
            Frame1.Controls.Add(_txtField_2);
            Frame1.Controls.Add(_txtField_1);
            Frame1.Controls.Add(Check1);
            Frame1.Controls.Add(txtCategory);
            Frame1.Controls.Add(Label7);
            Frame1.Controls.Add(Label3);
            Frame1.Controls.Add(Label2);
            Frame1.Controls.Add(Label1);
            Frame1.Controls.Add(Label4);
            Frame1.Controls.Add(Label5);
            Frame1.Controls.Add(Label6);
            Frame1.Controls.Add(Label11);
            Frame1.Controls.Add(Label15);
            //Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            Frame1.Enabled = true;
            Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            Frame1.Location = new System.Drawing.Point(8, 48);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new System.Drawing.Size(433, 281);
            Frame1.TabIndex = 9;
            Frame1.Text = "Product information";
            Frame1.Visible = true;
            // 
            // _txtField_6
            // 
            _txtField_6.AcceptsReturn = true;
            _txtField_6.AllowDrop = true;
            _txtField_6.BackColor = System.Drawing.SystemColors.Window;
            _txtField_6.BorderStyle = BorderStyle.Fixed3D;
            //_txtField_6.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_6.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_6.Location = new System.Drawing.Point(256, 240);
            _txtField_6.MaxLength = 0;
            _txtField_6.Name = "_txtField_6";
            _txtField_6.RightToLeft = RightToLeft.No;
            _txtField_6.Size = new System.Drawing.Size(105, 20);
            _txtField_6.TabIndex = 20;
            // 
            // _txtField_0
            // 
            _txtField_0.AcceptsReturn = true;
            _txtField_0.AllowDrop = true;
            _txtField_0.BackColor = System.Drawing.SystemColors.Window;
            _txtField_0.BorderStyle = BorderStyle.Fixed3D;
            //_txtField_0.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_0.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_0.Location = new System.Drawing.Point(104, 24);
            _txtField_0.MaxLength = 20;
            _txtField_0.Name = "_txtField_0";
            _txtField_0.RightToLeft = RightToLeft.No;
            _txtField_0.Size = new System.Drawing.Size(113, 20);
            _txtField_0.TabIndex = 0;
            // 
            // _txtField_5
            // 
            _txtField_5.AcceptsReturn = true;
            _txtField_5.AllowDrop = true;
            _txtField_5.BackColor = System.Drawing.SystemColors.Window;
            _txtField_5.BorderStyle = BorderStyle.Fixed3D;
            //_txtField_5.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_5.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_5.Location = new System.Drawing.Point(104, 240);
            _txtField_5.MaxLength = 0;
            _txtField_5.Name = "_txtField_5";
            _txtField_5.RightToLeft = RightToLeft.No;
            _txtField_5.Size = new System.Drawing.Size(105, 20);
            _txtField_5.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.AllowDrop = true;
            cmbCategory.BackColor = System.Drawing.SystemColors.Window;
            cmbCategory.CausesValidation = true;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Enabled = true;
            cmbCategory.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmbCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbCategory.IntegralHeight = true;
            cmbCategory.Location = new System.Drawing.Point(104, 117);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.RightToLeft = RightToLeft.No;
            cmbCategory.Size = new System.Drawing.Size(121, 21);
            cmbCategory.Sorted = false;
            cmbCategory.TabIndex = 3;
            cmbCategory.TabStop = true;
            cmbCategory.Visible = true;
            cmbCategory.SelectedIndexChanged += new System.EventHandler(cmbCategory_SelectedIndexChanged);
            // 
            // _txtField_4
            // 
            _txtField_4.AcceptsReturn = true;
            _txtField_4.AllowDrop = true;
            _txtField_4.BackColor = System.Drawing.SystemColors.Window;
            _txtField_4.BorderStyle = BorderStyle.Fixed3D;
            //_txtField_4.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_4.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_4.Location = new System.Drawing.Point(104, 210);
            _txtField_4.MaxLength = 0;
            _txtField_4.Name = "_txtField_4";
            _txtField_4.RightToLeft = RightToLeft.No;
            _txtField_4.Size = new System.Drawing.Size(105, 20);
            _txtField_4.TabIndex = 6;
            // 
            // _txtField_3
            // 
            _txtField_3.AcceptsReturn = true;
            _txtField_3.AllowDrop = true;
            _txtField_3.BackColor = System.Drawing.SystemColors.Window;
            _txtField_3.BorderStyle = BorderStyle.Fixed3D;
            //_txtField_3.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_3.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_3.Location = new System.Drawing.Point(104, 148);
            _txtField_3.MaxLength = 0;
            _txtField_3.Name = "_txtField_3";
            _txtField_3.RightToLeft = RightToLeft.No;
            _txtField_3.Size = new System.Drawing.Size(121, 20);
            _txtField_3.TabIndex = 4;
            // 
            // _txtField_2
            // 
            _txtField_2.AcceptsReturn = true;
            _txtField_2.AllowDrop = true;
            _txtField_2.BackColor = System.Drawing.SystemColors.Window;
            _txtField_2.BorderStyle = BorderStyle.Fixed3D;
            //_txtField_2.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_2.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_2.Location = new System.Drawing.Point(104, 88);
            _txtField_2.MaxLength = 255;
            _txtField_2.Name = "_txtField_2";
            _txtField_2.RightToLeft = RightToLeft.No;
            _txtField_2.Size = new System.Drawing.Size(305, 20);
            _txtField_2.TabIndex = 2;
            // 
            // _txtField_1
            // 
            _txtField_1.AcceptsReturn = true;
            _txtField_1.AllowDrop = true;
            _txtField_1.BackColor = System.Drawing.SystemColors.Window;
            _txtField_1.BorderStyle = BorderStyle.Fixed3D;
            //_txtField_1.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_1.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_1.Location = new System.Drawing.Point(104, 56);
            _txtField_1.MaxLength = 50;
            _txtField_1.Name = "_txtField_1";
            _txtField_1.RightToLeft = RightToLeft.No;
            _txtField_1.Size = new System.Drawing.Size(193, 20);
            _txtField_1.TabIndex = 1;
            // 
            // Check1
            // 
            Check1.AllowDrop = true;
            Check1.Appearance = Appearance.Normal;
            Check1.BackColor = System.Drawing.SystemColors.Control;
            Check1.CausesValidation = true;
            Check1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Check1.CheckState = CheckState.Unchecked;
            Check1.Enabled = true;
            Check1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Check1.ForeColor = System.Drawing.SystemColors.ControlText;
            Check1.Location = new System.Drawing.Point(104, 181);
            Check1.Name = "Check1";
            Check1.RightToLeft = RightToLeft.No;
            Check1.Size = new System.Drawing.Size(25, 17);
            Check1.TabIndex = 5;
            Check1.TabStop = true;
            Check1.Text = "";
            Check1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Check1.Visible = true;
            // 
            // txtCategory
            // 
            txtCategory.AcceptsReturn = true;
            txtCategory.AllowDrop = true;
            txtCategory.BackColor = System.Drawing.SystemColors.Window;
            txtCategory.BorderStyle = BorderStyle.Fixed3D;
            //txtCategory.Cursor = Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            txtCategory.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            txtCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            txtCategory.Location = new System.Drawing.Point(200, 120);
            txtCategory.MaxLength = 0;
            txtCategory.Name = "txtCategory";
            txtCategory.RightToLeft = RightToLeft.No;
            txtCategory.Size = new System.Drawing.Size(10, 13);
            txtCategory.TabIndex = 16;
            txtCategory.TabStop = false;
            txtCategory.TextChanged += new System.EventHandler(txtCategory_TextChanged);
            // 
            // Label7
            // 
            Label7.AllowDrop = true;
            Label7.BackColor = System.Drawing.SystemColors.Control;
            Label7.BorderStyle = BorderStyle.None;
            Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            Label7.Location = new System.Drawing.Point(216, 244);
            Label7.MinimumSize = new System.Drawing.Size(57, 17);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new System.Drawing.Size(57, 17);
            Label7.TabIndex = 19;
            Label7.Text = "Unit";
            // 
            // Label3
            // 
            Label3.AllowDrop = true;
            Label3.BackColor = System.Drawing.SystemColors.Control;
            Label3.BorderStyle = BorderStyle.None;
            Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            Label3.Location = new System.Drawing.Point(16, 24);
            Label3.MinimumSize = new System.Drawing.Size(89, 17);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new System.Drawing.Size(89, 17);
            Label3.TabIndex = 18;
            Label3.Text = "Product ";
            // 
            // Label2
            // 
            Label2.AllowDrop = true;
            Label2.BackColor = System.Drawing.SystemColors.Control;
            Label2.BorderStyle = BorderStyle.None;
            Label2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            Label2.Location = new System.Drawing.Point(16, 244);
            Label2.MinimumSize = new System.Drawing.Size(81, 17);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new System.Drawing.Size(81, 17);
            Label2.TabIndex = 17;
            Label2.Text = "Qty per unit";
            // 
            // Label1
            // 
            Label1.AllowDrop = true;
            Label1.BackColor = System.Drawing.SystemColors.Control;
            Label1.BorderStyle = BorderStyle.None;
            Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            Label1.Location = new System.Drawing.Point(16, 56);
            Label1.MinimumSize = new System.Drawing.Size(89, 17);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new System.Drawing.Size(89, 17);
            Label1.TabIndex = 15;
            Label1.Text = "Name";
            // 
            // Label4
            // 
            Label4.AllowDrop = true;
            Label4.BackColor = System.Drawing.SystemColors.Control;
            Label4.BorderStyle = BorderStyle.None;
            Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            Label4.Location = new System.Drawing.Point(16, 87);
            Label4.MinimumSize = new System.Drawing.Size(89, 17);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new System.Drawing.Size(89, 17);
            Label4.TabIndex = 14;
            Label4.Text = "Desc";
            // 
            // Label5
            // 
            Label5.AllowDrop = true;
            Label5.BackColor = System.Drawing.SystemColors.Control;
            Label5.BorderStyle = BorderStyle.None;
            Label5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            Label5.Location = new System.Drawing.Point(16, 148);
            Label5.MinimumSize = new System.Drawing.Size(89, 17);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new System.Drawing.Size(89, 17);
            Label5.TabIndex = 13;
            Label5.Text = "Serial number";
            // 
            // Label6
            // 
            Label6.AllowDrop = true;
            Label6.BackColor = System.Drawing.SystemColors.Control;
            Label6.BorderStyle = BorderStyle.None;
            Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            Label6.Location = new System.Drawing.Point(16, 210);
            Label6.MinimumSize = new System.Drawing.Size(81, 17);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new System.Drawing.Size(81, 17);
            Label6.TabIndex = 12;
            Label6.Text = "Unit price";
            // 
            // Label11
            // 
            Label11.AllowDrop = true;
            Label11.BackColor = System.Drawing.SystemColors.Control;
            Label11.BorderStyle = BorderStyle.None;
            Label11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            Label11.Location = new System.Drawing.Point(16, 118);
            Label11.MinimumSize = new System.Drawing.Size(89, 17);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new System.Drawing.Size(89, 17);
            Label11.TabIndex = 11;
            Label11.Text = "Category";
            // 
            // Label15
            // 
            Label15.AllowDrop = true;
            Label15.BackColor = System.Drawing.SystemColors.Control;
            Label15.BorderStyle = BorderStyle.None;
            Label15.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            Label15.Location = new System.Drawing.Point(16, 179);
            Label15.MinimumSize = new System.Drawing.Size(89, 17);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new System.Drawing.Size(89, 17);
            Label15.TabIndex = 10;
            Label15.Text = "Discontinued";
            // 
            // dcProducts
            // 
            //gap - todo: PBI 746470.Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
            dcProducts.AllowDrop = true;
            dcProducts.BackColor = System.Drawing.SystemColors.Window;
           // dcProducts.BOFAction = UpgradeHelpers.DB.BOFActionEnum.MoveFirst;
            dcProducts.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db";
            dcProducts.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
            dcProducts.Enabled = true;
            //dcProducts.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
            dcProducts.FactoryName = "Access";
            dcProducts.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            dcProducts.ForeColor = System.Drawing.SystemColors.WindowText;
            dcProducts.Location = new System.Drawing.Point(8, 336);
            dcProducts.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic;
            dcProducts.Name = "dcProducts";
            dcProducts.Password = "";
            dcProducts.QueryTimeout = 30;
            dcProducts.QueryType = System.Data.CommandType.Text;
            dcProducts.RecordSource = "Select * from Products";
            dcProducts.Text = "Products";
            dcProducts.UserName = "";
            dcProducts.Width = 177;
            // 
            // ImageList1
            // 
            ImageList1.ImageSize = new System.Drawing.Size(16, 16);
            //ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream"); // gap-todo: PBI 736455. Research, document and implement expected for ImageList control.
            //gap-note: Workaround. The following lines were modified in order to be able to import the images.
            ImageList1.ImageStream = new ImageList.ImageListStreamer(ImageList1, "SKS.frmProducts.ImageList1.ImageStream"); 
            ImageList1.TransparentColor = System.Drawing.Color.White;
            ImageList1.Images.SetKeyName(0, "");
            ImageList1.Images.SetKeyName(1, "");
            ImageList1.Images.SetKeyName(2, "");
            ImageList1.Images.SetKeyName(3, "");
            ImageList1.Images.SetKeyName(4, "");
            ImageList1.Images.SetKeyName(5, "");
            // 
            // Toolbar1
            // 
            Toolbar1.AllowDrop = true;
            Toolbar1.Dock = DockStyle.Top;
            Toolbar1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Toolbar1.ImageList = ImageList1;
            Toolbar1.Location = new System.Drawing.Point(0, 0);
            Toolbar1.Name = "Toolbar1";
            Toolbar1.ShowItemToolTips = true;
            Toolbar1.Size = new System.Drawing.Size(448, 44);
            Toolbar1.TabIndex = 8;
            Toolbar1.Items.Add(Toolbar1_Buttons_Button1);
            Toolbar1.Items.Add(Toolbar1_Buttons_Button2);
            Toolbar1.Items.Add(Toolbar1_Buttons_Button3);
            Toolbar1.Items.Add(Toolbar1_Buttons_Button4);
            Toolbar1.Items.Add(Toolbar1_Buttons_Button5);
            Toolbar1.Items.Add(Toolbar1_Buttons_Button6);
            // 
            // Toolbar1_Buttons_Button1
            // 
            Toolbar1_Buttons_Button1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Toolbar1_Buttons_Button1.ImageIndex = 0;
            //Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
            Toolbar1_Buttons_Button1.Size = new System.Drawing.Size(44, 39);
            Toolbar1_Buttons_Button1.Text = "Add";
            Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button1.ToolTipText = "Create a new record";
            Toolbar1_Buttons_Button1.Click += new System.EventHandler(Toolbar1_ButtonClick);
            // 
            // Toolbar1_Buttons_Button2
            // 
            Toolbar1_Buttons_Button2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Toolbar1_Buttons_Button2.ImageIndex = 1;
            //Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
            Toolbar1_Buttons_Button2.Size = new System.Drawing.Size(44, 39);
            Toolbar1_Buttons_Button2.Text = "Edit";
            Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button2.ToolTipText = "Edit this record";
            Toolbar1_Buttons_Button2.Click += new System.EventHandler(Toolbar1_ButtonClick);
            // 
            // Toolbar1_Buttons_Button3
            // 
            Toolbar1_Buttons_Button3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Toolbar1_Buttons_Button3.ImageIndex = 2;
            //Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
            Toolbar1_Buttons_Button3.Size = new System.Drawing.Size(44, 39);
            Toolbar1_Buttons_Button3.Text = "Save";
            Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button3.ToolTipText = "Save the current changes";
            Toolbar1_Buttons_Button3.Click += new System.EventHandler(Toolbar1_ButtonClick);
            // 
            // Toolbar1_Buttons_Button4
            // 
            Toolbar1_Buttons_Button4.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Toolbar1_Buttons_Button4.ImageIndex = 3;
            //Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
            Toolbar1_Buttons_Button4.Size = new System.Drawing.Size(44, 39);
            Toolbar1_Buttons_Button4.Text = "Delete";
            Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button4.ToolTipText = "Delete the current record";
            Toolbar1_Buttons_Button4.Click += new System.EventHandler(Toolbar1_ButtonClick);
            // 
            // Toolbar1_Buttons_Button5
            // 
            Toolbar1_Buttons_Button5.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Toolbar1_Buttons_Button5.ImageIndex = 4;
            //Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
            Toolbar1_Buttons_Button5.Size = new System.Drawing.Size(44, 39);
            Toolbar1_Buttons_Button5.Text = "Search";
            Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button5.ToolTipText = "Search for a record";
            Toolbar1_Buttons_Button5.Click += new System.EventHandler(Toolbar1_ButtonClick);
            // 
            // Toolbar1_Buttons_Button6
            // 
            Toolbar1_Buttons_Button6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Toolbar1_Buttons_Button6.ImageIndex = 5;
            //Toolbar1_Buttons_Button6.ImageScaling = ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
            Toolbar1_Buttons_Button6.Size = new System.Drawing.Size(44, 39);
            Toolbar1_Buttons_Button6.Text = "Cancel";
            Toolbar1_Buttons_Button6.TextImageRelation = TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button6.ToolTipText = "Cancel edited changes";
            Toolbar1_Buttons_Button6.Click += new System.EventHandler(Toolbar1_ButtonClick);
			// 
			// buttonFirst
			// 
			this.buttonFirst.Location = new System.Drawing.Point(12, 343);
			this.buttonFirst.Name = "buttonFirst";
			this.buttonFirst.Size = new System.Drawing.Size(32, 23);
			this.buttonFirst.TabIndex = 17;
			this.buttonFirst.Text = "<";
			this.buttonFirst.UseVisualStyleBackColor = true;
			this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
			// 
			// buttonPrevious
			// 
			this.buttonPrevious.Location = new System.Drawing.Point(50, 343);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(32, 23);
			this.buttonPrevious.TabIndex = 18;
			this.buttonPrevious.Text = "<<";
			this.buttonPrevious.UseVisualStyleBackColor = true;
			this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
			// 
			// buttonNext
			// 
			this.buttonNext.Location = new System.Drawing.Point(143, 344);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(32, 23);
			this.buttonNext.TabIndex = 19;
			this.buttonNext.Text = ">>";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// buttonLast
			// 
			this.buttonLast.Location = new System.Drawing.Point(185, 344);
			this.buttonLast.Name = "buttonLast";
			this.buttonLast.Size = new System.Drawing.Size(32, 23);
			this.buttonLast.TabIndex = 20;
			this.buttonLast.Text = ">";
			this.buttonLast.UseVisualStyleBackColor = true;
			this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
			// 
			// labelTable
			// 
			this.labelTable.AutoSize = true;
			this.labelTable.Location = new System.Drawing.Point(88, 349);
			this.labelTable.Name = "labelTable";
			this.labelTable.Size = new System.Drawing.Size(49, 13);
			this.labelTable.TabIndex = 21;
			this.labelTable.Text = this.dcProducts.Text;
			// 
			// 
			// frmProducts
			// 
			AllowDrop = true;
            //AutoScaleDimensions = new System.Drawing.SizeF(6, 13); //gap-todo: PBI 745733: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleDimensions property
            //AutoScaleMode = AutoScaleMode.Font; //gap-todo: PBI  745734: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleMode property
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(448, 379);
			this.Controls.Add(this.labelTable);
			this.Controls.Add(this.buttonLast);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.buttonPrevious);
			this.Controls.Add(this.buttonFirst);
			Controls.Add(Frame1);
            //Controls.Add(dcProducts);
            Controls.Add(Toolbar1);
            Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(3, 25);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProducts";
            RightToLeft = RightToLeft.No;
            //ShowInTaskbar = false; // gap-todo: PBI 745735. Add support for Form ShowInTaskbar property.
            Text = "Products";
            Activated += new System.EventHandler(frmProducts_Activated);
            Closed += new System.EventHandler(Form_Closed);
            //((System.ComponentModel.ISupportInitialize)dcProducts).EndInit(); //gap-todo: PBI 746470. Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
            Frame1.ResumeLayout(false);
            Toolbar1.ResumeLayout(false);
            ResumeLayout(false);
        }
        void ReLoadForm(bool addEvents)
        {
            InitializetxtField();
            BindInfo();
            VB6_AddADODataBinding();
        }
        void InitializetxtField()
        {
            txtField = new TextBox[7];
            txtField[6] = _txtField_6;
            txtField[0] = _txtField_0;
            txtField[5] = _txtField_5;
            txtField[4] = _txtField_4;
            txtField[3] = _txtField_3;
            txtField[2] = _txtField_2;
            txtField[1] = _txtField_1;
        }
        #endregion
        #region "Upgrade Support"
        public void VB6_AddADODataBinding(bool resetDataPointer = false)
        {
            dcProducts.Refresh();

            if (resetDataPointer)
                this._dataPointerInternal = 0;

            EditMode = false;
            CancellingMode = true;
            modFunctions.BindValuesToControls(this.DataPointer, dcProducts.Recordset, InfoToBind);
            EditMode = true;
            dcProducts.Recordset.AbsolutePosition = this.DataPointer;
            dcProducts.Recordset.CurrentPosition = this.DataPointer;
        }
        #endregion
    }
}
