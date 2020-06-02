namespace Kursovaia
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.VisualButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxZ = new System.Windows.Forms.CheckBox();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.space = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonPoints = new System.Windows.Forms.RadioButton();
            this.radioButtonWire = new System.Windows.Forms.RadioButton();
            this.radioButtonSolid = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotational speed";
            // 
            // VisualButton
            // 
            this.VisualButton.Location = new System.Drawing.Point(24, 384);
            this.VisualButton.Margin = new System.Windows.Forms.Padding(2);
            this.VisualButton.Name = "VisualButton";
            this.VisualButton.Size = new System.Drawing.Size(108, 20);
            this.VisualButton.TabIndex = 8;
            this.VisualButton.Text = "Visual";
            this.VisualButton.UseVisualStyleBackColor = true;
            this.VisualButton.Click += new System.EventHandler(this.VisualButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(36, 160);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 7;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TabStop = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(24, 432);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 20);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxZ);
            this.groupBox1.Controls.Add(this.checkBoxY);
            this.groupBox1.Controls.Add(this.checkBoxX);
            this.groupBox1.Location = new System.Drawing.Point(20, 226);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(116, 98);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction of rotation";
            // 
            // checkBoxZ
            // 
            this.checkBoxZ.AutoSize = true;
            this.checkBoxZ.Location = new System.Drawing.Point(16, 67);
            this.checkBoxZ.Name = "checkBoxZ";
            this.checkBoxZ.Size = new System.Drawing.Size(33, 17);
            this.checkBoxZ.TabIndex = 2;
            this.checkBoxZ.Text = "Z";
            this.checkBoxZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Location = new System.Drawing.Point(16, 43);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(33, 17);
            this.checkBoxY.TabIndex = 1;
            this.checkBoxY.Text = "Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Location = new System.Drawing.Point(16, 19);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(33, 17);
            this.checkBoxX.TabIndex = 0;
            this.checkBoxX.Text = "X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current speed: 0";
            // 
            // space
            // 
            this.space.AccumBits = ((byte)(0));
            this.space.AutoCheckErrors = false;
            this.space.AutoFinish = false;
            this.space.AutoMakeCurrent = true;
            this.space.AutoSwapBuffers = true;
            this.space.BackColor = System.Drawing.Color.Black;
            this.space.ColorBits = ((byte)(32));
            this.space.DepthBits = ((byte)(16));
            this.space.Location = new System.Drawing.Point(149, 9);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(928, 631);
            this.space.StencilBits = ((byte)(0));
            this.space.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonLine);
            this.groupBox3.Controls.Add(this.radioButtonPoints);
            this.groupBox3.Controls.Add(this.radioButtonWire);
            this.groupBox3.Controls.Add(this.radioButtonSolid);
            this.groupBox3.Location = new System.Drawing.Point(20, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(112, 112);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model type";
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(4, 84);
            this.radioButtonLine.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLine.TabIndex = 6;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonPoints
            // 
            this.radioButtonPoints.AutoSize = true;
            this.radioButtonPoints.Location = new System.Drawing.Point(4, 63);
            this.radioButtonPoints.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPoints.Name = "radioButtonPoints";
            this.radioButtonPoints.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPoints.TabIndex = 5;
            this.radioButtonPoints.Text = "Points";
            this.radioButtonPoints.UseVisualStyleBackColor = true;
            // 
            // radioButtonWire
            // 
            this.radioButtonWire.AutoSize = true;
            this.radioButtonWire.Checked = true;
            this.radioButtonWire.Location = new System.Drawing.Point(4, 20);
            this.radioButtonWire.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWire.Name = "radioButtonWire";
            this.radioButtonWire.Size = new System.Drawing.Size(47, 17);
            this.radioButtonWire.TabIndex = 3;
            this.radioButtonWire.TabStop = true;
            this.radioButtonWire.Text = "Wire";
            this.radioButtonWire.UseVisualStyleBackColor = true;
            // 
            // radioButtonSolid
            // 
            this.radioButtonSolid.AutoSize = true;
            this.radioButtonSolid.Location = new System.Drawing.Point(4, 42);
            this.radioButtonSolid.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSolid.Name = "radioButtonSolid";
            this.radioButtonSolid.Size = new System.Drawing.Size(48, 17);
            this.radioButtonSolid.TabIndex = 4;
            this.radioButtonSolid.Text = "Solid";
            this.radioButtonSolid.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 20);
            this.button1.TabIndex = 18;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.space);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.VisualButton);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VisualButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private Tao.Platform.Windows.SimpleOpenGlControl space;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonWire;
        private System.Windows.Forms.RadioButton radioButtonSolid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButtonPoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxZ;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.RadioButton radioButtonLine;
    }
}

