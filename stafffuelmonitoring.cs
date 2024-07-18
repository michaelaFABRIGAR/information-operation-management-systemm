using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace best
{
    public partial class stafffuelmonitoring : Form
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

        public stafffuelmonitoring()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            cbSortBy.SelectedIndexChanged += cbSortBy_SelectedIndexChanged;

            loadFuelBulk();
            loadFuel();
            loadBulkFuelRemaining();
        }

        //Fuel Consumption Section
        public void loadFuel()
        {
            try
            {
             
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string selectedCompany = lblDept.Text;
                string selectedDeptFuel = "SELECT fm.ID, fm.fuel_date, fm.plateNum, fm.department, fm.requestedBy, fm.qty, fb.PricePerLitter, fm.totalFuelAmount " +
                                          "FROM fuelmonitoring fm " +
                                          "JOIN fuelbulk fb ON fm.bulkID = fb.bulkID ";

                if (selectedCompany != "All Companies")
                {
                    selectedDeptFuel += "WHERE fm.department = @selectedCompany ";
                }

                cmd = new MySqlCommand(selectedDeptFuel, con);

                if (selectedCompany != "All Companies")
                {
                    cmd.Parameters.AddWithValue("@selectedCompany", selectedCompany);
                }

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    data_Fuel.Rows.Add(
                        rdr.GetInt32(0), rdr.GetDateTime(1), rdr.GetString(2), rdr.GetString(3),
                        rdr.GetString(4), rdr.GetDecimal(5), rdr.GetDecimal(6), rdr.GetDecimal(7));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading fuel data: {ex.Message}", "Error");
            }
            finally
            {
                if (rdr != null && !rdr.IsClosed)
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            CalculateFuelTotal(); // calculate the total fuel
        }



        //Fuel Bulk Section
        public void loadFuelBulk()
        {
            FuelBulk_Grid.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT bulkID, dateOrdered, amount, PricePerLitter, totalBulkPrice FROM fuelbulk;", con);
            rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                FuelBulk_Grid.Rows.Add(rdr.GetInt32(0), rdr.GetDateTime(1),
                    rdr.GetDecimal(2), rdr.GetDecimal(3), rdr.GetDecimal(4));
            }
            con.Close();
        }

        private void fuelmonitoring_Load(object sender, EventArgs e)
        {
            loadFuel();
            loadBulkFuelRemaining();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }




        public void loadBulkFuelRemaining()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                cmd = new MySqlCommand("SELECT bulkRemainFuelID, bulkRemainingFuel FROM bulkremainingfuel ORDER BY bulkRemainFuelID DESC;", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    data_BulkRemainingFuel.Rows.Add(rdr.GetInt32(0), rdr.GetDecimal(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading remaining fuel: {ex.Message}", "Error");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            // After loading the data into the grid, update the text box with the latest value
            UpdateRemainingFuelTextBox();
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
            // Fetch the current remaining fuel
            decimal currentRemainingFuel = 0;
            if (con.State != ConnectionState.Open)
                con.Open();

            cmd = new MySqlCommand("SELECT bulkRemainingFuel FROM bulkremainingfuel ORDER BY bulkRemainFuelID DESC LIMIT 1;", con);
            currentRemainingFuel = Convert.ToDecimal(cmd.ExecuteScalar());

            // Update the remaining fuel
            decimal newRemainingFuel = currentRemainingFuel - fuelConsumed;

            cmd = new MySqlCommand("INSERT INTO bulkremainingfuel (bulkRemainingFuel) VALUES (@remainingFuel);", con);
            cmd.Parameters.AddWithValue("@remainingFuel", newRemainingFuel);
            cmd.ExecuteNonQuery();

            txtRemainingFuel.Text = newRemainingFuel.ToString();

            con.Close();
        }

        private void UpdateRemainingFuelOnBulkAdd(decimal newBulkFuel)
        {
            //  Fetch the current remaining fuel
            decimal currentRemainingFuel = 0;
            if (con.State != ConnectionState.Open)
                con.Open();

            cmd = new MySqlCommand("SELECT bulkRemainingFuel FROM bulkremainingfuel ORDER BY bulkRemainFuelID DESC LIMIT 1;", con);
            object result = cmd.ExecuteScalar();
            if (result != null)
                currentRemainingFuel = Convert.ToDecimal(result);

            // Update the remaining fuel
            decimal newRemainingFuel = currentRemainingFuel + newBulkFuel;

            cmd = new MySqlCommand("INSERT INTO bulkremainingfuel (bulkRemainingFuel) VALUES (@remainingFuel);", con);
            cmd.Parameters.AddWithValue("@remainingFuel", newRemainingFuel);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        // Call btnBulkADD_Click after adding new bulk


        public void clearAll()
        {
            txtPlateNum.Clear();
            txtRequestedBy.Clear();
            txtQty.Clear();
            txtBulkAmount.Clear();
            txtPricePerLitter.Clear();
            txtTotalBP.Clear();

        }

        // Selection Change
        private void data_Fuel_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Fuel.SelectedRows.Count > 0)
            {
                txtFuelID.Text = data_Fuel.SelectedRows[0].Cells[0].Value.ToString();
                txtFuelDatePicker.Value = Convert.ToDateTime(data_Fuel.SelectedRows[0].Cells[1].Value);
                txtPlateNum.Text = data_Fuel.SelectedRows[0].Cells[2].Value.ToString();

                string department = data_Fuel.SelectedRows[0].Cells[3].Value.ToString();
                int departmentIndex = cbDepartment.FindStringExact(department);

                if (departmentIndex != -1)
                {
                    cbDepartment.SelectedIndex = departmentIndex;
                }
                else
                {
                    cbDepartment.SelectedIndex = -1;
                }

                txtRequestedBy.Text = data_Fuel.SelectedRows[0].Cells[4].Value.ToString();
                txtQty.Text = data_Fuel.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void FuelBulk_Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (FuelBulk_Grid.SelectedRows.Count > 0)
            {
                txtBulkID.Text = FuelBulk_Grid.SelectedRows[0].Cells[0].Value.ToString();
                DTBulk.Value = Convert.ToDateTime(FuelBulk_Grid.SelectedRows[0].Cells[1].Value);
                txtBulkAmount.Text = FuelBulk_Grid.SelectedRows[0].Cells[2].Value.ToString();
                txtPricePerLitter.Text = FuelBulk_Grid.SelectedRows[0].Cells[3].Value.ToString();
                txtTotalBP.Text = FuelBulk_Grid.SelectedRows[0].Cells[4].Value.ToString();
            }

        }

        private void btnFuelAdd_Click(object sender, EventArgs e)
        {
            if (!fuelTrucksValidateInput()) return;

            if (!decimal.TryParse(txtQty.Text, out decimal fuelConsumed))
            {
                MessageBox.Show("Invalid fuel consumption quantity. Please enter a valid number.", "Error");
                return;
            }

            // Call verifyFuelConsumption method to check if fuel consumption is valid
            if (!verifyFuelConsumption(fuelConsumed))
            {
                MessageBox.Show("Fuel consumption is not enough. Please check and try again.", "Error");
                return;
            }

            try
            {
                con.Open();

                // Fetch the latest bulkID
                cmd = new MySqlCommand("SELECT MAX(bulkID) FROM fuelbulk;", con);
                int latestBulkID = Convert.ToInt32(cmd.ExecuteScalar());

                // Check and ensure bulkID is valid
                if (latestBulkID <= 0)
                {
                    throw new Exception("No valid bulk entry found. Please add fuel bulk information first.");
                }

                // Calculate the total fuel amount based on the latest PricePerLitter
                decimal latestPricePerLitter = GetLatestPricePerLitter();
                decimal qty = decimal.Parse(txtQty.Text);
                decimal totalFuelAmount = qty * latestPricePerLitter;

                cmd = new MySqlCommand(
                    "INSERT INTO fuelmonitoring (fuel_date, plateNum, department, requestedBy, qty, bulkID, totalFuelAmount) " +
                    "VALUES (@fdate, @pnum, @dept, @rb, @qty, @bulkID, @totalFuelAmount);", con);

                cmd.Parameters.AddWithValue("@fdate", txtFuelDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@pnum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@dept", cbDepartment.Text);
                cmd.Parameters.AddWithValue("@rb", txtRequestedBy.Text);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@bulkID", latestBulkID);
                cmd.Parameters.AddWithValue("@totalFuelAmount", totalFuelAmount);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    UpdateRemainingFuel(qty);
                    MessageBox.Show("Fuel Consumption Added!", "Success");
                    loadBulkFuelRemaining();
                }
                else
                {
                    MessageBox.Show("Failed to add fuel consumption. No rows were affected.", "Error");
                }

                loadFuelBulk();
                loadFuel();
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
            finally
            {
                con.Close();
            }
        }

        private decimal GetLatestPricePerLitter()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT PricePerLitter FROM fuelbulk ORDER BY bulkID DESC LIMIT 1;", con))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
            }
        }

        private void btnFuelEdit_Click(object sender, EventArgs e)
        {
            if (!fuelTrucksValidateInput()) return;

            if (!decimal.TryParse(txtQty.Text, out decimal fuelConsumed))
            {
                MessageBox.Show("Invalid fuel consumption quantity. Please enter a valid number.", "Error");
                return;
            }

            // Call the verifyFuelConsumption method to check if fuel consumption is valid
            if (!verifyFuelConsumption(fuelConsumed))
            {
                MessageBox.Show("Fuel consumption is not enough. Please check and try again.", "Error");
                return;
            }

            try
            {
                decimal latestPricePerLitter = GetLatestPricePerLitter();
                decimal qty = decimal.Parse(txtQty.Text);
                decimal totalFuelAmount = qty * latestPricePerLitter;

                // Close the connection kung open 
                if (con.State == ConnectionState.Open)
                    con.Close();

                cmd = new MySqlCommand("UPDATE fuelmonitoring SET plateNum = @pnum, department = @dept, fuel_date = @fdate, " +
                    "requestedBy = @rb, qty = @qty, totalFuelAmount = @totalFuelAmount " +
                    "WHERE ID = @id;", con);

                cmd.Parameters.AddWithValue("@fdate", txtFuelDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@pnum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@dept", cbDepartment.Text);
                cmd.Parameters.AddWithValue("@rb", txtRequestedBy.Text);
                cmd.Parameters.AddWithValue("@qty", decimal.Parse(txtQty.Text));
                cmd.Parameters.AddWithValue("@totalFuelAmount", totalFuelAmount);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtFuelID.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                UpdateRemainingFuel(qty);
                con.Close(); // Close the connection after the operation

                MessageBox.Show("Details Edited Successfully", "Success");
                loadFuelBulk();
                loadBulkFuelRemaining();
                loadFuel();
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortCriteria = cbSortBy.SelectedItem.ToString();
            string orderByClause = "";

            switch (selectedSortCriteria)
            {
                case "Justine's Cargo":
                    lblDept.Text = "Justine's Cargo";
                    orderByClause = "ORDER BY totalFuelAmount DESC"; 
                    break;
                case "Justine's Scrap":
                    lblDept.Text = "Justine's Scrap";
                    orderByClause = "ORDER BY totalFuelAmount ASC"; 
                    break;
                case "Bodega 3":
                    lblDept.Text = "Bodega 3";
                    orderByClause = "ORDER BY totalFuelAmount DESC"; 
                    break;
                default:
                    lblDept.Text = "All Companies"; 
                    orderByClause = ""; 
                    break;
            }

            LoadFuelDeptData(orderByClause);
        }

       
    private void LoadFuelDeptData(string orderByClause)
    {
        try
        {
            con.Open();
            string selectedDeptFuel = "SELECT fm.ID, fm.fuel_date, fm.plateNum, fm.department, fm.requestedBy, fm.qty, fb.PricePerLitter, fm.totalFuelAmount " +
                                      "FROM fuelmonitoring fm " +
                                      "JOIN fuelbulk fb ON fm.bulkID = fb.bulkID ";

            if (lblDept.Text != "All Companies")
            {
                selectedDeptFuel += "WHERE fm.department = @selectedCompany ";
            }

            selectedDeptFuel += orderByClause + ";";

            cmd = new MySqlCommand(selectedDeptFuel, con);

            if (lblDept.Text != "All Companies")
            {
                cmd.Parameters.AddWithValue("@selectedCompany", lblDept.Text);
            }

            rdr = cmd.ExecuteReader();
            data_Fuel.Rows.Clear();

            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                DateTime fuelDate = rdr.GetDateTime(1);
                string plateNum = rdr.GetString(2);
                string department = rdr.GetString(3);
                string requestedBy = rdr.GetString(4);
                decimal qty = rdr.GetDecimal(5);
                decimal pricePerLitter = rdr.GetDecimal(6);
                decimal totalFuelAmount = rdr.GetDecimal(7);

                data_Fuel.Rows.Add(id, fuelDate, plateNum, department, requestedBy, qty, pricePerLitter, totalFuelAmount);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading fuel data: {ex.Message}", "Error");
        }
        finally
        {
            if (rdr != null && !rdr.IsClosed)
            {
                rdr.Close();
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        CalculateFuelTotal(); // Call to calculate the total fuel
    }

        //Calculate Total Fuel Cost By deparment
        private void CalculateFuelTotal()
        {
            try
            {
                con.Open();
                string selectedCompany = lblDept.Text;
                string selectedDeptFuel = "SELECT SUM(fm.totalFuelAmount) " +
                                          "FROM fuelmonitoring fm " +
                                          "JOIN fuelbulk fb ON fm.bulkID = fb.bulkID ";

                if (selectedCompany != "All Companies")
                {
                    selectedDeptFuel += "WHERE fm.department = @selectedCompany ";
                }

                cmd = new MySqlCommand(selectedDeptFuel, con);

                if (selectedCompany != "All Companies")
                {
                    cmd.Parameters.AddWithValue("@selectedCompany", selectedCompany);
                }

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    decimal totalFuelAmount = Convert.ToDecimal(result);
                    txtFuelTotal.Text = totalFuelAmount.ToString("N2");
                }
                else
                {
                    txtFuelTotal.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the total fuel: {ex.Message}", "Error");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }







        private void btnBulkADD_Click_1(object sender, EventArgs e)
        {
            if (!fuelBulkValidateInput()) return;
            decimal bulkAmount = decimal.Parse(txtBulkAmount.Text);

            try
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO fuelbulk (dateOrdered, amount, PricePerLitter, totalBulkPrice) " +
                                       "VALUES (@dto, @amount, @ppp, @tbp);", con);

                cmd.Parameters.AddWithValue("@dto", DTBulk.Value.Date);
                cmd.Parameters.AddWithValue("@amount", bulkAmount);
                cmd.Parameters.AddWithValue("@ppp", decimal.Parse(txtPricePerLitter.Text));
                cmd.Parameters.AddWithValue("@tbp", decimal.Parse(txtTotalBP.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Fuel Bulk Information Added!", "Success");
                loadFuelBulk();
                loadBulkFuelRemaining();
                UpdateRemainingFuelOnBulkAdd(bulkAmount);
                loadFuel();
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }




        private void btnBulkEdit_Click(object sender, EventArgs e)
        {
            if (!fuelBulkValidateInput()) return;
            decimal bulkAmount = decimal.Parse(txtBulkAmount.Text);
            UpdateRemainingFuelOnBulkAdd(bulkAmount);

            con.Open();
            cmd = new MySqlCommand("UPDATE fuelbulk SET dateOrdered = @dto, amount = @amount, PricePerLitter = @ppp, totalBulkPrice = @tbp " +
                "WHERE bulkID = @id;", con);

            cmd.Parameters.AddWithValue("@dto", DTBulk.Value.Date);
            cmd.Parameters.AddWithValue("@amount", decimal.Parse(txtBulkAmount.Text));
            cmd.Parameters.AddWithValue("@ppp", decimal.Parse(txtPricePerLitter.Text));
            cmd.Parameters.AddWithValue("@tbp", decimal.Parse(txtTotalBP.Text));
            cmd.Parameters.AddWithValue("@id", int.Parse(txtBulkID.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Fuel Bulk Information Edited!", "Success");
            loadFuelBulk();
            UpdateRemainingFuelOnBulkAdd(bulkAmount);
            loadBulkFuelRemaining();
            loadFuel();
        }
        private bool fuelTrucksValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPlateNum.Text))
            {
                MessageBox.Show("Plate number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbDepartment.Text))
            {
                MessageBox.Show("Department is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRequestedBy.Text))
            {
                MessageBox.Show("Requested by field is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Quantity is required.", "Error");
                return false;
            }
            if (!decimal.TryParse(txtQty.Text, out _))
            {
                MessageBox.Show("Quantity must be a valid number.", "Error");
                return false;
            }


            return true;
        }

        private bool fuelBulkValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBulkAmount.Text))
            {
                MessageBox.Show("Amount is required.", "Error");
                return false;
            }
            if (!decimal.TryParse(txtBulkAmount.Text, out _))
            {
                MessageBox.Show("Amount must be a valid number.", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPricePerLitter.Text))
            {
                MessageBox.Show("Price Per Litter is required.", "Error");
                return false;
            }
            if (!decimal.TryParse(txtPricePerLitter.Text, out _))
            {
                MessageBox.Show("Price Per Litter must be a valid number.", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTotalBP.Text))
            {
                MessageBox.Show("Total bulk price is required.", "Error");
                return false;
            }
            if (!decimal.TryParse(txtTotalBP.Text, out _))
            {
                MessageBox.Show("Total bulk price must be a valid number.", "Error");
                return false;
            }
            return true;
        }

        //Validate Fuel consumption
        private bool verifyFuelConsumption(decimal fuelConsumed)
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
                    if (remainingFuel >= fuelConsumed)
                    {
                        // There's enough remaining fuel
                        return true;
                    }
                    else
                    {
                        // Not enough remaining fuel
                        MessageBox.Show("Fuel not enough. Please refill before adding fuel consumption.", "Error");
                        return false;
                    }
                }
                else
                {
                    // No data found for remaining fuel
                    MessageBox.Show("No remaining fuel data found.", "Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking remaining fuel: {ex.Message}", "Error");
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}