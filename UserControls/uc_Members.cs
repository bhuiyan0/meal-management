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
    public partial class uc_Members : UserControl
    {
        public uc_Members()
        {
            InitializeComponent();
        }


        private void uc_Members_Load(object sender, EventArgs e)
        {
            GridViewLoad();
        }


        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
        }

        public void GridViewLoad()
        {
            string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Members where IsActive=1", con);
                DataTable table = new DataTable();
                da.Fill(table);

                dgvMember.DataSource = table;
                dgvMember.Columns["IsActive"].Visible = false;
                dgvMember.Columns["EmergencyContact"].Visible = false;
                dgvMember.Columns["EmergencyContactNo"].Visible = false;
                dgvMember.Columns["Image"].Visible = false;
                dgvMember.Columns["Occupation"].Visible = false;

                //modify the header text
                dgvMember.Columns["MemberID"].HeaderText = "ID";
                dgvMember.Columns["ContactNo"].HeaderText = "Contact No";

                dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            AddMember addmember = new AddMember();
            addmember.lblTitle.Text = "Update or Delete Member Info";
            addmember.txtFirstName.Text = this.dgvMember.CurrentRow.Cells["FullName"].Value.ToString();
            addmember.txtEmail.Text = this.dgvMember.CurrentRow.Cells["Email"].Value.ToString();
            addmember.txtContact.Text = this.dgvMember.CurrentRow.Cells["ContactNo"].Value.ToString();
            addmember.txtAddress.Text = this.dgvMember.CurrentRow.Cells["Address"].Value.ToString();
            addmember.txtDistrict.Text = this.dgvMember.CurrentRow.Cells["District"].Value.ToString();
            addmember.dtpDob.Text = this.dgvMember.CurrentRow.Cells["BirthDate"].Value.ToString();
            addmember.txtNidNo.Text = this.dgvMember.CurrentRow.Cells["NIDNo"].Value.ToString();
            addmember.txtOccupation.Text = this.dgvMember.CurrentRow.Cells["Occupation"].Value.ToString();

            addmember.txtEmergencyPerson.Text = this.dgvMember.CurrentRow.Cells["EmergencyContact"].Value.ToString();
            addmember.txtEmContactNo.Text = this.dgvMember.CurrentRow.Cells["EmergencyContactNo"].Value.ToString();
            addmember.lblImagePath.Text = this.dgvMember.CurrentRow.Cells["Image"].Value.ToString();
            addmember.lblID.Text = this.dgvMember.CurrentRow.Cells["MemberID"].Value.ToString();

            if (this.dgvMember.CurrentRow.Cells["IsActive"].Value.ToString() == "True")
            {
                addmember.chkIsActive.Checked = true;
            }
            else
            {
                addmember.chkIsActive.Checked = false;
            }
            string saveDirectory = @"C:\Uploads\";
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            addmember.picBoxImage.ImageLocation = saveDirectory + this.dgvMember.CurrentRow.Cells["Image"].Value.ToString();
            
        
            addmember.btnSave.Hide();
            addmember.btnUpdate.Show();
            addmember.btnDelete.Show();

            addmember.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridViewLoad();
        }
    }
}
