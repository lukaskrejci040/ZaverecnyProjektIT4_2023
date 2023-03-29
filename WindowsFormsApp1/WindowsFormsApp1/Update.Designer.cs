namespace WindowsFormsApp1
{
    partial class Update
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnStorno = new System.Windows.Forms.Button();
            this.TBEmployeeE = new System.Windows.Forms.TextBox();
            this.TBUserNameE = new System.Windows.Forms.TextBox();
            this.TBPasswordE = new System.Windows.Forms.TextBox();
            this.TBPasswordSaltE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TBAdminE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LWMain = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Heslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordSalt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(713, 422);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnStorno
            // 
            this.BtnStorno.Location = new System.Drawing.Point(12, 415);
            this.BtnStorno.Name = "BtnStorno";
            this.BtnStorno.Size = new System.Drawing.Size(75, 23);
            this.BtnStorno.TabIndex = 1;
            this.BtnStorno.Text = "Storno";
            this.BtnStorno.UseVisualStyleBackColor = true;
            this.BtnStorno.Click += new System.EventHandler(this.BtnStorno_Click);
            // 
            // TBEmployeeE
            // 
            this.TBEmployeeE.Location = new System.Drawing.Point(688, 292);
            this.TBEmployeeE.Name = "TBEmployeeE";
            this.TBEmployeeE.Size = new System.Drawing.Size(100, 20);
            this.TBEmployeeE.TabIndex = 2;
            this.TBEmployeeE.TextChanged += new System.EventHandler(this.TBEmployeeE_TextChanged);
            // 
            // TBUserNameE
            // 
            this.TBUserNameE.Location = new System.Drawing.Point(688, 318);
            this.TBUserNameE.Name = "TBUserNameE";
            this.TBUserNameE.Size = new System.Drawing.Size(100, 20);
            this.TBUserNameE.TabIndex = 3;
            // 
            // TBPasswordE
            // 
            this.TBPasswordE.Location = new System.Drawing.Point(688, 344);
            this.TBPasswordE.Name = "TBPasswordE";
            this.TBPasswordE.Size = new System.Drawing.Size(100, 20);
            this.TBPasswordE.TabIndex = 4;
            // 
            // TBPasswordSaltE
            // 
            this.TBPasswordSaltE.Location = new System.Drawing.Point(688, 370);
            this.TBPasswordSaltE.Name = "TBPasswordSaltE";
            this.TBPasswordSaltE.Size = new System.Drawing.Size(100, 20);
            this.TBPasswordSaltE.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jmeno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Heslo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "HesloSalt";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(668, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TBAdminE
            // 
            this.TBAdminE.Location = new System.Drawing.Point(688, 396);
            this.TBAdminE.Name = "TBAdminE";
            this.TBAdminE.Size = new System.Drawing.Size(100, 20);
            this.TBAdminE.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Admin? (True/False)";
            // 
            // LWMain
            // 
            this.LWMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Jmeno,
            this.Heslo,
            this.Password,
            this.PasswordSalt,
            this.Admin});
            this.LWMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWMain.FullRowSelect = true;
            this.LWMain.GridLines = true;
            this.LWMain.HideSelection = false;
            this.LWMain.Location = new System.Drawing.Point(0, 0);
            this.LWMain.Name = "LWMain";
            this.LWMain.Size = new System.Drawing.Size(800, 450);
            this.LWMain.TabIndex = 18;
            this.LWMain.UseCompatibleStateImageBehavior = false;
            this.LWMain.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 89;
            // 
            // Jmeno
            // 
            this.Jmeno.Text = "IdEmployee";
            this.Jmeno.Width = 87;
            // 
            // Heslo
            // 
            this.Heslo.Text = "Jmeno";
            this.Heslo.Width = 105;
            // 
            // Password
            // 
            this.Password.Text = "Heslo";
            // 
            // PasswordSalt
            // 
            this.PasswordSalt.Text = "HesloSalt";
            // 
            // Admin
            // 
            this.Admin.Text = "Admin?";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBAdminE);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPasswordSaltE);
            this.Controls.Add(this.TBPasswordE);
            this.Controls.Add(this.TBUserNameE);
            this.Controls.Add(this.TBEmployeeE);
            this.Controls.Add(this.BtnStorno);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LWMain);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnStorno;
        private System.Windows.Forms.TextBox TBEmployeeE;
        private System.Windows.Forms.TextBox TBUserNameE;
        private System.Windows.Forms.TextBox TBPasswordE;
        private System.Windows.Forms.TextBox TBPasswordSaltE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox TBAdminE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView LWMain;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Jmeno;
        private System.Windows.Forms.ColumnHeader Heslo;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader PasswordSalt;
        private System.Windows.Forms.ColumnHeader Admin;
    }
}