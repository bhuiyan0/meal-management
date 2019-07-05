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

namespace MyMess.Forms
{
    public partial class MealsEntry : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;

        public MealsEntry()
        {
            InitializeComponent();
        }

        public void MealsEntry_Load(object sender, EventArgs e)
        {
            currentId();
            memberName();

            comBoxMembers.Text = "select";
            dtpMealDate.Text = DateTime.Today.ToShortDateString();
            dtpMealDate.MaxDate = System.DateTime.Now;
        }

        private void myLoad(object sender, EventArgs e)
        {
            memberName();
            dtpMealDate.MaxDate = System.DateTime.Now;
        }


        //to get the last DepositID and increment it one so user can see the current id
        private void currentId()
        {
            int id;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query1 = "select max(MealID) from Meals";
                SqlCommand cmd = new SqlCommand(query1, con);
                string sid = cmd.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(sid)) { id = 0; } else { id = Convert.ToInt32(sid); }
            }
            txtID.Text = (id + 1).ToString();
        }

        //load the all active member in the combo box 
        private void memberName()
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

        //click event to add data to the gridview 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int bf = 0, l = 0, d = 0;
            if (chkBreakfast.Checked) { bf = 1; } else { bf = 0; }
            if (chkLunch.Checked) { l = 1; } else { l = 0; }
            if (chkDinner.Checked) { d = 1; } else { d = 0; }
            int meal = bf + l + d;

            if (dtpMealDate.Text != "" && comBoxMembers.Text != "select" && meal != 0)
            {
                int n = dgvMeals.Rows.Add();
                dgvMeals.Rows[n].Cells[0].Value = dtpMealDate.Text;
                dgvMeals.Rows[n].Cells[1].Value = comBoxMembers.Text;
                dgvMeals.Rows[n].Cells[2].Value = meal;

                //for increment the Meal Id textbox
                int preid = Convert.ToInt32(txtID.Text);
                string currenttid = (preid + 1).ToString();
                txtID.Text = currenttid;

                ClearData();
            }
            else
            {
                MessageBox.Show("you cant blank any field !");
            }
        }

        //insert data into Deposite table from datagridview
        private void btn_Click(object sender, EventArgs e)
        {
            //create the xmldate folder and a file "MyMess.xml" on c drive to store xml data 
            string saveDirectory = @"C:\xmldata\";
            if (!File.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }
            string xmlFile = Path.Combine(saveDirectory, "MyMess.xml");


            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                for (int i = 0; i < dgvMeals.RowCount - 1; i++)
                {
                    string memberName = dgvMeals.Rows[i].Cells[1].Value.ToString();
                    SqlCommand cmd1 = new SqlCommand("select MemberID from Members where FullName='" + memberName + "'", con);
                    int mid = (int)cmd1.ExecuteScalar();

                    string query = "insert into Meals(MemberID,MealDate,Quantity) values (@mid,@date,@qty)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date", dgvMeals.Rows[0].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@qty", dgvMeals.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@mid", mid);
                    cmd.ExecuteNonQuery();

                    //insert data into xml file
                    XmlDocument doc = new XmlDocument();
                    if (!File.Exists(xmlFile))
                    {
                        //create nodes
                        XmlElement root = doc.CreateElement("Meals");
                        XmlElement meal = doc.CreateElement("Meal");
                        XmlElement date = doc.CreateElement("Date");
                        XmlElement member = doc.CreateElement("MemberName");
                        XmlElement mealsEaten = doc.CreateElement("MealsEaten");

                        //add value
                        date.InnerText = dgvMeals.Rows[0].Cells[0].Value.ToString();
                        member.InnerText = memberName;
                        mealsEaten.InnerText = dgvMeals.Rows[i].Cells[2].Value.ToString();

                        //contstract the document
                        doc.AppendChild(root);
                        root.AppendChild(meal);
                        meal.AppendChild(date);
                        meal.AppendChild(member);
                        meal.AppendChild(mealsEaten);
                        doc.Save(xmlFile);
                    }
                    else
                    {
                        //load the xml file
                        doc.Load(xmlFile);

                        //get root element
                        XmlElement root = doc.DocumentElement;

                        XmlElement meal = doc.CreateElement("Meal");
                        XmlElement date = doc.CreateElement("Date");
                        XmlElement member = doc.CreateElement("MemberName");
                        XmlElement mealsEaten = doc.CreateElement("MealsEaten");

                        //add the values for each nodes
                        date.InnerText = dgvMeals.Rows[0].Cells[0].Value.ToString();
                        member.InnerText = memberName;
                        mealsEaten.InnerText = dgvMeals.Rows[i].Cells[2].Value.ToString();

                        //construct the Meal element
                        meal.AppendChild(date);
                        meal.AppendChild(member);
                        meal.AppendChild(mealsEaten);

                        //add the Meal element to the end of the root element
                        root.AppendChild(meal);

                        //save the document 
                        doc.Save(xmlFile);
                    }
                }
                MessageBox.Show("Meals successfully inserted to sql database and xml file");
                dgvMeals.Rows.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearData()
        {
            comBoxMembers.Text = "select";
            chkBreakfast.Checked = false;
            chkDinner.Checked = false;
            chkLunch.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtpMealDate.Text != "" && comBoxMembers.Text != "select" && txtMealsEaten.Value != 0)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "update Meals set MemberID=@mid,MealDate=@date,Quantity=@qty where MealID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date",dtpMealDate.Text) ;
                    cmd.Parameters.AddWithValue("@qty",txtMealsEaten.Value);
                    cmd.Parameters.AddWithValue("@id",Convert.ToInt32(txtID.Text));
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(comBoxMembers.SelectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Meals successfully updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("all field required");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
