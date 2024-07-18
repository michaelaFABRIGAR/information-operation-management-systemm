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

    public partial class staffrenewalLTO : Form
    {
        MySqlConnection con = new MySqlConnection(
        "datasource=localhost;" +
        "port=3306;" +
        "database=jcsdb;" +
        "username=root;" +
        "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public staffrenewalLTO()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            txtPlate.Clear();
            txtVehicleT.Clear();
            txtColor.Clear();
            txtMRate.Clear();
            txtRegName.Clear();
            txtUpdate.Clear();
            txtORnum.Clear();
        }
        private void renewalLTO_Load(object sender, EventArgs e)
        {
            renewalLTO_data();
        }
        private void renewalLTO_data()
        {
            dataLTOrenew.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT LTO_ID, PlateNo, VehicleType, Color, MVUCrate, Duedate, Regname, ORnum, ORdate, Update_ FROM ltorenewal;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataLTOrenew.Rows.Add(
                    rdr.GetInt32(0),
                    rdr.GetString(1),
                    rdr.GetString(2),
                    rdr.GetString(3),
                    rdr.GetString(4),
                    rdr.IsDBNull(5) ? (object)DBNull.Value : rdr.GetDateTime(5).ToString("yyyy-MM-dd"),
                    rdr.GetString(6),
                    rdr.GetString(7),
                    rdr.IsDBNull(8) ? (object)DBNull.Value : rdr.GetDateTime(8).ToString("yyyy-MM-dd"),
                    rdr.GetString(9)
                );
            }
            con.Close();
        }


        private DateTime GetDueDateFromPlateNumber(string plateNumber)
        {

            if (plateNumber.Length < 2)
                throw new ArgumentException("Plate number must be at least 2 characters long.");

            string lastTwoDigits = plateNumber.Substring(plateNumber.Length - 2);
            int lastDigit = int.Parse(lastTwoDigits.Substring(1, 1));
            int secondLastDigit = int.Parse(lastTwoDigits.Substring(0, 1));


            int month;
            switch (lastDigit)
            {
                case 1: month = 1; break;
                case 2: month = 2; break;
                case 3: month = 3; break;
                case 4: month = 4; break;
                case 5: month = 5; break;
                case 6: month = 6; break;
                case 7: month = 7; break;
                case 8: month = 8; break;
                case 9: month = 9; break;
                case 0: month = 10; break;
                default: throw new InvalidOperationException("Invalid plate number");
            }


            int day;
            if (secondLastDigit >= 1 && secondLastDigit <= 3)
            {
                day = 1;
            }
            else if (secondLastDigit >= 4 && secondLastDigit <= 6)
            {
                day = 8;
            }
            else if (secondLastDigit == 7 || secondLastDigit == 8)
            {
                day = 15;
            }
            else if (secondLastDigit == 9 || secondLastDigit == 0)
            {
                day = 22;
            }
            else
            {
                throw new InvalidOperationException("Invalid plate number");
            }

            int year = DateTime.Now.Year + 1;


            return new DateTime(year, month, day);
        }
        private void dataLTOrenew_SelectionChanged(object sender, EventArgs e)
        {
            if (dataLTOrenew.SelectedRows.Count > 0)
            {
                txtID.Text = dataLTOrenew.SelectedRows[0].Cells[0].Value.ToString();
                txtPlate.Text = dataLTOrenew.SelectedRows[0].Cells[1].Value.ToString();
                txtVehicleT.Text = dataLTOrenew.SelectedRows[0].Cells[2].Value.ToString();
                txtColor.Text = dataLTOrenew.SelectedRows[0].Cells[3].Value.ToString();
                txtMRate.Text = dataLTOrenew.SelectedRows[0].Cells[4].Value.ToString();
                txtDuedate.Value = dataLTOrenew.SelectedRows[0].Cells[5].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataLTOrenew.SelectedRows[0].Cells[5].Value);
                txtRegName.Text = dataLTOrenew.SelectedRows[0].Cells[6].Value.ToString();
                txtORnum.Text = dataLTOrenew.SelectedRows[0].Cells[7].Value.ToString();
                txtORdate.Value = dataLTOrenew.SelectedRows[0].Cells[8].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dataLTOrenew.SelectedRows[0].Cells[8].Value);
                txtUpdate.Text = dataLTOrenew.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

      

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }
        private void RefreshStatus()
        {
            con.Open();
            cmd = new MySqlCommand("UPDATE ltorenewal SET Update_ = " +
                                   "CASE " +
                                   "WHEN Duedate = CURDATE() AND ORdate = CURDATE() THEN 'DUE/OR' " +
                                   "WHEN Duedate = CURDATE() THEN 'DUE' " +
                                   "WHEN ORdate = CURDATE() THEN 'OR' " +
                                   "ELSE 'PENDING' " +
                                   "END;", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Status Updated Successfully!");
            renewalLTO_data();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!ValidateLTOInput()) return;
                DateTime dueDate = GetDueDateFromPlateNumber(txtPlate.Text);

                string dueUpdateStatus = (dueDate.Date == DateTime.Now.Date) ? "DUE" : "PENDING";
                string orUpdateStatus = (txtORdate.Value.Date == DateTime.Now.Date) ? "OR" : "PENDING";

                con.Open();
                cmd = new MySqlCommand("INSERT INTO ltorenewal (PlateNo, VehicleType, Color, MVUCrate, Duedate, Regname, ORnum, ORdate, Update_) " +
                                       "VALUES (@PlateNo, @VehicleType, @Color, @MVUCrate, @Duedate, @Regname, @ORnum, @ORdate, @Update);", con);
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.Parameters.AddWithValue("@VehicleType", txtVehicleT.Text);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@MVUCrate", txtMRate.Text);
                cmd.Parameters.AddWithValue("@Duedate", dueDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Regname", txtRegName.Text);
                cmd.Parameters.AddWithValue("@ORnum", txtORnum.Text);
                cmd.Parameters.AddWithValue("@ORdate", txtORdate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Update", (dueUpdateStatus == "DUE" && orUpdateStatus == "OR") ? "DUE/OR" : (dueUpdateStatus == "DUE" ? "DUE" : (orUpdateStatus == "OR" ? "OR" : "PENDING")));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                renewalLTO_data();
                ClearAll();
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(!ValidateLTOInput()) return;
            if (dataLTOrenew.SelectedRows.Count > 0)
            {
               
                    DateTime dueDate = GetDueDateFromPlateNumber(txtPlate.Text);

                    string dueUpdateStatus = (dueDate.Date == DateTime.Now.Date) ? "DUE" : "PENDING";
                    string orUpdateStatus = (txtORdate.Value.Date == DateTime.Now.Date) ? "OR" : "PENDING";

                    con.Open();
                    cmd = new MySqlCommand("UPDATE ltorenewal SET " +
                                           "PlateNo = @Plate, " +
                                           "VehicleType = @VehicleType, " +
                                           "Color = @Color, " +
                                           "MVUCrate = @MVUCrate, " +
                                           "Duedate = @Duedate, " +
                                           "Regname = @Regname, " +
                                           "ORnum = @ORnum, " +
                                           "ORdate = @ORdate, " +
                                           "Update_ = @Update " +
                                           "WHERE LTO_ID = @ID;", con);
                    cmd.Parameters.AddWithValue("@Plate", txtPlate.Text);
                    cmd.Parameters.AddWithValue("@VehicleType", txtVehicleT.Text);
                    cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@MVUCrate", txtMRate.Text);
                    cmd.Parameters.AddWithValue("@Duedate", dueDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Regname", txtRegName.Text);
                    cmd.Parameters.AddWithValue("@ORnum", txtORnum.Text);
                    cmd.Parameters.AddWithValue("@ORdate", txtORdate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Update", (dueUpdateStatus == "DUE" && orUpdateStatus == "OR") ? "DUE/OR" : (dueUpdateStatus == "DUE" ? "DUE" : (orUpdateStatus == "OR" ? "OR" : "PENDING")));
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully!");
                    renewalLTO_data();
                    ClearAll();
               
            }
            else
            {
                MessageBox.Show("Please select a record to update!");
            }
        }
        private bool ValidateLTOInput()
        {

            if (string.IsNullOrWhiteSpace(txtPlate.Text))
            {
                MessageBox.Show("Plate number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtVehicleT.Text))
            {
                MessageBox.Show("Vehicle Type is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("color is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMRate.Text))
            {
                MessageBox.Show("MVUC rate is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDuedate.Text))
            {
                MessageBox.Show("Due Date is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRegName.Text))
            {
                MessageBox.Show("Registered Name is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtORnum.Text))
            {
                MessageBox.Show("OR number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtORdate.Text))
            {
                MessageBox.Show("Or date is required.", "Error");
                return false;
            }



            return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataLTOrenew.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM ltorenewal WHERE LTO_ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtID.Text = string.Empty;
                txtPlate.Text = string.Empty;
                txtVehicleT.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtMRate.Text = string.Empty;
                txtDuedate.Text = string.Empty;
                txtRegName.Text = string.Empty;
                txtORnum.Text = string.Empty;
                txtORdate.Text = string.Empty;
                txtUpdate.Text = string.Empty;


                con.Close();
                MessageBox.Show("Successfully deleted!");
                renewalLTO_data();
            }
            else
            {
                MessageBox.Show("!SELECT A RECORD TO DELETE!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                dataLTOrenew.Rows.Clear();
                con.Open();
                cmd = new MySqlCommand("SELECT LTO_ID, PlateNo, VehicleType, Color, MVUCrate, Duedate, Regname, ORnum, ORdate, Update_ " +
                                       "FROM ltorenewal " +
                                       "WHERE CONCAT(LTO_ID, PlateNo, VehicleType, Color, MVUCrate, Duedate, Regname, ORnum, ORdate, Update_) LIKE @searchText;", con);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataLTOrenew.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2),
                        rdr.GetString(3), rdr.GetString(4), rdr.GetDateTime(5).ToString("yyyy-MM-dd"),
                        rdr.GetString(6), rdr.GetString(7), rdr.GetDateTime(8).ToString("yyyy-MM-dd"),
                        rdr.GetString(9));
                }
                con.Close();
            }
            else
            {
                renewalLTO_data();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
