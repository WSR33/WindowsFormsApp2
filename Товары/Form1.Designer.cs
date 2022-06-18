
namespace WindowsFormsApp2.Товары
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_name = new System.Windows.Forms.ComboBox();
            this.textBox_opisanie = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.label_proizvoditel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_name
            // 
            this.comboBox_name.FormattingEnabled = true;
            this.comboBox_name.Location = new System.Drawing.Point(375, 157);
            this.comboBox_name.Name = "comboBox_name";
            this.comboBox_name.Size = new System.Drawing.Size(188, 24);
            this.comboBox_name.TabIndex = 0;
            this.comboBox_name.SelectedIndexChanged += new System.EventHandler(this.comboBox_name_SelectedIndexChanged);
            // 
            // textBox_opisanie
            // 
            this.textBox_opisanie.Location = new System.Drawing.Point(375, 217);
            this.textBox_opisanie.Multiline = true;
            this.textBox_opisanie.Name = "textBox_opisanie";
            this.textBox_opisanie.Size = new System.Drawing.Size(188, 118);
            this.textBox_opisanie.TabIndex = 1;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.ForeColor = System.Drawing.Color.Green;
            this.label_price.Location = new System.Drawing.Point(370, 356);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(54, 19);
            this.label_price.TabIndex = 2;
            this.label_price.Text = "Цена:";
            // 
            // label_proizvoditel
            // 
            this.label_proizvoditel.AutoSize = true;
            this.label_proizvoditel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_proizvoditel.ForeColor = System.Drawing.Color.Green;
            this.label_proizvoditel.Location = new System.Drawing.Point(370, 381);
            this.label_proizvoditel.Name = "label_proizvoditel";
            this.label_proizvoditel.Size = new System.Drawing.Size(135, 19);
            this.label_proizvoditel.TabIndex = 3;
            this.label_proizvoditel.Text = "Производитель:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(82, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Location = new System.Drawing.Point(52, 136);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(245, 215);
            this.pictureBox_photo.TabIndex = 4;
            this.pictureBox_photo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "SPORT STORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(172, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "магазин спортивных товаров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(372, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите товар:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(372, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Описание товара:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(613, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Наличие товара:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "ДАЛЕЕ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "НАЗАД";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_photo);
            this.Controls.Add(this.label_proizvoditel);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox_opisanie);
            this.Controls.Add(this.comboBox_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_name;
        private System.Windows.Forms.TextBox textBox_opisanie;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_proizvoditel;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}