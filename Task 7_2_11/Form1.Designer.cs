namespace Task_7_2_11
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
            this.inputArr = new System.Windows.Forms.TextBox();
            this.GetQuantity = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.message1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputArr
            // 
            this.inputArr.Location = new System.Drawing.Point(30, 70);
            this.inputArr.Name = "inputArr";
            this.inputArr.Size = new System.Drawing.Size(482, 20);
            this.inputArr.TabIndex = 0;
            // 
            // GetQuantity
            // 
            this.GetQuantity.Location = new System.Drawing.Point(208, 152);
            this.GetQuantity.Name = "GetQuantity";
            this.GetQuantity.Size = new System.Drawing.Size(91, 31);
            this.GetQuantity.TabIndex = 1;
            this.GetQuantity.Text = "OK";
            this.GetQuantity.UseVisualStyleBackColor = true;
            this.GetQuantity.Click += new System.EventHandler(this.GetQuantity_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(27, 108);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(329, 13);
            this.result.TabIndex = 2;
            this.result.Text = "Количество элементов больше среднего арифметического N =";
            // 
            // message1
            // 
            this.message1.AutoSize = true;
            this.message1.Location = new System.Drawing.Point(27, 39);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(173, 13);
            this.message1.TabIndex = 3;
            this.message1.Text = "Введите ряд чисел через пробел";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 332);
            this.Controls.Add(this.message1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.GetQuantity);
            this.Controls.Add(this.inputArr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputArr;
        private System.Windows.Forms.Button GetQuantity;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label message1;
    }
}

