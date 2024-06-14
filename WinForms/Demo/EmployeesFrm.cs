
using System.Data;

namespace Demo
{
    public partial class EmployeesFrm : Form
    {
        public EmployeesFrm()
        {
            InitializeComponent();
        }

        private void cnlBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            if (this.empLst.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Are you sure to remove?", "Remove Employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataClass.RemoveEmployee();
                    PopulateListView(DataClass.EmpDT);
                }
            }
            else
            {
                MessageBox.Show("Select Employee!", "Remove Employee", MessageBoxButtons.OK);
            }
        }

        private void uptBtn_Click(object sender, EventArgs e)
        {
            var empFrm = new EmployeeFrm();
            empFrm.Text = "Update Employee";
            empFrm.ShowDialog();
            PopulateListView(DataClass.EmpDT);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var empFrm = new EmployeeFrm();
            empFrm.Text = "Add Employee";
            DataClass.SelectEmployee(-1);
            empFrm.ShowDialog();
            PopulateListView(DataClass.EmpDT);
        }

        private void EmployeesFrm_Load(object sender, EventArgs e)
        {
            var dt_Emp = DataClass.LoadEmployees();
            PopulateListView(dt_Emp);
        }

        private void PopulateListView(DataTable dt)
        {
            this.empLst.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();

                for (int i = 1; i < dr.ItemArray.Length; i++)
                {
                    item.SubItems.Add(dr.ItemArray[i]?.ToString());
                }
                this.empLst.Items.Add(item);
            }
        }

        private void empLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClass.SelectEmployee(this.empLst.SelectedIndices.Count > 0 ? this.empLst.SelectedIndices[0] : -1);
        }
    }
}
