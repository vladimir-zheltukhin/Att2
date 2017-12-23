namespace Task_8_1_11
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
            this.Message1 = new System.Windows.Forms.Label();
            this.inputList = new System.Windows.Forms.TextBox();
            this.resultList = new System.Windows.Forms.Label();
            this.startReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message1.Location = new System.Drawing.Point(28, 56);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(354, 16);
            this.Message1.TabIndex = 0;
            this.Message1.Text = "Введите ряд целых чисел через пробел или запятую";
            // 
            // inputList
            // 
            this.inputList.Location = new System.Drawing.Point(31, 89);
            this.inputList.Name = "inputList";
            this.inputList.Size = new System.Drawing.Size(517, 20);
            this.inputList.TabIndex = 1;
            // 
            // resultList
            // 
            this.resultList.AutoSize = true;
            this.resultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultList.Location = new System.Drawing.Point(28, 129);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(0, 16);
            this.resultList.TabIndex = 2;
            // 
            // startReverse
            // 
            this.startReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startReverse.Location = new System.Drawing.Point(230, 163);
            this.startReverse.Name = "startReverse";
            this.startReverse.Size = new System.Drawing.Size(75, 23);
            this.startReverse.TabIndex = 3;
            this.startReverse.Text = "Start";
            this.startReverse.UseVisualStyleBackColor = true;
            this.startReverse.Click += new System.EventHandler(this.startReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 262);
            this.Controls.Add(this.startReverse);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.inputList);
            this.Controls.Add(this.Message1);
            this.Name = "Form1";
            this.Text = "ReverseBetweenFirstMaxAndLastMin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message1;
        private System.Windows.Forms.TextBox inputList;
        private System.Windows.Forms.Label resultList;
        private System.Windows.Forms.Button startReverse;
    }
}

