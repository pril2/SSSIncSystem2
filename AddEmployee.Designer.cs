
using System.Windows.Forms;

namespace SSSIncSystem
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSource = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.addEmployee_clearBtn = new System.Windows.Forms.Button();
            this.addEmployee_deleteBtn = new System.Windows.Forms.Button();
            this.addEmployee_updateBtn = new System.Windows.Forms.Button();
            this.addEmployee_addBtn = new System.Windows.Forms.Button();
            this.addEmployee_ImportBtn = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_dateresigned = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.addEmployee_datehired = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.addEmployee_cellphone = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.addEmployee_expirydate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.addEmployee_lisence = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addEmployee_assignmentdesignation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.addEmployee_cashcard = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addEmployee_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addEmployee_philhealth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addEmployee_pagibig = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addEmployee_tin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addEmployee_sss = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_middlename = new System.Windows.Forms.TextBox();
            this.addEmployee_firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1117, 669);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Securiforce Security Services Inc. Data";
            // 
            // DataSource
            // 
            this.DataSource.BackColor = System.Drawing.Color.White;
            this.DataSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataSource.Controls.Add(this.addEmployee_status);
            this.DataSource.Controls.Add(this.label21);
            this.DataSource.Controls.Add(this.addEmployee_clearBtn);
            this.DataSource.Controls.Add(this.addEmployee_deleteBtn);
            this.DataSource.Controls.Add(this.addEmployee_updateBtn);
            this.DataSource.Controls.Add(this.addEmployee_addBtn);
            this.DataSource.Controls.Add(this.addEmployee_ImportBtn);
            this.DataSource.Controls.Add(this.addEmployee_picture);
            this.DataSource.Controls.Add(this.addEmployee_dateresigned);
            this.DataSource.Controls.Add(this.label20);
            this.DataSource.Controls.Add(this.addEmployee_datehired);
            this.DataSource.Controls.Add(this.label19);
            this.DataSource.Controls.Add(this.label18);
            this.DataSource.Controls.Add(this.addEmployee_cellphone);
            this.DataSource.Controls.Add(this.label17);
            this.DataSource.Controls.Add(this.addEmployee_expirydate);
            this.DataSource.Controls.Add(this.label16);
            this.DataSource.Controls.Add(this.addEmployee_lisence);
            this.DataSource.Controls.Add(this.label15);
            this.DataSource.Controls.Add(this.label14);
            this.DataSource.Controls.Add(this.addEmployee_assignmentdesignation);
            this.DataSource.Controls.Add(this.label13);
            this.DataSource.Controls.Add(this.addEmployee_cashcard);
            this.DataSource.Controls.Add(this.label12);
            this.DataSource.Controls.Add(this.addEmployee_address);
            this.DataSource.Controls.Add(this.label11);
            this.DataSource.Controls.Add(this.addEmployee_philhealth);
            this.DataSource.Controls.Add(this.label10);
            this.DataSource.Controls.Add(this.addEmployee_pagibig);
            this.DataSource.Controls.Add(this.label9);
            this.DataSource.Controls.Add(this.addEmployee_tin);
            this.DataSource.Controls.Add(this.label8);
            this.DataSource.Controls.Add(this.addEmployee_sss);
            this.DataSource.Controls.Add(this.label7);
            this.DataSource.Controls.Add(this.label6);
            this.DataSource.Controls.Add(this.addEmployee_middlename);
            this.DataSource.Controls.Add(this.addEmployee_firstname);
            this.DataSource.Controls.Add(this.label5);
            this.DataSource.Controls.Add(this.label4);
            this.DataSource.Controls.Add(this.addEmployee_lastname);
            this.DataSource.Controls.Add(this.label3);
            this.DataSource.Controls.Add(this.addEmployee_id);
            this.DataSource.Controls.Add(this.label2);
            this.DataSource.Location = new System.Drawing.Point(36, 310);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(1078, 352);
            this.DataSource.TabIndex = 48;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(709, 234);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(194, 21);
            this.addEmployee_status.TabIndex = 87;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(650, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 15);
            this.label21.TabIndex = 86;
            this.label21.Text = "Status:";
            // 
            // addEmployee_clearBtn
            // 
            this.addEmployee_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clearBtn.Location = new System.Drawing.Point(966, 306);
            this.addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            this.addEmployee_clearBtn.Size = new System.Drawing.Size(102, 28);
            this.addEmployee_clearBtn.TabIndex = 85;
            this.addEmployee_clearBtn.Text = "CLEAR";
            this.addEmployee_clearBtn.UseVisualStyleBackColor = false;
            this.addEmployee_clearBtn.Click += new System.EventHandler(this.addEmployee_clearBtn_Click);
            // 
            // addEmployee_deleteBtn
            // 
            this.addEmployee_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_deleteBtn.Location = new System.Drawing.Point(847, 306);
            this.addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            this.addEmployee_deleteBtn.Size = new System.Drawing.Size(102, 28);
            this.addEmployee_deleteBtn.TabIndex = 84;
            this.addEmployee_deleteBtn.Text = "DELETE";
            this.addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            this.addEmployee_deleteBtn.Click += new System.EventHandler(this.addEmployee_deleteBtn_Click);
            // 
            // addEmployee_updateBtn
            // 
            this.addEmployee_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_updateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_updateBtn.Location = new System.Drawing.Point(730, 306);
            this.addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            this.addEmployee_updateBtn.Size = new System.Drawing.Size(102, 28);
            this.addEmployee_updateBtn.TabIndex = 83;
            this.addEmployee_updateBtn.Text = "UPDATE";
            this.addEmployee_updateBtn.UseVisualStyleBackColor = false;
            this.addEmployee_updateBtn.Click += new System.EventHandler(this.addEmployee_updateBtn_Click);
            // 
            // addEmployee_addBtn
            // 
            this.addEmployee_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addEmployee_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_addBtn.Location = new System.Drawing.Point(611, 306);
            this.addEmployee_addBtn.Name = "addEmployee_addBtn";
            this.addEmployee_addBtn.Size = new System.Drawing.Size(102, 28);
            this.addEmployee_addBtn.TabIndex = 82;
            this.addEmployee_addBtn.Text = "ADD";
            this.addEmployee_addBtn.UseVisualStyleBackColor = false;
            this.addEmployee_addBtn.Click += new System.EventHandler(this.addEmployee_addBtn_Click);
            // 
            // addEmployee_ImportBtn
            // 
            this.addEmployee_ImportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addEmployee_ImportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_ImportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployee_ImportBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_ImportBtn.Location = new System.Drawing.Point(913, 142);
            this.addEmployee_ImportBtn.Name = "addEmployee_ImportBtn";
            this.addEmployee_ImportBtn.Size = new System.Drawing.Size(133, 31);
            this.addEmployee_ImportBtn.TabIndex = 81;
            this.addEmployee_ImportBtn.Text = "Import";
            this.addEmployee_ImportBtn.UseVisualStyleBackColor = false;
            this.addEmployee_ImportBtn.Click += new System.EventHandler(this.addEmployee_ImportBtn_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.Color.DarkGray;
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(913, 19);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(133, 120);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 80;
            this.addEmployee_picture.TabStop = false;
            // 
            // addEmployee_dateresigned
            // 
            this.addEmployee_dateresigned.Location = new System.Drawing.Point(502, 269);
            this.addEmployee_dateresigned.Name = "addEmployee_dateresigned";
            this.addEmployee_dateresigned.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_dateresigned.TabIndex = 79;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(327, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 15);
            this.label20.TabIndex = 78;
            this.label20.Text = "Date Resigned/Separated:";
            // 
            // addEmployee_datehired
            // 
            this.addEmployee_datehired.Location = new System.Drawing.Point(414, 234);
            this.addEmployee_datehired.Name = "addEmployee_datehired";
            this.addEmployee_datehired.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_datehired.TabIndex = 77;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(327, 236);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 15);
            this.label19.TabIndex = 76;
            this.label19.Text = "Date Hired:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(395, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 15);
            this.label18.TabIndex = 75;
            this.label18.Text = "REMARKS";
            // 
            // addEmployee_cellphone
            // 
            this.addEmployee_cellphone.Location = new System.Drawing.Point(413, 176);
            this.addEmployee_cellphone.Name = "addEmployee_cellphone";
            this.addEmployee_cellphone.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_cellphone.TabIndex = 74;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(314, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 73;
            this.label17.Text = "ECel/Tel Nos. :";
            // 
            // addEmployee_expirydate
            // 
            this.addEmployee_expirydate.Location = new System.Drawing.Point(410, 151);
            this.addEmployee_expirydate.Name = "addEmployee_expirydate";
            this.addEmployee_expirydate.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_expirydate.TabIndex = 72;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(314, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 15);
            this.label16.TabIndex = 71;
            this.label16.Text = "Expiry Date:";
            // 
            // addEmployee_lisence
            // 
            this.addEmployee_lisence.Location = new System.Drawing.Point(410, 124);
            this.addEmployee_lisence.Name = "addEmployee_lisence";
            this.addEmployee_lisence.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_lisence.TabIndex = 70;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(314, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 15);
            this.label15.TabIndex = 69;
            this.label15.Text = "License No. :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(358, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 15);
            this.label14.TabIndex = 68;
            this.label14.Text = "SECURITY LICENSE INFO.";
            // 
            // addEmployee_assignmentdesignation
            // 
            this.addEmployee_assignmentdesignation.Location = new System.Drawing.Point(481, 59);
            this.addEmployee_assignmentdesignation.Name = "addEmployee_assignmentdesignation";
            this.addEmployee_assignmentdesignation.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_assignmentdesignation.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(300, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 15);
            this.label13.TabIndex = 66;
            this.label13.Text = "Assignment / Designation:";
            // 
            // addEmployee_cashcard
            // 
            this.addEmployee_cashcard.Location = new System.Drawing.Point(413, 22);
            this.addEmployee_cashcard.Name = "addEmployee_cashcard";
            this.addEmployee_cashcard.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_cashcard.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(300, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 64;
            this.label12.Text = "Cash Card No. :";
            // 
            // addEmployee_address
            // 
            this.addEmployee_address.Location = new System.Drawing.Point(86, 311);
            this.addEmployee_address.Name = "addEmployee_address";
            this.addEmployee_address.Size = new System.Drawing.Size(318, 20);
            this.addEmployee_address.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 62;
            this.label11.Text = "Address :";
            // 
            // addEmployee_philhealth
            // 
            this.addEmployee_philhealth.Location = new System.Drawing.Point(123, 271);
            this.addEmployee_philhealth.Name = "addEmployee_philhealth";
            this.addEmployee_philhealth.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_philhealth.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(10, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 60;
            this.label10.Text = "PhilHealth No. :";
            // 
            // addEmployee_pagibig
            // 
            this.addEmployee_pagibig.Location = new System.Drawing.Point(108, 236);
            this.addEmployee_pagibig.Name = "addEmployee_pagibig";
            this.addEmployee_pagibig.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_pagibig.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(10, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 58;
            this.label9.Text = "Pag-Ibig No. :";
            // 
            // addEmployee_tin
            // 
            this.addEmployee_tin.Location = new System.Drawing.Point(54, 203);
            this.addEmployee_tin.Name = "addEmployee_tin";
            this.addEmployee_tin.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_tin.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "TIN :";
            // 
            // addEmployee_sss
            // 
            this.addEmployee_sss.Location = new System.Drawing.Point(84, 174);
            this.addEmployee_sss.Name = "addEmployee_sss";
            this.addEmployee_sss.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_sss.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "SSS No. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(51, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "GOVERNMENT INFORMATION";
            // 
            // addEmployee_middlename
            // 
            this.addEmployee_middlename.Location = new System.Drawing.Point(112, 119);
            this.addEmployee_middlename.Name = "addEmployee_middlename";
            this.addEmployee_middlename.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_middlename.TabIndex = 52;
            // 
            // addEmployee_firstname
            // 
            this.addEmployee_firstname.Location = new System.Drawing.Point(99, 91);
            this.addEmployee_firstname.Name = "addEmployee_firstname";
            this.addEmployee_firstname.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_firstname.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "First Name:";
            // 
            // addEmployee_lastname
            // 
            this.addEmployee_lastname.Location = new System.Drawing.Point(99, 54);
            this.addEmployee_lastname.Name = "addEmployee_lastname";
            this.addEmployee_lastname.Size = new System.Drawing.Size(194, 20);
            this.addEmployee_lastname.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = " Last Name:";
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.Location = new System.Drawing.Point(72, 19);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(221, 20);
            this.addEmployee_id.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = " ID No. :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(36, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 247);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DataSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(1143, 696);
            this.DataSource.ResumeLayout(false);
            this.DataSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DataSource;
        private System.Windows.Forms.Button addEmployee_clearBtn;
        private System.Windows.Forms.Button addEmployee_deleteBtn;
        private System.Windows.Forms.Button addEmployee_updateBtn;
        private System.Windows.Forms.Button addEmployee_addBtn;
        private System.Windows.Forms.Button addEmployee_ImportBtn;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.DateTimePicker addEmployee_dateresigned;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker addEmployee_datehired;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox addEmployee_cellphone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker addEmployee_expirydate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox addEmployee_lisence;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addEmployee_assignmentdesignation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addEmployee_cashcard;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox addEmployee_address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addEmployee_philhealth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addEmployee_pagibig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addEmployee_tin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addEmployee_sss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addEmployee_middlename;
        private System.Windows.Forms.TextBox addEmployee_firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label21;
        private PaintEventHandler dataGridView1_Paint;
        private DataGridView dataGridView1;
    }
}
