using System.Data;

namespace Demo
{
    internal static class DataClass
    {
        private static int selectedEmployee = -1;

        internal static DataTable EmpDT = new DataTable();
        internal static string[] Servers = { "localhost", "DB1" };
        internal static string[] Genders = { "Female", "Male" };
        internal static string[] Countries = { "CR", "Colombia", "Peru" };

        internal static DataTable LoadEmployees()
        {
            EmpDT.Columns.Add(new DataColumn("ID"));
            EmpDT.Columns.Add(new DataColumn("FName"));
            EmpDT.Columns.Add(new DataColumn("LName"));
            EmpDT.Columns.Add(new DataColumn("Gender"));
            EmpDT.Columns.Add(new DataColumn("Email"));
            EmpDT.Columns.Add(new DataColumn("BU"));
            EmpDT.Columns.Add(new DataColumn("Country"));
            EmpDT.Rows.Add(["12", "William", "Quesada", "Male", "wquesada@growthaccelerationpartners.com", "Migrations", "CR" ]);
            EmpDT.Rows.Add(["21", "Felipe", "Mora", "Male", "lmora@growthaccelerationpartners.com", "Migrations", "CR"]);
            EmpDT.Rows.Add(["11", "Cesar", "Castaneda", "Male", "ccastaneda@growthaccelerationpartners.com", "SDE", "Colombia"]);
            EmpDT.Rows.Add(["23", "Maria", "Lopez", "Female", "mlopez@growthaccelerationpartners.com", "SDE", "CR"]);
            EmpDT.Rows.Add(["55", "Myron", "Camacho", "Male", "mcamacho@growthaccelerationpartners.com", "Migrations", "CR"]);

            return EmpDT;
        }

        internal static void SelectEmployee(int index)
        {
            selectedEmployee = index;
        }

        internal static object?[] GetSelectedEmployee()
        {
            if (selectedEmployee == -1)
            {
                return null;
            }
            else
            {
                return EmpDT.Rows[selectedEmployee].ItemArray;
            }
        }

        internal static void ModifyEmployee(bool isUpdating, string id, string fname, string lname, string gender, string email, string bu, string country)
        {
            if (isUpdating)
            {
                EmpDT.Rows[selectedEmployee][0] = id;
                EmpDT.Rows[selectedEmployee][1] = fname;
                EmpDT.Rows[selectedEmployee][2] = lname;
                EmpDT.Rows[selectedEmployee][3] = gender;
                EmpDT.Rows[selectedEmployee][4] = email;
                EmpDT.Rows[selectedEmployee][5] = bu;
                EmpDT.Rows[selectedEmployee][6] = country;
            }
            else
            {
                EmpDT.Rows.Add([id, fname, lname, gender, email, bu, country]);
            }
        }

        internal static void RemoveEmployee()
        {
            EmpDT.Rows.RemoveAt(selectedEmployee);
        }
    }
}
