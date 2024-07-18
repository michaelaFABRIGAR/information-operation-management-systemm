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
    public partial class waybill : Form
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
        public waybill()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            txtID.Clear();
            txtDname.Clear();
            txtWnum.Clear();

        }
        private void waybill_Load(object sender, EventArgs e)
        {
            waybill_loader();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void waybill_loader()
        {
            con.Open();
            cmd = new MySqlCommand("SELECT ID, driverName, waybillNum, status FROM waybill;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataWaybill.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));

            }
            con.Close();
        }
        private void dataWaybill_SelectionChanged(object sender, EventArgs e)
        {
            if (dataWaybill.SelectedRows.Count > 0)
            {

                txtID.Text = dataWaybill.SelectedRows[0].Cells[0].Value.ToString();
                txtDname.Text = dataWaybill.SelectedRows[0].Cells[1].Value.ToString();
                txtWnum.Text = dataWaybill.SelectedRows[0].Cells[2].Value.ToString();
                txtStatus.Text = dataWaybill.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private bool ValidateWaybillInput()
        {

            if (string.IsNullOrWhiteSpace(txtDname.Text))
            {
                MessageBox.Show("Driver's Name is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtWnum.Text))
            {
                MessageBox.Show("Waybill Number is required.", "Error");
                return false;
            }
            

            return true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateWaybillInput()) return;
            con.Open();
            cmd = new MySqlCommand("INSERT INTO waybill (driverName, waybillNum) " +
                "VALUES (@driverName, @waybillNum);", con);
            cmd.Parameters.AddWithValue("@driverName", txtDname.Text);
            cmd.Parameters.AddWithValue("@waybillNum", txtWnum.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dataWaybill.Rows.Clear();
            waybill_loader();
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateWaybillInput()) return;
            if (dataWaybill.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE waybill SET " +
                   "driverName = @driverName, " +
                   "waybillNum = @waybillNum " +
                   "WHERE ID = @ID;", con);
                cmd.Parameters.AddWithValue("@driverName", txtDname.Text);
                cmd.Parameters.AddWithValue("@waybillNum", txtWnum.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                dataWaybill.Rows.Clear();
                waybill_loader();
                ClearAll();
            }
            else
            {
                MessageBox.Show("!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataWaybill.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM waybill WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtID.Text = string.Empty;
                txtDname.Text = string.Empty;
                txtWnum.Text = string.Empty;

                con.Close();
                MessageBox.Show("Successfully deleted!");
                dataWaybill.Rows.Clear();
                waybill_loader();
            }
            else
            {
                MessageBox.Show("FAILED TO DELETE!");
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (dataWaybill.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("UPDATE waybill SET status = 'USED' WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Waybill marked as USED successfully!");
                dataWaybill.Rows.Clear();
                waybill_loader();
            }
            else
            {
                MessageBox.Show("Please select a waybill.");
            }
        }

        private void btnNotUse_Click(object sender, EventArgs e)
        {
            if (dataWaybill.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("UPDATE waybill SET status = 'NOT USED' WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Waybill marked as NOT USED successfully!");
                dataWaybill.Rows.Clear();
                waybill_loader();
            }
            else
            {
                MessageBox.Show("Please select a waybill.");
            }
        }
    }
}
