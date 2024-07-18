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

namespace best
{
    public partial class truck : Form
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

        public truck()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            data_trucks.SelectionChanged += data_trucks_SelectionChanged;
        }

        private void truck_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void loadTruck()
        {
            data_trucks.Rows.Clear();

            con.Open();
            cmd = new MySqlCommand("SELECT id, plateNum, yearModel, category, Color, RegName, status FROM truck;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                data_trucks.Rows.Add(rdr.GetInt32(0), rdr.GetString(1),
                    rdr.GetString(2), rdr.GetString(3), rdr.GetString(4)
                    , rdr.GetString(5), rdr.GetString(6));

            }
            con.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoad_data_Click(object sender, EventArgs e)
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
        private DateTime GetDueDateFromPlateNumber(string plateNumber)
        {

            if (plateNumber.Length < 2)
                throw new ArgumentException("Plate number must be at least 2 characters long.");

            string lastTwoDigits = plateNumber.Substring(plateNumber.Length - 2);
            int lastDigit = int.Parse(lastTwoDigits.Substring(1, 1));
            int secondLastDigit = int.Parse(lastTwoDigits.Substring(0, 1));


            int month;
            switch (lastDigit)
            {
                case 1: month = 1; break;
                case 2: month = 2; break;
                case 3: month = 3; break;
                case 4: month = 4; break;
                case 5: month = 5; break;
                case 6: month = 6; break;
                case 7: month = 7; break;
                case 8: month = 8; break;
                case 9: month = 9; break;
                case 0: month = 10; break;
                default: throw new InvalidOperationException("Invalid plate number");
            }


            int day;
            if (secondLastDigit >= 1 && secondLastDigit <= 3)
            {
                day = 1;
            }
            else if (secondLastDigit >= 4 && secondLastDigit <= 6)
            {
                day = 8;
            }
            else if (secondLastDigit == 7 || secondLastDigit == 8)
            {
                day = 15;
            }
            else if (secondLastDigit == 9 || secondLastDigit == 0)
            {
                day = 22;
            }
            else
            {
                throw new InvalidOperationException("Invalid plate number");
            }

            int year = DateTime.Now.Year + 1;


            return new DateTime(year, month, day);
        }

        private void btnAddTruck_Click(object sender, EventArgs e)
        {
            addTrucks();
           
            
          
        }
        private void addTrucks()
        {
            DateTime dueDate = GetDueDateFromPlateNumber(txtPlateNum.Text);
            con.Open();
            cmd = new MySqlCommand("INSERT INTO " +
                "truck (plateNum, yearModel, category, Color, RegName,status) " +
                "VALUES (@pnum, @ym, @category, @Color, @RegName, @stat);", con);
            cmd.Parameters.AddWithValue("@pnum", txtPlateNum.Text);
            cmd.Parameters.AddWithValue("@ym", txtYearModel.Text);
            cmd.Parameters.AddWithValue("@category", cbCategory.Text);
            cmd.Parameters.AddWithValue("@Color", txtColor.Text);
            cmd.Parameters.AddWithValue("@RegName", txtRegName.Text);
            cmd.Parameters.AddWithValue("@stat", cbStatus.Text);
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("INSERT INTO ltorenewal (PlateNo,Duedate, Color, Regname) " +
                                   "VALUES (@PlateNo, @Duedate, @Color, @Regname);", con);
            cmd.Parameters.AddWithValue("@PlateNo", txtPlateNum.Text);
            cmd.Parameters.AddWithValue("@Color", txtColor.Text);
            cmd.Parameters.AddWithValue("@Regname", txtRegName.Text);
            cmd.Parameters.AddWithValue("@Duedate", dueDate.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("INSERT INTO insurancerenewal(plateNo)  " +
             "VALUES (@plateNo);", con);
            cmd.Parameters.AddWithValue("@plateNo", txtPlateNum.Text);
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("INSERT INTO ltfrbrenewal(PlateNum)  " +
             "VALUES (@PlateNum);", con);
            cmd.Parameters.AddWithValue("@PlateNum", txtPlateNum.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Truck Added!", "Success");
            loadTruck();
        }
        private void addtoDeliveries_Click(object sender, EventArgs e)
        {

            con.Open();

            cmd = new MySqlCommand("INSERT INTO delivery (PlateNo, Category, Status) " +
                                   "VALUES (@PlateNo, @Category, @Status);", con);
            cmd.Parameters.AddWithValue("@PlateNo", txtPlateNum.Text);
            cmd.Parameters.AddWithValue("@Category", cbCategory.Text);
            cmd.Parameters.AddWithValue("@Status", cbStatus.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Truck Added to Deliveries!", "Success");
            loadTruck();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadTruck();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (data_trucks.SelectedRows.Count > 0)
            {
                DateTime dueDate = GetDueDateFromPlateNumber(txtPlateNum.Text);
                con.Open();

                string oldPlateNum = data_trucks.SelectedRows[0].Cells[1].Value.ToString();

               
                cmd = new MySqlCommand("UPDATE truck SET plateNum = @plateNum, yearModel = @yearModel, category = @category, Color = @Color, RegName = @RegName, status = @status WHERE ID = @id;", con);
                cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@yearModel", txtYearModel.Text);
                cmd.Parameters.AddWithValue("@category", cbCategory.Text);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@RegName", txtRegName.Text);
                cmd.Parameters.AddWithValue("@status", cbStatus.Text);
                cmd.Parameters.AddWithValue("@id", txtTruckID.Text);
                cmd.ExecuteNonQuery();

           
                cmd = new MySqlCommand("UPDATE delivery SET PlateNo = @plateNum, Category = @category WHERE PlateNo = @oldPlateNum;", con);
                cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@category", cbCategory.Text);
                cmd.Parameters.AddWithValue("@oldPlateNum", oldPlateNum);
                cmd.ExecuteNonQuery();

        
                cmd = new MySqlCommand("UPDATE ltfrbrenewal SET PlateNum = @plateNum WHERE PlateNum = @oldPlateNum;", con);
                cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@oldPlateNum", oldPlateNum);
                cmd.ExecuteNonQuery();

              
                cmd = new MySqlCommand("UPDATE ltorenewal SET PlateNo = @plateNum, Duedate = @Duedate, Color = @Color, Regname = @RegName  WHERE PlateNo = @oldPlateNum;", con);
                cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@Duedate", dueDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@RegName", txtRegName.Text);
                cmd.Parameters.AddWithValue("@oldPlateNum", oldPlateNum);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("UPDATE insurancerenewal SET plateNo = @plateNum WHERE plateNo = @oldPlateNum;", con);
                cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                cmd.Parameters.AddWithValue("@oldPlateNum", oldPlateNum);
                cmd.ExecuteNonQuery();

                if (cbStatus.Text == "On Delivery")
                {
                    cmd = new MySqlCommand("UPDATE delivery SET Status = 'On Delivery' WHERE PlateNo = @plateNum;", con);
                    cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (cbStatus.Text == "Under Maintenance")
                {
                    cmd = new MySqlCommand("UPDATE delivery SET Status = 'Under Maintenance' WHERE PlateNo = @plateNum;", con);
                    cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (cbStatus.Text == "Available")
                {
                    cmd = new MySqlCommand("UPDATE delivery SET Status = 'Available' WHERE PlateNo = @plateNum;", con);
                    cmd.Parameters.AddWithValue("@plateNum", txtPlateNum.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Truck details updated successfully");

                con.Close();
                loadTruck();
            }
            else
            {
                MessageBox.Show("Please select a truck to update");
            }
        }









        private void data_trucks_SelectionChanged(object sender, EventArgs e)
        {
            if (data_trucks.SelectedRows.Count > 0)
            {
                txtTruckID.Text = data_trucks.SelectedRows[0].Cells[0].Value.ToString();
                txtPlateNum.Text = data_trucks.SelectedRows[0].Cells[1].Value.ToString();
                txtYearModel.Text = data_trucks.SelectedRows[0].Cells[2].Value.ToString();
                cbCategory.Text = data_trucks.SelectedRows[0].Cells[3].Value.ToString();
                txtColor.Text = data_trucks.SelectedRows[0].Cells[4].Value.ToString();
                txtRegName.Text = data_trucks.SelectedRows[0].Cells[5].Value.ToString();
                cbStatus.Text = data_trucks.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void ClearAll()
        {
            txtPlateNum.Clear();
            txtYearModel.Clear();
        }
            private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        
    }
    
}
