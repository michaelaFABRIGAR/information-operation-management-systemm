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
    public partial class deliveries : Form
    {
        MySqlConnection con = new MySqlConnection(
          "datasource=localhost;" +
          "port=3306;" +
          "database=jcsdb;" +
          "username=root;" +
          "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
     
        public deliveries()
        {
            InitializeComponent();
        }
        private bool ValidateDeliveriesInput()
        {
            if (string.IsNullOrWhiteSpace(txtPlate.Text))
            {
                MessageBox.Show("Plate number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDriverName.Text))
            {
                MessageBox.Show("Driver's Name is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Status is required.", "Error");
                return false;
            }

            return true;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
            Delivery_ID();
            Delivery_data();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            PopulateAvailableNames();




            txtDriverName.DropDown += txtDriverName_DropDown;
        }
       
        private void txtDriverName_DropDown(object sender, EventArgs e)
        {
            PopulateAvailableNames();
        }

        private void PopulateAvailableNames()
        {
           txtDriverName.Items.Clear();
            HashSet<string> uniqueNames = new HashSet<string>();

            con.Open();
            cmd = new MySqlCommand("SELECT CONCAT(empLname, ', ', empFname) AS FullName FROM empprofiling;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string fullName = rdr.GetString("FullName");
                if (uniqueNames.Add(fullName))
                {
                    txtDriverName.Items.Add(fullName);
                }
            }
            con.Close();
        }

        


        private void ClearAll()
        {
            txtID.Clear();
          

        }
        private s del;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (del == null || del.IsDisposed)
            {
                del = new s();
                del.Show();
            }
            else
            {
                del.BringToFront();
            }
            

        }
        private operationalform opform;
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            
           if (opform == null || opform.IsDisposed)
           {
               opform = new operationalform();
               opform.Show();
           }
           else
           {
               opform.BringToFront();
           }
          
        }

        private void deliveryData_SelectionChanged(object sender, EventArgs e)
        {
            if (deliveryData.SelectedRows.Count > 0)
            {
                txt_ID.Text = deliveryData.SelectedRows[0].Cells[0].Value.ToString();
                txtPlateNo.Text = deliveryData.SelectedRows[0].Cells[1].Value.ToString();
                PickerLdate.Value = Convert.ToDateTime(deliveryData.SelectedRows[0].Cells[2].Value);
                txtReference.Text = deliveryData.SelectedRows[0].Cells[3].Value.ToString();
                txtAmount.Text = deliveryData.SelectedRows[0].Cells[4].Value.ToString();
                txtLiquidation.Text = deliveryData.SelectedRows[0].Cells[5].Value.ToString();
                txtAdate.Text = deliveryData.SelectedRows[0].Cells[6].Value.ToString();
                txtDestination.Text = deliveryData.SelectedRows[0].Cells[7].Value.ToString();
                txtAmount_.Text = deliveryData.SelectedRows[0].Cells[8].Value.ToString();
                dropMop.Text = deliveryData.SelectedRows[0].Cells[9].Value.ToString();
                dropPd.Text = deliveryData.SelectedRows[0].Cells[10].Value.ToString();
                dropRemarks.Text = deliveryData.SelectedRows[0].Cells[11].Value.ToString();

            }
        }

        private void dataDeliveryId_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDeliveryId.SelectedRows.Count > 0)
            {
                txtID.Text = dataDeliveryId.SelectedRows[0].Cells[0].Value.ToString();
                txtPlate.Text = dataDeliveryId.SelectedRows[0].Cells[1].Value.ToString();
                txtCategory.Text = dataDeliveryId.SelectedRows[0].Cells[2].Value.ToString();
                txtDriverName.Text = dataDeliveryId.SelectedRows[0].Cells[3].Value.ToString();
                txtStatus.Text = dataDeliveryId.SelectedRows[0].Cells[4].Value.ToString();

                

            }
        }

        private void Delivery_ID()
        {
            dataDeliveryId.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, PlateNo , Category, DriversName, Status FROM delivery;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataDeliveryId.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));

            }
            con.Close();
        }
        private void Delivery_data()
        {
            deliveryData.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, PlateNo, LoadingDate, Reference,Amount1, Liquidation," +
                " ArrivalDate, Destination, Amount2, ModOfpay, PayDate, Remarks FROM deliverydata ;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                deliveryData.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                    rdr.GetDateTime(2).ToString("yyyy-MM-dd"), rdr.GetString(3), rdr.GetString(4)
                    , rdr.GetString(5), rdr.GetString(6), rdr.GetString(7)
                    , rdr.GetString(8), rdr.GetString(9), rdr.GetString(10)
                    , rdr.GetString(11));

            }
            con.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateDeliveriesInput()) return;
            con.Open();
            cmd = new MySqlCommand("INSERT INTO delivery (PlateNo, Category, DriversName, Status) " +
                                   "VALUES (@PlateNo, @Category, @DriversName, @Status);", con);
            cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@DriversName", txtDriverName.Text);
            cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("INSERT INTO " +
                "truck (plateNum,category,status) " +
                "VALUES (@pnum, @category, @stat);", con);

            cmd.Parameters.AddWithValue("@pnum", txtPlate.Text);
            cmd.Parameters.AddWithValue("@category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@stat", txtStatus.Text);
            cmd.ExecuteNonQuery();


            if (txtStatus.Text == "On delivery")
            {
                MySqlCommand updateTruckStatusCmd = new MySqlCommand("UPDATE truck SET status = 'On delivery' WHERE plateNum = @PlateNo;", con);
                updateTruckStatusCmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                updateTruckStatusCmd.ExecuteNonQuery();
            }
            else if (txtStatus.Text == "Completed")
            {
                cmd = new MySqlCommand("UPDATE truck SET status = 'Available' WHERE plateNum = @PlateNo;", con);
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.ExecuteNonQuery();
            }
            else if (txtStatus.Text == "Under Maintenance")
            {
                cmd = new MySqlCommand("UPDATE truck SET status = 'Under Maintenance' WHERE plateNum = @PlateNo;", con);
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.ExecuteNonQuery();
            }


            con.Close();
            
            Delivery_ID();
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateDeliveriesInput()) return;
            if (dataDeliveryId.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE delivery SET " +
                   "PlateNo = @PlateNo, " +
                   "Category = @Category, " +
                   "DriversName = @DriversName, " +
                   "Status = @Status " +
                   "WHERE ID = @ID;", con);
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@DriversName", txtDriverName.Text);
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();


                if (txtStatus.Text == "Completed")
                {
                    cmd = new MySqlCommand("UPDATE truck SET status = 'Available' WHERE plateNum = @PlateNo;", con);
                    cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                    cmd.ExecuteNonQuery();
                }

                else if (txtStatus.Text == "On Delivery")
                {
                    cmd = new MySqlCommand("UPDATE truck SET status = 'On delivery' WHERE plateNum = @PlateNo;", con);
                    cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (txtStatus.Text == "Under Maintenance")
                {
                    cmd = new MySqlCommand("UPDATE truck SET status = 'Under Maintenance' WHERE plateNum = @PlateNo;", con);
                    cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Success");
                
                Delivery_ID();
                ClearAll();
            }
            else
            {
                MessageBox.Show("No record selected!");
            }
        }

        private void ToggleDeliveryVisibility()
        {

            gDELIVERIES.Visible = !gDELIVERIES.Visible;
        }
        private void btnEditDeliveries_Click(object sender, EventArgs e)
        {
            ToggleDeliveryVisibility();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataDeliveryId.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM delivery WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtID.Text = string.Empty;
                txtPlate.Text = string.Empty;
                txtCategory.Text = string.Empty;
                txtDriverName.Text = string.Empty;
                txtStatus.Text = string.Empty;
                con.Close();
                MessageBox.Show("Successfully deleted!");
                Delivery_ID();
            }
            else
            {
                MessageBox.Show("FAILED!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
           
            string loadData = txtPlate.Text.Trim();
            if (!string.IsNullOrEmpty(loadData))
            {
                deliveryData.Rows.Clear();
                con.Open();
                cmd = new MySqlCommand("SELECT ID, PlateNo, LoadingDate, Reference, Amount1, Liquidation, " +
                                       "ArrivalDate, Destination, Amount2, ModOfpay, PayDate, Remarks " +
                                       "FROM deliverydata WHERE PlateNo LIKE @loadData;", con);
                cmd.Parameters.AddWithValue("@loadData", "%" + loadData + "%");
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    deliveryData.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                                          rdr.GetDateTime(2).ToString("yyyy-MM-dd"), rdr.GetString(3), rdr.GetString(4),
                                          rdr.GetString(5), rdr.GetString(6), rdr.GetString(7),
                                          rdr.GetString(8), rdr.GetString(9), rdr.GetString(10), rdr.GetString(11));
                }
                con.Close();
            }
            else
            {
                Delivery_data();
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtDname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ToggleDelInfoVisibility()
        {

            bool newVisibilityState = !gDELIVERIES.Visible;


            gDELIVERIES.Visible = newVisibilityState;

            if (newVisibilityState)
            {
                btnClose.Text = "";
            }
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            ToggleDelInfoVisibility();
        }

        private void btnAdate_Click(object sender, EventArgs e)
        {
            if (deliveryData.SelectedRows.Count > 0)
            {
                con.Open();

                int selectedId = Convert.ToInt32(deliveryData.SelectedRows[0].Cells[0].Value);
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");


                cmd = new MySqlCommand("UPDATE deliverydata SET ArrivalDate = @ArrivalDate WHERE ID = @ID;", con);
                cmd.Parameters.AddWithValue("@ArrivalDate", currentDate);
                cmd.Parameters.AddWithValue("@ID", selectedId);
                cmd.ExecuteNonQuery();



                cmd = new MySqlCommand("UPDATE delivery SET " +
                   "Status = @Status " +
                   "WHERE plateNo = @PlateNo;", con);
                cmd.Parameters.AddWithValue("@Status", "Available");
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("UPDATE truck SET " +
                   "status = @Status " +
                   "WHERE plateNum = @PlateNo;", con);
                cmd.Parameters.AddWithValue("@Status", "Available");
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.ExecuteNonQuery();



                con.Close();

                MessageBox.Show("Arrival Date Updated Successfully!", "Success");

                Delivery_data();
            }
            else
            {
                MessageBox.Show("Please select a record to update!", "Error");
            }
        }
        private bool ValidateDeliveryDataInput()
        {
            if (string.IsNullOrWhiteSpace(txtPlateNo.Text))
            {
                MessageBox.Show("Plate number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(PickerLdate.Text))
            {
                MessageBox.Show("Liquidation Date is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtReference.Text))
            {
                MessageBox.Show("Reference is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Amount is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLiquidation.Text))
            {
                MessageBox.Show("Liquidation is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Destination is required.", "Error");
                return false;

            }
            if (string.IsNullOrWhiteSpace(txtAmount_.Text))
            {
                MessageBox.Show("Amount is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(dropMop.Text))
            {
                MessageBox.Show("Mode of Payment is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(dropPd.Text))
            {
                MessageBox.Show("Payment Date is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(dropRemarks.Text))
            {
                MessageBox.Show("Remarks is required.", "Error");
                return false;
            }

            return true;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
             if (!ValidateDeliveryDataInput()) return;
            con.Open();
            cmd = new MySqlCommand("INSERT INTO deliverydata(PlateNo, LoadingDate, Reference, Amount1," +
                " Liquidation, ArrivalDate, Destination, Amount2, ModOfpay, PayDate, Remarks)" +
             "VALUES ( @PlateNo, @LoadingDate, @Reference, @Amount1,@Liquidation,@ArrivalDate,@Destination,@Amount2,@ModOfpay,@PayDate,@Remarks);", con);
            cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
            cmd.Parameters.AddWithValue("@LoadingDate", PickerLdate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Reference", txtReference.Text);
            cmd.Parameters.AddWithValue("@Amount1", txtAmount.Text);
            cmd.Parameters.AddWithValue("@Liquidation", txtLiquidation.Text);
            cmd.Parameters.AddWithValue("@ArrivalDate", "0000-00-00");
            cmd.Parameters.AddWithValue("@Destination", txtDestination.Text);
            cmd.Parameters.AddWithValue("@Amount2", txtAmount_.Text);
            cmd.Parameters.AddWithValue("@ModOfpay", dropMop.Text);
            cmd.Parameters.AddWithValue("@PayDate", dropPd.Text);
            cmd.Parameters.AddWithValue("@Remarks", dropRemarks.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            Delivery_data();
            ClearAll();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!ValidateDeliveryDataInput()) return;
            if (deliveryData.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE deliverydata SET " +
                    "PlateNo = @Plate, " +
                    "LoadingDate = @LoadingDate, " +
                    "Reference = @Reference, " +
                    "Amount1 = @Amount, " +
                    "Liquidation = @Liquidation, " +
                    "ArrivalDate = @Adate, " +
                    "Destination = @Destination, " +
                    "Amount2 = @Amount_, " +
                    "ModOfPay = @Mop, " +
                    "PayDate = @Pd, " +
                    "Remarks = @Remarks " +
                    "WHERE ID = @ID;", con);

                cmd.Parameters.AddWithValue("@Plate", txtPlate.Text);
                cmd.Parameters.AddWithValue("@LoadingDate", PickerLdate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Reference", txtReference.Text);
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@Liquidation", txtLiquidation.Text);
                cmd.Parameters.AddWithValue("@Adate", "0000-00-00");
                cmd.Parameters.AddWithValue("@Destination", txtDestination.Text);
                cmd.Parameters.AddWithValue("@Amount_", txtAmount_.Text);
                cmd.Parameters.AddWithValue("@Mop", dropMop.Text);
                cmd.Parameters.AddWithValue("@Pd", dropPd.Text);
                cmd.Parameters.AddWithValue("@Remarks", dropRemarks.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!", "Success");
                Delivery_data();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please select a record to update!", "Error");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (deliveryData.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM deliverydata WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtID.Text = string.Empty;
                txtPlate.Text = string.Empty;
                PickerLdate.Text = string.Empty;
                txtReference.Text = string.Empty;
                txtAmount.Text = string.Empty;
                txtLiquidation.Text = string.Empty;
                txtAdate.Text = string.Empty;
                txtDestination.Text = string.Empty;
                txtAmount_.Text = string.Empty;
                dropMop.Text = string.Empty;
                dropPd.Text = string.Empty;
                dropRemarks.Text = string.Empty;
                con.Close();
                MessageBox.Show("Successfully deleted!");
                Delivery_data();
            }
            else
            {
                MessageBox.Show("FAILED!!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Delivery_data();
        }

      

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            Delivery_data();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (dataDeliveryId.SelectedRows.Count > 0)
            {
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

             
                con.Open();
                cmd = new MySqlCommand("INSERT INTO deliverydata (PlateNo, LoadingDate, Driver) VALUES (@PlateNo, @LoadingDate, @Driver);", con);
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.Parameters.AddWithValue("@LoadingDate", currentDate);
                cmd.Parameters.AddWithValue("@Driver", txtDriverName.Text);
                cmd.ExecuteNonQuery();
                con.Close();

             
                Delivery_data();
                MessageBox.Show("Delivery data inserted successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a record from Delivery ID to proceed.", "Error");
            }
        }

        
    }
}
