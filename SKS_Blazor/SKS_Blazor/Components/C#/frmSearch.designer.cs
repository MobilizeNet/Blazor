using static System.Net.Mime.MediaTypeNames;
using Gap.Blazor;
using Telerik.Blazor;

namespace SKS_Blazor.Components
{
    public partial class frmSearch
    {

        #region "Upgrade Support "
        private static frmSearch m_vb6FormDefInstance;
        private static bool m_InitializingDefInstance;
        public static frmSearch DefInstance
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
        public static frmSearch CreateInstance()
        {
            frmSearch theInstance = new frmSearch();
            return theInstance;
        }
        private string[] visualControls = new string[] { "components", "ToolTipMain", "cmdClose", "cmdSearch", "ctrlLiner1", "cboSrchBy", "txtSrchStr", "Label20", "Label19", "Image3", "Label1", "lblSrchBy", "commandButtonHelper1" };
        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTipMain;
        public Button cmdClose;
        public Button cmdSearch;
        public PictureBox ctrlLiner1;
        public ComboBox cboSrchBy;
        public TextBox txtSrchStr;
        public Label Label20;
        public Label Label19;
        public PictureBox Image3;
        public Label Label1;
        public Label lblSrchBy;
        public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            ToolTipMain = new ToolTip(components);
            cmdClose = new  Button();
            cmdSearch = new Button();
            ctrlLiner1 = new PictureBox();
            cboSrchBy = new ComboBox();
            txtSrchStr = new TextBox();
            Label20 = new Label();
            Label19 = new Label();
            Image3 = new PictureBox();
            Label1 = new Label();
            lblSrchBy = new Label();
            SuspendLayout();
            commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
            // 
            // cmdClose
            // 
            cmdClose.AllowDrop = true;
            cmdClose.BackColor = System.Drawing.SystemColors.Control;
            cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdClose.Location = new System.Drawing.Point(272, 104);
            cmdClose.Name = "cmdClose";
            cmdClose.RightToLeft = RightToLeft.No;
            cmdClose.Size = new System.Drawing.Size(81, 25);
            cmdClose.TabIndex = 8;
            cmdClose.Text = "Close"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            cmdClose.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdClose.UseVisualStyleBackColor = false;
            cmdClose.Click += new System.EventHandler(cmdClose_Click);
            // 
            // cmdSearch
            // 
            cmdSearch.AllowDrop = true;
            cmdSearch.BackColor = System.Drawing.SystemColors.Control;
            cmdSearch.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            cmdSearch.Location = new System.Drawing.Point(184, 104);
            cmdSearch.Name = "cmdSearch";
            cmdSearch.RightToLeft =  RightToLeft.No;
            cmdSearch.Size = new System.Drawing.Size(81, 25);
            cmdSearch.TabIndex = 7;
            cmdSearch.Text = "Search"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            cmdSearch.TextImageRelation =  TextImageRelation.ImageAboveText;
            cmdSearch.UseVisualStyleBackColor = false;
            cmdSearch.Click += new System.EventHandler(cmdSearch_Click);
            // 
            // ctrlLiner1
            // 
            ctrlLiner1.AllowDrop = true;
            ctrlLiner1.BackColor = System.Drawing.SystemColors.Control;
            ctrlLiner1.BorderStyle =  BorderStyle.Fixed3D;
            ctrlLiner1.CausesValidation = true;
            ctrlLiner1.Dock =  DockStyle.None;
            ctrlLiner1.Enabled = true;
            ctrlLiner1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            ctrlLiner1.Location = new System.Drawing.Point(0, 56);
            ctrlLiner1.Name = "ctrlLiner1";
            ctrlLiner1.Size = new System.Drawing.Size(385, 2);
            ctrlLiner1.SizeMode =  PictureBoxSizeMode.Normal;
            ctrlLiner1.TabIndex = 6;
            ctrlLiner1.TabStop = true;
            ctrlLiner1.Visible = true;
            // 
            // cboSrchBy
            // 
            cboSrchBy.AllowDrop = true;
            cboSrchBy.BackColor = System.Drawing.SystemColors.Window;
            cboSrchBy.CausesValidation = true;
            cboSrchBy.DropDownStyle =  ComboBoxStyle.DropDownList;
            cboSrchBy.Enabled = true;
            cboSrchBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            cboSrchBy.ForeColor = System.Drawing.SystemColors.WindowText;
            cboSrchBy.IntegralHeight = true;
            cboSrchBy.Location = new System.Drawing.Point(208, 144);
            cboSrchBy.Name = "cboSrchBy";
            cboSrchBy.RightToLeft =  RightToLeft.No;
            cboSrchBy.Size = new System.Drawing.Size(145, 21);
            cboSrchBy.Sorted = false;
            cboSrchBy.TabIndex = 3;
            cboSrchBy.TabStop = true;
            cboSrchBy.Visible = true;
            cboSrchBy.SelectedIndexChanged += new System.EventHandler(cboSrchBy_SelectedIndexChanged);
            // 
            // txtSrchStr
            // 
            txtSrchStr.AcceptsReturn = true;
            txtSrchStr.AllowDrop = true;
            txtSrchStr.BackColor = System.Drawing.SystemColors.Window;
            txtSrchStr.BorderStyle =  BorderStyle.Fixed3D;
            //txtSrchStr.Cursor = System.Windows.Forms.Cursors.IBeam; //gap-todo: PBI 745731: [Blazor][DemoConversion][Controls] Add support for Control Cursor property
            txtSrchStr.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            txtSrchStr.ForeColor = System.Drawing.SystemColors.WindowText;
            txtSrchStr.Location = new System.Drawing.Point(136, 72);
            txtSrchStr.MaxLength = 0;
            txtSrchStr.Name = "txtSrchStr";
            txtSrchStr.RightToLeft =  RightToLeft.No;
            txtSrchStr.Size = new System.Drawing.Size(217, 19);
            txtSrchStr.TabIndex = 0;
            // 
            // Label20
            // 
            Label20.AllowDrop = true;
            Label20.AutoSize = true;
            Label20.BackColor = System.Drawing.Color.Transparent;
            Label20.BorderStyle =  BorderStyle.None;
            Label20.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label20.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Label20.Location = new System.Drawing.Point(49, 32);
            Label20.MinimumSize = new System.Drawing.Size(119, 13);
            Label20.Name = "Label20";
            Label20.RightToLeft =  RightToLeft.No;
            Label20.Size = new System.Drawing.Size(119, 13);
            Label20.TabIndex = 5;
            Label20.Text = "Search for a specific item";
            // 
            // Label19
            // 
            Label19.AllowDrop = true;
            Label19.AutoSize = true;
            Label19.BackColor = System.Drawing.Color.Transparent;
            Label19.BorderStyle =  BorderStyle.None;
            Label19.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 9.75f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Label19.Location = new System.Drawing.Point(49, 8);
            Label19.MinimumSize = new System.Drawing.Size(50, 16);
            Label19.Name = "Label19";
            Label19.RightToLeft =  RightToLeft.No;
            Label19.Size = new System.Drawing.Size(50, 16);
            Label19.TabIndex = 4;
            Label19.Text = "Search";
            Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Image3
            // 
            Image3.AllowDrop = true;
            Image3.BorderStyle =  BorderStyle.None;
            Image3.Enabled = true;
            Image3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Image3.Image = (System.Drawing.Image)resources.GetObject("Image3.Image");
            Image3.Location = new System.Drawing.Point(8, 8);
            Image3.Name = "Image3";
            Image3.Size = new System.Drawing.Size(16, 16);
            Image3.SizeMode =  PictureBoxSizeMode.Normal;
            Image3.Visible = true;
            // 
            // Label1
            // 
            Label1.AllowDrop = true;
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.SystemColors.Control;
            Label1.BorderStyle =  BorderStyle.None;
            Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            Label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Label1.Location = new System.Drawing.Point(125, 144);
            Label1.MinimumSize = new System.Drawing.Size(62, 13);
            Label1.Name = "Label1";
            Label1.RightToLeft =  RightToLeft.No;
            Label1.Size = new System.Drawing.Size(62, 13);
            Label1.TabIndex = 2;
            Label1.Text = "Search by:";
            Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSrchBy
            // 
            lblSrchBy.AllowDrop = true;
            lblSrchBy.AutoSize = true;
            lblSrchBy.BackColor = System.Drawing.SystemColors.Control;
            lblSrchBy.BorderStyle =  BorderStyle.None;
            lblSrchBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            lblSrchBy.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblSrchBy.Location = new System.Drawing.Point(7, 72);
            lblSrchBy.MinimumSize = new System.Drawing.Size(116, 13);
            lblSrchBy.Name = "lblSrchBy";
            lblSrchBy.RightToLeft =  RightToLeft.No;
            lblSrchBy.Size = new System.Drawing.Size(116, 13);
            lblSrchBy.TabIndex = 1;
            lblSrchBy.Text = "Field";
            lblSrchBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmSearch
            // 
            AllowDrop = true;
            //AutoScaleDimensions = new System.Drawing.SizeF(6, 13); //gap-todo: PBI 745733: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleDimensions property
            //AutoScaleMode =  AutoScaleMode.Font; //gap-todo: PBI 745734: [Blazor][DemoConversion][Controls] Add support for ContainerControl AutoScaleMode property
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(378, 173);
            Controls.Add(cmdClose);
            Controls.Add(cmdSearch);
            Controls.Add(ctrlLiner1);
            Controls.Add(cboSrchBy);
            Controls.Add(txtSrchStr);
            Controls.Add(Label20);
            Controls.Add(Label19);
            Controls.Add(Image3);
            Controls.Add(Label1);
            Controls.Add(lblSrchBy);
            Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
            FormBorderStyle =  FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("frmSearch.Icon"); 
            Location = new System.Drawing.Point(486, 322);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSearch";
            RightToLeft =  RightToLeft.No;
            //ShowInTaskbar = false; //gap-todo: PBI 745735: [Blazor][DemoConversion][Controls] Add support for Form ShowInTaskbar property
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            //commandButtonHelper1.SetStyle(cmdClose, 0); //pendingPbi
            //commandButtonHelper1.SetStyle(cmdSearch, 0); //pendingPbi
            Activated += new System.EventHandler(frmSearch_Activated);
            Closed += new System.EventHandler(Form_Closed);
            ResumeLayout(false);
        }
        #endregion
    }
}