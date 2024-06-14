namespace Demo
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private static object[] comboItems = DataClass.Servers;
        private void LoginFrm_Load(object? sender, EventArgs e)
        {
            this.srvCbx.Items.AddRange(comboItems);
            this.srvCbx.SelectedIndex = 0;
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var empFrm = new EmployeesFrm();
            empFrm.Show();
        }
    }
}
