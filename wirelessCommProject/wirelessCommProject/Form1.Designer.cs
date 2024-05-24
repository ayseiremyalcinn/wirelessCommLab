namespace wirelessCommProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(50, 94);
            button1.Name = "button1";
            button1.Size = new Size(215, 29);
            button1.TabIndex = 0;
            button1.Text = "Node'a Bağlan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "192.168.4.1:23";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "192.168.1.37";
            // 
            // button2
            // 
            button2.Location = new Point(50, 206);
            button2.Name = "button2";
            button2.Size = new Size(215, 29);
            button2.TabIndex = 2;
            button2.Text = "Broker'a Bağlan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 27);
            textBox3.TabIndex = 4;
            textBox3.Text = "irem";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 27);
            textBox4.TabIndex = 5;
            textBox4.Text = "irem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 86);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 126);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 7;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 46);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 8;
            label3.Text = "Broker Adresi:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 265);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.check__5_;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(157, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(108, 27);
            textBox5.TabIndex = 11;
            textBox5.Text = "telemetry";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 166);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 12;
            label7.Text = "Konu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 12);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 10;
            label4.Text = "MQTT Paneli";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(25, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 147);
            panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.check__5_;
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 14);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 10;
            label5.Text = "Wi-Fi Paneli";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 52);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 8;
            label6.Text = "IpPort:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(367, 21);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Vertical;
            textBox6.Size = new Size(250, 436);
            textBox6.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(638, 483);
            Controls.Add(textBox6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
