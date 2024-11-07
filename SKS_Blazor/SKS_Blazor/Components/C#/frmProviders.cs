namespace SKS_Blazor.Components
{
    using Gap.Blazor;
    using SKS_Blazor.Components.Pages;
    using UpgradeHelpers.Gui.Controls;

    public partial class frmProviders : Form
    {
        public frmProviders()
            : base()
        {
            this.View = typeof(FrmProvidersView);
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


        private void frmProviders_Activated(System.Object eventSender, System.EventArgs eventArgs)
        {
            //gap - note: This is generated as a stub.
            //if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
            //{
            //   // UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form)eventSender;
            //}
        }
        private bool NewMode = false;
        private bool EditMode = false;
        private bool CancellingMode = false;
        public int CurrentProviderID = 0;

        //Private Sub adcProviders_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
        //NewMode = False
        //EditMode = False
        //CancellingMode = False
        //End Sub

        //Private Sub dcProviders_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
        //CancellingMode = True
        //End Sub


        //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
        private void Form_Load()
        {
      //      dcProviders.ConnectionString = modMain.ConnectionString;

            NewMode = false;
            EditMode = false;
            CancellingMode = false;
        }

        private void Form_Closed(Object eventSender, EventArgs eventArgs) => CurrentProviderID = Convert.ToInt32(dcProviders.Recordset["ProviderId"]);


        private async void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
        {
            ToolStripItem Button = (ToolStripItem)eventSender;
            object x = null;
            //SKS Demo TODO: dcProviders.SetFocus()
            switch (Button.Text)
            {
                case "Add":
                    //Add new record 
                    NewMode = true;
                    BeforeInsert();
                    //dcProviders.Recordset.AddNew();//gap-mobilize Commented out because Binding Source feature is required
                    break;
                case "Edit":
                    //Edit mode 
                    EditMode = true;
                    break;
                case "Save":
                    Save();
                    break;
                case "Delete":
                    //Delete record 
                    if (await MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        dcProviders.Recordset.Delete();
                        dcProviders.Recordset.Requery();
                        AfterDelete();
                    }
                    break;
                case "Search":
                    //Search for records 
                    modFunctions.SearchShow("Providers", "ProviderName", "Provider");
                    break;
                case "Cancel":
                    CancellingMode = true;
                    //Cancel edited changes 
                    EditMode = false;
                    NewMode = false;
                    //dcProviders.Recordset.CancelUpdate();//gap-note Commented out due to Binding Source changes
                    dcProviders.Recordset.Requery();
                    CancellingMode = false;
                    this.Close();
                    break;
            }
        }


        private async void Save()
        {
            //Save data
            if (await modFunctions.TextBoxEmpty(txtField[0]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[1]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[2]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[4]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[5]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[6]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[7]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[7]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[10]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[11]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[12]))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtField[14]))
            {
                return;
            }
            if (NewMode)
            {
                AfterInsert();
            }
            dcProviders.Recordset.Update();
            dcProviders.Recordset.Requery();
            EditMode = false;
            NewMode = false;
        }

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
                modFunctions.SynchronizeData(this.DataPointer, dcProviders.Recordset, eventSender as Control, this.InfoToBind);
            }
        }

        //Used in search form
        //Public Sub SearchCriteria(field As String, value As String)
        //ExecuteSql "Select * from Providers where " & field & " LIKE '" & value & "%'"
        //If rs.RecordCount = 0 Then
        //    MsgBox "There are no records with the selected criteria", vbInformation, "Search"
        //Else
        //    LogStatus "There are " & rs.RecordCount & " that meet with the selected criteria"
        //    Set dcProviders.Recordset = rs
        //End If
        //End Sub

        #region Data Synchronization
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.DataPointer = 0;
            dcProviders.Recordset.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.DataPointer--;
            dcProviders.Recordset.CurrentPosition = this.DataPointer;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.DataPointer++;
            dcProviders.Recordset.CurrentPosition = this.DataPointer;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.DataPointer = modFunctions.GetRowsCount(dcProviders.Recordset);
            dcProviders.Recordset.MoveLast();
        }

        private void AfterDelete()
        {
            if (modFunctions.GetRowsCountNormal(dcProviders.Recordset) == 0)
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
        }

        private void AfterInsert()
        {
            string sqlToInsert = modFunctions.QueryToInsert(this.InfoToBind, "Providers", new Dictionary<string, string>() { { "ProviderID", new Random().Next(100, 99999).ToString() } });
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
                if (value >= 0 && value <= modFunctions.GetRowsCount(dcProviders.Recordset))
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
                {"ProviderName", this._txtField_0},
                {"PaymentTerms", this._txtField_1},
                {"EmailAddress", this._txtField_2},
                {"PostalCode", this._txtField_4},
                {"City", this._txtField_5},
                {"StateOrProvince", this._txtField_6},
                {"Country/Region", this._txtField_7},
                {"PhoneNumber", this._txtField_8},
                {"Extension", this._txtField_9},
                {"FaxNumber", this._txtField_10},
                {"ContactTitle", this._txtField_11},
                {"ContactFirstName", this._txtField_12},
                {"ContactLastName", this._txtField_13},
                {"Notes", this._txtField_14},

            };
        }

        private Dictionary<string, Control> InfoToBind { get; set; }

        #endregion
    }
}
