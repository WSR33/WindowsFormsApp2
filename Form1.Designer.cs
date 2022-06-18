
namespace WindowsFormsApp2
{
    partial class vhod
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
            this.button_capcha = new System.Windows.Forms.Button();
            this.button_vhod = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_capcha = new System.Windows.Forms.TextBox();
            this.label_capcha = new System.Windows.Forms.Label();
            this.button_dalee = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_capcha
            // 
            this.button_capcha.Location = new System.Drawing.Point(179, 406);
            this.button_capcha.Name = "button_capcha";
            this.button_capcha.Size = new System.Drawing.Size(75, 36);
            this.button_capcha.TabIndex = 0;
            this.button_capcha.Text = "КАПЧА";
            this.button_capcha.UseVisualStyleBackColor = true;
            this.button_capcha.Click += new System.EventHandler(this.button_capcha_Click);
            // 
            // button_vhod
            // 
            this.button_vhod.Location = new System.Drawing.Point(284, 406);
            this.button_vhod.Name = "button_vhod";
            this.button_vhod.Size = new System.Drawing.Size(75, 36);
            this.button_vhod.TabIndex = 1;
            this.button_vhod.Text = "ВХОД";
            this.button_vhod.UseVisualStyleBackColor = true;
            this.button_vhod.Click += new System.EventHandler(this.button_vhod_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(179, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(42, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пользователь:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label_login.Location = new System.Drawing.Point(76, 199);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(69, 27);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label_password.Location = new System.Drawing.Point(76, 264);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(82, 27);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Пароль";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(179, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(193, 22);
            this.textBox5.TabIndex = 7;
            // 
            // textBox_capcha
            // 
            this.textBox_capcha.Location = new System.Drawing.Point(149, 365);
            this.textBox_capcha.Name = "textBox_capcha";
            this.textBox_capcha.Size = new System.Drawing.Size(243, 22);
            this.textBox_capcha.TabIndex = 8;
            // 
            // label_capcha
            // 
            this.label_capcha.AutoSize = true;
            this.label_capcha.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_capcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label_capcha.Location = new System.Drawing.Point(227, 315);
            this.label_capcha.Name = "label_capcha";
            this.label_capcha.Size = new System.Drawing.Size(86, 29);
            this.label_capcha.TabIndex = 9;
            this.label_capcha.Text = "КАПЧА";
            this.label_capcha.Click += new System.EventHandler(this.label_capcha_Click);
            // 
            // button_dalee
            // 
            this.button_dalee.Location = new System.Drawing.Point(419, 481);
            this.button_dalee.Name = "button_dalee";
            this.button_dalee.Size = new System.Drawing.Size(75, 37);
            this.button_dalee.TabIndex = 10;
            this.button_dalee.Text = "ДАЛЕЕ";
            this.button_dalee.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(203, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "SPORT STORE\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(194, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "магазин спортивных товаров";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(387, 264);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 21);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Скрыть пароль";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.pictureBox1.Location = new System.Drawing.Point(113, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // vhod
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 539);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_dalee);
            this.Controls.Add(this.label_capcha);
            this.Controls.Add(this.textBox_capcha);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button_vhod);
            this.Controls.Add(this.button_capcha);
            this.Name = "vhod";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_capcha;
        private System.Windows.Forms.Button button_vhod;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox_capcha;
        private System.Windows.Forms.Label label_capcha;
        private System.Windows.Forms.Button button_dalee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

