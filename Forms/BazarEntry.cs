using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace MyMess
{
    public partial class BazarEntry : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;
        public BazarEntry()
        {
            InitializeComponent();
        }

        public void BazarEntry_Load(object sender, EventArgs e)
        {
            currentID();
            memberList();
            dtpBazarDate.Text = System.DateTime.Now.ToShortDateString();
            dtpBazarDate.MaxDate = System.DateTime.Now;
        }
        public void myLoad(object sender, EventArgs e)
        {
            memberList();
            comBoxMembers.Text = "select";
            dtpBazarDate.MaxDate = System.DateTime.Now;
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
        private void currentID()
        {
            int id;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string selectquery = "select max(BazarID) from Bazar";
                SqlCommand cmd = new SqlCommand(selectquery, con);
                string sid = cmd.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(sid)) { id = 0; } else { id = Convert.ToInt32(sid); }
            }
            txtID.Text = (id + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add to the gridview 
            if (dtpBazarDate.Text != "" && txtItemName.Text != "" && txtQuantity.Text != "" && txtCost.Text != "" && comBoxMembers.Text != "select")
            {
                int n = dgvAddBazar.Rows.Add();
                dgvAddBazar.Rows[n].Cells[0].Value = dtpBazarDate.Text;
                dgvAddBazar.Rows[n].Cells[1].Value = txtItemName.Text;
                dgvAddBazar.Rows[n].Cells[2].Value = txtQuantity.Text + comBoxUnit.Text;
                dgvAddBazar.Rows[n].Cells[3].Value = txtCost.Text;
                dgvAddBazar.Rows[n].Cells[4].Value = comBoxMembers.Text;

                //increment the BazarID textbox
                int preid = Convert.ToInt32(txtID.Text);
                string currenttid = (preid + 1).ToString();
                txtID.Text = currenttid;

                txtCost.Clear();
                txtItemName.Clear();
                txtQuantity.Clear();
                comBoxMembers.Text = "select";
                comBoxUnit.Text = "select";
            }
            else
            {
                MessageBox.Show("you cant black any field");
            }
        }


        //insert data form datagridview by loop
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                for (int i = 0; i < dgvAddBazar.RowCount - 1; i++)
                {
                    string memberName = dgvAddBazar.Rows[i].Cells[4].Value.ToString();
                    SqlCommand cmd1 = new SqlCommand("select MemberID from Members where FullName='" + memberName + "'", con);
                    int mid = (int)cmd1.ExecuteScalar();

                    string query = "insert into Bazar (BazarDate,ItemName,Quantity,Cost,MemberID) values (@date,@item,@qty,@cost,@member)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date", dgvAddBazar.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@item", dgvAddBazar.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@qty", dgvAddBazar.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToInt32(dgvAddBazar.Rows[i].Cells[3].Value));
                    cmd.Parameters.AddWithValue("@member", mid);
                    cmd.ExecuteNonQuery();
                }
                dgvAddBazar.Rows.Clear();
            }
            MessageBox.Show("Bazar Added Successfully.");
            txtItemName.Clear();
            txtQuantity.Clear();
            txtCost.Clear();
            comBoxUnit.Text = "select";
            comBoxMembers.Text = "select";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtpBazarDate.Text != "" && txtItemName.Text != "" && txtQuantity.Text != "" && txtCost.Text != "" && comBoxMembers.Text != "select")
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "update Bazar set BazarDate=@date,ItemName=@item,Quantity=@qty,Cost=@cost, MemberID=@mid where BazarID=@bid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date", dtpBazarDate.Text);
                    cmd.Parameters.AddWithValue("@item", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToInt32(txtCost.Text));
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(comBoxMembers.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@bid", Convert.ToInt32(txtID.Text));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Bazar Updated Successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("you can't blank any field");
            }
        }
    }
}
