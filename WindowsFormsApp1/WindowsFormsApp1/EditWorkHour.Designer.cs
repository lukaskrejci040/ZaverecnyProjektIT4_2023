namespace WindowsFormsApp1
{
    partial class EditWorkHour
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TBKdyE = new System.Windows.Forms.TextBox();
            this.TBHourE = new System.Windows.Forms.TextBox();
            this.TBWorkTypeE = new System.Windows.Forms.TextBox();
            this.TBContractE = new System.Windows.Forms.TextBox();
            this.TBEmployeeE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NUDID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBKdy = new System.Windows.Forms.TextBox();
            this.TBHour = new System.Windows.Forms.TextBox();
            this.TBWorkType = new System.Windows.Forms.TextBox();
            this.TBContract = new System.Windows.Forms.TextBox();
            this.TBEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBDelete = new System.Windows.Forms.TextBox();
            this.LWWorkHour = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kdy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(681, 353);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(107, 24);
            this.BtnEdit.TabIndex = 59;
            this.BtnEdit.Text = "Přepiš záznam";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TBKdyE
            // 
            this.TBKdyE.Location = new System.Drawing.Point(688, 327);
            this.TBKdyE.Name = "TBKdyE";
            this.TBKdyE.Size = new System.Drawing.Size(100, 20);
            this.TBKdyE.TabIndex = 53;
            // 
            // TBHourE
            // 
            this.TBHourE.Location = new System.Drawing.Point(688, 301);
            this.TBHourE.Name = "TBHourE";
            this.TBHourE.Size = new System.Drawing.Size(100, 20);
            this.TBHourE.TabIndex = 52;
            // 
            // TBWorkTypeE
            // 
            this.TBWorkTypeE.Location = new System.Drawing.Point(688, 275);
            this.TBWorkTypeE.Name = "TBWorkTypeE";
            this.TBWorkTypeE.Size = new System.Drawing.Size(100, 20);
            this.TBWorkTypeE.TabIndex = 51;
            // 
            // TBContractE
            // 
            this.TBContractE.Location = new System.Drawing.Point(688, 249);
            this.TBContractE.Name = "TBContractE";
            this.TBContractE.Size = new System.Drawing.Size(100, 20);
            this.TBContractE.TabIndex = 50;
            // 
            // TBEmployeeE
            // 
            this.TBEmployeeE.Location = new System.Drawing.Point(688, 223);
            this.TBEmployeeE.Name = "TBEmployeeE";
            this.TBEmployeeE.Size = new System.Drawing.Size(100, 20);
            this.TBEmployeeE.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Id editovaného záznamu";
            // 
            // NUDID
            // 
            this.NUDID.Location = new System.Drawing.Point(668, 197);
            this.NUDID.Name = "NUDID";
            this.NUDID.Size = new System.Drawing.Size(120, 20);
            this.NUDID.TabIndex = 47;
            this.NUDID.ValueChanged += new System.EventHandler(this.NUDID_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Editace záznamů";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(706, 155);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 45;
            this.BtnInsert.Text = "Přidat";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Kdy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "WorkType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Contract";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Employee";
            // 
            // TBKdy
            // 
            this.TBKdy.Location = new System.Drawing.Point(688, 129);
            this.TBKdy.Name = "TBKdy";
            this.TBKdy.Size = new System.Drawing.Size(100, 20);
            this.TBKdy.TabIndex = 39;
            // 
            // TBHour
            // 
            this.TBHour.Location = new System.Drawing.Point(688, 103);
            this.TBHour.Name = "TBHour";
            this.TBHour.Size = new System.Drawing.Size(100, 20);
            this.TBHour.TabIndex = 38;
            // 
            // TBWorkType
            // 
            this.TBWorkType.Location = new System.Drawing.Point(688, 77);
            this.TBWorkType.Name = "TBWorkType";
            this.TBWorkType.Size = new System.Drawing.Size(100, 20);
            this.TBWorkType.TabIndex = 37;
            // 
            // TBContract
            // 
            this.TBContract.Location = new System.Drawing.Point(688, 51);
            this.TBContract.Name = "TBContract";
            this.TBContract.Size = new System.Drawing.Size(100, 20);
            this.TBContract.TabIndex = 36;
            // 
            // TBEmployee
            // 
            this.TBEmployee.Location = new System.Drawing.Point(688, 25);
            this.TBEmployee.Name = "TBEmployee";
            this.TBEmployee.Size = new System.Drawing.Size(100, 20);
            this.TBEmployee.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Přídání hodnoty";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(713, 415);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 33;
            this.BtnDelete.Text = "Smazat";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Smaž toto ID";
            // 
            // TBDelete
            // 
            this.TBDelete.Location = new System.Drawing.Point(688, 389);
            this.TBDelete.Name = "TBDelete";
            this.TBDelete.Size = new System.Drawing.Size(100, 20);
            this.TBDelete.TabIndex = 31;
            // 
            // LWWorkHour
            // 
            this.LWWorkHour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Employee,
            this.Contract,
            this.WorkType,
            this.Hour,
            this.Kdy});
            this.LWWorkHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWWorkHour.FullRowSelect = true;
            this.LWWorkHour.GridLines = true;
            this.LWWorkHour.HideSelection = false;
            this.LWWorkHour.Location = new System.Drawing.Point(0, 0);
            this.LWWorkHour.Name = "LWWorkHour";
            this.LWWorkHour.Size = new System.Drawing.Size(800, 450);
            this.LWWorkHour.TabIndex = 30;
            this.LWWorkHour.UseCompatibleStateImageBehavior = false;
            this.LWWorkHour.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Employee
            // 
            this.Employee.Text = "Employee";
            this.Employee.Width = 82;
            // 
            // Contract
            // 
            this.Contract.Text = "Contract";
            this.Contract.Width = 89;
            // 
            // WorkType
            // 
            this.WorkType.Text = "Typ činnosti";
            this.WorkType.Width = 88;
            // 
            // Hour
            // 
            this.Hour.Text = "Hour";
            this.Hour.Width = 73;
            // 
            // Kdy
            // 
            this.Kdy.Text = "Kdy";
            this.Kdy.Width = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Employee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(634, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Contract";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(623, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "WorkType";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(650, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Hour";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(650, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Kdy";
            // 
            // EditWorkHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TBKdyE);
            this.Controls.Add(this.TBHourE);
            this.Controls.Add(this.TBWorkTypeE);
            this.Controls.Add(this.TBContractE);
            this.Controls.Add(this.TBEmployeeE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NUDID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBKdy);
            this.Controls.Add(this.TBHour);
            this.Controls.Add(this.TBWorkType);
            this.Controls.Add(this.TBContract);
            this.Controls.Add(this.TBEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDelete);
            this.Controls.Add(this.LWWorkHour);
            this.Name = "EditWorkHour";
            this.Text = "EditWorkHour";
            this.Load += new System.EventHandler(this.EditWorkHour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TBKdyE;
        private System.Windows.Forms.TextBox TBHourE;
        private System.Windows.Forms.TextBox TBWorkTypeE;
        private System.Windows.Forms.TextBox TBContractE;
        private System.Windows.Forms.TextBox TBEmployeeE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUDID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBKdy;
        private System.Windows.Forms.TextBox TBHour;
        private System.Windows.Forms.TextBox TBWorkType;
        private System.Windows.Forms.TextBox TBContract;
        private System.Windows.Forms.TextBox TBEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBDelete;
        private System.Windows.Forms.ListView LWWorkHour;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Employee;
        private System.Windows.Forms.ColumnHeader Contract;
        private System.Windows.Forms.ColumnHeader WorkType;
        private System.Windows.Forms.ColumnHeader Hour;
        private System.Windows.Forms.ColumnHeader Kdy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}