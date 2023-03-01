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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBDelete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LWMain
            // 
            this.LWMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Jmeno,
            this.Heslo,
            this.columnHeader1,
            this.columnHeader2});
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
            this.Jmeno.Text = "Jmeno";
            this.Jmeno.Width = 87;
            // 
            // Heslo
            // 
            this.Heslo.Text = "Heslo";
            this.Heslo.Width = 105;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBDelete;
    }
}