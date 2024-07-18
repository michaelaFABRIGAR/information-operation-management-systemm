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
    public partial class staffdeliveryadd : Form
    {
        MySqlConnection con = new MySqlConnection(
        "datasource=localhost;" +
        "port=3306;" +
        "database=jcsdb;" +
        "username=root;" +
        "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public staffdeliveryadd()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            txtReference.Clear();
            txtAmount.Clear();
            txtLiquidation.Clear();
            txtAdate.Clear();
            txtDestination.Clear();
            txtAmount.Clear();
            txtAmount_.Clear();
            dropRemarks.Clear();

        }
        

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deliveryadd_Load(object sender, EventArgs e)
        {
            Delivery_data();
            deliverID_load();
        }
        private void Delivery_data()
        {
            deliveryData.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, PlateNo, LoadingDate, Reference,Amount1, Liquidation," +
                " ArrivalDate, Destination, Amount2, ModOfpay, PayDate, Remarks, Driver FROM deliverydata ;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                deliveryData.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                rdr.GetDateTime(2).ToString("yyyy-MM-dd"), rdr.GetString(3), rdr.GetString(4)
                , rdr.GetString(5), rdr.GetString(6), rdr.GetString(7)
                , rdr.GetString(8), rdr.GetString(9), rdr.GetString(10)
                , rdr.GetString(11), rdr.GetString(12));

            }
            con.Close();
        }
        private void deliverID_load()
        {
            dataDeliveryId.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT PlateNo , DriversName FROM delivery;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataDeliveryId.Rows.Add(rdr.GetString(0), rdr.GetString(1));

            }
            con.Close();
        }
        private void deliveryData_SelectionChanged(object sender, EventArgs e)
        {
            if (deliveryData.SelectedRows.Count > 0)
            {
                txtID.Text = deliveryData.SelectedRows[0].Cells[0].Value.ToString();
                txtPlate.Text = deliveryData.SelectedRows[0].Cells[1].Value.ToString();
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
                txtDriver.Text = deliveryData.SelectedRows[0].Cells[12].Value.ToString();

            }
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
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

        private void txtUpdate_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
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
            if (string.IsNullOrWhiteSpace(txtPlate.Text))
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
        private void dataDeliveryId_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDeliveryId.SelectedRows.Count > 0)
            {

                txtPlate.Text = dataDeliveryId.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
