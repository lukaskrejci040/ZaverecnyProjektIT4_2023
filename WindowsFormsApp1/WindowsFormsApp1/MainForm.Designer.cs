namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.LWMain = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Heslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordSalt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBDelete = new System.Windows.Forms.TextBox();
            this.TBIdEmployee = new System.Windows.Forms.TextBox();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBPasswordSalt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TBAdmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.LWMain.TabIndex = 0;
            this.LWMain.UseCompatibleStateImageBehavior = false;
            this.LWMain.View = System.Windows.Forms.View.Details;
            this.LWMain.SelectedIndexChanged += new System.EventHandler(this.LWMain_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odstraň";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odstraň toto ID";
            // 
            // TBDelete
            // 
            this.TBDelete.Location = new System.Drawing.Point(688, 378);
            this.TBDelete.Name = "TBDelete";
            this.TBDelete.Size = new System.Drawing.Size(100, 20);
            this.TBDelete.TabIndex = 3;
            // 
            // TBIdEmployee
            // 
            this.TBIdEmployee.Location = new System.Drawing.Point(688, 69);
            this.TBIdEmployee.Name = "TBIdEmployee";
            this.TBIdEmployee.Size = new System.Drawing.Size(100, 20);
            this.TBIdEmployee.TabIndex = 4;
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(688, 95);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(100, 20);
            this.TBUserName.TabIndex = 5;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(688, 121);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 6;
            // 
            // TBPasswordSalt
            // 
            this.TBPasswordSalt.Location = new System.Drawing.Point(688, 147);
            this.TBPasswordSalt.Name = "TBPasswordSalt";
            this.TBPasswordSalt.Size = new System.Drawing.Size(100, 20);
            this.TBPasswordSalt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Přidání uživatele";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Okrasné pole";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(697, 198);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 13;
            this.BtnInsert.Text = "Pridat";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(697, 271);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Editace";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TBAdmin
            // 
            this.TBAdmin.Location = new System.Drawing.Point(688, 172);
            this.TBAdmin.Name = "TBAdmin";
            this.TBAdmin.Size = new System.Drawing.Size(100, 20);
            this.TBAdmin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Admin? (True/False)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBAdmin);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBPasswordSalt);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.TBIdEmployee);
            this.Controls.Add(this.TBDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LWMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LWMain;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Jmeno;
        private System.Windows.Forms.ColumnHeader Heslo;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader PasswordSalt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBDelete;
        private System.Windows.Forms.TextBox TBIdEmployee;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBPasswordSalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TBAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader Admin;
    }
}