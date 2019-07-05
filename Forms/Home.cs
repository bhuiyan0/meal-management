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
using MyMess.Forms;
using MyMess.Report;
using MyMess.UserControls;
namespace MyMess.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void addControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelHome.Controls.Clear();
            panelHome.Controls.Add(c);
        }
        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
        }

        private void dailyBazarEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dailyMealEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void depositsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void bazarReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtering filtering = new Filtering();
            filtering.btnBazar.Visible = true;
            filtering.comBoxMember.Visible = false;
            filtering.lblMember.Visible = false;
            filtering.lblTitle.Text = "Bazar Report";
            filtering.ShowDialog();
        }

        private void finalAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtering filtering = new Filtering();
            filtering.btnFinal.Visible = true;
            filtering.lblTitle.Text = "Final Report";
            filtering.lblMember.Visible = true;
            filtering.comBoxMember.Visible = true;
            filtering.ShowDialog();
        }

        private void mealReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtering filtering = new Filtering();
            filtering.btnMeal.Visible = true;
            filtering.lblTitle.Text = "Meal Report";
            filtering.ShowDialog();
        }



        private void addNewBazar_Click(object sender, EventArgs e)
        {
            BazarEntry bazarEntry = new BazarEntry();
            bazarEntry.ShowDialog();
        }

        private void bazarList_Click(object sender, EventArgs e)
        {
            uc_BazarList bazarList = new uc_BazarList();
            addControlToPanel(bazarList);
        }

        private void addNewMeal_Click(object sender, EventArgs e)
        {
            MealsEntry mealsEntry = new MealsEntry();
            mealsEntry.ShowDialog();

        }

        private void mealList_Click(object sender, EventArgs e)
        {
            uc_MealList mealList = new uc_MealList();
            addControlToPanel(mealList);
        }

        private void addNewDeposit_Click(object sender, EventArgs e)
        {
            DepositsEntry depositsEntry = new DepositsEntry();
            depositsEntry.ShowDialog();
        }

        private void depositList_Click(object sender, EventArgs e)
        {
            uc_DepositList depositList = new uc_DepositList();
            addControlToPanel(depositList);
        }

        private void addNewMember_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.ShowDialog();
        }

        private void memberList_Click(object sender, EventArgs e)
        {
            uc_Members uc_Members = new uc_Members();
            addControlToPanel(uc_Members);
        }
    }
}
