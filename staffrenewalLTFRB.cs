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
    public partial class staffrenewalLTFRB : Form
    {
        MySqlConnection con = new MySqlConnection(
        "datasource=localhost;" +
        "port=3306;" +
        "database=jcsdb;" +
        "username=root;" +
        "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public staffrenewalLTFRB()
        {
            InitializeComponent();
        }

        private void renewalLTFRB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            renewalLTFRB_data();
        }
        private void ClearAll()
        {
            txtID.Clear();
            txtCaseNum.Clear();
            txtPlateNum.Clear();
            txtUpdate.Clear();

        }
        private bool ValidateLTFRBInput()
        {

            if (string.IsNullOrWhiteSpace(txtCaseNum.Text))
            {
                MessageBox.Show("Case number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDecisionDate.Text))
            {
                MessageBox.Show("Decision Date is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPlateNum.Text))
            {
                MessageBox.Show("PlateNum by field is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtExpiryDate.Text))
            {
                MessageBox.Show("Expiry Date is required.", "Error");
                return false;
            }
         

            return true;
        }
        private void dataLTFRB_SelectionChanged(object sender, EventArgs e)
        {
            if (dataLTFRB.SelectedRows.Count > 0)
            {
                txtID.Text = dataLTFRB.SelectedRows[0].Cells[0].Value.ToString();
                txtCaseNum.Text = dataLTFRB.SelectedRows[0].Cells[1].Value.ToString();
                txtDecisionDate.Value = dataLTFRB.SelectedRows[0].Cells[2].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataLTFRB.SelectedRows[0].Cells[2].Value);
                txtPlateNum.Text = dataLTFRB.SelectedRows[0].Cells[3].Value.ToString();
                txtExpiryDate.Value = dataLTFRB.SelectedRows[0].Cells[4].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataLTFRB.SelectedRows[0].Cells[4].Value);
                txtUpdate.Text = dataLTFRB.SelectedRows[0].Cells[5].Value.ToString();
            }

        }
        private void renewalLTFRB_data()
        {
            dataLTFRB.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, CaseNum, DecisionDate, PlateNum, ExpiryDate, Update_ FROM ltfrbrenewal ;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataLTFRB.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.IsDBNull(2) ? (object)DBNull.Value : rdr.GetDateTime(2).ToString("yyyy-MM-dd"),
                    rdr.GetString(3), rdr.IsDBNull(4) ? (object)DBNull.Value : rdr.GetDateTime(4).ToString("yyyy-MM-dd"), rdr.GetString(5));

            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateLTFRBInput()) return;
            string decUpdateStatus = (txtDecisionDate.Value.Date == DateTime.Now.Date) ? "DECISION_D" : "PENDING";
            string exUpdateStatus = (txtExpiryDate.Value.Date == DateTime.Now.Date) ? "EXPIRY_D" : "PENDING";
            string updateStatus = (decUpdateStatus == "DECISION_D" && exUpdateStatus == "EXPIRY_D") ? "DEC/EX" : (decUpdateStatus == "DECISION_D" ? "DECISION_D" : (exUpdateStatus == "EXPIRY_D" ? "EXPIRY_D" : "PENDING"));
            con.Open();
            cmd = new MySqlCommand("INSERT INTO ltfrbrenewal(CaseNum, DecisionDate, PlateNum, ExpiryDate, Update_)  " +
             "VALUES (@CaseNum, @DecisionDate, @PlateNum, @Expirydate, @Update);", con);
            cmd.Parameters.AddWithValue("@CaseNum", txtCaseNum.Text);
            cmd.Parameters.AddWithValue("@DecisionDate", txtDecisionDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@PlateNum", txtPlateNum.Text);
            cmd.Parameters.AddWithValue("@Expirydate", txtExpiryDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Update", updateStatus);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            renewalLTFRB_data();
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateLTFRBInput()) return;
            if (dataLTFRB.SelectedRows.Count > 0)
            {
                string decUpdateStatus = (txtDecisionDate.Value.Date == DateTime.Now.Date) ? "DECISION_D" : "PENDING";
                string exUpdateStatus = (txtExpiryDate.Value.Date == DateTime.Now.Date) ? "EXPIRY_D" : "PENDING";
                string updateStatus = (decUpdateStatus == "DECISION_D" && exUpdateStatus == "EXPIRY_D") ? "DEC/EX" : (decUpdateStatus == "DECISION_D" ? "DECISION_D" : (exUpdateStatus == "EXPIRY_D" ? "EXPIRY_D" : "PENDING"));
                con.Open();
                cmd = new MySqlCommand("UPDATE ltfrbrenewal SET " +
                    "CaseNum = @CaseNum, " +
                    "DecisionDate = @DecisionDate, " +
                    "PlateNum =  @PlateNum, " +
                    "ExpiryDate = @ExpiryDate, " +
                    "Update_ = @Update " +
                    "WHERE ID = @ID;", con);
                cmd.Parameters.AddWithValue("@CaseNum", txtCaseNum.Text);
                cmd.Parameters.AddWithValue("@DecisionDate", txtDecisionDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@PlateNum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@ExpiryDate", txtExpiryDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Update", updateStatus);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!");
                renewalLTFRB_data();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please select a record to update!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataLTFRB.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM ltfrbrenewal WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtID.Text = string.Empty;
                txtCaseNum.Text = string.Empty;
                txtDecisionDate.Text = string.Empty;
                txtPlateNum.Text = string.Empty;
                txtExpiryDate.Text = string.Empty;
                txtUpdate.Text = string.Empty;


                con.Close();
                MessageBox.Show("Successfully deleted!");
                renewalLTFRB_data();
            }
            else
            {
                MessageBox.Show("!SELECT A RECORD TO DELETE!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }
        private void RefreshStatus()
        {
            con.Open();
            cmd = new MySqlCommand("UPDATE ltfrbrenewal SET Update_ = " +
                                   "CASE " +
                                   "WHEN DecisionDate = CURDATE() AND ExpiryDate = CURDATE() THEN 'DEC/EX' " +
                                   "WHEN DecisionDate = CURDATE() THEN 'DECISION_D' " +
                                   "WHEN ExpiryDate = CURDATE() THEN 'EXPIRY_D' " +
                                   "ELSE 'PENDING' " +
                                   "END;", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update refresh Successfully!");
            renewalLTFRB_data();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                dataLTFRB.Rows.Clear();
                con.Open();
                cmd = new MySqlCommand("SELECT ID, CaseNum, DecisionDate, PlateNum, ExpiryDate, Update_ " +
                                       "FROM ltfrbrenewal " +
                                       "WHERE CONCAT(ID, CaseNum, DecisionDate, PlateNum, ExpiryDate, Update_) LIKE @searchText;", con);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataLTFRB.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetDateTime(2).ToString("yyyy-MM-dd"),
                        rdr.GetString(3), rdr.GetDateTime(4).ToString("yyyy-MM-dd"), rdr.GetString(5));
                }
                con.Close();
            }
            else
            {
                renewalLTFRB_data();
            }
        }
    }
}
