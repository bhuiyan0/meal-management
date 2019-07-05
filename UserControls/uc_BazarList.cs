using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMess.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace MyMess
{
    public partial class uc_BazarList : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;
        public uc_BazarList()
        {
            InitializeComponent();
        }

        private void uc_BazarList_Load_1(object sender, EventArgs e)
        {
            showData();
            memberList();
        }

        private void showData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from vw_Bazars", con);
                DataTable table = new DataTable();
                da.Fill(table);
                dgvBazarList.DataSource = table;

                //modify the header text
                dgvBazarList.Columns["BazarID"].HeaderText = "ID";
                dgvBazarList.Columns["ItemName"].HeaderText = "Item Name";
                dgvBazarList.Columns["FullName"].HeaderText = "Bazar By";
                dgvBazarList.Columns["Cost"].HeaderText = "Amount";
                dgvBazarList.Columns["MemberID"].Visible = false;

                dgvBazarList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }

        }
        private void dgvBazarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BazarEntry bazar = new BazarEntry();
            bazar.lblTitle.Text = "Update Bazar Details";
            bazar.txtItemName.Text = this.dgvBazarList.CurrentRow.Cells["ItemName"].Value.ToString();
            bazar.txtCost.Text = this.dgvBazarList.CurrentRow.Cells["Cost"].Value.ToString();
            bazar.txtQuantity.Text = this.dgvBazarList.CurrentRow.Cells["Quantity"].Value.ToString();
            bazar.comBoxMembers.SelectedText = this.dgvBazarList.CurrentRow.Cells["FullName"].Value.ToString();
            bazar.dtpBazarDate.Text = this.dgvBazarList.CurrentRow.Cells["BazarDate"].Value.ToString();
            bazar.txtID.Text = this.dgvBazarList.CurrentRow.Cells["BazarID"].Value.ToString();

            bazar.ClientSize = new System.Drawing.Size(718, 270);
            bazar.Load -= new System.EventHandler(bazar.BazarEntry_Load);
        

            bazar.comBoxUnit.Visible = false;
            bazar.btnAdd.Visible = false;
            //bazar.btnSave.Hide();
            bazar.btnUpdate.Visible = true;
            bazar.btnCancel.Visible = true;

            bazar.ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radByName.Checked)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select * from vw_Bazars where MemberID=@mid", con);
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(comBoxSearch.SelectedValue.ToString()));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dgvBazarList.DataSource = table;

                    //modify the header text
                    dgvBazarList.Columns["BazarID"].HeaderText = "ID";
                    dgvBazarList.Columns["ItemName"].HeaderText = "Item Name";
                    dgvBazarList.Columns["FullName"].HeaderText = "Bazar By";
                    dgvBazarList.Columns["Cost"].HeaderText = "Amount";
                    dgvBazarList.Columns["MemberID"].Visible = false;

                    dgvBazarList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
            else 
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select * from vw_Bazars where BazarDate=@date", con);
                    //cmd.Parameters.AddWithValue("@name", comBoxSearch.Text);
                    cmd.Parameters.AddWithValue("@date",dtpSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dgvBazarList.DataSource = table;

                    //modify the header text
                    dgvBazarList.Columns["BazarID"].HeaderText = "ID";
                    dgvBazarList.Columns["ItemName"].HeaderText = "Item Name";
                    dgvBazarList.Columns["FullName"].HeaderText = "Bazar By";
                    dgvBazarList.Columns["Cost"].HeaderText = "Amount";
                    dgvBazarList.Columns["MemberID"].Visible = false;

                    dgvBazarList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

