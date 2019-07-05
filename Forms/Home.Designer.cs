namespace MyMess.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyBazarEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyMealEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositsEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazarReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBazar = new System.Windows.Forms.ToolStripMenuItem();
            this.bazarList = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMeal = new System.Windows.Forms.ToolStripMenuItem();
            this.mealList = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.depositList = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.memberList = new System.Windows.Forms.ToolStripMenuItem();
            this.panelParent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.panelHome);
            this.panelParent.Controls.Add(this.panel1);
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(0, 0);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1084, 661);
            this.panelParent.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelHome.BackgroundImage = global::MyMess.Properties.Resources.horizon_cloud_sky_sun_sunrise_sunset_675161_pxhere_com;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 40);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1084, 621);
            this.panelHome.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblCurrentDate);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(891, 13);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentDate.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 30);
            this.toolStripMenuItem1.Text = "Home";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoSize = false;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyBazarEntryToolStripMenuItem,
            this.dailyMealEntryToolStripMenuItem,
            this.depositsEntryToolStripMenuItem,
            this.membersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // dailyBazarEntryToolStripMenuItem
            // 
            this.dailyBazarEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBazar,
            this.bazarList});
            this.dailyBazarEntryToolStripMenuItem.Name = "dailyBazarEntryToolStripMenuItem";
            this.dailyBazarEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.dailyBazarEntryToolStripMenuItem.Text = "Bazars";
            this.dailyBazarEntryToolStripMenuItem.Click += new System.EventHandler(this.dailyBazarEntryToolStripMenuItem_Click);
            // 
            // dailyMealEntryToolStripMenuItem
            // 
            this.dailyMealEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMeal,
            this.mealList});
            this.dailyMealEntryToolStripMenuItem.Name = "dailyMealEntryToolStripMenuItem";
            this.dailyMealEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.dailyMealEntryToolStripMenuItem.Text = "Meals";
            this.dailyMealEntryToolStripMenuItem.Click += new System.EventHandler(this.dailyMealEntryToolStripMenuItem_Click);
            // 
            // depositsEntryToolStripMenuItem
            // 
            this.depositsEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDeposit,
            this.depositList});
            this.depositsEntryToolStripMenuItem.Name = "depositsEntryToolStripMenuItem";
            this.depositsEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.depositsEntryToolStripMenuItem.Text = "Deposits";
            this.depositsEntryToolStripMenuItem.Click += new System.EventHandler(this.depositsEntryToolStripMenuItem_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMember,
            this.memberList});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.membersToolStripMenuItem.Text = "Members";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.AutoSize = false;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazarReportToolStripMenuItem,
            this.mealReportToolStripMenuItem,
            this.finalAccountToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // bazarReportToolStripMenuItem
            // 
            this.bazarReportToolStripMenuItem.Name = "bazarReportToolStripMenuItem";
            this.bazarReportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.bazarReportToolStripMenuItem.Text = "Bazar Report";
            this.bazarReportToolStripMenuItem.Click += new System.EventHandler(this.bazarReportToolStripMenuItem_Click);
            // 
            // mealReportToolStripMenuItem
            // 
            this.mealReportToolStripMenuItem.Name = "mealReportToolStripMenuItem";
            this.mealReportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.mealReportToolStripMenuItem.Text = "Meal Report";
            this.mealReportToolStripMenuItem.Click += new System.EventHandler(this.mealReportToolStripMenuItem_Click);
            // 
            // finalAccountToolStripMenuItem
            // 
            this.finalAccountToolStripMenuItem.Name = "finalAccountToolStripMenuItem";
            this.finalAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.finalAccountToolStripMenuItem.Text = "Final Report";
            this.finalAccountToolStripMenuItem.Click += new System.EventHandler(this.finalAccountToolStripMenuItem_Click);
            // 
            // addNewBazar
            // 
            this.addNewBazar.Name = "addNewBazar";
            this.addNewBazar.Size = new System.Drawing.Size(180, 24);
            this.addNewBazar.Text = "Add New Bazar";
            this.addNewBazar.Click += new System.EventHandler(this.addNewBazar_Click);
            // 
            // bazarList
            // 
            this.bazarList.Name = "bazarList";
            this.bazarList.Size = new System.Drawing.Size(180, 24);
            this.bazarList.Text = "Bazar List";
            this.bazarList.Click += new System.EventHandler(this.bazarList_Click);
            // 
            // addNewMeal
            // 
            this.addNewMeal.Name = "addNewMeal";
            this.addNewMeal.Size = new System.Drawing.Size(180, 24);
            this.addNewMeal.Text = "Add New Meal";
            this.addNewMeal.Click += new System.EventHandler(this.addNewMeal_Click);
            // 
            // mealList
            // 
            this.mealList.Name = "mealList";
            this.mealList.Size = new System.Drawing.Size(180, 24);
            this.mealList.Text = "Meal List";
            this.mealList.Click += new System.EventHandler(this.mealList_Click);
            // 
            // addNewDeposit
            // 
            this.addNewDeposit.Name = "addNewDeposit";
            this.addNewDeposit.Size = new System.Drawing.Size(183, 24);
            this.addNewDeposit.Text = "Add New Deposit";
            this.addNewDeposit.Click += new System.EventHandler(this.addNewDeposit_Click);
            // 
            // depositList
            // 
            this.depositList.Name = "depositList";
            this.depositList.Size = new System.Drawing.Size(183, 24);
            this.depositList.Text = "Deposit List";
            this.depositList.Click += new System.EventHandler(this.depositList_Click);
            // 
            // addNewMember
            // 
            this.addNewMember.Name = "addNewMember";
            this.addNewMember.Size = new System.Drawing.Size(186, 24);
            this.addNewMember.Text = "Add New Member";
            this.addNewMember.Click += new System.EventHandler(this.addNewMember_Click);
            // 
            // memberList
            // 
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(186, 24);
            this.memberList.Text = "MemberList";
            this.memberList.Click += new System.EventHandler(this.memberList_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelParent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyBazarEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyMealEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositsEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazarReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalAccountToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewBazar;
        private System.Windows.Forms.ToolStripMenuItem bazarList;
        private System.Windows.Forms.ToolStripMenuItem addNewMeal;
        private System.Windows.Forms.ToolStripMenuItem mealList;
        private System.Windows.Forms.ToolStripMenuItem addNewDeposit;
        private System.Windows.Forms.ToolStripMenuItem depositList;
        private System.Windows.Forms.ToolStripMenuItem addNewMember;
        private System.Windows.Forms.ToolStripMenuItem memberList;
    }
}