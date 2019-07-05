namespace MyMess.Forms
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtNidNo = new System.Windows.Forms.TextBox();
            this.lblNidNo = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtEmergencyPerson = new System.Windows.Forms.TextBox();
            this.lblEmergencyPerson = new System.Windows.Forms.Label();
            this.txtEmContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(375, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create New Member";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(46, 72);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(92, 18);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name  *";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(146, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(256, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(557, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(446, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 18);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(42, 116);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 18);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Location = new System.Drawing.Point(557, 65);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(206, 26);
            this.txtContact.TabIndex = 4;
            this.txtContact.Tag = "";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(446, 67);
            this.lblContact.Name = "lblContact";
            this.lblContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblContact.Size = new System.Drawing.Size(100, 18);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact No  *";
            // 
            // txtDistrict
            // 
            this.txtDistrict.AutoCompleteCustomSource.AddRange(new string[] {
            "Comilla",
            "Feni",
            "Brahmanbaria",
            "Rangamati",
            "Noakhali",
            "Chandpur",
            "Lakshmipur",
            "Chittagong",
            "Coxsbazar",
            "Khagrachhari",
            "Bandarban",
            "Rajshahi",
            "Sirajganj",
            "Pabna",
            "Bogra",
            "Rajshahi",
            "Natore",
            "Joypurhat",
            "Chapainawabganj",
            "Naogaon",
            "Khulna",
            "Jessore",
            "Satkhira",
            "Meherpur",
            "Narail",
            "Chuadanga",
            "Kushtia",
            "Magura",
            "Khulna",
            "Bagerhat",
            "Jhenaidah",
            "Barisal",
            "Jhalakathi",
            "Patuakhali",
            "Pirojpur",
            "Barisal",
            "Bhola",
            "Barguna",
            "Sylhet",
            "Moulvibazar",
            "Habiganj",
            "Sunamganj",
            "Dhaka",
            "Narsingdi",
            "Gazipur",
            "Shariatpur",
            "Narayanganj",
            "Tangail",
            "Kishoreganj",
            "Manikganj",
            "Munshiganj",
            "Rajbari",
            "Madaripur",
            "Gopalganj",
            "Faridpur",
            "Panchagarh",
            "Dinajpur",
            "Lalmonirhat",
            "Nilphamari",
            "Gaibandha",
            "Thakurgaon",
            "Rangpur",
            "Kurigram",
            "Mymensingh",
            "Sherpur",
            "Jamalpur",
            "Netrokona"});
            this.txtDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDistrict.Location = new System.Drawing.Point(146, 177);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(195, 26);
            this.txtDistrict.TabIndex = 2;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(43, 180);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(71, 18);
            this.lblDistrict.TabIndex = 11;
            this.lblDistrict.Text = "District  *";
            // 
            // txtNidNo
            // 
            this.txtNidNo.Location = new System.Drawing.Point(557, 169);
            this.txtNidNo.Name = "txtNidNo";
            this.txtNidNo.Size = new System.Drawing.Size(206, 26);
            this.txtNidNo.TabIndex = 6;
            // 
            // lblNidNo
            // 
            this.lblNidNo.AutoSize = true;
            this.lblNidNo.Location = new System.Drawing.Point(446, 172);
            this.lblNidNo.Name = "lblNidNo";
            this.lblNidNo.Size = new System.Drawing.Size(68, 18);
            this.lblNidNo.TabIndex = 13;
            this.lblNidNo.Text = "NID No *";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(557, 227);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(170, 26);
            this.txtOccupation.TabIndex = 7;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(446, 230);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(87, 18);
            this.lblOccupation.TabIndex = 15;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 113);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(256, 58);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "";
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImage.Location = new System.Drawing.Point(778, 59);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(162, 176);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 19;
            this.picBoxImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(778, 240);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(162, 31);
            this.btnImage.TabIndex = 10;
            this.btnImage.Text = "Browse";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(43, 224);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(88, 18);
            this.lblDob.TabIndex = 21;
            this.lblDob.Text = "Birth Date *";
            // 
            // txtEmergencyPerson
            // 
            this.txtEmergencyPerson.Location = new System.Drawing.Point(334, 267);
            this.txtEmergencyPerson.Name = "txtEmergencyPerson";
            this.txtEmergencyPerson.Size = new System.Drawing.Size(212, 26);
            this.txtEmergencyPerson.TabIndex = 8;
            // 
            // lblEmergencyPerson
            // 
            this.lblEmergencyPerson.AutoSize = true;
            this.lblEmergencyPerson.Location = new System.Drawing.Point(46, 270);
            this.lblEmergencyPerson.Name = "lblEmergencyPerson";
            this.lblEmergencyPerson.Size = new System.Drawing.Size(213, 18);
            this.lblEmergencyPerson.TabIndex = 25;
            this.lblEmergencyPerson.Text = "Emergency Contact Person  *";
            // 
            // txtEmContactNo
            // 
            this.txtEmContactNo.Location = new System.Drawing.Point(334, 299);
            this.txtEmContactNo.Name = "txtEmContactNo";
            this.txtEmContactNo.Size = new System.Drawing.Size(212, 26);
            this.txtEmContactNo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Emergency Contact Person Phone No *";
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(146, 218);
            this.dtpDob.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(144, 26);
            this.dtpDob.TabIndex = 3;
            this.dtpDob.Value = new System.DateTime(2019, 3, 9, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.Location = new System.Drawing.Point(163, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(280, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(60, 367);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(97, 22);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "Is Active ?";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(637, 336);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(0, 18);
            this.lblImagePath.TabIndex = 28;
            this.lblImagePath.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(619, 368);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 18);
            this.lblID.TabIndex = 29;
            this.lblID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.Location = new System.Drawing.Point(46, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 40);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.Location = new System.Drawing.Point(163, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 40);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(954, 465);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtEmContactNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmergencyPerson);
            this.Controls.Add(this.lblEmergencyPerson);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.txtNidNo);
            this.Controls.Add(this.lblNidNo);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Form";
            this.Load += new System.EventHandler(this.AddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblFullName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.TextBox txtDistrict;
        public System.Windows.Forms.Label lblDistrict;
        public System.Windows.Forms.TextBox txtNidNo;
        public System.Windows.Forms.Label lblNidNo;
        public System.Windows.Forms.TextBox txtOccupation;
        public System.Windows.Forms.Label lblOccupation;
        public System.Windows.Forms.RichTextBox txtAddress;
        public System.Windows.Forms.PictureBox picBoxImage;
        public System.Windows.Forms.Button btnImage;
        public System.Windows.Forms.Label lblDob;
        public System.Windows.Forms.TextBox txtEmergencyPerson;
        public System.Windows.Forms.Label lblEmergencyPerson;
        public System.Windows.Forms.TextBox txtEmContactNo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpDob;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.CheckBox chkIsActive;
        public System.Windows.Forms.Label lblImagePath;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
    }
}