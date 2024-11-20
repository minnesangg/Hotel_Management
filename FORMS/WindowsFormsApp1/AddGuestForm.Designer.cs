using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    partial class AddGuestForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAim;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtPassportDate;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtRegistrar;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtYear;

        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnUpdateGuest;
        private System.Windows.Forms.Button btnDeleteGuest;

        private System.Windows.Forms.DataGridView dgvGuests;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAim = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtPassportDate = new System.Windows.Forms.TextBox();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtRegistrar = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnUpdateGuest = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxCash = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1245, 599);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 22);
            this.txtAddress.TabIndex = 0;
            // 
            // txtAim
            // 
            this.txtAim.Location = new System.Drawing.Point(409, 599);
            this.txtAim.Name = "txtAim";
            this.txtAim.Size = new System.Drawing.Size(159, 22);
            this.txtAim.TabIndex = 1;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(1042, 681);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(159, 22);
            this.txtComment.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(616, 532);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(159, 22);
            this.txtDate.TabIndex = 4;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(827, 532);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(159, 22);
            this.txtDepartureDate.TabIndex = 5;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(1042, 599);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(159, 22);
            this.txtGuestID.TabIndex = 6;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(827, 681);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(159, 22);
            this.txtMoney.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 532);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(421, 680);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(159, 22);
            this.txtPassport.TabIndex = 9;
            // 
            // txtPassportDate
            // 
            this.txtPassportDate.Location = new System.Drawing.Point(226, 680);
            this.txtPassportDate.Name = "txtPassportDate";
            this.txtPassportDate.Size = new System.Drawing.Size(159, 22);
            this.txtPassportDate.TabIndex = 10;
            // 
            // txtReceipt
            // 
            this.txtReceipt.Location = new System.Drawing.Point(827, 599);
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(159, 22);
            this.txtReceipt.TabIndex = 12;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(1245, 535);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(159, 22);
            this.txtRegion.TabIndex = 13;
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Location = new System.Drawing.Point(409, 532);
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(159, 22);
            this.txtRegistrar.TabIndex = 14;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(1042, 532);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(159, 22);
            this.txtTown.TabIndex = 15;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(616, 599);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(159, 22);
            this.txtWork.TabIndex = 16;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(226, 599);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(159, 22);
            this.txtYear.TabIndex = 17;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Location = new System.Drawing.Point(12, 82);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(100, 30);
            this.btnAddGuest.TabIndex = 18;
            this.btnAddGuest.Text = "Додати";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGuest
            // 
            this.btnUpdateGuest.Location = new System.Drawing.Point(12, 226);
            this.btnUpdateGuest.Name = "btnUpdateGuest";
            this.btnUpdateGuest.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateGuest.TabIndex = 19;
            this.btnUpdateGuest.Text = "Оновити";
            this.btnUpdateGuest.UseVisualStyleBackColor = true;
            this.btnUpdateGuest.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(12, 348);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteGuest.TabIndex = 20;
            this.btnDeleteGuest.Text = "Видалити";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dgvGuests
            // 
            this.dgvGuests.ColumnHeadersHeight = 29;
            this.dgvGuests.Location = new System.Drawing.Point(118, 49);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersWidth = 51;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(1370, 400);
            this.dgvGuests.TabIndex = 19;
            this.dgvGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Прізвище для бронювання";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Номер паспорту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1292, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Адреса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "ФІО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ціль візиту";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 648);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Оплата готівкою";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Дата в паспорті";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1092, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Місто ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Робота";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(861, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "ID Резервації";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(882, 648);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Гроші";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(676, 504);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Дата";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Рік";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1292, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Область";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(875, 504);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "Від\'їзд";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1092, 571);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 36;
            this.label16.Text = "ID гостя";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1076, 648);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "Коментарі";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(756, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 16);
            this.label19.TabIndex = 39;
            this.label19.Text = "ДОДАТИ НОВОГО ГОСТЯ";
            // 
            // checkBoxCash
            // 
            this.checkBoxCash.AutoSize = true;
            this.checkBoxCash.Location = new System.Drawing.Point(661, 680);
            this.checkBoxCash.Name = "checkBoxCash";
            this.checkBoxCash.Size = new System.Drawing.Size(53, 20);
            this.checkBoxCash.TabIndex = 40;
            this.checkBoxCash.Text = "Так";
            this.checkBoxCash.UseVisualStyleBackColor = true;
            // 
            // AddGuestForm
            // 
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.checkBoxCash);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAim);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtPassportDate);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.btnUpdateGuest);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.dgvGuests);
            this.Name = "AddGuestForm";
            this.Text = "Додати/Оновити/Видалити гостя";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        // DataGridView cell click event
        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Заповнення полів даними, вибраними в DataGridView
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private CheckBox checkBoxCash;
    }
}
