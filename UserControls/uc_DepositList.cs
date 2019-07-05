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


namespace MyMess.UserControls
{
    public partial class uc_DepositList : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;

        public uc_DepositList()
        {
            InitializeComponent();
        }
        
        private void uc_DepositList_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            memberList();
        }

        private void showData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from vw_Deposits", con);
                DataTable table = new DataTable();
                da.Fill(table);
                dgvDepositList.DataSource = table;

                //modify the header text
                dgvDepositList.Columns["DepositID"].HeaderText = "ID";
                dgvDepositList.Columns["FullName"].HeaderText = "Member Name";
                dgvDepositList.Columns["DepositDate"].HeaderText = "Date";
                dgvDepositList.Columns["MemberID"].Visible = false;
                dgvDepositList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void dgvDepostList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DepositsEntry deposits = new DepositsEntry();
            deposits.lblTitle.Text = "Update Deposit Details";
            deposits.txtAmount.Text = this.dgvDepositList.CurrentRow.Cells["Amount"].Value.ToString();
            deposits.txtID.Text = this.dgvDepositList.CurrentRow.Cells["DepositID"].Value.ToString();
            deposits.dtpDepositeDate.Text = this.dgvDepositList.CurrentRow.Cells["DepositDate"].Value.ToString();
            deposits.comBoxMembers.Text = this.dgvDepositList.CurrentRow.Cells["FullName"].Value.ToString();

            deposits.Load -= new System.EventHandler(deposits.DepositsEntry_Load);
            deposits.btnSave.Visible = false;
            deposits.btnUpdate.Visible = true;
            deposits.btnClose.Text = "Cancel";

            deposits.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radByName.Checked)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select * from vw_Deposits where MemberID=@mid", con);
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(comBoxSearch.SelectedValue.ToString()));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dgvDepositList.DataSource = table;

                    //modify the header text
                    dgvDepositList.Columns["DepositID"].HeaderText = "ID";
                    dgvDepositList.Columns["FullName"].HeaderText = "Member Name";
                    dgvDepositList.Columns["DepositDate"].HeaderText = "Date";
                    dgvDepositList.Columns["MemberID"].Visible = false;

                    dgvDepositList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select * from vw_Deposits where DepositDate=@date", con);
                    cmd.Parameters.AddWithValue("@date", dtpSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dgvDepositList.DataSource = table;

                    //modify the header text
                    dgvDepositList.Columns["DepositID"].HeaderText = "ID";
                    dgvDepositList.Columns["FullName"].HeaderText = "Member Name";
                    dgvDepositList.Columns["DepositDate"].HeaderText = "Date";
                    dgvDepositList.Columns["MemberID"].Visible = false;

                    dgvDepositList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
