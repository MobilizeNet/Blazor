namespace SKS_Blazor.Components
{
    using Gap.Blazor;
    using SKS_Blazor.Components.Pages;
    using UpgradeHelpers.Gui.Controls;
    using UpgradeHelpers.Helpers;

    public partial class frmProducts : Form
    {
        public frmProducts()
            : base()
        {
            this.View = typeof(FrmProductsView);
            if (m_vb6FormDefInstance is null)
            {
                if (m_InitializingDefInstance)
                {
                    m_vb6FormDefInstance = this;
                }
                else
                {
                    try
                    {
                        //For the start-up form, the first instance created is the default instance.
                        if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                        {
                            m_vb6FormDefInstance = this;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            //This call is required by the Windows Form Designer.
            InitializeComponent();
            ReLoadForm(false);
        }


        private void frmProducts_Activated(System.Object eventSender, System.EventArgs eventArgs)
        {
            //gap-note: This is generated as a stub.
            //if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
            //{
            //    UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form)eventSender;
            //}
        }
        private bool NewMode = false;
        private bool EditMode = false;
        private bool CancellingMode = false;
        public string CurrentProductID = "";

        //SKS Demo TODO: Go the the designer and change the data binding of _txtField_4 like this:
        //_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2");


        private void cmbCategory_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
        {
            if (cmbCategory.Items.Count == 0 || cmbCategory.SelectedIndex == -1)
            {
                return;
            }
            txtCategory.Text = cmbCategory.GetItemData(cmbCategory.SelectedIndex).ToString();
        }


        private void Form_Closed(Object eventSender, EventArgs eventArgs) => CurrentProductID = Convert.ToString(dcProducts.Recordset["ProductId"]);


        private void txtCategory_TextChanged(Object eventSender, EventArgs eventArgs)
        {
			if (NewMode == true)
			{
				return;
			}

			if (cmbCategory.Items.Count == 0)
            {
                modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if (String.IsNullOrEmpty(txtCategory.Text))
            {
                cmbCategory.SelectedIndex = -1;
                return;
            }
            int Index = -1;
            int tempForEndVar = cmbCategory.Items.Count;
            for (modMain.i = 0; modMain.i <= tempForEndVar; modMain.i++)
            {
                if (cmbCategory.GetItemData(modMain.i) == StringsHelper.ToDoubleSafe(txtCategory.Text))
                {
                    Index = modMain.i;
                    break;
                }
            }
            cmbCategory.SelectedIndex = modMain.i;

			if (!CancellingMode)
			{
				EditMode = true;
			}

			if (EditMode)
			{
				modFunctions.SynchronizeData(this.DataPointer, dcProducts.Recordset, eventSender as Control, this.InfoToBind);
			}
		}

        //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
        private void Form_Load()
        {
            txtCategory.Height = 0;
            txtCategory.Width = 0;
            dcProducts.ConnectionString = modMain.ConnectionString;
            NewMode = false;
            EditMode = false;
            CancellingMode = false;
            if (cmbCategory.Items.Count == 0)
            {
                modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
            }
        }

        private async void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
        {
            ToolStripItem Button = (ToolStripItem)eventSender;
            object x = null;
            //SKS Demo TODO: dcProducts.SetFocus()
            switch (Button.Text)
            {
                case "Add":
                    //Add new record 
                    NewMode = true;
					//dcProducts.Recordset.AddNew(); //gap-mobilize Commented out because Binding Source feature is required
					BeforeInsert();
                    //dcProducts.Recordset["UnitsInStock"] = 0;
                    //dcProducts.Recordset["UnitsOnOrder"] = 0;
                    //dcProducts.Recordset["Discontinued"] = 0;
                    break;
                case "Edit":
                    //Edit mode 
                    EditMode = true;
                    //dcProducts.Recordset.EditMode = 
                    break;
                case "Save":
					//Save data 
					if (NewMode)
					{
						AfterInsert();
					}
					modFunctions.SynchronizeData(this.DataPointer, dcProducts.Recordset, this.Check1, this.InfoToBind);
					dcProducts.Recordset.Update();
                    dcProducts.Recordset.Requery();  // SQLite ODBC driver needs to requery the info 
                    EditMode = false;
                    NewMode = false;
                    break;
                case "Delete":
                    //Delete record 
                    if (await MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dcProducts.Recordset.Delete();
                        dcProducts.Recordset.Requery();
                        AfterDelete();
                    }
                    break;
                case "Search":
                    //Search for records 
                    modFunctions.SearchShow("Products", "ProductName", "product");
                    break;
                case "Cancel":
                    CancellingMode = true;
                    //Cancel edited changes 
                    EditMode = false;
                    NewMode = false;
                    //dcProducts.Recordset.CancelUpdate();//gap-note Commented out due to Binding Source changes
                    dcProducts.Recordset.Requery();
                    CancellingMode = false;
                    this.Close();
                    break;
            }
        }

		//Private Sub txtField_KeyPress(Index As Integer, KeyAscii As Integer)
		//If Index = 0 Then
		//    KeyAscii = Asc(UCase(Chr(KeyAscii)))
		//ElseIf Index = 4 Or Index = 5 Then
		//    Select Case KeyAscii
		//        Case vbKey0 To vbKey9
		//        Case vbKeyBack, vbKeyClear, vbKeyDelete
		//        Case vbKeyLeft, vbKeyRight, vbKeyUp, vbKeyDown, vbKeyTab
		//        Case Else
		//            KeyAscii = 0
		//            Beep
		//    End Select
		//End If
		//End Sub

		#region Data Synchronization

		private void txtField_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			if (NewMode == true)
			{
				return;
			}

			if (!CancellingMode)
			{
				EditMode = true;
			}

			if (EditMode)
			{
				modFunctions.SynchronizeData(this.DataPointer, dcProducts.Recordset, eventSender as Control, this.InfoToBind);
			}
		}

		private void buttonFirst_Click(object sender, EventArgs e)
		{
			this.DataPointer = 0;
			dcProducts.Recordset.MoveFirst();
		}

		private void buttonPrevious_Click(object sender, EventArgs e)
		{
			this.DataPointer--;
			dcProducts.Recordset.CurrentPosition = this.DataPointer;
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			this.DataPointer++;
			dcProducts.Recordset.CurrentPosition = this.DataPointer;
		}

		private void buttonLast_Click(object sender, EventArgs e)
		{
			this.DataPointer = modFunctions.GetRowsCount(dcProducts.Recordset);
			dcProducts.Recordset.MoveLast();
		}

		private void AfterDelete()
		{
			if (modFunctions.GetRowsCountNormal(dcProducts.Recordset) == 0)
			{
				modFunctions.EmptyControls(this.InfoToBind);
			}
			else
			{
				buttonFirst_Click(null, null);
			}
		}

		private void BeforeInsert()
		{
			modFunctions.EmptyControls(this.InfoToBind);
			cmbCategory_SelectedIndexChanged(null, null); // line to set the category index that will be used
		}

		private void AfterInsert()
		{
			string sqlToInsert = modFunctions.QueryToInsert(this.InfoToBind, "products",
				new Dictionary<string, string>()
				{
					{ "UnitsInStock", "0" },
					{ "UnitsOnOrder", "0"},
				});
			modConnection.ExecuteSql(sqlToInsert);
			NewMode = false;
		}

		private int DataPointer
		{
			get
			{
				return this._dataPointerInternal;
			}
			set
			{
				if (value >= 0 && value <= modFunctions.GetRowsCount(dcProducts.Recordset))
				{
					_dataPointerInternal = value;
					VB6_AddADODataBinding();
				}
			}
		}
		private int _dataPointerInternal = 0;

		private void BindInfo()
		{
			InfoToBind = new Dictionary<string, Control>()
			{
				{"ProductID", this._txtField_0},
				{"ProductName", this._txtField_1},
				{"ProductDescription", this._txtField_2},
				{"SerialNumber", this._txtField_3},
				{"UnitPrice", this._txtField_4},
				{"QuantityPerUnit", this._txtField_5},
				{"Unit", this._txtField_6},
				{"CategoryID", this.txtCategory},
				{"Discontinued", this.Check1}

			};
		}

		private Dictionary<string, Control> InfoToBind { get; set; }

		#endregion
	}
}
