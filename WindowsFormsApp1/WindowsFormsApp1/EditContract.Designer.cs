namespace WindowsFormsApp1
{
    partial class EditContract
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBDescriptionEdit = new System.Windows.Forms.TextBox();
            this.TBCustomerEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NUDID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.TBCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBDelete = new System.Windows.Forms.TextBox();
            this.LWContract = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(681, 275);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(107, 24);
            this.BtnEdit.TabIndex = 59;
            this.BtnEdit.Text = "Přepiš záznam";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(644, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Popis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Zákazník";
            // 
            // TBDescriptionEdit
            // 
            this.TBDescriptionEdit.Location = new System.Drawing.Point(688, 249);
            this.TBDescriptionEdit.Name = "TBDescriptionEdit";
            this.TBDescriptionEdit.Size = new System.Drawing.Size(100, 20);
            this.TBDescriptionEdit.TabIndex = 50;
            // 
            // TBCustomerEdit
            // 
            this.TBCustomerEdit.Location = new System.Drawing.Point(688, 223);
            this.TBCustomerEdit.Name = "TBCustomerEdit";
            this.TBCustomerEdit.Size = new System.Drawing.Size(100, 20);
            this.TBCustomerEdit.TabIndex = 49;
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
            this.BtnInsert.Location = new System.Drawing.Point(706, 77);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 45;
            this.BtnInsert.Text = "Přidat";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(688, 51);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(100, 20);
            this.TBDescription.TabIndex = 36;
            // 
            // TBCustomer
            // 
            this.TBCustomer.Location = new System.Drawing.Point(688, 25);
            this.TBCustomer.Name = "TBCustomer";
            this.TBCustomer.Size = new System.Drawing.Size(100, 20);
            this.TBCustomer.TabIndex = 35;
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
            // LWContract
            // 
            this.LWContract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Customer,
            this.Description});
            this.LWContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWContract.FullRowSelect = true;
            this.LWContract.GridLines = true;
            this.LWContract.HideSelection = false;
            this.LWContract.Location = new System.Drawing.Point(0, 0);
            this.LWContract.Name = "LWContract";
            this.LWContract.Size = new System.Drawing.Size(800, 450);
            this.LWContract.TabIndex = 30;
            this.LWContract.UseCompatibleStateImageBehavior = false;
            this.LWContract.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Customer
            // 
            this.Customer.Text = "Zákazník";
            // 
            // Description
            // 
            this.Description.Text = "Popis";
            this.Description.Width = 312;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Zákazník";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Popis";
            // 
            // EditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBDescriptionEdit);
            this.Controls.Add(this.TBCustomerEdit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NUDID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.TBCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDelete);
            this.Controls.Add(this.LWContract);
            this.Name = "EditContract";
            this.Text = "EditContract";
            this.Load += new System.EventHandler(this.EditContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBDescriptionEdit;
        private System.Windows.Forms.TextBox TBCustomerEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUDID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.TextBox TBCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBDelete;
        private System.Windows.Forms.ListView LWContract;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}