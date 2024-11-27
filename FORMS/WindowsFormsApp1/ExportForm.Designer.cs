namespace HotelManagment
{
    partial class ExportForm
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
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.txtTableDescription = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.btnExportToWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(74, 38);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(210, 24);
            this.comboBoxTables.TabIndex = 0;
            // 
            // txtTableDescription
            // 
            this.txtTableDescription.Location = new System.Drawing.Point(891, 38);
            this.txtTableDescription.Multiline = true;
            this.txtTableDescription.Name = "txtTableDescription";
            this.txtTableDescription.Size = new System.Drawing.Size(329, 136);
            this.txtTableDescription.TabIndex = 1;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 255);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(1279, 243);
            this.dataGridViewData.TabIndex = 2;
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.Location = new System.Drawing.Point(97, 110);
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.Size = new System.Drawing.Size(164, 64);
            this.btnExportToWord.TabIndex = 3;
            this.btnExportToWord.Text = "ЕКСПОРТ";
            this.btnExportToWord.UseVisualStyleBackColor = true;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 523);
            this.Controls.Add(this.btnExportToWord);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.txtTableDescription);
            this.Controls.Add(this.comboBoxTables);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.TextBox txtTableDescription;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button btnExportToWord;
    }
}