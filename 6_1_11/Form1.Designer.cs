namespace _6_1_11
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
            this.result = new System.Windows.Forms.Label();
            this.GetFileName = new System.Windows.Forms.Button();
            this.GetFileExtension = new System.Windows.Forms.Button();
            this.inputStr = new System.Windows.Forms.TextBox();
            this.Message1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(36, 92);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 0;
            // 
            // GetFileName
            // 
            this.GetFileName.Location = new System.Drawing.Point(111, 117);
            this.GetFileName.Name = "GetFileName";
            this.GetFileName.Size = new System.Drawing.Size(131, 23);
            this.GetFileName.TabIndex = 1;
            this.GetFileName.Text = "Имя файла";
            this.GetFileName.UseVisualStyleBackColor = true;
            this.GetFileName.Click += new System.EventHandler(this.GetFileName_Click);
            // 
            // GetFileExtension
            // 
            this.GetFileExtension.Location = new System.Drawing.Point(342, 117);
            this.GetFileExtension.Name = "GetFileExtension";
            this.GetFileExtension.Size = new System.Drawing.Size(131, 23);
            this.GetFileExtension.TabIndex = 2;
            this.GetFileExtension.Text = "Разрешение файла";
            this.GetFileExtension.UseVisualStyleBackColor = true;
            this.GetFileExtension.Click += new System.EventHandler(this.GetFileExtension_Click);
            // 
            // inputStr
            // 
            this.inputStr.Location = new System.Drawing.Point(39, 56);
            this.inputStr.Name = "inputStr";
            this.inputStr.Size = new System.Drawing.Size(522, 20);
            this.inputStr.TabIndex = 3;
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Location = new System.Drawing.Point(232, 27);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(146, 13);
            this.Message1.TabIndex = 4;
            this.Message1.Text = "Введите полное имя файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 355);
            this.Controls.Add(this.Message1);
            this.Controls.Add(this.inputStr);
            this.Controls.Add(this.GetFileExtension);
            this.Controls.Add(this.GetFileName);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button GetFileName;
        private System.Windows.Forms.Button GetFileExtension;
        private System.Windows.Forms.TextBox inputStr;
        private System.Windows.Forms.Label Message1;
    }
}

