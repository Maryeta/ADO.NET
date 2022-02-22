
namespace LINQsqlSproc
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
            this.orderDetailsButton = new System.Windows.Forms.Button();
            this.orderHistoryButton = new System.Windows.Forms.Button();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderDetailsButton
            // 
            this.orderDetailsButton.Location = new System.Drawing.Point(36, 188);
            this.orderDetailsButton.Name = "orderDetailsButton";
            this.orderDetailsButton.Size = new System.Drawing.Size(184, 62);
            this.orderDetailsButton.TabIndex = 0;
            this.orderDetailsButton.Text = "Подробности заказа";
            this.orderDetailsButton.UseVisualStyleBackColor = true;
            this.orderDetailsButton.Click += new System.EventHandler(this.orderDetailsButton_Click);
            // 
            // orderHistoryButton
            // 
            this.orderHistoryButton.Location = new System.Drawing.Point(284, 188);
            this.orderHistoryButton.Name = "orderHistoryButton";
            this.orderHistoryButton.Size = new System.Drawing.Size(165, 62);
            this.orderHistoryButton.TabIndex = 1;
            this.orderHistoryButton.Text = "История заказа";
            this.orderHistoryButton.UseVisualStyleBackColor = true;
            this.orderHistoryButton.Click += new System.EventHandler(this.orderHistoryButton_Click);
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(202, 55);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(190, 22);
            this.orderTextBox.TabIndex = 2;
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Location = new System.Drawing.Point(202, 110);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(190, 22);
            this.CustomerTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите код заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите код клиента";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerTextBox);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.orderHistoryButton);
            this.Controls.Add(this.orderDetailsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderDetailsButton;
        private System.Windows.Forms.Button orderHistoryButton;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

