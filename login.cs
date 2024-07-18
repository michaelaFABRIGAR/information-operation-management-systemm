using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace FinalGUI
{
    public partial class login : Form
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
        public login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginInput()) return;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var userDetails = GetUserDetails(username, password);

            if (userDetails.Item2 == "Admin")
            {
                this.Hide();
                Dashboard Dashboard = new Dashboard(userDetails.Item1, userDetails.Item2, userDetails.Item3);
                Dashboard.Show();
            }
            else if (userDetails.Item2 == "Staff")
            {
                this.Hide();
                staffDashboard staffDashboard = new staffDashboard(userDetails.Item1, userDetails.Item2, userDetails.Item3);
                staffDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateLoginInput()
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is Empty.", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is empty.", "Error");
                return false;
            }
           

            return true;
        }

        private (string, string, byte[]) GetUserDetails(string username, string password)
        {
            try
            {
                con.Open();
                string query = "SELECT username, workLevel, Image FROM users WHERE BINARY username = @username AND BINARY password = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string retrievedUsername = rdr["username"].ToString();
                    string workLevel = rdr["workLevel"].ToString();
                    byte[] image = (byte[])rdr["Image"];
                    return (retrievedUsername, workLevel, image);
                }
                else
                {
                    return (null, null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null, null);
            }
            finally
            {
                con.Close();
            }
        }
      

        private void login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !btnCheckBox.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
