namespace Report
{
    partial class Form_Treatment
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdPatient = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtWaitingTime = new System.Windows.Forms.TextBox();
            this.TxtDiagnosis = new System.Windows.Forms.TextBox();
            this.TxtTreatment = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonListPatient = new System.Windows.Forms.Button();
            this.TxtIdTreatment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgTreatment = new System.Windows.Forms.DataGridView();
            this.txtBerthday = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(125, 403);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 44);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(291, 403);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(151, 44);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(465, 403);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(151, 44);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(636, 403);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(151, 44);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diagnosis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wateing Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Treatment";
            // 
            // TxtIdPatient
            // 
            this.TxtIdPatient.Location = new System.Drawing.Point(206, 45);
            this.TxtIdPatient.Name = "TxtIdPatient";
            this.TxtIdPatient.Size = new System.Drawing.Size(490, 22);
            this.TxtIdPatient.TabIndex = 9;
            this.TxtIdPatient.Text = "1";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(206, 171);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(490, 22);
            this.TxtAge.TabIndex = 10;
            this.TxtAge.Text = "18";
            // 
            // TxtWaitingTime
            // 
            this.TxtWaitingTime.Location = new System.Drawing.Point(206, 209);
            this.TxtWaitingTime.Name = "TxtWaitingTime";
            this.TxtWaitingTime.Size = new System.Drawing.Size(490, 22);
            this.TxtWaitingTime.TabIndex = 11;
            this.TxtWaitingTime.Text = "30";
            // 
            // TxtDiagnosis
            // 
            this.TxtDiagnosis.Location = new System.Drawing.Point(206, 249);
            this.TxtDiagnosis.Name = "TxtDiagnosis";
            this.TxtDiagnosis.Size = new System.Drawing.Size(490, 22);
            this.TxtDiagnosis.TabIndex = 12;
            this.TxtDiagnosis.Text = "Fieber";
            // 
            // TxtTreatment
            // 
            this.TxtTreatment.Location = new System.Drawing.Point(206, 290);
            this.TxtTreatment.Multiline = true;
            this.TxtTreatment.Name = "TxtTreatment";
            this.TxtTreatment.Size = new System.Drawing.Size(490, 107);
            this.TxtTreatment.TabIndex = 13;
            this.TxtTreatment.Text = "3 Tage zu Hause";
            // 
            // buttonListPatient
            // 
            this.buttonListPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListPatient.Location = new System.Drawing.Point(709, 40);
            this.buttonListPatient.Margin = new System.Windows.Forms.Padding(10);
            this.buttonListPatient.Name = "buttonListPatient";
            this.buttonListPatient.Size = new System.Drawing.Size(113, 31);
            this.buttonListPatient.TabIndex = 14;
            this.buttonListPatient.Text = "List Patient";
            this.buttonListPatient.UseVisualStyleBackColor = true;
            this.buttonListPatient.Click += new System.EventHandler(this.buttonListPatient_Click);
            // 
            // TxtIdTreatment
            // 
            this.TxtIdTreatment.Location = new System.Drawing.Point(206, 12);
            this.TxtIdTreatment.Name = "TxtIdTreatment";
            this.TxtIdTreatment.Size = new System.Drawing.Size(490, 22);
            this.TxtIdTreatment.TabIndex = 16;
            this.TxtIdTreatment.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id Treatment";
            // 
            // dgTreatment
            // 
            this.dgTreatment.AllowUserToAddRows = false;
            this.dgTreatment.AllowUserToDeleteRows = false;
            this.dgTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTreatment.Location = new System.Drawing.Point(12, 460);
            this.dgTreatment.Name = "dgTreatment";
            this.dgTreatment.ReadOnly = true;
            this.dgTreatment.RowHeadersWidth = 51;
            this.dgTreatment.RowTemplate.Height = 24;
            this.dgTreatment.Size = new System.Drawing.Size(854, 202);
            this.dgTreatment.TabIndex = 17;
            this.dgTreatment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTreatment_CellClick);
            this.dgTreatment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTreatment_CellContentClick);
            // 
            // txtBerthday
            // 
            this.txtBerthday.Location = new System.Drawing.Point(206, 140);
            this.txtBerthday.Name = "txtBerthday";
            this.txtBerthday.Size = new System.Drawing.Size(327, 22);
            this.txtBerthday.TabIndex = 20;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(206, 109);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(327, 22);
            this.txtLastname.TabIndex = 19;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(206, 77);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(327, 22);
            this.txtFirstname.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Berthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Lastname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Firstname";
            // 
            // Form_Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 674);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBerthday);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.dgTreatment);
            this.Controls.Add(this.TxtIdTreatment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonListPatient);
            this.Controls.Add(this.TxtTreatment);
            this.Controls.Add(this.TxtDiagnosis);
            this.Controls.Add(this.TxtWaitingTime);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtIdPatient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form_Treatment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Treatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTreatment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdPatient;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtWaitingTime;
        private System.Windows.Forms.TextBox TxtDiagnosis;
        private System.Windows.Forms.TextBox TxtTreatment;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonListPatient;
        private System.Windows.Forms.TextBox TxtIdTreatment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgTreatment;
        private System.Windows.Forms.TextBox txtBerthday;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

