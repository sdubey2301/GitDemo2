namespace Employee
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
            this.components = new System.ComponentModel.Container();
            this.grid_Update = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lblcontactno = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblempID = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Update
            // 
            this.grid_Update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Update.Location = new System.Drawing.Point(56, 257);
            this.grid_Update.Name = "grid_Update";
            this.grid_Update.RowHeadersWidth = 62;
            this.grid_Update.RowTemplate.Height = 28;
            this.grid_Update.Size = new System.Drawing.Size(699, 191);
            this.grid_Update.TabIndex = 22;
            this.grid_Update.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grid_Update.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Update_CellDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(374, 194);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 57);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(211, 194);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 57);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(374, 157);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(100, 26);
            this.txtcontact.TabIndex = 19;
            // 
            // lblcontactno
            // 
            this.lblcontactno.AutoSize = true;
            this.lblcontactno.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactno.Location = new System.Drawing.Point(221, 154);
            this.lblcontactno.Name = "lblcontactno";
            this.lblcontactno.Size = new System.Drawing.Size(128, 27);
            this.lblcontactno.TabIndex = 18;
            this.lblcontactno.Text = "Contact no";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(374, 115);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 26);
            this.txtAge.TabIndex = 17;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(221, 112);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(50, 27);
            this.lblage.TabIndex = 16;
            this.lblage.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(374, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 26);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(221, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 27);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempID.Location = new System.Drawing.Point(221, 20);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(81, 27);
            this.lblempID.TabIndex = 23;
            this.lblempID.Text = "EmpID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(374, 23);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 26);
            this.txtEmpID.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblempID);
            this.Controls.Add(this.grid_Update);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.lblcontactno);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Update;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label lblcontactno;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblempID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}