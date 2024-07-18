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
    public partial class staffbilling : Form
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
        public staffbilling()
        {
            InitializeComponent();
        }

        private void billing_Load(object sender, EventArgs e)
        {
            BillingForm_load();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }
        private void ClearAll()
        {
            txtID.Clear();
            txtbsNum.Clear();
            txtcompanyName.Clear();
            txtTinNum.Clear();
            txtParticulars.Clear();
            txtGross.Clear();
            txtVat.Clear();
            txtNet.Clear();
            txtwithTax.Clear();
            txtamountDue.Clear();
            txtdrNum.Clear();

        }
        private void BillingForm_load()
        {
            dataBilling.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, bsNumber, Date_, companyName, tinNum, particulars, Gross, Vat, Net, withTax, amountDue, drNum, voucherDate FROM billing ;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataBilling.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetDateTime(2).ToString("yyyy-MM-dd"), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5)
                    , rdr.GetDecimal(6), rdr.GetDecimal(7), rdr.GetDecimal(8), rdr.GetDecimal(9), rdr.GetDecimal(10), rdr.GetString(11), rdr.GetDateTime(12).ToString("yyyy-MM-dd"));

            }
            con.Close();
        }
        private void dataBilling_SelectionChanged(object sender, EventArgs e)
        {
            if (dataBilling.SelectedRows.Count > 0)
            {

                txtID.Text = dataBilling.SelectedRows[0].Cells[0].Value.ToString();
                txtbsNum.Text = dataBilling.SelectedRows[0].Cells[1].Value.ToString();
                txtDate.Value = Convert.ToDateTime(dataBilling.SelectedRows[0].Cells[2].Value);
                txtcompanyName.Text = dataBilling.SelectedRows[0].Cells[3].Value.ToString();
                txtTinNum.Text = dataBilling.SelectedRows[0].Cells[4].Value.ToString();
                txtParticulars.Text = dataBilling.SelectedRows[0].Cells[5].Value.ToString();
                txtGross.Text = dataBilling.SelectedRows[0].Cells[6].Value.ToString();
                txtVat.Text = dataBilling.SelectedRows[0].Cells[7].Value.ToString();
                txtNet.Text = dataBilling.SelectedRows[0].Cells[8].Value.ToString();
                txtwithTax.Text = dataBilling.SelectedRows[0].Cells[9].Value.ToString();
                txtamountDue.Text = dataBilling.SelectedRows[0].Cells[10].Value.ToString();
                txtdrNum.Text = dataBilling.SelectedRows[0].Cells[11].Value.ToString();
                txtVdate.Value = Convert.ToDateTime(dataBilling.SelectedRows[0].Cells[12].Value);




            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateBillingInput()) return;
            decimal gross, vat, net, withTax, amountDue;
            decimal.TryParse(txtGross.Text, out gross);
            
                net = gross / 1.12m;
                vat = gross - net;
                withTax = net * 0.02m;
                amountDue = gross - withTax;

                txtNet.Text = net.ToString("N");
                txtVat.Text = vat.ToString("N");
                txtwithTax.Text = withTax.ToString("N");
                txtamountDue.Text = amountDue.ToString("N");

            con.Open();
            cmd = new MySqlCommand("INSERT INTO billing (bsNumber, Date_, companyName, tinNum, particulars, Gross, Vat, Net, withTax, amountDue, drNum, voucherDate) " +
                "VALUES (@bsNumber, @Date_, @companyName, @tinNum, @particulars, @Gross, @Vat, @Net, @withTax, @amountDue, @drNum, @voucherDate);", con);

            cmd.Parameters.AddWithValue("@bsNumber", txtbsNum.Text);
            cmd.Parameters.AddWithValue("@Date_", txtDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@companyName", txtcompanyName.Text);
            cmd.Parameters.AddWithValue("@tinNum", txtTinNum.Text);
            cmd.Parameters.AddWithValue("@particulars", txtParticulars.Text);
            cmd.Parameters.AddWithValue("@Gross", gross);
            cmd.Parameters.AddWithValue("@Vat", vat);
            cmd.Parameters.AddWithValue("@Net", net);
            cmd.Parameters.AddWithValue("@withTax", withTax);
            cmd.Parameters.AddWithValue("@amountDue", amountDue);
            cmd.Parameters.AddWithValue("@drNum", txtdrNum.Text);
            cmd.Parameters.AddWithValue("@voucherDate", txtVdate.Value.ToString("yyyy-MM-dd"));

            cmd.ExecuteNonQuery();
            con.Close();
            BillingForm_load();
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!ValidateBillingInput()) return;
            decimal gross, vat, net, withTax, amountDue;
            decimal.TryParse(txtGross.Text, out gross);
                net = gross / 1.12m;
                vat = gross - net;
                withTax = net * 0.02m;
                amountDue = gross - withTax;

                txtNet.Text = net.ToString("N");
                txtVat.Text = vat.ToString("N");
                txtwithTax.Text = withTax.ToString("N");
                txtamountDue.Text = amountDue.ToString("N");

                con.Open();
                var cmd = new MySqlCommand("UPDATE billing SET " +
                    "bsNumber = @bsNumber, " +
                    "Date_ = @Date_, " +
                    "companyName = @companyName, " +
                    "tinNum = @tinNum, " +
                    "particulars = @particulars, " +
                    "Gross = @Gross, " +
                    "Vat = @Vat, " +
                    "Net = @Net, " +
                    "withTax = @withTax, " +
                    "amountDue = @amountDue, " +
                    "drNum = @drNum, " +
                    "voucherDate = @voucherDate " +
                    "WHERE ID = @ID;", con);

                cmd.Parameters.AddWithValue("@bsNumber", txtbsNum.Text);
                cmd.Parameters.AddWithValue("@Date_", txtDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@companyName", txtcompanyName.Text);
                cmd.Parameters.AddWithValue("@tinNum", txtTinNum.Text);
                cmd.Parameters.AddWithValue("@particulars", txtParticulars.Text);
                cmd.Parameters.AddWithValue("@Gross", gross);
                cmd.Parameters.AddWithValue("@Vat", vat);
                cmd.Parameters.AddWithValue("@Net", net);
                cmd.Parameters.AddWithValue("@withTax", withTax);
                cmd.Parameters.AddWithValue("@amountDue", amountDue);
                cmd.Parameters.AddWithValue("@drNum", txtdrNum.Text);
                cmd.Parameters.AddWithValue("@voucherDate", txtVdate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            

            MessageBox.Show("Record Updated Successfully!", "Success");
            BillingForm_load();
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataBilling.SelectedRows.Count > 0)
            {
                con.Open();
                int selectedId = Convert.ToInt32(txtID.Text);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM billing WHERE ID = @selectedId", con);
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                txtID.Text = string.Empty;
                txtbsNum.Text = string.Empty;
                txtDate.Text = string.Empty;
                txtcompanyName.Text = string.Empty;
                txtTinNum.Text = string.Empty;
                txtParticulars.Text = string.Empty;
                txtGross.Text = string.Empty;
                txtVat.Text = string.Empty;
                txtNet.Text = string.Empty;
                txtwithTax.Text = string.Empty;
                txtamountDue.Text = string.Empty;
                txtdrNum.Text = string.Empty;
                txtVdate.Text = string.Empty;
                con.Close();
                MessageBox.Show("Successfully deleted!");
                BillingForm_load();
            }
            else
            {
                MessageBox.Show("FAILED TO DELETE!!");
            }
        }
        private bool ValidateBillingInput()
        {

            if (string.IsNullOrWhiteSpace(txtbsNum.Text))
            {
                MessageBox.Show("BS number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("Date is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtcompanyName.Text))
            {
                MessageBox.Show("Company by field is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTinNum.Text))
            {
                MessageBox.Show("Tin Number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtParticulars.Text))
            {
                MessageBox.Show("Particulars is required.", "Error");
                return false;
            }
            if (!decimal.TryParse(txtGross.Text, out _))
            {
                MessageBox.Show("Gross must be a valid number.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtdrNum.Text))
            {
                MessageBox.Show("DR number is required.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtVdate.Text))
            {
                MessageBox.Show("Voucher Date is required.", "Error");
                return false;
            }
            return true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    dataBilling.Rows.Clear();
                    con.Open();

                    string query = "SELECT ID, bsNumber, Date_, companyName, tinNum, particulars, Gross, Vat, Net, withTax, amountDue, drNum, voucherDate " +
                                   "FROM billing " +
                                   "WHERE CONCAT(ID, ' ', bsNumber, ' ', Date_, ' ', companyName, ' ', tinNum, ' ', particulars, ' ', Gross, ' ', Vat, ' ', Net, ' ', withTax, ' ', amountDue, ' ', drNum, ' ', voucherDate) " +
                                   "LIKE @searchTerm";

                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        dataBilling.Rows.Add(rdr.GetInt32(0),
                                             rdr.GetString(1),
                                             rdr.GetDateTime(2).ToString("yyyy-MM-dd"),
                                             rdr.GetString(3),
                                             rdr.GetString(4),
                                             rdr.GetString(5),
                                             rdr.GetDecimal(6),
                                             rdr.GetDecimal(7),
                                             rdr.GetDecimal(8),
                                             rdr.GetDecimal(9),
                                             rdr.GetDecimal(10),
                                             rdr.GetString(11),
                                             rdr.GetDateTime(12).ToString("yyyy-MM-dd"));
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    con.Close();
                }
            }
            else
            {

                BillingForm_load();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
