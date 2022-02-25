
namespace ApressFinancialApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.apressFinancialDataSet = new ApressFinancialApp.ApressFinancialDataSet();
            this.customersTableAdapter1 = new ApressFinancialApp.ApressFinancialDataSetTableAdapters.CustomersTableAdapter();
            this.queriesTableAdapter1 = new ApressFinancialApp.ApressFinancialDataSetTableAdapters.QueriesTableAdapter();
            this.transactionsTableAdapter1 = new ApressFinancialApp.ApressFinancialDataSetTableAdapters.TransactionsTableAdapter();
            this.gridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.otherInitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.accountNumTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // apressFinancialDataSet
            // 
            this.apressFinancialDataSet.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter1
            // 
            this.transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView1.Location = new System.Drawing.Point(12, 180);
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeadersWidth = 51;
            this.gridView1.RowTemplate.Height = 24;
            this.gridView1.Size = new System.Drawing.Size(988, 314);
            this.gridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Other Initials";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(118, 28);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 22);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(118, 80);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 22);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // otherInitTextBox
            // 
            this.otherInitTextBox.Location = new System.Drawing.Point(118, 130);
            this.otherInitTextBox.Name = "otherInitTextBox";
            this.otherInitTextBox.Size = new System.Drawing.Size(150, 22);
            this.otherInitTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adress ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Account Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Account Type ID";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(425, 28);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(139, 22);
            this.adressTextBox.TabIndex = 10;
            // 
            // accountNumTextBox
            // 
            this.accountNumTextBox.Location = new System.Drawing.Point(425, 80);
            this.accountNumTextBox.Name = "accountNumTextBox";
            this.accountNumTextBox.Size = new System.Drawing.Size(139, 22);
            this.accountNumTextBox.TabIndex = 11;
            // 
            // accountTypeTextBox
            // 
            this.accountTypeTextBox.Location = new System.Drawing.Point(425, 130);
            this.accountTypeTextBox.Name = "accountTypeTextBox";
            this.accountTypeTextBox.Size = new System.Drawing.Size(139, 22);
            this.accountTypeTextBox.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(635, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 45);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(635, 109);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 43);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(790, 32);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 45);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 506);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.accountTypeTextBox);
            this.Controls.Add(this.accountNumTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.otherInitTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApressFinancialDataSet apressFinancialDataSet;
        private ApressFinancialDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private ApressFinancialDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private ApressFinancialDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
        private System.Windows.Forms.DataGridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox otherInitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox accountNumTextBox;
        private System.Windows.Forms.TextBox accountTypeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}

