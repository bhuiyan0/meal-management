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
using MyMess.Report;
using MyMess.Forms;

namespace MyMess.Forms
{
    public partial class ReportForm : Form
    {

       // Filtering Filtering = new Filtering();
        string cs = ConfigurationManager.ConnectionStrings["MyMessDB"].ConnectionString;
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    if (label4.Text=="bazar")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from vw_BazarDetails where BazarDate between @fromdate and @todate", con);
                        cmd.Parameters.AddWithValue("@fromdate", label1.Text);
                        cmd.Parameters.AddWithValue("@todate", label2.Text);
                        //cmd.Parameters.AddWithValue("@name", label3.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("There is no data to show !");
                            this.Close();
                        }
                        else
                        {
                            BazarReport Bazar = new BazarReport();
                            Bazar.SetDataSource(dt);
                            MainReportViwer.ReportSource = Bazar;
                        }
                    }

                    else if (label4.Text=="meal")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from vw_MealDetails where MealDate between @fromdate and @todate ", con);
                        //cmd.Parameters.AddWithValue("@name", label3.Text);
                        cmd.Parameters.AddWithValue("@fromdate", label1.Text);
                        cmd.Parameters.AddWithValue("@todate", label2.Text);
                        //cmd.Parameters.AddWithValue("@name", label3.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("There is no data to show !");
                            this.Close();
                        }
                        else
                        {
                            MealReport meal = new MealReport();
                            meal.SetDataSource(dt);
                            MainReportViwer.ReportSource = meal;
                        }
                    }

                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from vw_FinalDetails where BazarDate between @fromdate and @todate and FullName=@name", con);
                        cmd.Parameters.AddWithValue("@name", label3.Text);
                        cmd.Parameters.AddWithValue("@fromdate", label1.Text);
                        cmd.Parameters.AddWithValue("@todate", label2.Text);
                        //cmd.Parameters.AddWithValue("@name", label3.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("There is no data to show !");
                            this.Close();
                        }
                        else
                        {
                            FinalReport final = new FinalReport();
                            final.SetDataSource(dt);
                            MainReportViwer.ReportSource = final;
                        }
                    }
                }
            }
           //
        }
    }
}
