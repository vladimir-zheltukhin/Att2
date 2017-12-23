namespace Task_6_2_11
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
            this.button_start = new System.Windows.Forms.Button();
            this.inputE = new System.Windows.Forms.TextBox();
            this.inputX = new System.Windows.Forms.TextBox();
            this.EMessage = new System.Windows.Forms.Label();
            this.XMessage = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(291, 26);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(97, 87);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // inputE
            // 
            this.inputE.Location = new System.Drawing.Point(113, 40);
            this.inputE.Name = "inputE";
            this.inputE.Size = new System.Drawing.Size(100, 20);
            this.inputE.TabIndex = 1;
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(113, 84);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 20);
            this.inputX.TabIndex = 3;
            // 
            // EMessage
            // 
            this.EMessage.AutoSize = true;
            this.EMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EMessage.Location = new System.Drawing.Point(84, 43);
            this.EMessage.Name = "EMessage";
            this.EMessage.Size = new System.Drawing.Size(27, 16);
            this.EMessage.TabIndex = 5;
            this.EMessage.Text = "E =";
            // 
            // XMessage
            // 
            this.XMessage.AutoSize = true;
            this.XMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMessage.Location = new System.Drawing.Point(84, 85);
            this.XMessage.Name = "XMessage";
            this.XMessage.Size = new System.Drawing.Size(26, 16);
            this.XMessage.TabIndex = 7;
            this.XMessage.Text = "X =";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(78, 141);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 329);
            this.Controls.Add(this.result);
            this.Controls.Add(this.XMessage);
            this.Controls.Add(this.EMessage);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.inputE);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox inputE;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.Label EMessage;
        private System.Windows.Forms.Label XMessage;
        private System.Windows.Forms.Label result;
    }
}

