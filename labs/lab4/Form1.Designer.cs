namespace lab4
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
            this.openfile = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.timeload = new System.Windows.Forms.Label();
            this.searchword1 = new System.Windows.Forms.TextBox();
            this.search1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchword2 = new System.Windows.Forms.TextBox();
            this.search2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.searchword3 = new System.Windows.Forms.TextBox();
            this.search3 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.upgrade = new System.Windows.Forms.Button();
            this.min1 = new System.Windows.Forms.TextBox();
            this.min2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.BackColor = System.Drawing.Color.HotPink;
            this.openfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.openfile.ForeColor = System.Drawing.Color.Black;
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(131, 42);
            this.openfile.TabIndex = 0;
            this.openfile.Text = "Открыть файл";
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.time.ForeColor = System.Drawing.SystemColors.Info;
            this.time.Location = new System.Drawing.Point(149, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(299, 20);
            this.time.TabIndex = 1;
            this.time.Text = "Время загрузки и сохранения в список";
            // 
            // timeload
            // 
            this.timeload.AutoSize = true;
            this.timeload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timeload.ForeColor = System.Drawing.SystemColors.Info;
            this.timeload.Location = new System.Drawing.Point(149, 34);
            this.timeload.Name = "timeload";
            this.timeload.Size = new System.Drawing.Size(30, 20);
            this.timeload.TabIndex = 2;
            this.timeload.Text = "0 c";
            // 
            // searchword1
            // 
            this.searchword1.AccessibleDescription = " ";
            this.searchword1.AccessibleName = "";
            this.searchword1.BackColor = System.Drawing.Color.Fuchsia;
            this.searchword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchword1.Location = new System.Drawing.Point(82, 142);
            this.searchword1.Name = "searchword1";
            this.searchword1.Size = new System.Drawing.Size(99, 26);
            this.searchword1.TabIndex = 3;
            this.searchword1.Tag = "";
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.Violet;
            this.search1.Location = new System.Drawing.Point(14, 142);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(62, 26);
            this.search1.TabIndex = 4;
            this.search1.Text = "Поиск";
            this.search1.UseVisualStyleBackColor = false;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 244);
            this.listBox1.TabIndex = 5;
            // 
            // searchword2
            // 
            this.searchword2.AccessibleDescription = " ";
            this.searchword2.AccessibleName = "";
            this.searchword2.BackColor = System.Drawing.Color.Fuchsia;
            this.searchword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchword2.Location = new System.Drawing.Point(322, 141);
            this.searchword2.Name = "searchword2";
            this.searchword2.Size = new System.Drawing.Size(99, 26);
            this.searchword2.TabIndex = 3;
            this.searchword2.Tag = "";
            // 
            // search2
            // 
            this.search2.BackColor = System.Drawing.Color.Violet;
            this.search2.Location = new System.Drawing.Point(253, 141);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(62, 26);
            this.search2.TabIndex = 4;
            this.search2.Text = "Поиск";
            this.search2.UseVisualStyleBackColor = false;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(197, 183);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(224, 244);
            this.listBox2.TabIndex = 5;
            // 
            // searchword3
            // 
            this.searchword3.AccessibleDescription = " ";
            this.searchword3.AccessibleName = "";
            this.searchword3.BackColor = System.Drawing.Color.Fuchsia;
            this.searchword3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchword3.Location = new System.Drawing.Point(560, 142);
            this.searchword3.Name = "searchword3";
            this.searchword3.Size = new System.Drawing.Size(99, 26);
            this.searchword3.TabIndex = 3;
            this.searchword3.Tag = "";
            // 
            // search3
            // 
            this.search3.BackColor = System.Drawing.Color.Violet;
            this.search3.Location = new System.Drawing.Point(492, 142);
            this.search3.Name = "search3";
            this.search3.Size = new System.Drawing.Size(62, 26);
            this.search3.TabIndex = 4;
            this.search3.Text = "Поиск";
            this.search3.UseVisualStyleBackColor = false;
            this.search3.Click += new System.EventHandler(this.search3_Click);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(436, 183);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(223, 244);
            this.listBox3.TabIndex = 5;
            // 
            // upgrade
            // 
            this.upgrade.Location = new System.Drawing.Point(503, 12);
            this.upgrade.Name = "upgrade";
            this.upgrade.Size = new System.Drawing.Size(140, 27);
            this.upgrade.TabIndex = 6;
            this.upgrade.Text = "Модифицировать";
            this.upgrade.UseVisualStyleBackColor = true;
            this.upgrade.Click += new System.EventHandler(this.upgrade_Click);
            // 
            // min1
            // 
            this.min1.AccessibleDescription = " ";
            this.min1.AccessibleName = "";
            this.min1.BackColor = System.Drawing.Color.Fuchsia;
            this.min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.min1.Location = new System.Drawing.Point(197, 141);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(50, 26);
            this.min1.TabIndex = 3;
            this.min1.Tag = "";
            // 
            // min2
            // 
            this.min2.AccessibleDescription = " ";
            this.min2.AccessibleName = "";
            this.min2.BackColor = System.Drawing.Color.Fuchsia;
            this.min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.min2.Location = new System.Drawing.Point(436, 142);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(50, 26);
            this.min2.TabIndex = 3;
            this.min2.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Макс";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(439, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Макс";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Обычный поиск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(200, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поиск Левинштейна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(432, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Поиск Дамерау-Левенштейна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(671, 439);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upgrade);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.search3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.searchword3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.searchword2);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.searchword1);
            this.Controls.Add(this.timeload);
            this.Controls.Add(this.time);
            this.Controls.Add(this.openfile);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Донченко Мария ИУ5ц-53Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label timeload;
        private System.Windows.Forms.TextBox searchword1;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox searchword2;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox searchword3;
        private System.Windows.Forms.Button search3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button upgrade;
        private System.Windows.Forms.TextBox min1;
        private System.Windows.Forms.TextBox min2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

