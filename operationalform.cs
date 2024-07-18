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
    public partial class operationalform : Form
    {
        MySqlConnection con = new MySqlConnection(
          "datasource=localhost;" +
          "port=3306;" +
          "database=jcsdb;" +
          "username=root;" +
          "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        MySqlDataAdapter adapter;
        DataTable table;
        public operationalform()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            txtParts.Clear();
            txtPlate.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtTotalCost.Clear();
            txtID.Clear();
        }
        private void OperationalExpenses_load()
        {
            dataOpEx.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, PlateNo, Parts, Price, Quantity, totalCost FROM operationexpenses ;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataOpEx.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetDecimal(3), rdr.GetDecimal(4), rdr.GetDecimal(5));

            }
            con.Close();
        }
        private void operationalform_Load(object sender, EventArgs e)
        {
            OperationalExpenses_load();

            deliverID_load();
            
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
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataOpEx_SelectionChanged(object sender, EventArgs e)
        {
            if (dataOpEx.SelectedRows.Count > 0)
            {
                txtID.Text = dataOpEx.SelectedRows[0].Cells[0].Value.ToString();
                txtPlate.Text = dataOpEx.SelectedRows[0].Cells[1].Value.ToString();
                txtParts.Text = dataOpEx.SelectedRows[0].Cells[2].Value.ToString();
                txtPrice.Text = dataOpEx.SelectedRows[0].Cells[3].Value.ToString();
                txtQuantity.Text = dataOpEx.SelectedRows[0].Cells[4].Value.ToString();
                txtTotalCost.Text = dataOpEx.SelectedRows[0].Cells[5].Value.ToString();




            }
        }

        private void dataDeliveryId_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDeliveryId.SelectedRows.Count > 0)
            {

                txtPlate.Text = dataDeliveryId.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateOpExInput()) return;
            decimal price, quantity, totalCost;
            if (decimal.TryParse(txtPrice.Text, out price) && decimal.TryParse(txtQuantity.Text, out quantity))
            {
                totalCost = price * quantity;
                con.Open();
                cmd = new MySqlCommand("INSERT INTO operationexpenses (PlateNo, Parts, Price, Quantity, totalCost) " +
                    "VALUES (@PlateNo,@Parts,@Price,@Quantity,@TotalCost);", con);
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.Parameters.AddWithValue("@Parts", txtParts.Text);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@TotalCost", totalCost);

                cmd.ExecuteNonQuery();
                con.Close();
                OperationalExpenses_load();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Invalid price or quantity.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataOpEx.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM operationexpenses WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtID.Text = string.Empty;
                txtPlate.Text = string.Empty;
                txtParts.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                txtTotalCost.Text = string.Empty;
                con.Close();
                MessageBox.Show("Successfully deleted!");
                OperationalExpenses_load();
            }
            else
            {
                MessageBox.Show("FAILED!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!ValidateOpExInput()) return;
            decimal price, quantity, totalCost;
            if (decimal.TryParse(txtPrice.Text, out price) && decimal.TryParse(txtQuantity.Text, out quantity))
            {
                totalCost = price * quantity;
                con.Open();
                cmd = new MySqlCommand("UPDATE operationexpenses SET " +
                   "PlateNo = @PlateNo, " +
                   "Parts = @Parts, " +
                   "Price = @Price, " +
                   "Quantity = @Quantity, " +
                   "totalCost = @TotalCost " +
                   "WHERE ID = @ID;", con);
                cmd.Parameters.AddWithValue("@PlateNo", txtPlate.Text);
                cmd.Parameters.AddWithValue("@Parts", txtParts.Text);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@TotalCost", totalCost);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                OperationalExpenses_load();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Invalid price or quantity.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                dataOpEx.Rows.Clear();
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM operationexpenses WHERE CONCAT_WS(',', ID, PlateNo, Parts, Price, Quantity, totalCost) LIKE @searchText;", con);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataOpEx.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetDecimal(3), rdr.GetDecimal(4), rdr.GetDecimal(5));
                }
                con.Close();
            }
            else
            {
                OperationalExpenses_load();
            }
        }
        private bool ValidateOpExInput()
        {

            if (string.IsNullOrWhiteSpace(txtPlate.Text))
            {
                MessageBox.Show("Plate number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtParts.Text))
            {
                MessageBox.Show("Parts is required.", "Error");
                return false;
            }
            if (!decimal.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Quantity must be a valid number.", "Error");
                return false;
            }
                

            return true;
        }
    }
}
