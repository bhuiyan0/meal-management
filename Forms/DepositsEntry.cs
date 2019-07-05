using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

using System.Data.SqlClient;
using System.Configuration;

namespace MyMess
{
    public partial class DepositsEntry : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;
        public DepositsEntry()
        {
            InitializeComponent();
        }
        public void DepositsEntry_Load(object sender, EventArgs e)
        {
            CurrentID();
            memberList();
            dtpDepositeDate.Text = DateTime.Now.ToShortDateString();

            dtpDepositeDate.MaxDate = System.DateTime.Now;
        }

        private void myLoad(object sender, EventArgs e)
        {
            memberList();
            dtpDepositeDate.MaxDate = System.DateTime.Now;
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
                comBoxMembers.DataSource = dt;
                comBoxMembers.DisplayMember = "FullName";
                comBoxMembers.ValueMember = "MemberID";
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (comBoxMembers.Text!="select" && txtAmount.Text!="" && dtpDepositeDate.Text!="")
                {
                    con.Open();
                    //SqlCommand cmd1 = new SqlCommand("select MemberID from Members where FullName='" + comBoxMembers.Text + "'", con);
                    //int mid = (int)cmd1.ExecuteScalar();

                    string query = "insert into Deposits(DepositDate,Amount,MemberID) values (@date,@amount,@memberid)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date", dtpDepositeDate.Text);
                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@memberid", Convert.ToInt32(comBoxMembers.SelectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposits inserted successfully.");
                    ClearData();

                    //increment the DepositsID and show on Readonly textbox
                    CurrentID();
                }
                else
                {
                    MessageBox.Show("you can't blank any field!");
                }
            }
        }

        private void ClearData()
        {
            txtAmount.Text = "";
            comBoxMembers.Text = "select";
            dtpDepositeDate.Text = DateTime.Today.ToShortDateString();
        }
        private void CurrentID()
        {
            int id ;
            using (SqlConnection con=new SqlConnection (cs))
            {
                con.Open();
                string selectquery = "select max(DepositID) from Deposits";
                SqlCommand cmd = new SqlCommand(selectquery, con);
                string sid = cmd.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(sid)) { id = 0; } else { id = Convert.ToInt32(sid); }
            }
            txtID.Text = (id + 1).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (comBoxMembers.Text != "select" && txtAmount.Text != "" && dtpDepositeDate.Text != "")
                {
                    con.Open();
                    string query = "update Deposits set DepositDate=@date,Amount=@amount,MemberID=@memberid where DepositID=@did";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date", dtpDepositeDate.Text);
                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@memberid", Convert.ToInt32(comBoxMembers.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@did", Convert.ToInt32(txtID.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposits updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("you can't blank any field!");
                }
            }
        }
    }
}
