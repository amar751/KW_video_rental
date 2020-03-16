namespace KW_video_rental
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCDetails = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.CContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVDetails = new System.Windows.Forms.Button();
            this.txtVCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVDelete = new System.Windows.Forms.Button();
            this.btnVUpdate = new System.Windows.Forms.Button();
            this.btnVAdd = new System.Windows.Forms.Button();
            this.txtVGenre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVPlot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVCopies = new System.Windows.Forms.TextBox();
            this.txtVYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVRatting = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRDetails = new System.Windows.Forms.Button();
            this.btnVideoMost = new System.Windows.Forms.Button();
            this.btnCustomerMost = new System.Windows.Forms.Button();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnRentDelete = new System.Windows.Forms.Button();
            this.btnVReturn = new System.Windows.Forms.Button();
            this.btnVIssue = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCDetails);
            this.groupBox1.Controls.Add(this.btnCDelete);
            this.groupBox1.Controls.Add(this.btnCUpdate);
            this.groupBox1.Controls.Add(this.btnCAdd);
            this.groupBox1.Controls.Add(this.CContact);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CPlace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CName);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Customer Details";
            // 
            // btnCDetails
            // 
            this.btnCDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCDetails.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDetails.Location = new System.Drawing.Point(553, 85);
            this.btnCDetails.Name = "btnCDetails";
            this.btnCDetails.Size = new System.Drawing.Size(102, 27);
            this.btnCDetails.TabIndex = 9;
            this.btnCDetails.Text = "DETAILS";
            this.btnCDetails.UseVisualStyleBackColor = false;
            this.btnCDetails.Click += new System.EventHandler(this.btnCDetails_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCDelete.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDelete.Location = new System.Drawing.Point(445, 85);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(102, 27);
            this.btnCDelete.TabIndex = 8;
            this.btnCDelete.Text = "DELETE";
            this.btnCDelete.UseVisualStyleBackColor = false;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCUpdate.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCUpdate.Location = new System.Drawing.Point(323, 85);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(102, 27);
            this.btnCUpdate.TabIndex = 7;
            this.btnCUpdate.Text = "UPDATE";
            this.btnCUpdate.UseVisualStyleBackColor = false;
            this.btnCUpdate.Click += new System.EventHandler(this.btnCUpdate_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCAdd.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAdd.Location = new System.Drawing.Point(201, 85);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(103, 27);
            this.btnCAdd.TabIndex = 6;
            this.btnCAdd.Text = "ADD";
            this.btnCAdd.UseVisualStyleBackColor = false;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // CContact
            // 
            this.CContact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CContact.Location = new System.Drawing.Point(656, 37);
            this.CContact.Name = "CContact";
            this.CContact.Size = new System.Drawing.Size(143, 32);
            this.CContact.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "CM Contact";
            // 
            // CPlace
            // 
            this.CPlace.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPlace.Location = new System.Drawing.Point(368, 37);
            this.CPlace.Name = "CPlace";
            this.CPlace.Size = new System.Drawing.Size(143, 32);
            this.CPlace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "CM Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "CM Name";
            // 
            // CName
            // 
            this.CName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.Location = new System.Drawing.Point(97, 31);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(143, 32);
            this.CName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVDetails);
            this.groupBox2.Controls.Add(this.txtVCost);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnVDelete);
            this.groupBox2.Controls.Add(this.btnVUpdate);
            this.groupBox2.Controls.Add(this.btnVAdd);
            this.groupBox2.Controls.Add(this.txtVGenre);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVPlot);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtVCopies);
            this.groupBox2.Controls.Add(this.txtVYear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtVRatting);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtVName);
            this.groupBox2.Location = new System.Drawing.Point(0, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 148);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Video Details";
            // 
            // btnVDetails
            // 
            this.btnVDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVDetails.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDetails.Location = new System.Drawing.Point(549, 118);
            this.btnVDetails.Name = "btnVDetails";
            this.btnVDetails.Size = new System.Drawing.Size(102, 27);
            this.btnVDetails.TabIndex = 10;
            this.btnVDetails.Text = "DETAILS";
            this.btnVDetails.UseVisualStyleBackColor = false;
            this.btnVDetails.Click += new System.EventHandler(this.btnVDetails_Click);
            // 
            // txtVCost
            // 
            this.txtVCost.Enabled = false;
            this.txtVCost.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVCost.Location = new System.Drawing.Point(747, 82);
            this.txtVCost.Name = "txtVCost";
            this.txtVCost.Size = new System.Drawing.Size(104, 32);
            this.txtVCost.TabIndex = 18;
            this.txtVCost.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(667, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "VM Cost";
            this.label8.Visible = false;
            // 
            // btnVDelete
            // 
            this.btnVDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVDelete.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDelete.Location = new System.Drawing.Point(445, 121);
            this.btnVDelete.Name = "btnVDelete";
            this.btnVDelete.Size = new System.Drawing.Size(87, 27);
            this.btnVDelete.TabIndex = 8;
            this.btnVDelete.Text = "DELETE";
            this.btnVDelete.UseVisualStyleBackColor = false;
            this.btnVDelete.Click += new System.EventHandler(this.btnVDelete_Click);
            // 
            // btnVUpdate
            // 
            this.btnVUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVUpdate.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVUpdate.Location = new System.Drawing.Point(340, 118);
            this.btnVUpdate.Name = "btnVUpdate";
            this.btnVUpdate.Size = new System.Drawing.Size(85, 27);
            this.btnVUpdate.TabIndex = 7;
            this.btnVUpdate.Text = "UPDATE";
            this.btnVUpdate.UseVisualStyleBackColor = false;
            this.btnVUpdate.Click += new System.EventHandler(this.btnVUpdate_Click);
            // 
            // btnVAdd
            // 
            this.btnVAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVAdd.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAdd.Location = new System.Drawing.Point(253, 118);
            this.btnVAdd.Name = "btnVAdd";
            this.btnVAdd.Size = new System.Drawing.Size(70, 27);
            this.btnVAdd.TabIndex = 6;
            this.btnVAdd.Text = "ADD";
            this.btnVAdd.UseVisualStyleBackColor = false;
            this.btnVAdd.Click += new System.EventHandler(this.btnVAdd_Click);
            // 
            // txtVGenre
            // 
            this.txtVGenre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVGenre.Location = new System.Drawing.Point(537, 82);
            this.txtVGenre.Name = "txtVGenre";
            this.txtVGenre.Size = new System.Drawing.Size(124, 32);
            this.txtVGenre.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genre";
            // 
            // txtVPlot
            // 
            this.txtVPlot.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVPlot.Location = new System.Drawing.Point(323, 82);
            this.txtVPlot.Name = "txtVPlot";
            this.txtVPlot.Size = new System.Drawing.Size(127, 32);
            this.txtVPlot.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "VD Plot";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "VD Copies";
            // 
            // txtVCopies
            // 
            this.txtVCopies.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVCopies.Location = new System.Drawing.Point(97, 82);
            this.txtVCopies.Name = "txtVCopies";
            this.txtVCopies.Size = new System.Drawing.Size(126, 32);
            this.txtVCopies.TabIndex = 11;
            // 
            // txtVYear
            // 
            this.txtVYear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVYear.Location = new System.Drawing.Point(537, 31);
            this.txtVYear.Name = "txtVYear";
            this.txtVYear.Size = new System.Drawing.Size(124, 32);
            this.txtVYear.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "VM year";
            // 
            // txtVRatting
            // 
            this.txtVRatting.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVRatting.Location = new System.Drawing.Point(323, 31);
            this.txtVRatting.Name = "txtVRatting";
            this.txtVRatting.Size = new System.Drawing.Size(127, 32);
            this.txtVRatting.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "VD Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "VD Name";
            // 
            // txtVName
            // 
            this.txtVName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVName.Location = new System.Drawing.Point(97, 31);
            this.txtVName.Name = "txtVName";
            this.txtVName.Size = new System.Drawing.Size(126, 32);
            this.txtVName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRDetails);
            this.groupBox3.Controls.Add(this.btnVideoMost);
            this.groupBox3.Controls.Add(this.btnCustomerMost);
            this.groupBox3.Controls.Add(this.dtpReturn);
            this.groupBox3.Controls.Add(this.dtpIssue);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.BtnRentDelete);
            this.groupBox3.Controls.Add(this.btnVReturn);
            this.groupBox3.Controls.Add(this.btnVIssue);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtVId);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtCId);
            this.groupBox3.Location = new System.Drawing.Point(0, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(857, 121);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental Details";
            // 
            // btnRDetails
            // 
            this.btnRDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRDetails.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDetails.Location = new System.Drawing.Point(747, 87);
            this.btnRDetails.Name = "btnRDetails";
            this.btnRDetails.Size = new System.Drawing.Size(102, 27);
            this.btnRDetails.TabIndex = 19;
            this.btnRDetails.Text = "DETAILS";
            this.btnRDetails.UseVisualStyleBackColor = false;
            this.btnRDetails.Click += new System.EventHandler(this.btnRDetails_Click);
            // 
            // btnVideoMost
            // 
            this.btnVideoMost.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVideoMost.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoMost.Location = new System.Drawing.Point(609, 90);
            this.btnVideoMost.Name = "btnVideoMost";
            this.btnVideoMost.Size = new System.Drawing.Size(134, 27);
            this.btnVideoMost.TabIndex = 14;
            this.btnVideoMost.Text = "Rated Movie";
            this.btnVideoMost.UseVisualStyleBackColor = false;
            this.btnVideoMost.Click += new System.EventHandler(this.btnVideoMost_Click);
            // 
            // btnCustomerMost
            // 
            this.btnCustomerMost.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCustomerMost.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerMost.Location = new System.Drawing.Point(445, 87);
            this.btnCustomerMost.Name = "btnCustomerMost";
            this.btnCustomerMost.Size = new System.Drawing.Size(158, 27);
            this.btnCustomerMost.TabIndex = 13;
            this.btnCustomerMost.Text = "Valuable Customer";
            this.btnCustomerMost.UseVisualStyleBackColor = false;
            this.btnCustomerMost.Click += new System.EventHandler(this.btnCustomerMost_Click);
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(656, 62);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(161, 20);
            this.dtpReturn.TabIndex = 12;
            // 
            // dtpIssue
            // 
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssue.Location = new System.Drawing.Point(471, 62);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(161, 20);
            this.dtpIssue.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(693, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 21);
            this.label15.TabIndex = 9;
            this.label15.Text = "Return Date";
            // 
            // BtnRentDelete
            // 
            this.BtnRentDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnRentDelete.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRentDelete.Location = new System.Drawing.Point(308, 87);
            this.BtnRentDelete.Name = "BtnRentDelete";
            this.BtnRentDelete.Size = new System.Drawing.Size(102, 27);
            this.BtnRentDelete.TabIndex = 8;
            this.BtnRentDelete.Text = "DELETE";
            this.BtnRentDelete.UseVisualStyleBackColor = false;
            this.BtnRentDelete.Click += new System.EventHandler(this.BtnRentDelete_Click);
            // 
            // btnVReturn
            // 
            this.btnVReturn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVReturn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVReturn.Location = new System.Drawing.Point(188, 85);
            this.btnVReturn.Name = "btnVReturn";
            this.btnVReturn.Size = new System.Drawing.Size(102, 27);
            this.btnVReturn.TabIndex = 7;
            this.btnVReturn.Text = "RETURN";
            this.btnVReturn.UseVisualStyleBackColor = false;
            this.btnVReturn.Click += new System.EventHandler(this.btnVReturn_Click);
            // 
            // btnVIssue
            // 
            this.btnVIssue.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVIssue.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIssue.Location = new System.Drawing.Point(68, 85);
            this.btnVIssue.Name = "btnVIssue";
            this.btnVIssue.Size = new System.Drawing.Size(103, 27);
            this.btnVIssue.TabIndex = 6;
            this.btnVIssue.Text = "ISSUE";
            this.btnVIssue.UseVisualStyleBackColor = false;
            this.btnVIssue.Click += new System.EventHandler(this.btnVIssue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(511, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Issue Date";
            // 
            // txtVId
            // 
            this.txtVId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVId.Location = new System.Drawing.Point(247, 37);
            this.txtVId.Name = "txtVId";
            this.txtVId.Size = new System.Drawing.Size(122, 32);
            this.txtVId.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(184, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "VD id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "CM id";
            // 
            // txtCId
            // 
            this.txtCId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCId.Location = new System.Drawing.Point(68, 34);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(110, 32);
            this.txtCId.TabIndex = 0;
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(6, 448);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(845, 210);
            this.dgvDetails.TabIndex = 10;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(907, 671);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.TextBox CContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVGenre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVPlot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVCopies;
        private System.Windows.Forms.TextBox txtVYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVRatting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVName;
        private System.Windows.Forms.Button btnVDelete;
        private System.Windows.Forms.Button btnVUpdate;
        private System.Windows.Forms.Button btnVAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVideoMost;
        private System.Windows.Forms.Button btnCustomerMost;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnRentDelete;
        private System.Windows.Forms.Button btnVReturn;
        private System.Windows.Forms.Button btnVIssue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnCDetails;
        private System.Windows.Forms.Button btnVDetails;
        private System.Windows.Forms.Button btnRDetails;
    }
}

