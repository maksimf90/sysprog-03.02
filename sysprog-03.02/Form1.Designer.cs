namespace sysprog_03._02
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(119, 34);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 0;
            this.Login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(119, 73);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
    }
}

