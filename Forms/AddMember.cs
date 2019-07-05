using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace MyMess.Forms
{
    public partial class AddMember : Form
    {
        uc_Members members = new uc_Members();

        string imageLocation = "";
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;

        public AddMember()
        {
            InitializeComponent();
        }
        private void AddMember_Load(object sender, EventArgs e)
        {
            dtpDob.Text = DateTime.Today.ToShortDateString();
            dtpDob.MaxDate = System.DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var imagePath = "";
            string saveDirectory = @"C:\Uploads\";
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }
            imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());

            if (txtAddress.Text!=""&&txtContact.Text!=""&&txtDistrict.Text!=""&& txtEmail.Text!=""&&txtEmContactNo.Text!=""&&txtEmergencyPerson.Text!=""&&txtFirstName.Text!=""&& txtNidNo.Text!="" &&txtOccupation.Text!="" &&imageLocation!="")
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    int isActive;
                    if (chkIsActive.Checked == true) { isActive = 1; } else { isActive = 0; }

                    string insertCommand = "insert into Members (FullName,Address,District,ContactNo,Email,BirthDate,NIDNo,Occupation,EmergencyContact,EmergencyContactNo,Image,IsActive) values(@fname,@address,@dist,@contact,@email,@dob,@nid,@occup,@econtact,@econtactno,@image,@isactive)";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertCommand, con);
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@dist", txtDistrict.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@dob", dtpDob.Text);
                    cmd.Parameters.AddWithValue("@nid", txtNidNo.Text);
                    cmd.Parameters.AddWithValue("@occup", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@econtact", txtEmergencyPerson.Text);
                    cmd.Parameters.AddWithValue("@econtactno", txtEmContactNo.Text);
                    cmd.Parameters.AddWithValue("@image", imagePath);
                    cmd.Parameters.AddWithValue("@isactive", isActive);
                    cmd.ExecuteNonQuery();

                    picBoxImage.Refresh();
                    MessageBox.Show("New member added successfully !!");
                }
            }
            else
            {
                MessageBox.Show("you can't blank any field !");
            }
            File.Copy(imageLocation, Path.Combine(saveDirectory, Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
            clearData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                picBoxImage.ImageLocation = imageLocation;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this data ??", "Confirm Delete !!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    //SqlCommand cmd = new SqlCommand("delete from Members where MemberID=@mid",con);
                    SqlCommand cmd = new SqlCommand("update Members set IsActive=0 where MemberID=@mid", con);
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt16(lblID.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                members.GridViewLoad();

                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var imagePath = "";
            string saveDirectory = @"C:\Uploads\";
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }
            if (string.IsNullOrEmpty(lblImagePath.Text))
            {
                imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());
            }
            else
            {
                imagePath = lblImagePath.Text;

            }

            var confirmResult = MessageBox.Show("Are you sure to update this data ??", "Confirm Update!!", MessageBoxButtons.YesNo);
            if (txtAddress.Text != "" && txtContact.Text != "" && txtDistrict.Text != "" && txtEmail.Text != "" && txtEmContactNo.Text != "" && txtEmergencyPerson.Text != "" && txtFirstName.Text != "" && txtNidNo.Text != "" && txtOccupation.Text != "" && picBoxImage.ImageLocation != "")
            {

                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', update the data
                    int isActive;
                    if (chkIsActive.Checked) { isActive = 1; } else { isActive = 0; }
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        string updateQuery = "update Members set FullName=@fname,Address=@address,District=@dist,ContactNo=@contact,Email=@email,BirthDate=@dob,NIDNo=@nid,Occupation=@occupation,EmergencyContact=@econtact,EmergencyContactNo=@econtactno,Image=@image,IsActive=@isactive where MemberID=@mid";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(updateQuery, con);
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@dist", txtDistrict.Text);
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@dob", dtpDob.Text);
                        cmd.Parameters.AddWithValue("@nid", txtNidNo.Text);
                        cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@econtact", txtEmergencyPerson.Text);
                        cmd.Parameters.AddWithValue("@econtactno", txtEmContactNo.Text);
                        cmd.Parameters.AddWithValue("@image", imagePath);
                        cmd.Parameters.AddWithValue("@isactive", isActive);
                        cmd.Parameters.AddWithValue("@mid", Convert.ToInt16(lblID.Text));

                        cmd.ExecuteNonQuery();
                    }
                    File.Copy(imageLocation, Path.Combine(saveDirectory, Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("you can't blank any field !");
            }
        }

        private void clearData()
        {
            txtAddress.Clear();
            txtContact.Clear();
            txtDistrict.Clear();
            txtEmail.Clear();
            txtEmContactNo.Clear();
            txtEmergencyPerson.Clear();
            txtFirstName.Clear();
            txtNidNo.Clear();
            txtOccupation.Clear();
            chkIsActive.Checked = false;
            picBoxImage.ImageLocation = "";
            dtpDob.Text = DateTime.Now.ToShortDateString();
        }
    }
}
