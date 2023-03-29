namespace WindowsFormsApp1
{
    partial class ContractList
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
            this.LWContract = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.LWContract.TabIndex = 31;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Storno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LWContract);
            this.Name = "ContractList";
            this.Text = "ContractList";
            this.Load += new System.EventHandler(this.ContractList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LWContract;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button button1;
    }
}