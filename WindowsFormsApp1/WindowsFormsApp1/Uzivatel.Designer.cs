namespace WindowsFormsApp1
{
    partial class Uzivatel
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
            this.label3 = new System.Windows.Forms.Label();
            this.TBWorkTypeE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NUDID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBWorkType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBDelete = new System.Windows.Forms.TextBox();
            this.LblUziv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NUDHour = new System.Windows.Forms.NumericUpDown();
            this.NUDHourE = new System.Windows.Forms.NumericUpDown();
            this.TBContract = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TBContractE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LWUziv = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PracovniDoba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHourE)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "WorkType";
            // 
            // TBWorkTypeE
            // 
            this.TBWorkTypeE.Location = new System.Drawing.Point(688, 248);
            this.TBWorkTypeE.Name = "TBWorkTypeE";
            this.TBWorkTypeE.Size = new System.Drawing.Size(100, 20);
            this.TBWorkTypeE.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Id editovaného záznamu";
            // 
            // NUDID
            // 
            this.NUDID.Location = new System.Drawing.Point(668, 198);
            this.NUDID.Name = "NUDID";
            this.NUDID.Size = new System.Drawing.Size(120, 20);
            this.NUDID.TabIndex = 109;
            this.NUDID.ValueChanged += new System.EventHandler(this.NUDID_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Editace záznamů";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(713, 102);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 107;
            this.BtnInsert.Text = "Přidat";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "WorkType";
            // 
            // TBWorkType
            // 
            this.TBWorkType.Location = new System.Drawing.Point(688, 26);
            this.TBWorkType.Name = "TBWorkType";
            this.TBWorkType.Size = new System.Drawing.Size(100, 20);
            this.TBWorkType.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Přídání hodnoty";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(681, 301);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(107, 24);
            this.BtnEdit.TabIndex = 98;
            this.BtnEdit.Text = "Přepiš záznam";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(713, 415);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 96;
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
            this.label1.TabIndex = 95;
            this.label1.Text = "Smaž toto ID";
            // 
            // TBDelete
            // 
            this.TBDelete.Location = new System.Drawing.Point(688, 389);
            this.TBDelete.Name = "TBDelete";
            this.TBDelete.Size = new System.Drawing.Size(100, 20);
            this.TBDelete.TabIndex = 94;
            // 
            // LblUziv
            // 
            this.LblUziv.AutoSize = true;
            this.LblUziv.Location = new System.Drawing.Point(510, 10);
            this.LblUziv.Name = "LblUziv";
            this.LblUziv.Size = new System.Drawing.Size(62, 13);
            this.LblUziv.TabIndex = 115;
            this.LblUziv.Text = "Sample text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "Zobrazeni Typů práce";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NUDHour
            // 
            this.NUDHour.Location = new System.Drawing.Point(688, 76);
            this.NUDHour.Name = "NUDHour";
            this.NUDHour.Size = new System.Drawing.Size(100, 20);
            this.NUDHour.TabIndex = 117;
            // 
            // NUDHourE
            // 
            this.NUDHourE.Location = new System.Drawing.Point(688, 224);
            this.NUDHourE.Name = "NUDHourE";
            this.NUDHourE.Size = new System.Drawing.Size(100, 20);
            this.NUDHourE.TabIndex = 118;
            // 
            // TBContract
            // 
            this.TBContract.Location = new System.Drawing.Point(688, 52);
            this.TBContract.Name = "TBContract";
            this.TBContract.Size = new System.Drawing.Size(100, 20);
            this.TBContract.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Contract";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 121;
            this.button2.Text = "Zobrazeni kontraktů";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBContractE
            // 
            this.TBContractE.Location = new System.Drawing.Point(688, 274);
            this.TBContractE.Name = "TBContractE";
            this.TBContractE.Size = new System.Drawing.Size(100, 20);
            this.TBContractE.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 123;
            this.label7.Text = "Contract";
            // 
            // LWUziv
            // 
            this.LWUziv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.WorkType,
            this.PracovniDoba,
            this.Datum,
            this.Contract});
            this.LWUziv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWUziv.FullRowSelect = true;
            this.LWUziv.GridLines = true;
            this.LWUziv.HideSelection = false;
            this.LWUziv.Location = new System.Drawing.Point(0, 0);
            this.LWUziv.Name = "LWUziv";
            this.LWUziv.Size = new System.Drawing.Size(800, 450);
            this.LWUziv.TabIndex = 124;
            this.LWUziv.UseCompatibleStateImageBehavior = false;
            this.LWUziv.View = System.Windows.Forms.View.Details;
            this.LWUziv.SelectedIndexChanged += new System.EventHandler(this.LWUziv_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id Práce";
            this.Id.Width = 63;
            // 
            // WorkType
            // 
            this.WorkType.Text = "Contract";
            this.WorkType.Width = 85;
            // 
            // PracovniDoba
            // 
            this.PracovniDoba.Text = "Typ práce";
            this.PracovniDoba.Width = 83;
            // 
            // Datum
            // 
            this.Datum.Text = "Pracovní doba";
            this.Datum.Width = 141;
            // 
            // Contract
            // 
            this.Contract.Text = "Datum činnosti";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(650, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 125;
            this.label10.Text = "Hour";
            // 
            // Uzivatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBContractE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBContract);
            this.Controls.Add(this.NUDHourE);
            this.Controls.Add(this.NUDHour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblUziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBWorkTypeE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NUDID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBWorkType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDelete);
            this.Controls.Add(this.LWUziv);
            this.Name = "Uzivatel";
            this.Text = "Uzivatel";
            this.Load += new System.EventHandler(this.Uzivatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHourE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBWorkTypeE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUDID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBWorkType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBDelete;
        private System.Windows.Forms.Label LblUziv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NUDHour;
        private System.Windows.Forms.NumericUpDown NUDHourE;
        private System.Windows.Forms.TextBox TBContract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBContractE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView LWUziv;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader WorkType;
        private System.Windows.Forms.ColumnHeader PracovniDoba;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Contract;
        private System.Windows.Forms.Label label10;
    }
}