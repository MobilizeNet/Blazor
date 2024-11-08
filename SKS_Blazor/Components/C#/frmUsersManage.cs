﻿namespace SKS_Blazor.Components
{
    using Gap.Blazor;
    using SKS_Blazor.Components.Pages;
    using UpgradeHelpers.Gui.Controls;
    using UpgradeHelpers.Helpers;

    public partial class frmUsersManage : Form
    {
        public frmUsersManage()
           : base()
        {
            this.View = typeof(FrmUsersManageView);
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


        private void frmUsersManage_Activated(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
            {
                //UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form)eventSender; //gap-todo:
            }
        }
        string CurrentEditedUser = "";

        private void cmdClear_Click(Object eventSender, EventArgs eventArgs)
        {
            txtUsername.Text = "";
            txtUsername.Focus();
            ClearFields();
        }

        private async void cmdDelete_Click(Object eventSender, EventArgs eventArgs)
        {
            if (await modFunctions.NoRecords(lstAccounts, "Please add/select a user"))
            {
                return;
            }
            //if (MessageBox.Show($"Are you sure you want to delete the user '{lstAccounts.FocusedItem.Text}'?", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)  //gap-todo: 
            {
                modConnection.ExecuteSql("Select * from Users");
                if (modConnection.rs.RecordCount == 1)
                {
                    await MessageBox.Show("You cannot delete the last user", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                modConnection.ExecuteSql($"Delete From Users Where Username = '{lstAccounts.FocusedItem.Text}'");
                LoadUsers();
            }
        }

        private async void cmdEdit_Click(Object eventSender, EventArgs eventArgs)
        {
            if (await modFunctions.NoRecords(lstAccounts, "Please add/select a user"))
            {
                return;
            }
            modConnection.ExecuteSql($"Select * from Users where Username = '{lstAccounts.FocusedItem.Text}'");
            txtUsername.Text = Convert.ToString(modConnection.rs["UserName"]);
            if (modConnection.rs.EOF)
            {
                await MessageBox.Show("This user does not exist", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
            }
            else
            {
                txtUsername.Text = Convert.ToString(modConnection.rs["UserName"]);
                CurrentEditedUser = txtUsername.Text;
                txtPassword.Text = Convert.ToString(modConnection.rs["Password"]);
                txtFullname.Text = Convert.ToString(modConnection.rs["Fullname"]);
                cboLevel.Text = Convert.ToString(modConnection.rs["Level"]);
                cmdSave.Text = "Update"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
            }
        }

        private async void cmdSave_Click(Object eventSender, EventArgs eventArgs)
        {
            bool addRecord = false;//gap-note line added due to Binding Source feature plus a small adjustment in the logic
            string SecId = "";
            if (await modFunctions.TextBoxEmpty(txtUsername))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtPassword))
            {
                return;
            }
            if (await modFunctions.TextBoxEmpty(txtFullname))
            {
                return;
            }
            if (await modFunctions.ComboEmpty(cboLevel))
            {
                return;
            }

            modConnection.ExecuteSql($"Select * from Users where Username = '{txtUsername.Text}'");
            if (cmdSave.Text != "&Update")
            {
                if (!modConnection.rs.EOF)
                {
                    await MessageBox.Show("Add failed: Username already exists", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cboLevel.Text != "Administrator")
                {
                    modConnection.ExecuteSql2("Select * from Users where level = 'Administrator'");
                    if (modConnection.rs2.EOF)
                    {
                        await MessageBox.Show("Update failed: No any Administrator found on accounts.  You are not allowed to change the level of this account", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!modMain.CurrentUserAdmin && cboLevel.Text == "Administrator")
                {
                    await MessageBox.Show("You cannot add another level without being 'Administrator'", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboLevel.Focus();
                    return;
                }
                //modConnection.rs.AddNew();//gap-note commented due to Binding Source feature
                string sqlToInsert = modFunctions.QueryToInsert(new Dictionary<string, Control>()//gap-note line added due to Binding Source feature plus a small adjustment in the logic
                {
                    {"UserName", this.txtUsername},
                    {"Password", this.txtPassword},
                    {"Level", this.cboLevel},
                    {"Fullname", this.txtFullname},
                }, "Users", new Dictionary<string, string>());
                modConnection.ExecuteSql(sqlToInsert);//gap-note line added due to Binding Source feature plus a small adjustment in the logic
                addRecord = true;//gap-note line added due to Binding Source feature plus a small adjustment in the logic
                modMain.msg = $"Added new user {txtUsername.Text}";
            }
            else if (CurrentEditedUser != txtUsername.Text)
            {
                modConnection.ExecuteSql2($"Select * from Users where username = '{txtUsername.Text}'");
                if (!modConnection.rs2.EOF)
                {
                    await MessageBox.Show($"Username '{txtUsername.Text}' already exists.", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                    modFunctions.SelectAll(txtUsername);
                    return;
                }
                modMain.msg = $"Record for the user {txtUsername.Text} has been successfully updated";
            }
            else
            {
                modMain.msg = $"Record for the user {txtUsername.Text} has been successfully updated";
            }
            if (!addRecord)
            {
                modConnection.rs["UserName"] = txtUsername.Text;
                modConnection.rs["Password"] = txtPassword.Text;
                modConnection.rs["Level"] = cboLevel.Text;
                modConnection.rs["Fullname"] = txtFullname.Text;
                modConnection.rs.Update();
            }
            modMain.LogStatus(modMain.msg);
            ClearFields();
            LoadUsers();

            if (modMain.CurrentUserAdmin)
            {
                this.Close();
            }
        }

        public void LoadUsers()
        {
            modConnection.ExecuteSql("Select * from Users");
            lstAccounts.Items.Clear();
            ListViewItem x = null;
            while (!modConnection.rs.EOF)
            {
                x = lstAccounts.Items.Add(Convert.ToString(modConnection.rs["UserName"]));
                ListView.GetListViewSubItem(x, 1).Text = Convert.ToString(modConnection.rs["Fullname"]);
                ListView.GetListViewSubItem(x, 2).Text = Convert.ToString(modConnection.rs["Level"]);
                modConnection.rs.MoveNext();
            }
        }

        public void LoadUsersAvoidingWith()
        {
            modConnection.ExecuteSql("Select * from Users");
            lstAccounts.Items.Clear();
            ListViewItem x = null;
            while (!modConnection.rs.EOF)
            {
                x = lstAccounts.Items.Add(Convert.ToString(modConnection.rs["UserName"]));
                ListView.GetListViewSubItem(x, 1).Text = Convert.ToString(modConnection.rs["Fullname"]);
                ListView.GetListViewSubItem(x, 2).Text = Convert.ToString(modConnection.rs["Level"]);
                modConnection.rs.MoveNext();
            }
        }


        public void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullname.Text = "";
            cboLevel.SelectedIndex = -1;
            cmdSave.Text = "Save"; //gap-todo: ealeman. PBI 745736. Mnemonics feature is pending.
        }

        private void cmdClose_Click(Object eventSender, EventArgs eventArgs) => this.Close();


        //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
        private void Form_Load()
        {
            modConnection.ExecuteSql("Select * from Levels");
            while (!modConnection.rs.EOF)
            {
                cboLevel.AddItem(Convert.ToString(modConnection.rs["Level"]));
                modConnection.rs.MoveNext();
            }
            if (modMain.CurrentUserAdmin)
            {
                cboLevel.Text = "Administrator";
            }
            else
            {
                cboLevel.SelectedIndex = -1;
            }
            LoadUsers();
        }

        private async void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
            if (modMain.CurrentUserAdmin)
            {
                modConnection.ExecuteSql("Select * from Users");
                if (modConnection.rs.EOF)
                {
                    await MessageBox.Show($"System has failed to initialized. Please contact your administrator{Environment.NewLine}{Environment.NewLine}Status: analysing accounts configuration{Environment.NewLine}" +
                                    $"Error: No users found", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                //frmxSplash.tmrLoad.Enabled = True
            }
            modMain.LogStatus("");
        }

        private void lstAccounts_DoubleClick(Object eventSender, EventArgs eventArgs) => cmdEdit_Click(cmdEdit, new EventArgs());


        private void txtFullname_Enter(Object eventSender, EventArgs eventArgs) => modFunctions.SelectAll(txtFullname);


        private void txtPassword_Enter(Object eventSender, EventArgs eventArgs) => modFunctions.SelectAll(txtPassword);


        private void txtUsername_Enter(Object eventSender, EventArgs eventArgs) => modFunctions.SelectAll(txtUsername);

    }
}



