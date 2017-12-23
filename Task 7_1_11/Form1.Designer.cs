namespace Task_7_1_11
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
            this.InputStr1 = new System.Windows.Forms.TextBox();
            this.InputStr2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.FindNumbers = new System.Windows.Forms.Button();
            this.Message1 = new System.Windows.Forms.Label();
            this.Message2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputStr1
            // 
            this.InputStr1.Location = new System.Drawing.Point(26, 57);
            this.InputStr1.Name = "InputStr1";
            this.InputStr1.Size = new System.Drawing.Size(490, 20);
            this.InputStr1.TabIndex = 0;
            // 
            // InputStr2
            // 
            this.InputStr2.Location = new System.Drawing.Point(26, 123);
            this.InputStr2.Name = "InputStr2";
            this.InputStr2.Size = new System.Drawing.Size(100, 20);
            this.InputStr2.TabIndex = 1;
            this.InputStr2.TextChanged += new System.EventHandler(this.InputStr2_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(23, 158);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 2;
            // 
            // FindNumbers
            // 
            this.FindNumbers.Location = new System.Drawing.Point(220, 204);
            this.FindNumbers.Name = "FindNumbers";
            this.FindNumbers.Size = new System.Drawing.Size(75, 23);
            this.FindNumbers.TabIndex = 3;
            this.FindNumbers.Text = "OK";
            this.FindNumbers.UseVisualStyleBackColor = true;
            this.FindNumbers.Click += new System.EventHandler(this.FindNumbers_Click);
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Location = new System.Drawing.Point(23, 25);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(173, 13);
            this.Message1.TabIndex = 4;
            this.Message1.Text = "Введите ряд чисел через пробел";
            // 
            // Message2
            // 
            this.Message2.AutoSize = true;
            this.Message2.Location = new System.Drawing.Point(23, 95);
            this.Message2.Name = "Message2";
            this.Message2.Size = new System.Drawing.Size(81, 13);
            this.Message2.TabIndex = 5;
            this.Message2.Text = "Введите число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 406);
            this.Controls.Add(this.Message2);
            this.Controls.Add(this.Message1);
            this.Controls.Add(this.FindNumbers);
            this.Controls.Add(this.result);
            this.Controls.Add(this.InputStr2);
            this.Controls.Add(this.InputStr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputStr1;
        private System.Windows.Forms.TextBox InputStr2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button FindNumbers;
        private System.Windows.Forms.Label Message1;
        private System.Windows.Forms.Label Message2;
    }
}

