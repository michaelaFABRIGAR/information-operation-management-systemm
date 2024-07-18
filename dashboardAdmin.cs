using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class dashboardAdmin : Form
    {
        MySqlConnection con = new MySqlConnection(
        "datasource=localhost;" +
        "port=3306;" +
        "database=jcsdb;" +
        "username=root;" +
        "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public dashboardAdmin()
        {
            InitializeComponent();
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            data_trucks.AutoGenerateColumns = true;
        }

        private void CustomizeDataGridView()
        {
            // Customize DataGridView appearance and behavior here if needed
        }

        private void dashboardAdmin_Load(object sender, EventArgs e)
        {
            CustomizeDataGridView();
            loadTruck("SELECT ID, plateNum ,category,status FROM truck;");
            renewalLTO_data();
            renewalInsurance_data();
            UpdateRemainingFuelTextBox();
            renewalLTFRB_data();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void renewalLTO_data()
        {
            data_LTO.Rows.Clear();

            DateTime currentDate = DateTime.Now.Date;
            DateTime oneMonthBefore = currentDate.AddMonths(-1);
            DateTime oneMonthAfter = currentDate.AddMonths(1);

            con.Open();
            cmd = new MySqlCommand("SELECT LTO_ID, PlateNo, Duedate, ORdate FROM ltorenewal;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int ltoId = rdr.GetInt32(0);
                string plateNo = rdr.GetString(1);
                DateTime? dueDate = rdr.IsDBNull(2) ? (DateTime?)null : rdr.GetDateTime(2);
                DateTime? orDate = rdr.IsDBNull(3) ? (DateTime?)null : rdr.GetDateTime(3);

                if ((dueDate.HasValue && dueDate.Value >= oneMonthBefore && dueDate.Value <= oneMonthAfter) ||
                    (orDate.HasValue && orDate.Value >= oneMonthBefore && orDate.Value <= oneMonthAfter))
                {
                    data_LTO.Rows.Add(ltoId, plateNo, dueDate?.ToString("yyyy-MM-dd"), orDate?.ToString("yyyy-MM-dd"));
                }
            }
            rdr.Close();
            con.Close();
        }


        private void renewalInsurance_data()
        {
            data_Insurance.Rows.Clear();

            DateTime currentDate = DateTime.Now.Date;
            DateTime oneMonthBefore = currentDate.AddMonths(-1);
            DateTime oneMonthAfter = currentDate.AddMonths(1);

            con.Open();
            cmd = new MySqlCommand("SELECT ID, policyNo, from_, to_, checkDate, orDate FROM insurancerenewal;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                string policyNo = rdr.GetString(1);
                DateTime? fromDate = rdr.IsDBNull(2) ? (DateTime?)null : rdr.GetDateTime(2);
                DateTime? toDate = rdr.IsDBNull(3) ? (DateTime?)null : rdr.GetDateTime(3);
                DateTime? checkDate = rdr.IsDBNull(4) ? (DateTime?)null : rdr.GetDateTime(4);
                DateTime? orDate = rdr.IsDBNull(5) ? (DateTime?)null : rdr.GetDateTime(5);

                if ((checkDate.HasValue && checkDate.Value >= oneMonthBefore && checkDate.Value <= oneMonthAfter) ||
                    (orDate.HasValue && orDate.Value >= oneMonthBefore && orDate.Value <= oneMonthAfter) ||
                    (fromDate.HasValue && toDate.HasValue && fromDate.Value <= currentDate && toDate.Value >= currentDate))
                {
                    data_Insurance.Rows.Add(id, policyNo, fromDate?.ToString("yyyy-MM-dd"), toDate?.ToString("yyyy-MM-dd"), checkDate?.ToString("yyyy-MM-dd"), orDate?.ToString("yyyy-MM-dd"));
                }
            }
            rdr.Close();
            con.Close();
        }


        private void renewalLTFRB_data()
        {
            data_LTFRB.Rows.Clear();

            DateTime currentDate = DateTime.Now.Date;
            DateTime twelveMonthsBefore = currentDate.AddMonths(-12);
            DateTime oneMonthAfter = currentDate.AddMonths(1);

            con.Open();
            cmd = new MySqlCommand("SELECT ID, CaseNum, DecisionDate, ExpiryDate FROM ltfrbrenewal;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                string caseNum = rdr.GetString(1);
                DateTime? decisionDate = rdr.IsDBNull(2) ? (DateTime?)null : rdr.GetDateTime(2);
                DateTime? expiryDate = rdr.IsDBNull(3) ? (DateTime?)null : rdr.GetDateTime(3);

                if ((decisionDate.HasValue && decisionDate.Value >= twelveMonthsBefore && decisionDate.Value <= oneMonthAfter) ||
                    (expiryDate.HasValue && expiryDate.Value >= twelveMonthsBefore && expiryDate.Value <= oneMonthAfter))
                {
                    data_LTFRB.Rows.Add(id, caseNum, decisionDate?.ToString("yyyy-MM-dd"), expiryDate?.ToString("yyyy-MM-dd"));
                }
            }
            rdr.Close();
            con.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            RefreshLTOStatus();
            RefreshLTFRBStatus();
            RefreshInsuranceStatus();
            Check();
            renewalLTO_data();
            UpdateRemainingFuelTextBox();
            renewalInsurance_data();
            renewalLTFRB_data();
        }

        private void Check()
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime oneMonthBefore = currentDate.AddMonths(-1);
            DateTime twelveMonthsBefore = currentDate.AddMonths(-12);
            DateTime oneMonthAfter = currentDate.AddMonths(1);

            List<(DateTime? dueDate, DateTime? orDate)> ltoDates = GetAllDueAndOrDates();
            bool checkLTO = ltoDates.Any(datePair => datePair.dueDate >= oneMonthBefore && datePair.dueDate <= oneMonthAfter ||
                                                      datePair.orDate >= oneMonthBefore && datePair.orDate <= oneMonthAfter);
            txtLTO.Text = checkLTO ? "CHECK LTO" : "NOT YET";

            List<(DateTime? from_, DateTime? to_, DateTime? checkDate, DateTime? orDate)> insuranceDates = GetAllInsuranceDates();
            bool checkInsurance = insuranceDates.Any(datePair => datePair.checkDate >= oneMonthBefore && datePair.checkDate <= oneMonthAfter ||
                                                                  datePair.orDate >= oneMonthBefore && datePair.orDate <= oneMonthAfter ||
                                                                  datePair.from_ <= currentDate && datePair.to_ >= currentDate);
            txtINSURANCE.Text = checkInsurance ? "CHECK INSURANCE" : "NOT YET";

            List<(DateTime? decisionDate, DateTime? expiryDate)> ltfrbDates = GetAllLTFRBDates();
            bool checkLTFRB = ltfrbDates.Any(datePair => datePair.decisionDate >= twelveMonthsBefore && datePair.decisionDate <= oneMonthAfter ||
                                                          datePair.expiryDate >= twelveMonthsBefore && datePair.expiryDate <= oneMonthAfter);
            txtLTFRB.Text = checkLTFRB ? "CHECK LTFRB" : "NOT YET";
        }


        private List<(DateTime? dueDate, DateTime? orDate)> GetAllDueAndOrDates()
        {
            List<(DateTime? dueDate, DateTime? orDate)> datesList = new List<(DateTime? dueDate, DateTime? orDate)>();

            try
            {
                con.Open();
                string query = "SELECT Duedate, ORdate FROM ltorenewal";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DateTime? dueDate = rdr.IsDBNull(0) ? (DateTime?)null : rdr.GetDateTime("Duedate");
                    DateTime? orDate = rdr.IsDBNull(1) ? (DateTime?)null : rdr.GetDateTime("ORdate");
                    datesList.Add((dueDate, orDate));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

            return datesList;
        }



        private List<(DateTime? from_, DateTime? to_, DateTime? checkDate, DateTime? orDate)> GetAllInsuranceDates()
        {
            List<(DateTime? from_, DateTime? to_, DateTime? checkDate, DateTime? orDate)> datesList = new List<(DateTime? from_, DateTime? to_, DateTime? checkDate, DateTime? orDate)>();

            try
            {
                con.Open();
                string query = "SELECT from_, to_, checkDate, orDate FROM insurancerenewal";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DateTime? from_ = rdr.IsDBNull(0) ? (DateTime?)null : rdr.GetDateTime("from_");
                    DateTime? to_ = rdr.IsDBNull(1) ? (DateTime?)null : rdr.GetDateTime("to_");
                    DateTime? checkDate = rdr.IsDBNull(2) ? (DateTime?)null : rdr.GetDateTime("checkDate");
                    DateTime? orDate = rdr.IsDBNull(3) ? (DateTime?)null : rdr.GetDateTime("orDate");
                    datesList.Add((from_, to_, checkDate, orDate));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

            return datesList;
        }

        private List<(DateTime? decisionDate, DateTime? expiryDate)> GetAllLTFRBDates()
        {
            List<(DateTime? decisionDate, DateTime? expiryDate)> datesList = new List<(DateTime? decisionDate, DateTime? expiryDate)>();

            try
            {
                con.Open();
                string query = "SELECT DecisionDate, ExpiryDate FROM ltfrbrenewal";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DateTime? decisionDate = rdr.IsDBNull(0) ? (DateTime?)null : rdr.GetDateTime("DecisionDate");
                    DateTime? expiryDate = rdr.IsDBNull(1) ? (DateTime?)null : rdr.GetDateTime("ExpiryDate");
                    datesList.Add((decisionDate, expiryDate));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

            return datesList;
        }

        private void RefreshLTOStatus()
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
        }

        private void RefreshLTFRBStatus()
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
        }

        private void btnShowLTO_Click(object sender, EventArgs e)
        {
            data_LTO.Visible = !data_LTO.Visible;

            if (data_LTO.Visible)
            {
                btnShowLTO.Text = "Hide";
            }
            else
            {
                btnShowLTO.Text = "Show";
            }
        }

        private void btnShowLTFRB_Click(object sender, EventArgs e)
        {
            data_LTFRB.Visible = !data_LTFRB.Visible;

            if (data_LTFRB.Visible)
            {
                btnShowLTFRB.Text = "Hide";
            }
            else
            {
                btnShowLTFRB.Text = "Show";
            }
        }

        private void btnShowINSURANCE_Click(object sender, EventArgs e)
        {
            data_Insurance.Visible = !data_Insurance.Visible;

            if (data_Insurance.Visible)
            {
                btnShowINSURANCE.Text = "Hide";
            }
            else
            {
                btnShowINSURANCE.Text = "Show";
            }
        }

        private void loadTruck(string query)
        {
            data_trucks.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, plateNum ,category,status FROM truck;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                data_trucks.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                    rdr.GetString(2), rdr.GetString(3));

            }
            con.Close();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cbStatus.SelectedItem?.ToString();
            string query = "SELECT ID, plateNum, category, status FROM truck";

            if (selectedStatus != "Show All Status")
            {
                query += " WHERE status = @status";
            }

            if (selectedStatus == "Available" || selectedStatus == "Under Maintenance")
            {
                query += " ORDER BY plateNum DESC";
            }
            else if (selectedStatus == "On delivery")
            {
                query += " ORDER BY plateNum ASC";
            }

            data_trucks.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand(query, con);
            if (selectedStatus != "Show All Status")
            {
                cmd.Parameters.AddWithValue("@status", selectedStatus);
            }
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                data_trucks.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                    rdr.GetString(2), rdr.GetString(3));
            }
            con.Close();
        }

        private void UpdateRemainingFuelTextBox()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                cmd = new MySqlCommand("SELECT bulkRemainingFuel FROM bulkremainingfuel ORDER BY bulkRemainFuelID DESC LIMIT 1;", con);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    decimal remainingFuel = Convert.ToDecimal(result);
                    txtRemainingFuel.Text = remainingFuel.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating remaining fuel: {ex.Message}", "Error");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void UpdateRemainingFuel(decimal fuelConsumed)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                // Fetch the current remaining fuel
                decimal currentRemainingFuel = 0;
                cmd = new MySqlCommand("SELECT bulkRemainingFuel FROM bulkremainingfuel ORDER BY bulkRemainFuelID DESC LIMIT 1;", con);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    currentRemainingFuel = Convert.ToDecimal(result);
                }

                // Calculate new remaining fuel
                decimal newRemainingFuel = currentRemainingFuel - fuelConsumed;

                // Update the database with new remaining fuel
                cmd = new MySqlCommand("INSERT INTO bulkremainingfuel (bulkRemainingFuel) VALUES (@remainingFuel);", con);
                cmd.Parameters.AddWithValue("@remainingFuel", newRemainingFuel);
                cmd.ExecuteNonQuery();

                // Update the UI with new remaining fuel
                txtRemainingFuel.Text = newRemainingFuel.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating remaining fuel: {ex.Message}", "Error");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            data_trucks.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, plateNum ,category,status FROM truck;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                data_trucks.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                    rdr.GetString(2), rdr.GetString(3));

            }
            con.Close();
        }



        // Ensure to handle other events and methods as per your application's requirements

    }
}
