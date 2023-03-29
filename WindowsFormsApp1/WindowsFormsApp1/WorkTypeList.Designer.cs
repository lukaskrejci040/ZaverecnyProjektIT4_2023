namespace WindowsFormsApp1
{
    partial class WorkTypeList
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
            this.LWWorkType = new System.Windows.Forms.ListView();
            this.IdWorkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionWorkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LWWorkType
            // 
            this.LWWorkType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdWorkType,
            this.Name,
            this.DescriptionWorkType});
            this.LWWorkType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWWorkType.FullRowSelect = true;
            this.LWWorkType.GridLines = true;
            this.LWWorkType.HideSelection = false;
            this.LWWorkType.Location = new System.Drawing.Point(0, 0);
            this.LWWorkType.Name = "LWWorkType";
            this.LWWorkType.Size = new System.Drawing.Size(800, 450);
            this.LWWorkType.TabIndex = 63;
            this.LWWorkType.UseCompatibleStateImageBehavior = false;
            this.LWWorkType.View = System.Windows.Forms.View.Details;
            // 
            // IdWorkType
            // 
            this.IdWorkType.Text = "Id";
            // 
            // Name
            // 
            this.Name.Text = "Název činnosti";
            this.Name.Width = 154;
            // 
            // DescriptionWorkType
            // 
            this.DescriptionWorkType.Text = "Popis ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "Storno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorkTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LWWorkType);
            
            this.Text = "WorkTypeList";
            this.Load += new System.EventHandler(this.WorkTypeList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LWWorkType;
        private System.Windows.Forms.ColumnHeader IdWorkType;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader DescriptionWorkType;
        private System.Windows.Forms.Button button1;
    }
}