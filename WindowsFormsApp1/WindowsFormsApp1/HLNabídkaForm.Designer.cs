namespace WindowsFormsApp1
{
    partial class HLNabídkaForm
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
            this.BtnStorno = new System.Windows.Forms.Button();
            this.BtnEditUser = new System.Windows.Forms.Button();
            this.BtnEditRole = new System.Windows.Forms.Button();
            this.BtnEditEmployee = new System.Windows.Forms.Button();
            this.BtnEditContract = new System.Windows.Forms.Button();
            this.BtnEditWorkType = new System.Windows.Forms.Button();
            this.BtnEditWorkHour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStorno
            // 
            this.BtnStorno.Location = new System.Drawing.Point(12, 415);
            this.BtnStorno.Name = "BtnStorno";
            this.BtnStorno.Size = new System.Drawing.Size(75, 23);
            this.BtnStorno.TabIndex = 0;
            this.BtnStorno.Text = "Storno";
            this.BtnStorno.UseVisualStyleBackColor = true;
            this.BtnStorno.Click += new System.EventHandler(this.BtnStorno_Click);
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.Location = new System.Drawing.Point(12, 91);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(162, 23);
            this.BtnEditUser.TabIndex = 1;
            this.BtnEditUser.Text = "Nabídka uživatelů";
            this.BtnEditUser.UseVisualStyleBackColor = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // BtnEditRole
            // 
            this.BtnEditRole.Location = new System.Drawing.Point(12, 120);
            this.BtnEditRole.Name = "BtnEditRole";
            this.BtnEditRole.Size = new System.Drawing.Size(162, 23);
            this.BtnEditRole.TabIndex = 2;
            this.BtnEditRole.Text = "Nabídka rolí";
            this.BtnEditRole.UseVisualStyleBackColor = true;
            // 
            // BtnEditEmployee
            // 
            this.BtnEditEmployee.Location = new System.Drawing.Point(12, 149);
            this.BtnEditEmployee.Name = "BtnEditEmployee";
            this.BtnEditEmployee.Size = new System.Drawing.Size(162, 23);
            this.BtnEditEmployee.TabIndex = 3;
            this.BtnEditEmployee.Text = "Nabídka zaměstnanců";
            this.BtnEditEmployee.UseVisualStyleBackColor = true;
            this.BtnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // BtnEditContract
            // 
            this.BtnEditContract.Location = new System.Drawing.Point(12, 178);
            this.BtnEditContract.Name = "BtnEditContract";
            this.BtnEditContract.Size = new System.Drawing.Size(162, 23);
            this.BtnEditContract.TabIndex = 4;
            this.BtnEditContract.Text = "Nabídka zakázek";
            this.BtnEditContract.UseVisualStyleBackColor = true;
            this.BtnEditContract.Click += new System.EventHandler(this.BtnEditContract_Click);
            // 
            // BtnEditWorkType
            // 
            this.BtnEditWorkType.Location = new System.Drawing.Point(12, 207);
            this.BtnEditWorkType.Name = "BtnEditWorkType";
            this.BtnEditWorkType.Size = new System.Drawing.Size(162, 23);
            this.BtnEditWorkType.TabIndex = 5;
            this.BtnEditWorkType.Text = "Nabídka typů činností";
            this.BtnEditWorkType.UseVisualStyleBackColor = true;
            this.BtnEditWorkType.Click += new System.EventHandler(this.BtnEditWorkType_Click);
            // 
            // BtnEditWorkHour
            // 
            this.BtnEditWorkHour.Location = new System.Drawing.Point(12, 236);
            this.BtnEditWorkHour.Name = "BtnEditWorkHour";
            this.BtnEditWorkHour.Size = new System.Drawing.Size(162, 23);
            this.BtnEditWorkHour.TabIndex = 6;
            this.BtnEditWorkHour.Text = "Nabídka pracovních hodin";
            this.BtnEditWorkHour.UseVisualStyleBackColor = true;
            this.BtnEditWorkHour.Click += new System.EventHandler(this.BtnEditWorkHour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin menu";
            // 
            // HLNabídkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEditWorkHour);
            this.Controls.Add(this.BtnEditWorkType);
            this.Controls.Add(this.BtnEditContract);
            this.Controls.Add(this.BtnEditEmployee);
            this.Controls.Add(this.BtnEditRole);
            this.Controls.Add(this.BtnEditUser);
            this.Controls.Add(this.BtnStorno);
            this.Name = "HLNabídkaForm";
            this.Text = "HLNabídkaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStorno;
        private System.Windows.Forms.Button BtnEditUser;
        private System.Windows.Forms.Button BtnEditRole;
        private System.Windows.Forms.Button BtnEditEmployee;
        private System.Windows.Forms.Button BtnEditContract;
        private System.Windows.Forms.Button BtnEditWorkType;
        private System.Windows.Forms.Button BtnEditWorkHour;
        private System.Windows.Forms.Label label1;
    }
}