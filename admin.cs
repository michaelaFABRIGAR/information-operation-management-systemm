using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGUI
{
    public partial class admin : Form
    {
        MySqlConnection con = new MySqlConnection(
         "datasource=localhost;" +
         "port=3306;" +
         "database=jcsdb;" +
         "username=root;" +
         "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            Admin_data();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }
        private void ClearAll()
        {
            txtID.Clear();

            txtName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();


        }
        private void Admin_data()
        {
            dataAdmin.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT ID, Image, Name, username, password, workLevel FROM users ;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                byte[] imageData = (byte[])rdr["Image"];
                Image image = ByteArrayToImage(imageData);
                string name = rdr.GetString(2);
                string username = rdr.GetString(3);
                string password = rdr.GetString(4);
                string workLevel = rdr.GetString(5);

                dataAdmin.Rows.Add(id, image, name, username, password, workLevel);
            }
            con.Close();
        }
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                if (byteArrayIn != null && byteArrayIn.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(byteArrayIn))
                    {
                        Image returnImage = Image.FromStream(ms);
                        return returnImage;
                    }
                }
                else
                {

                    return null;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }
        private void dataAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dataAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataAdmin.SelectedRows[0];

                txtID.Text = selectedRow.Cells[0].Value != null ? selectedRow.Cells[0].Value.ToString() : "";

                Bitmap imageBitmap = (Bitmap)selectedRow.Cells[1].Value;
                showImage.Image = imageBitmap;

                txtName.Text = selectedRow.Cells[2].Value != null ? selectedRow.Cells[2].Value.ToString() : "";
                txtUserName.Text = selectedRow.Cells[3].Value != null ? selectedRow.Cells[3].Value.ToString() : "";
                txtPassword.Text = selectedRow.Cells[4].Value != null ? selectedRow.Cells[4].Value.ToString() : "";
                txtWorkLevel.Text = selectedRow.Cells[5].Value != null ? selectedRow.Cells[5].Value.ToString() : "";
            }
        }

        private void btnsetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    showImage.Image = selectedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                ImageFormat format = image.RawFormat;


                image.Save(ms, format);

                return ms.ToArray();
            }
        }
        private void dataAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataAdmin.Rows[e.RowIndex];
                Bitmap imageBitmap = (Bitmap)selectedRow.Cells[1].Value;
                showImage.Image = imageBitmap;

                txtID.Text = selectedRow.Cells[0].Value?.ToString();
                txtName.Text = selectedRow.Cells[2].Value?.ToString();
                txtUserName.Text = selectedRow.Cells[3].Value?.ToString();
                txtPassword.Text = selectedRow.Cells[4].Value?.ToString();
                txtWorkLevel.Text = selectedRow.Cells[5].Value?.ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("INSERT INTO users(Name, username, password, workLevel) " +
                "VALUES (@Name, @username, @password, @workLevel);", con);

            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@workLevel", txtWorkLevel.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Admin_data();
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataAdmin.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE users SET " +
                   "Name = @Name, " +
                   "username = @Username, " +
                   "password = @password, " +
                   "workLevel = @workLevel " +
                   "WHERE ID = @ID;", con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@workLevel", txtWorkLevel.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                Admin_data();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            if (dataAdmin.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE users SET " +
                   "Image = @Image " +
                   "WHERE ID = @ID;", con);

                if (showImage.Image != null)
                {
                    byte[] imageData = ConvertImageToBytes(showImage.Image);
                    cmd.Parameters.AddWithValue("@Image", imageData);
                }
                else
                {
                    MessageBox.Show("Please upload an image first.");
                    con.Close();
                    return;
                }

                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Image updated successfully.");
                Admin_data();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
    }
}
