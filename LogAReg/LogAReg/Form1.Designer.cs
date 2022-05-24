namespace LogAReg
{
    partial class authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorization));
            this.Reg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogClick = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogClick)).BeginInit();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.AutoSize = true;
            this.Reg.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg.Location = new System.Drawing.Point(113, 302);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(102, 16);
            this.Reg.TabIndex = 2;
            this.Reg.Text = "Нет аккаунта?";
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LogClick
            // 
            this.LogClick.Image = ((System.Drawing.Image)(resources.GetObject("LogClick.Image")));
            this.LogClick.Location = new System.Drawing.Point(137, 249);
            this.LogClick.Name = "LogClick";
            this.LogClick.Size = new System.Drawing.Size(50, 37);
            this.LogClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogClick.TabIndex = 2;
            this.LogClick.TabStop = false;
            this.LogClick.Click += new System.EventHandler(this.LogClick_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(92, 166);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(148, 22);
            this.Login.TabIndex = 0;
            this.Login.Text = "Введите логин";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(92, 211);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(148, 22);
            this.Password.TabIndex = 1;
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 371);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LogClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Reg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 410);
            this.MinimumSize = new System.Drawing.Size(360, 410);
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LogClick;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
    }
}

