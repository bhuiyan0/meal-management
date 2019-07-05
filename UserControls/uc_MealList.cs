using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using MyMess.Forms;

namespace MyMess.UserControls
{
    public partial class uc_MealList : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;

        public uc_MealList()
        {
            InitializeComponent();
        }

        private void uc_MealList_Load(object sender, EventArgs e)
        {
            showData();
            memberList();
        }
        private void showData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from vw_Meals", con);
                DataTable table = new DataTable();
                da.Fill(table);
                dgvMeals.DataSource = table;
                //modify the header text
                dgvMeals.Columns["MealID"].HeaderText = "ID";
                dgvMeals.Columns["Quantity"].HeaderText = "Meals Eaten";
                dgvMeals.Columns["FullName"].HeaderText = "Member Name";
                dgvMeals.Columns["MealDate"].HeaderText = "Date";
                dgvMeals.Columns["MemberID"].Visible = false;

                dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvMeals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MealsEntry meals = new MealsEntry();
            meals.lblTitle.Text = "Update Meals Details";
            meals.txtMealsEaten.Text = this.dgvMeals.CurrentRow.Cells["Quantity"].Value.ToString();
            meals.txtID.Text = this.dgvMeals.CurrentRow.Cells["MealID"].Value.ToString();
            meals.dtpMealDate.Text = this.dgvMeals.CurrentRow.Cells["MealDate"].Value.ToString();
            meals.comBoxMembers.Text = this.dgvMeals.CurrentRow.Cells["FullName"].Value.ToString();

            meals.Load -= new EventHandler(meals.MealsEntry_Load);
            meals.Size = new System.Drawing.Size(500, 300);
            meals.dgvMeals.Visible = false;
            meals.chkBreakfast.Visible = false;
            meals.chkDinner.Visible = false;
            meals.chkLunch.Visible = false;
            meals.txtMealsEaten.Visible = true;
            meals.btn.Hide();
            meals.btnUpdate.Visible = true;
            meals.btnCancel.Visible = true;
            meals.lblTitle.Location = new System.Drawing.Point(150, 10);
            meals.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radByName.Checked)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select * from vw_Meals  where MemberID=@mid", con);
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(comBoxSearch.SelectedValue.ToString()));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dgvMeals.DataSource = table;
                    //modify the header text
                    dgvMeals.Columns["MealID"].HeaderText = "ID";
                    dgvMeals.Columns["Quantity"].HeaderText = "Meals Eaten";
                    dgvMeals.Columns["FullName"].HeaderText = "Member Name";
                    dgvMeals.Columns["MealDate"].HeaderText = "Date";
                    dgvMeals.Columns["MemberID"].Visible = false;
                    dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select * from vw_Meals  where MealDate=@date", con);
                    cmd.Parameters.AddWithValue("@date", dtpSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dgvMeals.DataSource = table;
                    //modify the header text
                    dgvMeals.Columns["MealID"].HeaderText = "ID";
                    dgvMeals.Columns["Quantity"].HeaderText = "Meals Eaten";
                    dgvMeals.Columns["FullName"].HeaderText = "Member Name";
                    dgvMeals.Columns["MealDate"].HeaderText = "Date";
                    dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
        }

        private void radByName_CheckedChanged(object sender, EventArgs e)
        {
            if (radByName.Checked)
            {
                comBoxSearch.Visible = true;
                dtpSearch.Visible = false;
            }
            else
            {
                comBoxSearch.Visible = false;
                dtpSearch.Visible = true;

            }

        }
        private void memberList()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "Select * From Members where IsActive=1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comBoxSearch.DataSource = dt;
                comBoxSearch.DisplayMember = "FullName";
                comBoxSearch.ValueMember = "MemberID";
            }
        }

    }
}
