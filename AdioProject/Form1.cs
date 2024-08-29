using AdioProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;

namespace AdioProject
{
    public partial class VehicleManagement : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int intVehId = 0;
        string strPreviousImage = "";
        bool defaultImage = true;
        OpenFileDialog ofd = new OpenFileDialog();
        public VehicleManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadVehicleList();
            Clear();

        }

        private void LoadVehicleList()
        {

           
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewAllVehicles", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["Image"] = File.ReadAllBytes(Application.StartupPath + "\\images\\" + dr["ImagePath"].ToString());

                }
                dgvVehicleList.RowTemplate.Height = 80;
                dgvVehicleList.DataSource = dt;

                ((DataGridViewImageColumn)dgvVehicleList.Columns[dgvVehicleList.Columns.Count
                    - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                dgvVehicleList.AllowUserToAddRows = false;

                sda.Dispose();
            }
        }

        private void LoadCategory()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Category", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow topRow = dt.NewRow();
                topRow[0] = 0;
                topRow[1] = "--Select--";
                dt.Rows.InsertAt(topRow, 0);
                combCatagory.ValueMember = "CategoryId";
                combCatagory.DisplayMember = "CategoryTitle";
                combCatagory.DataSource = dt;
            }
        }

        private void Clear()
        {
            VCode.Text = "";
            VehicleName.Text = "";
            combCatagory.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            radDiesel.Checked = true;
            cheStock.Checked = true;
            intVehId = 0;
            butDelete.Enabled = false;
            btnSave.Text = "Save";
            pictureBoxVehicle.Image = Image.FromFile(Application.StartupPath + "\\images\\5.png");
            defaultImage = true;
            if (dgvProduct.DataSource == null)
            {
                dgvProduct.Rows.Clear();
            }
            else
            {
                dgvProduct.DataSource = (dgvProduct.DataSource as DataTable).Clone();
            }
        }

      

        private void butReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void butBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png,.png)|*.png;*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxVehicle.Image = new Bitmap(ofd.FileName);
                if (intVehId == 0)
                {
                    defaultImage = false;
                    strPreviousImage = "";
                }
            }

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            pictureBoxVehicle.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.jpeg");
            defaultImage = true;
            strPreviousImage = "";
        }

        bool ValidateMasterDetailForm()
        {
            bool isValid = true;
            if (VehicleName.Text.Trim() == "")
            {
                MessageBox.Show("Vehicle name is required");
                isValid = false;
            }
            return isValid;
        }

        string SaveImage(string imgPath)
        {
            string fileName = Path.GetFileNameWithoutExtension(imgPath);
            string ext = Path.GetExtension(imgPath);
            fileName = fileName.Length <= 15 ? fileName : fileName.Substring(0, 15);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + ext;
            pictureBoxVehicle.Image.Save(Application.StartupPath + "\\images\\" + fileName);
            return fileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateMasterDetailForm())
            {
                int intVehId = 0;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("VehicleAddOrEdit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleId", intVehId);
                    cmd.Parameters.AddWithValue("@VehicleCode", VehicleCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@VehicleName", VehicleName.Text.Trim());
                    cmd.Parameters.AddWithValue("@CategoryId", Convert.ToInt16(combCatagory.SelectedValue));
                    cmd.Parameters.AddWithValue("@LaunchDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@IsAvailable", cheStock.Checked ? "True" : "False");
                    cmd.Parameters.AddWithValue("@EngineType", radDiesel.Checked ? "Diesel" : "Electrict");
                    if (defaultImage)
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    }
                    else if (intVehId > 0 && strPreviousImage != "")
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", strPreviousImage);
                        
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", SaveImage(ofd.FileName));
                    }
                    intVehId = Convert.ToInt16(cmd.ExecuteScalar());
                }
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    foreach (DataGridViewRow item in dgvProduct.Rows)
                    {
                        if (item.IsNewRow) break;
                        else
                        {
                            SqlCommand cmd = new SqlCommand("VehModelWithPriceAddAndEdit", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MWPId", Convert.ToInt32(item.Cells["dgvProductId"].Value == DBNull.Value ? "0" : item.Cells["dgvProductId"].Value));
                            cmd.Parameters.AddWithValue("@VehicleId", intVehId);

                            cmd.Parameters.AddWithValue("@ModelName", item.Cells["ModelName"].Value);

                            cmd.Parameters.AddWithValue("@Price", item.Cells["Price"].Value);
                            cmd.ExecuteNonQuery();
                        }

                    }


                }
                LoadVehicleList();
                Clear();
                MessageBox.Show("Submitted Successfully");

            }
        }

      
        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string image = "";
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("ViewVehicleByVehicleId", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@VehicleId", intVehId);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DataRow dr = ds.Tables[0].Rows[0];
                    if (dr["ImagePath"] != DBNull.Value)
                    {
                        image = dr["ImagePath"].ToString();
                        var filename = Application.StartupPath + "\\images\\" + image;
                        if (pictureBoxVehicle.Image != null)
                        {
                            pictureBoxVehicle.Image.Dispose();
                            pictureBoxVehicle.Image = null;
                            System.IO.File.Delete(filename);
                        }

                    }

                    SqlCommand cmd = new SqlCommand("VehicleModelWithPriceDelete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleId", intVehId);
                    sda.Dispose();
                    cmd.ExecuteNonQuery();
                    LoadVehicleList();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }

        }

       

        private void ViewReport_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewAllVehicles", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                List<VehicleViewModels> list = new List<VehicleViewModels>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        VehicleViewModels VehicleVm = new VehicleViewModels();

                        VehicleVm.VehicleId = row["VehicleId"] != DBNull.Value ? Convert.ToInt32(row["VehicleId"]) : 0;
                        VehicleVm.VehicleCode = row["VehicleCode"].ToString();
                        VehicleVm.VehicleName = row["VehicleName"].ToString();

                        // Handling DBNull for LaunchDate
                        if (DateTime.TryParse(row["LaunchDate"].ToString(), out DateTime launchDate))
                            VehicleVm.LaunchDate = launchDate;

                        VehicleVm.EngineType = row["EngineType"].ToString();

                        // Handling DBNull for IsAvailable
                        if (bool.TryParse(row["IsAvailable"].ToString(), out bool isAvailable))
                            VehicleVm.IsAvailable = isAvailable;

                        // Handling DBNull for TotalModelWithPrice
                        VehicleVm.TotalModelWithPrice = row["TotalModelWithPrice"] != DBNull.Value ? Convert.ToInt32(row["TotalModelWithPrice"]) : 0;

                        VehicleVm.CategoryTitle = row["CategoryTitle"].ToString();
                        VehicleVm.ImagePath = Application.StartupPath + "\\images\\" + row["ImagePath"].ToString();

                        list.Add(VehicleVm);
                    }

                    using (VehicleReport report = new VehicleReport(list))
                    {
                        report.ShowDialog();
                    }
                }
                else
                {
                    // Handle case when no data is retrieved from the database
                    MessageBox.Show("No data available to generate report.");
                }


            }
        }

        private void dgvVehicleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehicleList.CurrentRow.Index != -1)
            {
                DataGridViewRow dgvRow = dgvVehicleList.CurrentRow;
                intVehId = Convert.ToInt32(dgvRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("ViewVehicleByVehicleId", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@VehicleId", intVehId);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    //--Master---
                    DataRow dr = ds.Tables[0].Rows[0];
                    VCode.Text = dr["VehicleCode"].ToString();
                    VehicleName.Text = dr["VehicleName"].ToString();
                    combCatagory.SelectedValue = Convert.ToInt32(dr["CategoryId"].ToString());
                    dateTimePicker1.Value = Convert.ToDateTime(dr["LaunchDate"].ToString());
                    if (Convert.ToBoolean(dr["IsAvailable"].ToString()))
                    {
                        cheStock.Checked = true;
                    }
                    else
                    {
                        cheStock.Checked = false;
                    }
                    if ((dr["EngineType"].ToString().Trim()) == "Diesel")
                    {
                        radDiesel.Checked = true;
                    }
                    else
                    {
                        radDiesel.Checked = false;
                    }
                    if ((dr["EngineType"].ToString().Trim()) == "radBattery")
                    {
                        radBattery.Checked = true;
                    }
                    else
                    {
                        radBattery.Checked = false;
                    }
                    if (dr["ImagePath"] == DBNull.Value)
                    {
                        pictureBoxVehicle.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
                    }
                    else
                    {
                        string image = dr["ImagePath"].ToString();
                        pictureBoxVehicle.Image = new Bitmap(dr["ImagePath"].ToString());
                        strPreviousImage = dr["ImagePath"].ToString();
                        defaultImage = false;
                    }

                    //--Details---
                    dgvProduct.AutoGenerateColumns = false;
                    dgvProduct.DataSource = ds.Tables[1];
                    butDelete.Enabled = true;
                    btnSave.Text = "Update";
                    VehicleInfo.SelectedIndex = 0;
                }
            }

        }

        private void dgvProduct_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvProduct.CurrentRow;
            if (dgvRow.Cells["dgvProductId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("ProductDelete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dgvProductId", dgvRow.Cells["dgvProductId"].Value);
                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    e.Cancel = true;
                }
            }

        }
    }
}
