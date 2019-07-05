namespace MyMess.Forms
{
    partial class MealsEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealsEntry));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.comBoxMembers = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblMealEaten = new System.Windows.Forms.Label();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.chkLunch = new System.Windows.Forms.CheckBox();
            this.chkDinner = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMealsEaten = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMealsEaten)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
            this.lblTitle.Location = new System.Drawing.Point(276, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Meal Entry";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(72, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMealDate.Location = new System.Drawing.Point(179, 81);
            this.dtpMealDate.MaxDate = new System.DateTime(2099, 3, 9, 0, 0, 0, 0);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(110, 26);
            this.dtpMealDate.TabIndex = 2;
            this.dtpMealDate.Value = new System.DateTime(2019, 3, 9, 0, 0, 0, 0);
            // 
            // comBoxMembers
            // 
            this.comBoxMembers.FormattingEnabled = true;
            this.comBoxMembers.Location = new System.Drawing.Point(179, 113);
            this.comBoxMembers.Name = "comBoxMembers";
            this.comBoxMembers.Size = new System.Drawing.Size(180, 26);
            this.comBoxMembers.TabIndex = 16;
            this.comBoxMembers.Text = "Select";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(72, 116);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(66, 18);
            this.lblMember.TabIndex = 15;
            this.lblMember.Text = "Member";
            // 
            // lblMealEaten
            // 
            this.lblMealEaten.AutoSize = true;
            this.lblMealEaten.Location = new System.Drawing.Point(72, 152);
            this.lblMealEaten.Name = "lblMealEaten";
            this.lblMealEaten.Size = new System.Drawing.Size(87, 18);
            this.lblMealEaten.TabIndex = 17;
            this.lblMealEaten.Text = "Meal Eaten";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(180, 151);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(94, 22);
            this.chkBreakfast.TabIndex = 18;
            this.chkBreakfast.Text = "Breakfast";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // chkLunch
            // 
            this.chkLunch.AutoSize = true;
            this.chkLunch.Location = new System.Drawing.Point(280, 151);
            this.chkLunch.Name = "chkLunch";
            this.chkLunch.Size = new System.Drawing.Size(68, 22);
            this.chkLunch.TabIndex = 19;
            this.chkLunch.Text = "Lunch";
            this.chkLunch.UseVisualStyleBackColor = true;
            // 
            // chkDinner
            // 
            this.chkDinner.AutoSize = true;
            this.chkDinner.Location = new System.Drawing.Point(354, 151);
            this.chkDinner.Name = "chkDinner";
            this.chkDinner.Size = new System.Drawing.Size(73, 22);
            this.chkDinner.TabIndex = 20;
            this.chkDinner.Text = "Dinner";
            this.chkDinner.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(18, 465);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(80, 30);
            this.btn.TabIndex = 21;
            this.btn.Text = "Save";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(113, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(178, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 27);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMeals
            // 
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMeals.Location = new System.Drawing.Point(12, 215);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.Size = new System.Drawing.Size(638, 233);
            this.dgvMeals.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Member Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Meals Eaten";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "SL No :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(179, 49);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 27;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(179, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 27);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(294, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 27);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMealsEaten
            // 
            this.txtMealsEaten.Location = new System.Drawing.Point(180, 150);
            this.txtMealsEaten.Name = "txtMealsEaten";
            this.txtMealsEaten.Size = new System.Drawing.Size(120, 26);
            this.txtMealsEaten.TabIndex = 31;
            this.txtMealsEaten.Visible = false;
            // 
            // MealsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 507);
            this.Controls.Add(this.txtMealsEaten);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMeals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.chkDinner);
            this.Controls.Add(this.chkLunch);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.lblMealEaten);
            this.Controls.Add(this.comBoxMembers);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.dtpMealDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MealsEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MealsEntry";
            this.Load += new System.EventHandler(this.MealsEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMealsEaten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.DateTimePicker dtpMealDate;
        public System.Windows.Forms.ComboBox comBoxMembers;
        public System.Windows.Forms.Label lblMember;
        public System.Windows.Forms.Label lblMealEaten;
        public System.Windows.Forms.CheckBox chkBreakfast;
        public System.Windows.Forms.CheckBox chkLunch;
        public System.Windows.Forms.CheckBox chkDinner;
        public System.Windows.Forms.Button btn;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvMeals;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.NumericUpDown txtMealsEaten;
    }
}