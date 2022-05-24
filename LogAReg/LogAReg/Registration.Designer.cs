namespace LogAReg
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.LogClick = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(101, 234);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(133, 22);
            this.Password.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(101, 193);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(133, 22);
            this.Login.TabIndex = 0;
            this.Login.Text = "Введите логин";
            // 
            // LogClick
            // 
            this.LogClick.Image = ((System.Drawing.Image)(resources.GetObject("LogClick.Image")));
            this.LogClick.Location = new System.Drawing.Point(142, 262);
            this.LogClick.Name = "LogClick";
            this.LogClick.Size = new System.Drawing.Size(50, 37);
            this.LogClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogClick.TabIndex = 5;
            this.LogClick.TabStop = false;
            this.LogClick.Click += new System.EventHandler(this.LogClick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Регистрация";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LogClick);
            this.MaximumSize = new System.Drawing.Size(360, 410);
            this.MinimumSize = new System.Drawing.Size(360, 410);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.PictureBox LogClick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}