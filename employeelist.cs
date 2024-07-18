using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace FinalGUI
{
    public partial class employeelist : Form
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
        public employeelist()
        {
            InitializeComponent();
        }

        private void employeelist_Load(object sender, EventArgs e)
        {
            workinfoLoad();
            LoadPersonalInfo(); 
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void btnWorkinfo_Click(object sender, EventArgs e)
        {
          
            ToggleWorkInfoVisibility();


        }
        private void workinfoLoad()
        {
            dataworkinfo.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, EmployeeID, empFname, empLname, empMname, paymentMethod, position, dateHire, dateSeperated, workStatus, SSSnum, pagIbigNum, philHealthNum FROM empprofiling;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataworkinfo.Rows.Add(
                    rdr.GetInt32(0),
                    rdr.GetInt32(1),
                    rdr.GetString(2),
                    rdr.GetString(3),
                    rdr.GetString(4),
                    rdr.GetString(5),
                    rdr.GetString(6),
                    rdr.GetDateTime(7).ToString("yyyy-MM-dd"),
                    rdr.GetDateTime(8).ToString("yyyy-MM-dd"),
                    rdr.GetString(9),
                    rdr.GetString(10),
                    rdr.GetString(11),
                    rdr.GetString(12)
                );
            }
            con.Close();
        }
        private void ToggleWorkInfoVisibility()
        {
       
            bool newVisibilityState = !dataworkinfo.Visible;

           
            dataworkinfo.Visible = newVisibilityState;
            showWorkInfo.Visible = newVisibilityState;

            if (newVisibilityState)
            {
                btnWorkinfo.Text = "Hide Work Info";
            }
            else
            {
                btnWorkinfo.Text = "Show Work Info";
            }
        }
        public void LoadFormInPanel(Form form)
        {
            
        }
        private void ClearAll()
        {
            empPosition.Clear();
            empSSS.Clear();
            empPAGIBIG.Clear();
            empPhilHealth.Clear();
            txtID_.Clear();
            empAddress.Clear();
            empContactNum.Clear();
            empFname.Clear();
            empLname.Clear();
            empMname.Clear();
            empPAGIBIG.Clear();
            emppersonalID_.Clear();
            EmpContactPerson.Clear();
            

        }
        private void btnEdit__Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("UPDATE empprofiling SET  paymentMethod = @payMethod, position = @position, dateHire = @dateHire, dateSeperated = @dateSeparated, workStatus = @workStatus, SSSnum = @SSSnum, pagIbigNum = @pagIbigNum, philHealthNum = @philHealthNum WHERE ID = @empID;", con);

            
            cmd.Parameters.AddWithValue("@payMethod", cbEmpPayMethod.Text);
            cmd.Parameters.AddWithValue("@position", empPosition.Text);
            cmd.Parameters.AddWithValue("@dateHire", empDateHire.Value.Date);
            cmd.Parameters.AddWithValue("@dateSeparated", empDateSeparate.Value.Date);
            cmd.Parameters.AddWithValue("@workStatus", cbEmpWorkStatus.Text);
            cmd.Parameters.AddWithValue("@SSSnum", empSSS.Text);
            cmd.Parameters.AddWithValue("@pagIbigNum", empPAGIBIG.Text);
            cmd.Parameters.AddWithValue("@philHealthNum", empPhilHealth.Text);
            cmd.Parameters.AddWithValue("@empID", txtID_.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            workinfoLoad();
            MessageBox.Show("Employee Details Updated!", "Success");

            ClearAll();
        }

        private void btnLoadWorkinfo_Click(object sender, EventArgs e)
        {

        }

        private void dataworkinfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataworkinfo.SelectedRows.Count > 0)
            {
                txtID_.Text = dataworkinfo.SelectedRows[0].Cells[0].Value.ToString();
                empworkID.Text = dataworkinfo.SelectedRows[0].Cells[1].Value.ToString();
                cbEmpPayMethod.Text = dataworkinfo.SelectedRows[0].Cells[5].Value.ToString();
                empPosition.Text = dataworkinfo.SelectedRows[0].Cells[6].Value.ToString();
                empDateHire.Value = Convert.ToDateTime(dataworkinfo.SelectedRows[0].Cells[7].Value);
                empDateSeparate.Value = Convert.ToDateTime(dataworkinfo.SelectedRows[0].Cells[8].Value);
                cbEmpWorkStatus.Text = dataworkinfo.SelectedRows[0].Cells[9].Value.ToString();
                empSSS.Text = dataworkinfo.SelectedRows[0].Cells[10].Value.ToString();
                empPAGIBIG.Text = dataworkinfo.SelectedRows[0].Cells[11].Value.ToString();
                empPhilHealth.Text = dataworkinfo.SelectedRows[0].Cells[12].Value.ToString();
                

            }
        }
        private void LoadPersonalInfo()
        {
            dataPersonalInfo.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT Id, EmployeeID, empFname, empLname, empMname, address, civilStatus, sex, contactNum, dateOfBirth, contactPerson FROM empprofiling;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataPersonalInfo.Rows.Add(
                    rdr.GetInt64(0),
                    rdr.GetInt32(1),
                    rdr.GetString(2),
                    rdr.GetString(3),
                    rdr.GetString(4),
                    rdr.GetString(5),
                    rdr.GetString(6),
                    rdr.GetString(7),
                    rdr.GetString(8),
                    rdr.GetDateTime(9),
                    rdr.GetString(10)
                );
            }
            rdr.Close();
            con.Close();
        }
        private void btnLoadPersonalinfo_Click(object sender, EventArgs e)
        {
           


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
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(empFname.Text) ||
                string.IsNullOrEmpty(empLname.Text) ||
                string.IsNullOrEmpty(empMname.Text) ||
                 string.IsNullOrEmpty(emppersonalID_.Text) ||
                string.IsNullOrEmpty(empAddress.Text) ||
                string.IsNullOrEmpty(cbCivilStat.Text) ||
                string.IsNullOrEmpty(empContactNum.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Rmale.Checked && !Rfemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        private void btnEditPinfo_Click(object sender, EventArgs e)
        {

            if (!ValidateInput())
                return;

            if (dataPersonalInfo.Rows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE empprofiling SET EmployeeID = @empPID, empFname = @empFname, empLname = @empLname, empMname = @empMname, " +
                    "address = @address, civilStatus = @civilStatus, sex = @sex, " +
                    "contactNum = @contactNum, dateOfBirth = @dateOfBirth, contactPerson = @contactPerson WHERE Id = @empID;", con);

                cmd.Parameters.AddWithValue("@empPID", emppersonalID_.Text);
                cmd.Parameters.AddWithValue("@empFname", empFname.Text);
                cmd.Parameters.AddWithValue("@empLname", empLname.Text);
                cmd.Parameters.AddWithValue("@empMname", empMname.Text);
                cmd.Parameters.AddWithValue("@address", empAddress.Text);
                cmd.Parameters.AddWithValue("@civilStatus", cbCivilStat.Text);
                cmd.Parameters.AddWithValue("@sex", GetSelectedSex());
                cmd.Parameters.AddWithValue("@contactNum", empContactNum.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", empDOB.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@contactPerson", EmpContactPerson.Text);
                cmd.Parameters.AddWithValue("@empID", empID_.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Details Edited Successfully", "Success");
                LoadPersonalInfo();
                ClearAll();
            }
        }
        

        private void dataPersonalInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataPersonalInfo.SelectedRows.Count > 0)
            {
                empID_.Text = dataPersonalInfo.SelectedRows[0].Cells[0].Value.ToString();
                emppersonalID_.Text = dataPersonalInfo.SelectedRows[0].Cells[1].Value.ToString();
                empFname.Text = dataPersonalInfo.SelectedRows[0].Cells[2].Value.ToString();
                empLname.Text = dataPersonalInfo.SelectedRows[0].Cells[3].Value.ToString();
                empMname.Text = dataPersonalInfo.SelectedRows[0].Cells[4].Value.ToString();
                empAddress.Text = dataPersonalInfo.SelectedRows[0].Cells[5].Value.ToString();
                cbCivilStat.Text = dataPersonalInfo.SelectedRows[0].Cells[6].Value.ToString();
                string sex = dataPersonalInfo.SelectedRows[0].Cells[7].Value.ToString();
                if (sex.Equals("Male", StringComparison.OrdinalIgnoreCase))
                {
                    Rmale.Checked = true;
                }
                else if (sex.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    Rfemale.Checked = true;
                }
                empContactNum.Text = dataPersonalInfo.SelectedRows[0].Cells[8].Value.ToString();
                empDOB.Value = Convert.ToDateTime(dataPersonalInfo.SelectedRows[0].Cells[9].Value);
                EmpContactPerson.Text = dataPersonalInfo.SelectedRows[0].Cells[10].Value.ToString();
            }
        }
        private employeeadd emp;

        private void btnAddwork_Click(object sender, EventArgs e)
        {
            if (emp == null || emp.IsDisposed)
            {
                emp = new employeeadd();
                emp.Show();
            }
            else
            {
                emp.BringToFront();
            }
        }

        private void btnaddPersonal_Click(object sender, EventArgs e)
        {
            if (emp == null || emp.IsDisposed)
            {
                emp = new employeeadd();
                emp.Show();
            }
            else
            {
                emp.BringToFront();
            }
        }

        private void btnSearchWorkinfo_Click(object sender, EventArgs e)
        {

            string searchText = txtworkinfo.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchWorkInfo(searchText);
            }
            else
            {
                workinfoLoad();
            }
        }
        private void SearchWorkInfo(string searchText)
        {
            dataworkinfo.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT ID, EmployeeID, empFname, empLname, empMname, paymentMethod, position, dateHire, dateSeperated, workStatus, SSSnum, pagIbigNum, philHealthNum FROM empprofiling WHERE CONCAT_WS(',', ID, EmployeeID, empFname, empLname, empMname, paymentMethod, position, dateHire, dateSeperated, workStatus, SSSnum, pagIbigNum, philHealthNum) LIKE @searchText;", con);
            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

            Console.WriteLine("Search Text: " + searchText);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataworkinfo.Rows.Add(
                    rdr.GetInt32(0),
                    rdr.GetInt32(1),
                    rdr.GetString(2),
                    rdr.GetString(3),
                    rdr.GetString(4),
                    rdr.GetString(5),
                    rdr.GetString(6),
                    rdr.GetDateTime(7).ToString("yyyy-MM-dd"),
                    rdr.GetDateTime(8).ToString("yyyy-MM-dd"),
                    rdr.GetString(9),
                    rdr.GetString(10),
                    rdr.GetString(11),
                    rdr.GetString(12)
                );
            }

            rdr.Close();
            con.Close();
        }
        private void SearchPersonalInfo(string searchText)
        {
            dataPersonalInfo.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT Id, EmployeeID, empFname, empLname, empMname, address, civilStatus, sex, contactNum, dateOfBirth, contactPerson FROM empprofiling WHERE CONCAT_WS(',', Id, EmployeeID, empFname, empLname, empMname, address, civilStatus, sex, contactNum, dateOfBirth, contactPerson) LIKE @searchText;", con);
            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataPersonalInfo.Rows.Add(
                    rdr.GetInt64(0),
                    rdr.GetInt32(1),
                    rdr.GetString(2),
                    rdr.GetString(3),
                    rdr.GetString(4),
                    rdr.GetString(5),
                    rdr.GetString(6),
                    rdr.GetString(7),
                    rdr.GetString(8),
                    rdr.GetDateTime(9),
                    rdr.GetString(10)
                );
            }
            rdr.Close();
            con.Close();
        }
        private void btnSearchPersonalinfo_Click(object sender, EventArgs e)
        {
            string searchText = txtPersonalInfo.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchPersonalInfo(searchText);
            }
            else
            {
                LoadPersonalInfo();
            }
        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void txtID__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
