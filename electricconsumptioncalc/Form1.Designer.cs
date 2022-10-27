namespace electricconsumptioncalc
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.powerbox = new System.Windows.Forms.TextBox();
            this.monthlycbox = new System.Windows.Forms.TextBox();
            this.dailycbox = new System.Windows.Forms.TextBox();
            this.monthlyhbox = new System.Windows.Forms.TextBox();
            this.dailyhbox = new System.Windows.Forms.TextBox();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.electricbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Power:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daily Working Hour:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Working Hour: ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Daily Energy Consumption:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monthly Energy Consumption:";
            // 
            // powerbox
            // 
            this.powerbox.Location = new System.Drawing.Point(111, 24);
            this.powerbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.powerbox.Name = "powerbox";
            this.powerbox.Size = new System.Drawing.Size(95, 21);
            this.powerbox.TabIndex = 6;
            // 
            // monthlycbox
            // 
            this.monthlycbox.Location = new System.Drawing.Point(198, 411);
            this.monthlycbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.monthlycbox.Name = "monthlycbox";
            this.monthlycbox.Size = new System.Drawing.Size(95, 21);
            this.monthlycbox.TabIndex = 7;
            // 
            // dailycbox
            // 
            this.dailycbox.Location = new System.Drawing.Point(181, 373);
            this.dailycbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dailycbox.Name = "dailycbox";
            this.dailycbox.Size = new System.Drawing.Size(95, 21);
            this.dailycbox.TabIndex = 8;
            // 
            // monthlyhbox
            // 
            this.monthlyhbox.Location = new System.Drawing.Point(148, 150);
            this.monthlyhbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.monthlyhbox.Name = "monthlyhbox";
            this.monthlyhbox.Size = new System.Drawing.Size(95, 21);
            this.monthlyhbox.TabIndex = 9;
            // 
            // dailyhbox
            // 
            this.dailyhbox.Location = new System.Drawing.Point(148, 106);
            this.dailyhbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dailyhbox.Name = "dailyhbox";
            this.dailyhbox.Size = new System.Drawing.Size(95, 21);
            this.dailyhbox.TabIndex = 10;
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(78, 61);
            this.numberbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(95, 21);
            this.numberbox.TabIndex = 11;
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(18, 261);
            this.calculatebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(192, 27);
            this.calculatebutton.TabIndex = 12;
            this.calculatebutton.Text = "CALCULATE";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 342);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 466);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monthly Electric Consumption:\r\n";
            // 
            // electricbox
            // 
            this.electricbox.Location = new System.Drawing.Point(200, 463);
            this.electricbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.electricbox.Name = "electricbox";
            this.electricbox.Size = new System.Drawing.Size(95, 21);
            this.electricbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(214, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "kwh.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(522, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.electricbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.dailyhbox);
            this.Controls.Add(this.monthlyhbox);
            this.Controls.Add(this.dailycbox);
            this.Controls.Add(this.monthlycbox);
            this.Controls.Add(this.powerbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "ELECTRİC CALCULATE CONSUMPTİON";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox powerbox;
        private System.Windows.Forms.TextBox monthlycbox;
        private System.Windows.Forms.TextBox dailycbox;
        private System.Windows.Forms.TextBox monthlyhbox;
        private System.Windows.Forms.TextBox dailyhbox;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox electricbox;
        private System.Windows.Forms.Label label8;
    }
}

