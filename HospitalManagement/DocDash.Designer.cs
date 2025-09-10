namespace HospitalManagement
{
    partial class DocDash
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
            this.components = new System.ComponentModel.Container();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDBDataSet1 = new HospitalManagement.HospitalDBDataSet1();
            this.usersTableAdapter = new HospitalManagement.HospitalDBDataSet1TableAdapters.UsersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.AddMedRec = new System.Windows.Forms.Button();
            this.UpMedRec = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hospitalDBDataSet1;
            // 
            // hospitalDBDataSet1
            // 
            this.hospitalDBDataSet1.DataSetName = "HospitalDBDataSet1";
            this.hospitalDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddMedRec
            // 
            this.AddMedRec.Location = new System.Drawing.Point(628, 115);
            this.AddMedRec.Name = "AddMedRec";
            this.AddMedRec.Size = new System.Drawing.Size(130, 23);
            this.AddMedRec.TabIndex = 2;
            this.AddMedRec.Text = "Add Medical Record";
            this.AddMedRec.UseVisualStyleBackColor = true;
            // 
            // UpMedRec
            // 
            this.UpMedRec.Location = new System.Drawing.Point(628, 242);
            this.UpMedRec.Name = "UpMedRec";
            this.UpMedRec.Size = new System.Drawing.Size(130, 23);
            this.UpMedRec.TabIndex = 3;
            this.UpMedRec.Text = "Update Medical Record";
            this.UpMedRec.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Crimson;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(701, 26);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(73, 27);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // DocDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.UpMedRec);
            this.Controls.Add(this.AddMedRec);
            this.Controls.Add(this.label1);
            this.Name = "DocDash";
            this.Text = "Doctor Dashboard";
            this.Load += new System.EventHandler(this.DocDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HospitalDBDataSet1 hospitalDBDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HospitalDBDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMedRec;
        private System.Windows.Forms.Button UpMedRec;
        private System.Windows.Forms.Button Logout;
    }
}