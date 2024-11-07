using UpgradeHelpers.Helpers;

namespace SKS_Blazor.Components
{
    using Gap.Blazor;
    using SKS_Blazor.Components.Pages;
    using UpgradeHelpers.DB.ADO;
    using UpgradeHelpers.Helpers;

    public partial class frmLogin: Form
    {

        public frmLogin(): base()
        {
            this.View = typeof(FrmLoginView);
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


        private void frmLogin_Activated(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
            {
                // gap-note: This is generated as a Stub.
                //UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form)eventSender;
            }
        }

        public bool LoginSucceeded = false;

        private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
        {
            LoginSucceeded = false;
            this.Close();
        }

        // gap-note: Change this method to async so it can wait for the modal result.
        private async void cmdOk_Click(Object eventSender, EventArgs eventArgs)
        {
            modConnection.ExecuteSql($"SELECT * FROM Users WHERE username = '{txtUserName.Text}' and password = '{txtPassword.Text}'");
            if (modConnection.rs.EOF)
            {
                // gap-note: Await the modal result.
                await MessageBox.Show("Invalid 'Username' or 'Password', please try again!", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                modFunctions.SelectAll(txtUserName);
                return;
            }
            modMain.UserFullname = Convert.ToString(modConnection.rs["Fullname"]);
            modMain.UserLevel = Convert.ToString(modConnection.rs["Level"]);
            modMain.CurrentUserAdmin = (modMain.UserLevel == "Administrator");
            // gap-todo: PBI 745731. Add support for Control Cursor property.
            //this.Cursor = CursorHelper.CursorDefault;
            LoginSucceeded = true;
            modMain.LogStatus($"User : {modMain.UserFullname} logged at {DateTimeHelper.ToString(DateTime.Parse(DateTimeHelper.ToString(DateTime.Now)))},{DateTimeHelper.ToString(DateTime.Now)}");
            this.Close();
        }
        private void Form_Closed(Object eventSender, EventArgs eventArgs)
        {
        }
    }
}
