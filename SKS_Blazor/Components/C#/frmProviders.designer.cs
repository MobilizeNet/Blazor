using static System.Net.Mime.MediaTypeNames;
using Gap.Blazor;
using Telerik.Blazor;
namespace SKS_Blazor.Components
{
    partial class frmProviders

    {


        #region "Upgrade Support "
        private static frmProviders m_vb6FormDefInstance;
        private static bool m_InitializingDefInstance;
        public static frmProviders DefInstance
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
        public static frmProviders CreateInstance()
        {
            frmProviders theInstance = new frmProviders();
            theInstance.Form_Load();
            return theInstance;
        }
        private string[] visualControls = new string[] { "components", "ToolTipMain", "dcProviders", "_txtField_1", "_txtField_4", "_txtField_0", "_txtField_6", "_txtField_7", "_txtField_2", "_txtField_5", "_txtField_11", "_txtField_13", "_txtField_12", "Label7", "Label3", "Label2", "Frame2", "_txtField_8", "_txtField_10", "_txtField_14", "_txtField_9", "Label4", "Label15", "Label14", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "Label1", "Frame1", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField" };
        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTipMain;
        public Gap.Blazor.VBUC.ADODataControlHelper dcProviders;
        public TextBox _txtField_1;
        public TextBox _txtField_4;
        public TextBox _txtField_0;
        public TextBox _txtField_6;
        public TextBox _txtField_7;
        public TextBox _txtField_2;
        public TextBox _txtField_5;
        public TextBox _txtField_11;
        public TextBox _txtField_13;
        public TextBox _txtField_12;
        public Label Label7;
        public Label Label3;
        public Label Label2;
        public GroupBox Frame2;
        public TextBox _txtField_8;
        public TextBox _txtField_10;
        public TextBox _txtField_14;
        public TextBox _txtField_9;
        public Label Label4;
        public Label Label15;
        public Label Label14;
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label9;
        public Label Label8;
        public Label Label6;
        public Label Label1;
        public GroupBox Frame1;
        public ImageList ImageList1;
        public ToolStripButton Toolbar1_Buttons_Button1;
        public ToolStripButton Toolbar1_Buttons_Button2;
        public ToolStripButton Toolbar1_Buttons_Button3;
        public ToolStripButton Toolbar1_Buttons_Button4;
        public ToolStripButton Toolbar1_Buttons_Button5;
        public ToolStripButton Toolbar1_Buttons_Button6;
        public ToolStrip Toolbar1;
        public TextBox[] txtField = new TextBox[15];
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProviders));
            ToolTipMain = new ToolTip(components);
            dcProviders = new Gap.Blazor.VBUC.ADODataControlHelper(); //gap-todo: PBI 746470. Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
            Frame1 = new GroupBox();
            _txtField_1 = new TextBox();
            _txtField_4 = new TextBox();
            _txtField_0 = new TextBox();
            _txtField_6 = new TextBox();
            _txtField_7 = new TextBox();
            _txtField_2 = new TextBox();
            _txtField_5 = new TextBox();
            Frame2 = new GroupBox();
            _txtField_11 = new TextBox();
            _txtField_13 = new TextBox();
            _txtField_12 = new TextBox();
            Label7 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            _txtField_8 = new TextBox();
            _txtField_10 = new TextBox();
            _txtField_14 = new TextBox();
            _txtField_9 = new TextBox();
            Label4 = new Label();
            Label15 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label6 = new Label();
            Label1 = new Label();
            ImageList1 = new ImageList();
            Toolbar1 = new ToolStrip();
            Toolbar1_Buttons_Button1 = new ToolStripButton();
            Toolbar1_Buttons_Button2 = new ToolStripButton();
            Toolbar1_Buttons_Button3 = new ToolStripButton();
            Toolbar1_Buttons_Button4 = new ToolStripButton();
            Toolbar1_Buttons_Button5 = new ToolStripButton();
            Toolbar1_Buttons_Button6 = new ToolStripButton();
            buttonFirst = new Button();
            buttonPrevious = new Button();
            buttonNext = new Button();
            buttonLast = new Button();
            labelTable = new Label();
            //((System.ComponentModel.ISupportInitialize)dcProviders).BeginInit(); //gap-todo: PBI 746470. Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
            Frame1.SuspendLayout();
            Frame2.SuspendLayout();
            Toolbar1.SuspendLayout();
            SuspendLayout();
            // 
            // dcProviders
            // 
            //gap-todo: PBI 746470. Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
           // dcProviders.AllowDrop = true;
          //  dcProviders.BackColor = System.Drawing.SystemColors.Window;
            //dcProviders.BOFAction = UpgradeHelpers.DB.BOFActionEnum.MoveFirst;
            dcProviders.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db;";
            //dcProviders.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
           // dcProviders.Enabled = true;
            //dcProviders.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
            dcProviders.FactoryName = "Access";
           // dcProviders.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
           // dcProviders.ForeColor = System.Drawing.SystemColors.WindowText;
            //dcProviders.Location = new System.Drawing.Point(8, 408);
            //dcProviders.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic;
            //dcProviders.Name = "dcProviders";
           // dcProviders.Password = "";
            dcProviders.QueryTimeout = 30;
            dcProviders.QueryType = System.Data.CommandType.Text;
            dcProviders.RecordSource = "Select * from Providers";
           // dcProviders.Text = "Suppliers";
            dcProviders.UserName = "";
           // dcProviders.Width = 177;
            // 
            // Frame1
            // 
            Frame1.AllowDrop = true;
            Frame1.BackColor = System.Drawing.SystemColors.Control;
            Frame1.Controls.Add(_txtField_1);
            Frame1.Controls.Add(_txtField_4);
            Frame1.Controls.Add(_txtField_0);
            Frame1.Controls.Add(_txtField_6);
            Frame1.Controls.Add(_txtField_7);
            Frame1.Controls.Add(_txtField_2);
            Frame1.Controls.Add(_txtField_5);
            Frame1.Controls.Add(Frame2);
            Frame1.Controls.Add(_txtField_8);
            Frame1.Controls.Add(_txtField_10);
            Frame1.Controls.Add(_txtField_14);
            Frame1.Controls.Add(_txtField_9);
            Frame1.Controls.Add(Label4);
            Frame1.Controls.Add(Label15);
            Frame1.Controls.Add(Label14);
            Frame1.Controls.Add(Label13);
            Frame1.Controls.Add(Label12);
            Frame1.Controls.Add(Label11);
            Frame1.Controls.Add(Label10);
            Frame1.Controls.Add(Label9);
            Frame1.Controls.Add(Label8);
            Frame1.Controls.Add(Label6);
            Frame1.Controls.Add(Label1);
//            Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            Frame1.Enabled = true;
            Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            Frame1.Location = new System.Drawing.Point(8, 48);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new System.Drawing.Size(433, 353);
            Frame1.TabIndex = 14;
            Frame1.Text = "Supplier information";
            Frame1.Visible = true;
            // 
            // _txtField_1
            // 
            _txtField_1.AcceptsReturn = true;
            _txtField_1.AllowDrop = true;
            _txtField_1.BackColor = System.Drawing.SystemColors.Window;
            _txtField_1.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_1.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_1.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_1.Location = new System.Drawing.Point(16, 288);
            _txtField_1.MaxLength = 0;
            _txtField_1.Multiline = true;
            _txtField_1.Name = "_txtField_1";
            _txtField_1.RightToLeft = RightToLeft.No;
            _txtField_1.Size = new System.Drawing.Size(401, 52);
            _txtField_1.TabIndex = 29;
            _txtField_1.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_4
            // 
            _txtField_4.AcceptsReturn = true;
            _txtField_4.AllowDrop = true;
            _txtField_4.BackColor = System.Drawing.SystemColors.Window;
            _txtField_4.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_4.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_4.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_4.Location = new System.Drawing.Point(104, 83);
            _txtField_4.MaxLength = 0;
            _txtField_4.Name = "_txtField_4";
            _txtField_4.RightToLeft = RightToLeft.No;
            _txtField_4.Size = new System.Drawing.Size(105, 20);
            _txtField_4.TabIndex = 5;
            _txtField_4.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_0
            // 
            _txtField_0.AcceptsReturn = true;
            _txtField_0.AllowDrop = true;
            _txtField_0.BackColor = System.Drawing.SystemColors.Window;
            _txtField_0.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_0.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_0.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_0.Location = new System.Drawing.Point(104, 24);
            _txtField_0.MaxLength = 0;
            _txtField_0.Name = "_txtField_0";
            _txtField_0.RightToLeft = RightToLeft.No;
            _txtField_0.Size = new System.Drawing.Size(105, 20);
            _txtField_0.TabIndex = 0;
            _txtField_0.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_6
            // 
            _txtField_6.AcceptsReturn = true;
            _txtField_6.AllowDrop = true;
            _txtField_6.BackColor = System.Drawing.SystemColors.Window;
            _txtField_6.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_6.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_6.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_6.Location = new System.Drawing.Point(104, 145);
            _txtField_6.MaxLength = 0;
            _txtField_6.Name = "_txtField_6";
            _txtField_6.RightToLeft = RightToLeft.No;
            _txtField_6.Size = new System.Drawing.Size(105, 20);
            _txtField_6.TabIndex = 7;
            _txtField_6.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_7
            // 
            _txtField_7.AcceptsReturn = true;
            _txtField_7.AllowDrop = true;
            _txtField_7.BackColor = System.Drawing.SystemColors.Window;
            _txtField_7.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_7.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_7.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_7.Location = new System.Drawing.Point(104, 176);
            _txtField_7.MaxLength = 0;
            _txtField_7.Name = "_txtField_7";
            _txtField_7.RightToLeft = RightToLeft.No;
            _txtField_7.Size = new System.Drawing.Size(105, 20);
            _txtField_7.TabIndex = 8;
            _txtField_7.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_2
            // 
            _txtField_2.AcceptsReturn = true;
            _txtField_2.AllowDrop = true;
            _txtField_2.BackColor = System.Drawing.SystemColors.Window;
            _txtField_2.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_2.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_2.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_2.Location = new System.Drawing.Point(104, 54);
            _txtField_2.MaxLength = 0;
            _txtField_2.Name = "_txtField_2";
            _txtField_2.RightToLeft = RightToLeft.No;
            _txtField_2.Size = new System.Drawing.Size(105, 20);
            _txtField_2.TabIndex = 1;
            _txtField_2.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_5
            // 
            _txtField_5.AcceptsReturn = true;
            _txtField_5.AllowDrop = true;
            _txtField_5.BackColor = System.Drawing.SystemColors.Window;
            _txtField_5.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_5.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_5.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_5.Location = new System.Drawing.Point(104, 114);
            _txtField_5.MaxLength = 0;
            _txtField_5.Name = "_txtField_5";
            _txtField_5.RightToLeft = RightToLeft.No;
            _txtField_5.Size = new System.Drawing.Size(105, 20);
            _txtField_5.TabIndex = 6;
            _txtField_5.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // Frame2
            // 
            Frame2.AllowDrop = true;
            Frame2.BackColor = System.Drawing.SystemColors.Control;
            Frame2.Controls.Add(_txtField_11);
            Frame2.Controls.Add(_txtField_13);
            Frame2.Controls.Add(_txtField_12);
            Frame2.Controls.Add(Label7);
            Frame2.Controls.Add(Label3);
            Frame2.Controls.Add(Label2);
//            Frame2.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            Frame2.Enabled = true;
            Frame2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            Frame2.Location = new System.Drawing.Point(224, 14);
            Frame2.Name = "Frame2";
            Frame2.RightToLeft = RightToLeft.No;
            Frame2.Size = new System.Drawing.Size(194, 97);
            Frame2.TabIndex = 24;
            Frame2.Text = "Contact";
            Frame2.Visible = true;
            // 
            // _txtField_11
            // 
            _txtField_11.AcceptsReturn = true;
            _txtField_11.AllowDrop = true;
            _txtField_11.BackColor = System.Drawing.SystemColors.Window;
            _txtField_11.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_11.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_11.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_11.Location = new System.Drawing.Point(64, 16);
            _txtField_11.MaxLength = 0;
            _txtField_11.Name = "_txtField_11";
            _txtField_11.RightToLeft = RightToLeft.No;
            _txtField_11.Size = new System.Drawing.Size(121, 20);
            _txtField_11.TabIndex = 2;
            _txtField_11.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_13
            // 
            _txtField_13.AcceptsReturn = true;
            _txtField_13.AllowDrop = true;
            _txtField_13.BackColor = System.Drawing.SystemColors.Window;
            _txtField_13.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_13.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_13.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_13.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_13.Location = new System.Drawing.Point(64, 64);
            _txtField_13.MaxLength = 0;
            _txtField_13.Name = "_txtField_13";
            _txtField_13.RightToLeft = RightToLeft.No;
            _txtField_13.Size = new System.Drawing.Size(121, 20);
            _txtField_13.TabIndex = 4;
            _txtField_13.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_12
            // 
            _txtField_12.AcceptsReturn = true;
            _txtField_12.AllowDrop = true;
            _txtField_12.BackColor = System.Drawing.SystemColors.Window;
            _txtField_12.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_12.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_12.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_12.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_12.Location = new System.Drawing.Point(64, 40);
            _txtField_12.MaxLength = 0;
            _txtField_12.Name = "_txtField_12";
            _txtField_12.RightToLeft = RightToLeft.No;
            _txtField_12.Size = new System.Drawing.Size(121, 20);
            _txtField_12.TabIndex = 3;
            _txtField_12.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // Label7
            // 
            Label7.AllowDrop = true;
            Label7.BackColor = System.Drawing.SystemColors.Control;
            Label7.BorderStyle = BorderStyle.None;
            Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            Label7.Location = new System.Drawing.Point(8, 16);
            Label7.MinimumSize = new System.Drawing.Size(49, 17);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new System.Drawing.Size(49, 17);
            Label7.TabIndex = 27;
            Label7.Text = "Title:";
            // 
            // Label3
            // 
            Label3.AllowDrop = true;
            Label3.BackColor = System.Drawing.SystemColors.Control;
            Label3.BorderStyle = BorderStyle.None;
            Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            Label3.Location = new System.Drawing.Point(8, 69);
            Label3.MinimumSize = new System.Drawing.Size(57, 17);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new System.Drawing.Size(57, 17);
            Label3.TabIndex = 26;
            Label3.Text = "Last name:";
            // 
            // Label2
            // 
            Label2.AllowDrop = true;
            Label2.BackColor = System.Drawing.SystemColors.Control;
            Label2.BorderStyle = BorderStyle.None;
            Label2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            Label2.Location = new System.Drawing.Point(8, 43);
            Label2.MinimumSize = new System.Drawing.Size(57, 17);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new System.Drawing.Size(57, 17);
            Label2.TabIndex = 25;
            Label2.Text = "First name:";
            // 
            // _txtField_8
            // 
            _txtField_8.AcceptsReturn = true;
            _txtField_8.AllowDrop = true;
            _txtField_8.BackColor = System.Drawing.SystemColors.Window;
            _txtField_8.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_8.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_8.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_8.Location = new System.Drawing.Point(312, 115);
            _txtField_8.MaxLength = 0;
            _txtField_8.Name = "_txtField_8";
            _txtField_8.RightToLeft = RightToLeft.No;
            _txtField_8.Size = new System.Drawing.Size(105, 20);
            _txtField_8.TabIndex = 9;
            _txtField_8.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_10
            // 
            _txtField_10.AcceptsReturn = true;
            _txtField_10.AllowDrop = true;
            _txtField_10.BackColor = System.Drawing.SystemColors.Window;
            _txtField_10.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_10.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_10.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_10.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_10.Location = new System.Drawing.Point(312, 176);
            _txtField_10.MaxLength = 0;
            _txtField_10.Name = "_txtField_10";
            _txtField_10.RightToLeft = RightToLeft.No;
            _txtField_10.Size = new System.Drawing.Size(105, 20);
            _txtField_10.TabIndex = 11;
            _txtField_10.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_14
            // 
            _txtField_14.AcceptsReturn = true;
            _txtField_14.AllowDrop = true;
            _txtField_14.BackColor = System.Drawing.SystemColors.Window;
            _txtField_14.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_14.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_14.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_14.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_14.Location = new System.Drawing.Point(16, 216);
            _txtField_14.MaxLength = 0;
            _txtField_14.Multiline = true;
            _txtField_14.Name = "_txtField_14";
            _txtField_14.RightToLeft = RightToLeft.No;
            _txtField_14.Size = new System.Drawing.Size(401, 52);
            _txtField_14.TabIndex = 12;
            _txtField_14.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // _txtField_9
            // 
            _txtField_9.AcceptsReturn = true;
            _txtField_9.AllowDrop = true;
            _txtField_9.BackColor = System.Drawing.SystemColors.Window;
            _txtField_9.BorderStyle = BorderStyle.Fixed3D;
//            _txtField_9.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            _txtField_9.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            _txtField_9.ForeColor = System.Drawing.SystemColors.WindowText;
            _txtField_9.Location = new System.Drawing.Point(312, 145);
            _txtField_9.MaxLength = 0;
            _txtField_9.Name = "_txtField_9";
            _txtField_9.RightToLeft = RightToLeft.No;
            _txtField_9.Size = new System.Drawing.Size(105, 20);
            _txtField_9.TabIndex = 10;
            _txtField_9.TextChanged += new System.EventHandler(txtField_TextChanged);
            // 
            // Label4
            // 
            Label4.AllowDrop = true;
            Label4.BackColor = System.Drawing.SystemColors.Control;
            Label4.BorderStyle = BorderStyle.None;
            Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            Label4.Location = new System.Drawing.Point(16, 272);
            Label4.MinimumSize = new System.Drawing.Size(89, 17);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new System.Drawing.Size(89, 17);
            Label4.TabIndex = 30;
            Label4.Text = "Payment Terms:";
            // 
            // Label15
            // 
            Label15.AllowDrop = true;
            Label15.BackColor = System.Drawing.SystemColors.Control;
            Label15.BorderStyle = BorderStyle.None;
            Label15.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            Label15.Location = new System.Drawing.Point(16, 83);
            Label15.MinimumSize = new System.Drawing.Size(89, 17);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new System.Drawing.Size(89, 17);
            Label15.TabIndex = 28;
            Label15.Text = "Zip code:";
            // 
            // Label14
            // 
            Label14.AllowDrop = true;
            Label14.BackColor = System.Drawing.SystemColors.Control;
            Label14.BorderStyle = BorderStyle.None;
            Label14.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            Label14.Location = new System.Drawing.Point(16, 176);
            Label14.MinimumSize = new System.Drawing.Size(89, 17);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new System.Drawing.Size(89, 17);
            Label14.TabIndex = 23;
            Label14.Text = "Country";
            // 
            // Label13
            // 
            Label13.AllowDrop = true;
            Label13.BackColor = System.Drawing.SystemColors.Control;
            Label13.BorderStyle = BorderStyle.None;
            Label13.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            Label13.Location = new System.Drawing.Point(16, 145);
            Label13.MinimumSize = new System.Drawing.Size(89, 17);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new System.Drawing.Size(89, 17);
            Label13.TabIndex = 22;
            Label13.Text = "State/Prov";
            // 
            // Label12
            // 
            Label12.AllowDrop = true;
            Label12.BackColor = System.Drawing.SystemColors.Control;
            Label12.BorderStyle = BorderStyle.None;
            Label12.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            Label12.Location = new System.Drawing.Point(16, 200);
            Label12.MinimumSize = new System.Drawing.Size(89, 17);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new System.Drawing.Size(89, 17);
            Label12.TabIndex = 21;
            Label12.Text = "Notes:";
            // 
            // Label11
            // 
            Label11.AllowDrop = true;
            Label11.BackColor = System.Drawing.SystemColors.Control;
            Label11.BorderStyle = BorderStyle.None;
            Label11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            Label11.Location = new System.Drawing.Point(16, 54);
            Label11.MinimumSize = new System.Drawing.Size(89, 17);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new System.Drawing.Size(89, 17);
            Label11.TabIndex = 20;
            Label11.Text = "Email:";
            // 
            // Label10
            // 
            Label10.AllowDrop = true;
            Label10.BackColor = System.Drawing.SystemColors.Control;
            Label10.BorderStyle = BorderStyle.None;
            Label10.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            Label10.Location = new System.Drawing.Point(232, 176);
            Label10.MinimumSize = new System.Drawing.Size(89, 17);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new System.Drawing.Size(89, 17);
            Label10.TabIndex = 19;
            Label10.Text = "Fax";
            // 
            // Label9
            // 
            Label9.AllowDrop = true;
            Label9.BackColor = System.Drawing.SystemColors.Control;
            Label9.BorderStyle = BorderStyle.None;
            Label9.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            Label9.Location = new System.Drawing.Point(232, 145);
            Label9.MinimumSize = new System.Drawing.Size(89, 17);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new System.Drawing.Size(89, 17);
            Label9.TabIndex = 18;
            Label9.Text = "Ext";
            // 
            // Label8
            // 
            Label8.AllowDrop = true;
            Label8.BackColor = System.Drawing.SystemColors.Control;
            Label8.BorderStyle = BorderStyle.None;
            Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            Label8.Location = new System.Drawing.Point(232, 115);
            Label8.MinimumSize = new System.Drawing.Size(89, 17);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new System.Drawing.Size(89, 17);
            Label8.TabIndex = 17;
            Label8.Text = "Phone";
            // 
            // Label6
            // 
            Label6.AllowDrop = true;
            Label6.BackColor = System.Drawing.SystemColors.Control;
            Label6.BorderStyle = BorderStyle.None;
            Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            Label6.Location = new System.Drawing.Point(16, 114);
            Label6.MinimumSize = new System.Drawing.Size(89, 17);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new System.Drawing.Size(89, 17);
            Label6.TabIndex = 16;
            Label6.Text = "City:";
            // 
            // Label1
            // 
            Label1.AllowDrop = true;
            Label1.BackColor = System.Drawing.SystemColors.Control;
            Label1.BorderStyle = BorderStyle.None;
            Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            Label1.Location = new System.Drawing.Point(16, 24);
            Label1.MinimumSize = new System.Drawing.Size(89, 17);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new System.Drawing.Size(89, 17);
            Label1.TabIndex = 15;
            Label1.Text = "Name";
            // 
            // ImageList1
            // 
            ImageList1.ImageSize = new System.Drawing.Size(16, 16);
            //ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream"); // gap-todo: PBI 736455. Research, document and implement expected for ImageList control.
            //gap-note: Workaround. The following lines were modified in order to be able to import the images.
            ImageList1.ImageStream = new ImageList.ImageListStreamer(ImageList1, "SKS.frmProviders.ImageList1.ImageStream"); 
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
            Toolbar1.Size = new System.Drawing.Size(454, 44);
            Toolbar1.TabIndex = 13;
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
            //Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
            Toolbar1_Buttons_Button1.Size = new System.Drawing.Size(44, 39);
            Toolbar1_Buttons_Button1.Text = "Add";
            Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button1.ToolTipText = "Create a new record";
            Toolbar1_Buttons_Button1.Click += new System.EventHandler(Toolbar1_ButtonClick);
            // 
            // Toolbar1_Buttons_Button2
            // 
            Toolbar1_Buttons_Button2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Toolbar1_Buttons_Button2.ImageIndex = 1; //gap-todo: PBI 746461. Add support for ToolStripItem ImageIndex property.
            //Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None; //gap-todo: PBI 746462. Add support for ToolStripItem ImageScaling property.
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
            Toolbar1_Buttons_Button3.TextImageRelation =TextImageRelation.ImageAboveText;
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
            Toolbar1_Buttons_Button4.TextImageRelation =TextImageRelation.ImageAboveText;
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
            Toolbar1_Buttons_Button5.TextImageRelation =TextImageRelation.ImageAboveText;
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
            Toolbar1_Buttons_Button6.TextImageRelation =TextImageRelation.ImageAboveText;
            Toolbar1_Buttons_Button6.ToolTipText = "Cancel edited changes";
            Toolbar1_Buttons_Button6.Click += new System.EventHandler(Toolbar1_ButtonClick);
            // 
            // buttonFirst
            // 
            buttonFirst.Location = new System.Drawing.Point(13, 408);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new System.Drawing.Size(32, 23);
            buttonFirst.TabIndex = 17;
            buttonFirst.Text = "<";
            buttonFirst.UseVisualStyleBackColor = true;
            buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new System.Drawing.Point(47, 408);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new System.Drawing.Size(32, 23);
            buttonPrevious.TabIndex = 18;
            buttonPrevious.Text = "<<";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            buttonNext.Location = new System.Drawing.Point(147, 409);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new System.Drawing.Size(32, 23);
            buttonNext.TabIndex = 19;
            buttonNext.Text = ">>";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            buttonLast.Location = new System.Drawing.Point(185, 409);
            buttonLast.Name = "buttonLast";
            buttonLast.Size = new System.Drawing.Size(32, 23);
            buttonLast.TabIndex = 20;
            buttonLast.Text = ">";
            buttonLast.UseVisualStyleBackColor = true;
            buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.Location = new System.Drawing.Point(85, 414);
            labelTable.Name = "labelTable";
            labelTable.Size = new System.Drawing.Size(34, 13);
            labelTable.TabIndex = 21;
            labelTable.Text = "Providers";
            // 
            // frmProviders
            // 
            AllowDrop = true;
            //AutoScaleDimensions = new System.Drawing.SizeF(6, 13);  //gap-todo: PBI 745733: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleDimensions property
            //AutoScaleMode = AutoScaleMode.Font; //gap-todo: PBI  745734: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleMode property
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(454, 447);
            //Controls.Add(dcProviders); //gap-todo: PBI 746470. Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
            Controls.Add(this.labelTable);
            Controls.Add(this.buttonLast);
            Controls.Add(this.buttonNext);
            Controls.Add(this.buttonPrevious);
            Controls.Add(this.buttonFirst);
            Controls.Add(Frame1);
            Controls.Add(Toolbar1);
            Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(3, 25);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProviders";
            RightToLeft = RightToLeft.No;
            Text = "Suppliers";
            Activated += new System.EventHandler(frmProviders_Activated);
            Closed += new System.EventHandler(Form_Closed);
            //((System.ComponentModel.ISupportInitialize)dcProviders).EndInit(); //gap-todo: PBI 746470. Add support for the control UpgradeHelpers.DB.ADO.ADODataControlHelper.
            Frame1.ResumeLayout(false);
            Frame2.ResumeLayout(false);
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
            txtField = new TextBox[15];
            txtField[1] = _txtField_1;
            txtField[4] = _txtField_4;
            txtField[0] = _txtField_0;
            txtField[6] = _txtField_6;
            txtField[7] = _txtField_7;
            txtField[2] = _txtField_2;
            txtField[5] = _txtField_5;
            txtField[11] = _txtField_11;
            txtField[13] = _txtField_13;
            txtField[12] = _txtField_12;
            txtField[8] = _txtField_8;
            txtField[10] = _txtField_10;
            txtField[14] = _txtField_14;
            txtField[9] = _txtField_9;
        }
        #endregion
        #region "Upgrade Support"
        public void VB6_AddADODataBinding(bool resetDataPointer = false)
        {
            dcProviders.Refresh();

            if (resetDataPointer)
                this._dataPointerInternal = 0;

            EditMode = false;
            CancellingMode = true;
            modFunctions.BindValuesToControls(this.DataPointer, dcProviders.Recordset, InfoToBind);
            EditMode = true;
            dcProviders.Recordset.AbsolutePosition = this.DataPointer;
            dcProviders.Recordset.CurrentPosition = this.DataPointer;
        }
        #endregion
    }
}
