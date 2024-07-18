using best;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGUI
{
    public partial class staffDashboard : Form
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
        private string username;
        private string workLevel;
        private byte[] image;
        public string testVar;
        public staffDashboard(string username, string workLevel, byte[] image)
        {
            InitializeComponent();
            this.username = username;
            this.workLevel = workLevel;
            this.image = image;

            DisplayUserDetails();
        }
        private void DisplayUserDetails()
        {
            lbUsername.Text = username;
            lbWorklevel.Text = workLevel;

            if (image != null)
            {

                using (MemoryStream ms = new MemoryStream(image))
                {
                    showImage.Image = Image.FromStream(ms);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new dashboardStaff());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffdeliveries());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffWaybill());
        }

        public void LoadFormInPanel(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill; 
            pnlContent.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffbilling());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new stafffuelmonitoring());
        }

        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dropContainer.Height += 15;
                if (dropContainer.Height >= 161) 
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                dropContainer.Height -= 15;
                if(dropContainer.Height <= 45) 
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffrenewalLTO());
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffrenewalLTFRB());
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffrenewalInsurance());
        }

        public void testButton(Form abc)
        {
            this.Show();
            LoadFormInPanel(abc);
            if(testVar == "abc")
            {
                this.Visible = false;
            }
        

        }
        
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new stafftruck());
        }
    }
}
