using static System.Windows.Forms.AxHost;

namespace Demo
{
    public partial class EmployeeFrm : Form
    {
        public EmployeeFrm()
        {
            InitializeComponent();
        }

        private static bool isUpdating = false;
        private void cnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DataClass.ModifyEmployee(isUpdating, this.IDTxt.Text, this.fnameTxt.Text, this.lnameTxt.Text, this.genderCmb.Text, this.emailTxt.Text, this.buTxt.Text, this.ctryCmb.Text);
            SaveProcess();
        }

        private void EmployeeFrm_Load(object sender, EventArgs e)
        {
            this.genderCmb.Items.AddRange(DataClass.Genders);
            this.ctryCmb.Items.AddRange(DataClass.Countries);
            var emp = DataClass.GetSelectedEmployee();
            if (emp != null )
            {
                isUpdating = true;
                this.IDTxt.Text = emp?[0]?.ToString();
                this.fnameTxt.Text = emp?[1]?.ToString();
                this.lnameTxt.Text = emp?[2]?.ToString();
                this.genderCmb.Text = emp?[3]?.ToString();
                this.emailTxt.Text = emp?[4]?.ToString();
                this.buTxt.Text = emp?[5]?.ToString();
                this.ctryCmb.Text = emp?[6]?.ToString();
            }
        }

        private void SaveProcess()
        {
            Thread backgroundThread = new Thread(new ThreadStart(UpdateProcessState));
            backgroundThread.IsBackground = true;
            saveProcessLbl.Visible = true;
            backgroundThread.Start();
        }

        private void UpdateProcessState()
        {
            string[] processStates = { "Preparing save", "Saving", "Finalizing", "Completed!" };
            foreach (var state in processStates)
            {
                // Simulate some work
                Thread.Sleep(1000);
                saveProcessLbl.Invoke(new Action(() => saveProcessLbl.Text = state));
            }

            SaveCompleted();
        }

        private void SaveCompleted()
        {
            this.Invoke(new Action(() => this.Close()));
            saveProcessLbl.Invoke(new Action(() => saveProcessLbl.Visible = false));
        }
    }
}
