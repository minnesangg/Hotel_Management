using System;

namespace HotelManagment
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEnterDepartment;
        private System.Windows.Forms.Label lblChooseAndClick;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.TextBox txtManagementRole;


        private void InitializeComponent()
        {
            this.lblEnterDepartment = new System.Windows.Forms.Label();
            this.lblChooseAndClick = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtManagementRole = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterDepartment
            // 
            this.lblEnterDepartment.AutoSize = true;
            this.lblEnterDepartment.Location = new System.Drawing.Point(34, 35);
            this.lblEnterDepartment.Name = "lblEnterDepartment";
            this.lblEnterDepartment.Size = new System.Drawing.Size(81, 16);
            this.lblEnterDepartment.TabIndex = 1;
            this.lblEnterDepartment.Text = "Enter Name:";
            // 
            // lblChooseAndClick
            // 
            this.lblChooseAndClick.AutoSize = true;
            this.lblChooseAndClick.Location = new System.Drawing.Point(330, 35);
            this.lblChooseAndClick.Name = "lblChooseAndClick";
            this.lblChooseAndClick.Size = new System.Drawing.Size(112, 16);
            this.lblChooseAndClick.TabIndex = 2;
            this.lblChooseAndClick.Text = "Choose and Click";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(34, 55);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(200, 22);
            this.txtDepartment.TabIndex = 3;
            this.txtDepartment.TextChanged += new System.EventHandler(this.txtDepartment_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(555, 204);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(0, 0);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthDate.TabIndex = 0;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 22);
            this.dtpHireDate.TabIndex = 0;
            // 
            // txtManagementRole
            // 
            this.txtManagementRole.Location = new System.Drawing.Point(0, 0);
            this.txtManagementRole.Name = "txtManagementRole";
            this.txtManagementRole.Size = new System.Drawing.Size(100, 22);
            this.txtManagementRole.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(333, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 132);
            this.listBox1.TabIndex = 7;
            // 
            // SearchForm
            // 
            this.ClientSize = new System.Drawing.Size(570, 400);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblChooseAndClick);
            this.Controls.Add(this.lblEnterDepartment);
            this.Name = "SearchForm";
            this.Text = "Reservations Search";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadData();
        }

        private void LoadDepartments()
        {
        }

        private System.Windows.Forms.ListBox listBox1;
    }
}