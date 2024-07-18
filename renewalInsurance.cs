using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
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
    public partial class renewalInsurance : Form
    {
        MySqlConnection con = new MySqlConnection(
        "datasource=localhost;" +
        "port=3306;" +
        "database=jcsdb;" +
        "username=root;" +
        "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public renewalInsurance()
        {
            InitializeComponent();
        }
        private void renewalInsurance_Load(object sender, EventArgs e)
        {
            renewalInsurance_data();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }
        private void ClearAll()
        {
            txtID.Clear();
            txtplateNo.Clear();
            txtvehicleUnit.Clear();
      
            txtpolicyNo.Clear();
            txtGross.Clear();
            txtNet.Clear();
            txtDiffer.Clear();
            txtCVno.Clear();
            txtCheckno.Clear();
            txtBank.Clear();
            txtOrNo.Clear();
            txtUpdate.Clear();

        }
        private void renewalInsurance_data()
        {
            dataInsurance.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, plateNo, vehicleUnit, insuranceType,  policyNo, from_, to_, Gross, Net, Difference, cvNo, checkNo, checkDate, Bank, orNo, orDate, Update_ FROM insurancerenewal;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataInsurance.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2),
                rdr.GetString(3), rdr.GetString(4), rdr.IsDBNull(5) ? (object)DBNull.Value : rdr.GetDateTime(5).ToString("yyyy-MM-dd")
                , rdr.IsDBNull(6) ? (object)DBNull.Value : rdr.GetDateTime(6).ToString("yyyy-MM-dd"), rdr.GetString(7), rdr.GetString(8)
                , rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.IsDBNull(12) ? (object)DBNull.Value : rdr.GetDateTime(12).ToString("yyyy-MM-dd")
                , rdr.GetString(13), rdr.GetString(14), rdr.IsDBNull(15) ? (object)DBNull.Value : rdr.GetDateTime(15).ToString("yyyy-MM-dd"), rdr.GetString(16));
            }
            con.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                dataInsurance.Rows.Clear();
                con.Open();
                cmd = new MySqlCommand("SELECT ID, plateNo, vehicleUnit, insuranceType,  policyNo, from_, to_, Gross, Net, Difference, cvNo, checkNo, checkDate, Bank, orNo, orDate, Update_ " +
                                       "FROM insurancerenewal " +
                                       "WHERE CONCAT(ID, plateNo, vehicleUnit, insuranceType,  policyNo, from_, to_, Gross, Net, Difference, cvNo, checkNo, checkDate, Bank, orNo, orDate, Update_) LIKE @searchText;", con);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataInsurance.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2),
                        rdr.GetString(3), rdr.GetString(4), rdr.GetDateTime(5).ToString("yyyy-MM-dd"),
                        rdr.GetDateTime(6).ToString("yyyy-MM-dd"), rdr.GetString(7), rdr.GetString(8),
                        rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.GetDateTime(12).ToString("yyyy-MM-dd"),
                        rdr.GetString(13), rdr.GetString(14), rdr.GetDateTime(15).ToString("yyyy-MM-dd"), rdr.GetString(16));
                }
                con.Close();
            }
            else
            {
                renewalInsurance_data();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshInsuranceStatus();
        }
        private void RefreshInsuranceStatus()
        {
            con.Open();
            cmd = new MySqlCommand("UPDATE insurancerenewal SET Update_ = " +
                                   "CASE " +
                                   "WHEN checkDate = CURDATE() AND orDate = CURDATE() AND from_ <= CURDATE() AND to_ >= CURDATE() THEN 'RENEW/CHECK/OR' " +
                                   "WHEN checkDate = CURDATE() AND from_ <= CURDATE() AND to_ >= CURDATE() THEN 'RENEW/CHECK' " +
                                   "WHEN orDate = CURDATE() AND from_ <= CURDATE() AND to_ >= CURDATE() THEN 'RENEW/OR' " +
                                   "WHEN checkDate = CURDATE() AND orDate = CURDATE() THEN 'OR/CHECK' " +
                                   "WHEN checkDate = CURDATE() THEN 'CHECK' " +
                                   "WHEN orDate = CURDATE()  THEN 'OR' " +
                                   "WHEN from_ <= CURDATE() AND to_ >= CURDATE() THEN 'RENEW' " +
                                   "ELSE 'PENDING' " +
                                   "END;", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update refresh Successfully!");
            renewalInsurance_data();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInsuranceInput()) return;
            DateTime currentDate = DateTime.Now.Date;
            string checkUpdateStatus = (txtCheckdate.Value.Date == currentDate) ? "CHECK" : "PENDING";
            string orUpdateStatus = (txtOrdate.Value.Date == currentDate) ? "OR" : "PENDING";


            bool isRenewalPeriod = (currentDate >= txtFrom.Value.Date && currentDate <= txtTo.Value.Date);

            con.Open();
            cmd = new MySqlCommand("INSERT INTO insurancerenewal(plateNo, vehicleUnit, insuranceType, policyNo, from_, to_, Gross, Net, Difference, cvNo, checkNo, checkDate, Bank, orNo, orDate, Update_)  " +
             "VALUES (@plateNo,@vehicleUnit,@insuranceType,@policyNo,@from_,@to_,@Gross,@Net,@Difference,@cvNo,@checkNo,@checkDate,@Bank,@orNo,@orDate,@Update);", con);
            cmd.Parameters.AddWithValue("@plateNo", txtplateNo.Text);
            cmd.Parameters.AddWithValue("@vehicleUnit", txtvehicleUnit.Text);
            cmd.Parameters.AddWithValue("@insuranceType", txtinsuranceType.Text);
            cmd.Parameters.AddWithValue("@policyNo", txtpolicyNo.Text);
            cmd.Parameters.AddWithValue("@from_", txtFrom.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@to_", txtTo.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Gross", txtGross.Text);
            cmd.Parameters.AddWithValue("@Net", txtNet.Text);
            cmd.Parameters.AddWithValue("@Difference", txtDiffer.Text);
            cmd.Parameters.AddWithValue("@cvNo", txtCVno.Text);
            cmd.Parameters.AddWithValue("@checkNo", txtCheckno.Text);
            cmd.Parameters.AddWithValue("@checkDate", txtCheckdate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Bank", txtBank.Text);
            cmd.Parameters.AddWithValue("@orNo", txtOrNo.Text);
            cmd.Parameters.AddWithValue("@orDate", txtOrdate.Value.ToString("yyyy-MM-dd"));


            string updateStatus = "PENDING";
            if (checkUpdateStatus == "CHECK" && orUpdateStatus == "OR" && isRenewalPeriod)
            {
                updateStatus = "RENEW/CHECK/OR";
            }
            else if (checkUpdateStatus == "CHECK" && orUpdateStatus == "OR")
            {
                updateStatus = "CHECK/OR";
            }
            else if (checkUpdateStatus == "CHECK" && isRenewalPeriod)
            {
                updateStatus = "RENEW/CHECK";
            }
            else if (orUpdateStatus == "OR" && isRenewalPeriod)
            {
                updateStatus = "RENEW/OR";
            }
            else if (checkUpdateStatus == "CHECK")
            {
                updateStatus = "CHECK";
            }
            else if (orUpdateStatus == "OR")
            {
                updateStatus = "OR";
            }
            else if (isRenewalPeriod)
            {
                updateStatus = "RENEW";
            }


            cmd.Parameters.AddWithValue("@Update", updateStatus);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully!");
            renewalInsurance_data();
            ClearAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateInsuranceInput()) return;
            if (dataInsurance.SelectedRows.Count > 0)
            {
                DateTime currentDate = DateTime.Now.Date;
                string checkUpdateStatus = (txtCheckdate.Value.Date == currentDate) ? "CHECK" : "PENDING";
                string orUpdateStatus = (txtOrdate.Value.Date == currentDate) ? "OR" : "PENDING";

                bool isRenewalPeriod = (currentDate >= txtFrom.Value.Date && currentDate <= txtTo.Value.Date);

                con.Open();
                cmd = new MySqlCommand("UPDATE insurancerenewal SET " +
                    "plateNo = @plateNo, " +
                    "vehicleUnit = @vehicleUnit, " +
                    "insuranceType =  @insuranceType, " +
                    "policyNo = @policyNo, " +
                    "from_ = @from_, " +
                    "to_ = @to_, " +
                    "Gross = @Gross, " +
                    "Net = @Net, " +
                    "Difference = @Difference, " +
                    "cvNo = @cvNo, " +
                    "checkNo = @checkNo, " +
                    "checkDate = @checkDate, " +
                    "Bank = @Bank, " +
                    "orNo = @orNo, " +
                    "orDate = @orDate, " +
                    "Update_ = @Update " +
                    "WHERE ID = @ID;", con);
                cmd.Parameters.AddWithValue("@plateNo", txtplateNo.Text);
                cmd.Parameters.AddWithValue("@vehicleUnit", txtvehicleUnit.Text);
                cmd.Parameters.AddWithValue("@insuranceType", txtinsuranceType.Text);
                cmd.Parameters.AddWithValue("@policyNo", txtpolicyNo.Text);
                cmd.Parameters.AddWithValue("@from_", txtFrom.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@to_", txtTo.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gross", txtGross.Text);
                cmd.Parameters.AddWithValue("@Net", txtNet.Text);
                cmd.Parameters.AddWithValue("@Difference", txtDiffer.Text);
                cmd.Parameters.AddWithValue("@cvNo", txtCVno.Text);
                cmd.Parameters.AddWithValue("@checkNo", txtCheckno.Text);
                cmd.Parameters.AddWithValue("@checkDate", txtCheckdate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Bank", txtBank.Text);
                cmd.Parameters.AddWithValue("@orNo", txtOrNo.Text);
                cmd.Parameters.AddWithValue("@orDate", txtOrdate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                string updateStatus = "PENDING";
                if (checkUpdateStatus == "CHECK" && orUpdateStatus == "OR" && isRenewalPeriod)
                {
                    updateStatus = "RENEW/CHECK/OR";
                }
                else if (checkUpdateStatus == "CHECK" && isRenewalPeriod)
                {
                    updateStatus = "RENEW/CHECK";
                }
                else if (orUpdateStatus == "OR" && isRenewalPeriod)
                {
                    updateStatus = "RENEW/OR";
                }
                else if (checkUpdateStatus == "CHECK")
                {
                    updateStatus = "CHECK";
                }
                else if (orUpdateStatus == "OR")
                {
                    updateStatus = "OR";
                }
                else if (isRenewalPeriod)
                {
                    updateStatus = "RENEW";
                }


                cmd.Parameters.AddWithValue("@Update", updateStatus);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!");
                renewalInsurance_data();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please select a record to update!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataInsurance.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM insurancerenewal WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtID.Text = string.Empty;
                txtplateNo.Text = string.Empty;
                txtvehicleUnit.Text = string.Empty;
                txtinsuranceType.Text = string.Empty;
                txtpolicyNo.Text = string.Empty;
                txtFrom.Text = string.Empty;
                txtTo.Text = string.Empty;
                txtGross.Text = string.Empty;
                txtNet.Text = string.Empty;
                txtDiffer.Text = string.Empty;
                txtCVno.Text = string.Empty;
                txtCheckno.Text = string.Empty;
                txtCheckdate.Text = string.Empty;
                txtCheckdate.Text = string.Empty;
                txtOrNo.Text = string.Empty;
                txtOrdate.Text = string.Empty;
                txtUpdate.Text = string.Empty;


                con.Close();
                MessageBox.Show("Successfully deleted!");
                renewalInsurance_data();
            }
            else
            {
                MessageBox.Show("!SELECT A RECORD TO DELETE!");
            }
        }

        private void dataInsurance_SelectionChanged(object sender, EventArgs e)
        {
            if (dataInsurance.SelectedRows.Count > 0)
            {
                txtID.Text = dataInsurance.SelectedRows[0].Cells[0].Value.ToString();
                txtplateNo.Text = dataInsurance.SelectedRows[0].Cells[1].Value.ToString();
                txtvehicleUnit.Text = dataInsurance.SelectedRows[0].Cells[2].Value.ToString();
                txtinsuranceType.Text = dataInsurance.SelectedRows[0].Cells[3].Value.ToString();
                txtpolicyNo.Text = dataInsurance.SelectedRows[0].Cells[4].Value.ToString();
                txtFrom.Value = dataInsurance.SelectedRows[0].Cells[5].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataInsurance.SelectedRows[0].Cells[5].Value);
                txtTo.Value = dataInsurance.SelectedRows[0].Cells[6].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataInsurance.SelectedRows[0].Cells[6].Value);
                txtGross.Text = dataInsurance.SelectedRows[0].Cells[7].Value.ToString();
                txtNet.Text = dataInsurance.SelectedRows[0].Cells[8].Value.ToString();
                txtDiffer.Text = dataInsurance.SelectedRows[0].Cells[9].Value.ToString();
                txtCVno.Text = dataInsurance.SelectedRows[0].Cells[10].Value.ToString();
                txtCheckno.Text = dataInsurance.SelectedRows[0].Cells[11].Value.ToString();
                txtCheckdate.Value = dataInsurance.SelectedRows[0].Cells[12].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataInsurance.SelectedRows[0].Cells[12].Value);
                txtBank.Text = dataInsurance.SelectedRows[0].Cells[13].Value.ToString();
                txtOrNo.Text = dataInsurance.SelectedRows[0].Cells[14].Value.ToString();
                txtOrdate.Value = dataInsurance.SelectedRows[0].Cells[15].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataInsurance.SelectedRows[0].Cells[15].Value);
                txtUpdate.Text = dataInsurance.SelectedRows[0].Cells[16].Value.ToString();
            }
        }
        private bool ValidateInsuranceInput()
        {
            if (string.IsNullOrWhiteSpace(txtplateNo.Text))
            {
                MessageBox.Show("Plate number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtvehicleUnit.Text))
            {
                MessageBox.Show("Vehicle Unit is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtinsuranceType.Text))
            {
                MessageBox.Show("Insurance type is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGross.Text))
            {
                MessageBox.Show("Gross is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNet.Text))
            {
                MessageBox.Show("Net is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiffer.Text))
            {
                MessageBox.Show("Difference is required.", "Error");
                return false;

            }
            if (string.IsNullOrWhiteSpace(txtCheckno.Text))
            {
                MessageBox.Show("Check No. is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBank.Text))
            {
                MessageBox.Show("Bank is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrNo.Text))
            {
                MessageBox.Show("Or Number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCVno.Text))
            {
                MessageBox.Show("CV Number is required.", "Error");
                return false;
            }
            return true;
        }


    }
}
