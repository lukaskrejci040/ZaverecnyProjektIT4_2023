namespace WindowsFormsApp1
{
    partial class EditEmployee
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
            this.LWEmployee = new System.Windows.Forms.ListView();
            this.IdEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBBirthDate = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NUDID = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.TBFirstNameEdit = new System.Windows.Forms.TextBox();
            this.TBLastNameEdit = new System.Windows.Forms.TextBox();
            this.TBBirthDateEdit = new System.Windows.Forms.TextBox();
            this.TBEmailEdit = new System.Windows.Forms.TextBox();
            this.TBPhoneEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).BeginInit();
            this.SuspendLayout();
            // 
            // LWEmployee
            // 
            this.LWEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdEmployee,
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.Email,
            this.Phone});
            this.LWEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWEmployee.FullRowSelect = true;
            this.LWEmployee.GridLines = true;
            this.LWEmployee.HideSelection = false;
            this.LWEmployee.Location = new System.Drawing.Point(0, 0);
            this.LWEmployee.Name = "LWEmployee";
            this.LWEmployee.Size = new System.Drawing.Size(800, 450);
            this.LWEmployee.TabIndex = 0;
            this.LWEmployee.UseCompatibleStateImageBehavior = false;
            this.LWEmployee.View = System.Windows.Forms.View.Details;
            // 
            // IdEmployee
            // 
            this.IdEmployee.Text = "IdEmployee";
            this.IdEmployee.Width = 82;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Křestní jméno";
            this.FirstName.Width = 96;
            // 
            // LastName
            // 
            this.LastName.Text = "Příjmení";
            this.LastName.Width = 61;
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "Datum narození";
            this.BirthDate.Width = 95;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 115;
            // 
            // Phone
            // 
            this.Phone.Text = "Tel. číslo";
            // 
            // TBDelete
            // 
            this.TBDelete.Location = new System.Drawing.Point(688, 389);
            this.TBDelete.Name = "TBDelete";
            this.TBDelete.Size = new System.Drawing.Size(100, 20);
            this.TBDelete.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Smaž toto ID";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(713, 415);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Smazat";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Přídání hodnoty";
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(688, 25);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(100, 20);
            this.TBFirstName.TabIndex = 5;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(688, 51);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(100, 20);
            this.TBLastName.TabIndex = 6;
            // 
            // TBBirthDate
            // 
            this.TBBirthDate.Location = new System.Drawing.Point(688, 77);
            this.TBBirthDate.Name = "TBBirthDate";
            this.TBBirthDate.Size = new System.Drawing.Size(100, 20);
            this.TBBirthDate.TabIndex = 7;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(688, 103);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 8;
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(688, 129);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(100, 20);
            this.TBPhone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jmeno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Příjmení";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum narození (dd.mm.yyyy h:mm:ss)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(706, 155);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 15;
            this.BtnInsert.Text = "Přidat";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Editace záznamů";
            // 
            // NUDID
            // 
            this.NUDID.Location = new System.Drawing.Point(668, 197);
            this.NUDID.Name = "NUDID";
            this.NUDID.Size = new System.Drawing.Size(120, 20);
            this.NUDID.TabIndex = 17;
            this.NUDID.ValueChanged += new System.EventHandler(this.NUDID_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Id editovaného záznamu";
            // 
            // TBFirstNameEdit
            // 
            this.TBFirstNameEdit.Location = new System.Drawing.Point(688, 223);
            this.TBFirstNameEdit.Name = "TBFirstNameEdit";
            this.TBFirstNameEdit.Size = new System.Drawing.Size(100, 20);
            this.TBFirstNameEdit.TabIndex = 19;
            // 
            // TBLastNameEdit
            // 
            this.TBLastNameEdit.Location = new System.Drawing.Point(688, 249);
            this.TBLastNameEdit.Name = "TBLastNameEdit";
            this.TBLastNameEdit.Size = new System.Drawing.Size(100, 20);
            this.TBLastNameEdit.TabIndex = 20;
            // 
            // TBBirthDateEdit
            // 
            this.TBBirthDateEdit.Location = new System.Drawing.Point(688, 275);
            this.TBBirthDateEdit.Name = "TBBirthDateEdit";
            this.TBBirthDateEdit.Size = new System.Drawing.Size(100, 20);
            this.TBBirthDateEdit.TabIndex = 21;
            // 
            // TBEmailEdit
            // 
            this.TBEmailEdit.Location = new System.Drawing.Point(688, 301);
            this.TBEmailEdit.Name = "TBEmailEdit";
            this.TBEmailEdit.Size = new System.Drawing.Size(100, 20);
            this.TBEmailEdit.TabIndex = 22;
            // 
            // TBPhoneEdit
            // 
            this.TBPhoneEdit.Location = new System.Drawing.Point(688, 327);
            this.TBPhoneEdit.Name = "TBPhoneEdit";
            this.TBPhoneEdit.Size = new System.Drawing.Size(100, 20);
            this.TBPhoneEdit.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Jméno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(634, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Příjmení";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(495, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Datum narození (dd.mm.yyyy h:mm:ss)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(650, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(644, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Phone";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(681, 353);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(107, 24);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "Přepiš záznam";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBPhoneEdit);
            this.Controls.Add(this.TBEmailEdit);
            this.Controls.Add(this.TBBirthDateEdit);
            this.Controls.Add(this.TBLastNameEdit);
            this.Controls.Add(this.TBFirstNameEdit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NUDID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBBirthDate);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDelete);
            this.Controls.Add(this.LWEmployee);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LWEmployee;
        private System.Windows.Forms.ColumnHeader IdEmployee;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.TextBox TBDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.TextBox TBBirthDate;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUDID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBFirstNameEdit;
        private System.Windows.Forms.TextBox TBLastNameEdit;
        private System.Windows.Forms.TextBox TBBirthDateEdit;
        private System.Windows.Forms.TextBox TBEmailEdit;
        private System.Windows.Forms.TextBox TBPhoneEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnEdit;
    }
}