using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGUI
{
    public partial class employeeadd : Form
    {
        MySqlConnection con = new MySqlConnection(
           "datasource=localhost;" +
           "port=3306;" +
           "database=JCSdb;" +
           "username=root;" +
           "password=;" +
           "Convert Zero Datetime=True;");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public employeeadd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void employeeadd_Load(object sender, EventArgs e)
        {

        }
        public void clearAll()
        {
            empFname.Clear();
            empLname.Clear();
            empMname.Clear();
            empAddress.Clear();
            empContactNum.Clear();

            empPosition.Clear();
            empSSS.Clear();
            empPAGIBIG.Clear();
            empPhilHealth.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateDeliveriesInput()) return;
            con.Open();
            cmd = new MySqlCommand("INSERT INTO empprofiling (EmployeeID, empFname, empLname, empMname, address, civilStatus, sex, contactNum, dateOfBirth, contactPerson, paymentMethod, position, dateHire,dateSeperated, workStatus, SSSnum, pagIbigNum, philHealthNum) " +
                "VALUES (@empID, @empFname, @empLname, @empMname, @empAddress, @civilStatus, @sex, @contactNum, @dateOfBirth, @contactPerson, @payMethod, @position, @dateHire, @dateSeparated, @workStatus, @SSSnum, @pagIbigNum, @philHealthNum);", con);

            cmd.Parameters.AddWithValue("@empID", emplyeeID.Text);
            cmd.Parameters.AddWithValue("@empFname", empFname.Text);
            cmd.Parameters.AddWithValue("@empLname", empLname.Text);
            cmd.Parameters.AddWithValue("@empMname", empMname.Text);
            cmd.Parameters.AddWithValue("@empAddress", empAddress.Text);
            cmd.Parameters.AddWithValue("@civilStatus", cbCivilStat.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sex", GetSelectedSex());
            cmd.Parameters.AddWithValue("@contactNum", empContactNum.Text);
            cmd.Parameters.AddWithValue("@dateOfBirth", empDOB.Value.Date);
            cmd.Parameters.AddWithValue("@contactPerson", empContactNum.Text);
            cmd.Parameters.AddWithValue("@payMethod", cbEmpPayMethod.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@position", empPosition.Text);
            cmd.Parameters.AddWithValue("@dateHire", empDateHire.Value.Date);
            cmd.Parameters.AddWithValue("@dateSeparated", empDateSeparate.Value.Date);
            cmd.Parameters.AddWithValue("@workStatus", cbEmpWorkStatus.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@SSSnum", empSSS.Text);
            cmd.Parameters.AddWithValue("@pagIbigNum", empPAGIBIG.Text);
            cmd.Parameters.AddWithValue("@philHealthNum", empPhilHealth.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Employee Details Added!", "Success");

            clearAll();
        }
        private string GetSelectedSex()
        {
            if (Rmale.Checked)
            {
                return "Male";
            }
            else if (Rfemale.Checked)
            {
                return "Female";
            }

            return string.Empty;
        }
        private bool ValidateDeliveriesInput()
        {
            if (string.IsNullOrWhiteSpace(emplyeeID.Text))
            {
                MessageBox.Show("Employee ID is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empFname.Text))
            {
                MessageBox.Show("First Name is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empLname.Text))
            {
                MessageBox.Show("Last Name is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empAddress.Text))
            {
                MessageBox.Show("Address is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbCivilStat.Text))
            {
                MessageBox.Show("Civil Status is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(GetSelectedSex()))
            {
                MessageBox.Show("Sex selection is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empContactNum.Text))
            {
                MessageBox.Show("Contact Number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(EmpContactPerson.Text))
            {
                MessageBox.Show("Contact Person is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbEmpPayMethod.Text))
            {
                MessageBox.Show("Payment Method is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empPosition.Text))
            {
                MessageBox.Show("Position is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbEmpWorkStatus.Text))
            {
                MessageBox.Show("Work Status is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empSSS.Text))
            {
                MessageBox.Show("SSS# is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empPAGIBIG.Text))
            {
                MessageBox.Show("PABIBIG# is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(empPhilHealth.Text))
            {
                MessageBox.Show("PHIL-Health#  is required.", "Error");
                return false;
            }

            return true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
