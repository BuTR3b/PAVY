namespace FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxGun = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDrum = new System.Windows.Forms.Button();
            this.buttonShot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGun
            // 
            this.pictureBoxGun.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGun.Image")));
            this.pictureBoxGun.Location = new System.Drawing.Point(44, 12);
            this.pictureBoxGun.Name = "pictureBoxGun";
            this.pictureBoxGun.Size = new System.Drawing.Size(223, 168);
            this.pictureBoxGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGun.TabIndex = 0;
            this.pictureBoxGun.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inspired by the movie \"13\"";
            // 
            // buttonDrum
            // 
            this.buttonDrum.Image = ((System.Drawing.Image)(resources.GetObject("buttonDrum.Image")));
            this.buttonDrum.Location = new System.Drawing.Point(12, 229);
            this.buttonDrum.Name = "buttonDrum";
            this.buttonDrum.Size = new System.Drawing.Size(132, 124);
            this.buttonDrum.TabIndex = 4;
            this.buttonDrum.UseVisualStyleBackColor = true;
            this.buttonDrum.Click += new System.EventHandler(this.buttonDrum_Click);
            // 
            // buttonShot
            // 
            this.buttonShot.Image = ((System.Drawing.Image)(resources.GetObject("buttonShot.Image")));
            this.buttonShot.Location = new System.Drawing.Point(222, 229);
            this.buttonShot.Name = "buttonShot";
            this.buttonShot.Size = new System.Drawing.Size(132, 124);
            this.buttonShot.TabIndex = 5;
            this.buttonShot.Text = " ";
            this.buttonShot.UseVisualStyleBackColor = true;
            this.buttonShot.Click += new System.EventHandler(this.buttonShot_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Level:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonShot);
            this.Controls.Add(this.buttonDrum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxGun);
            this.Name = "Form1";
            this.Text = "Russian roulette";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDrum;
        private System.Windows.Forms.Button buttonShot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

