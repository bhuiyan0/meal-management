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
using MyMess.Forms;
using MyMess.Report;
using System.Configuration;

namespace MyMess
{
    public partial class Filtering : Form
    {
        ReportForm ReportForm = new ReportForm();
        BazarReport bazarReport = new BazarReport();

        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;
        public Filtering()
        {
            InitializeComponent();
        }

        private void Filtering_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "Select * From Members where IsActive=1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comBoxMember.DataSource = dt;
                comBoxMember.DisplayMember = "FullName";
                comBoxMember.ValueMember = "MemberID";
            }
            comBoxMember.Text = "select";

            dtpTo.Text = DateTime.Today.ToShortDateString();
            dtpTo.MaxDate = System.DateTime.Now;
            dtpFrom.Text = DateTime.Today.ToShortDateString();
            dtpFrom.MaxDate = System.DateTime.Now;

        }

        private void btnBazar_Click(object sender, EventArgs e)
        {
            ReportForm.label1.Text = dtpFrom.Text;
            ReportForm.label2.Text = dtpTo.Text;
            ReportForm.label4.Text = "bazar";
            ReportForm.ShowDialog();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            ReportForm.label1.Text = dtpFrom.Text;
            ReportForm.label2.Text = dtpTo.Text;
            ReportForm.label4.Text = "meal";
            if (comBoxMember.Text != "select" || comBoxMember.Text != "")
            {
                ReportForm.label3.Text = comBoxMember.Text.ToString();
            }
            ReportForm.ShowDialog();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (comBoxMember.Text!="" && comBoxMember.Text!="select")
            {
                ReportForm.label1.Text = dtpFrom.Text;
                ReportForm.label2.Text = dtpTo.Text;
                ReportForm.label4.Text = "final";
                ReportForm.label3.Text = comBoxMember.Text.ToString();
                ReportForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("please select a member");
            }
           
        }
    }
}
