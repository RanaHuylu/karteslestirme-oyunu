﻿
namespace OYUN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.pBarSkor = new System.Windows.Forms.ProgressBar();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Pink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Pink;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label16.Location = new System.Drawing.Point(399, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 79);
            this.label16.TabIndex = 15;
            this.label16.Text = "\\";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label16.Click += new System.EventHandler(this.label_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Pink;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label15.Location = new System.Drawing.Point(268, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 79);
            this.label15.TabIndex = 14;
            this.label15.Text = "/";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label15.Click += new System.EventHandler(this.label_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Pink;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label14.Location = new System.Drawing.Point(137, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 79);
            this.label14.TabIndex = 13;
            this.label14.Text = "\\";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label14.Click += new System.EventHandler(this.label_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Pink;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label13.Location = new System.Drawing.Point(6, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 79);
            this.label13.TabIndex = 12;
            this.label13.Text = "/";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label13.Click += new System.EventHandler(this.label_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Pink;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label12.Location = new System.Drawing.Point(399, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 76);
            this.label12.TabIndex = 11;
            this.label12.Text = "/";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label12.Click += new System.EventHandler(this.label_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Pink;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label11.Location = new System.Drawing.Point(268, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 76);
            this.label11.TabIndex = 10;
            this.label11.Text = "\\";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label11.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Pink;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label10.Location = new System.Drawing.Point(137, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 76);
            this.label10.TabIndex = 9;
            this.label10.Text = "/";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label10.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Pink;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label9.Location = new System.Drawing.Point(6, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 76);
            this.label9.TabIndex = 8;
            this.label9.Text = "\\";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Pink;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label8.Location = new System.Drawing.Point(399, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 76);
            this.label8.TabIndex = 7;
            this.label8.Text = "\\";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label8.Click += new System.EventHandler(this.label_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label7.Location = new System.Drawing.Point(268, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 76);
            this.label7.TabIndex = 6;
            this.label7.Text = "/";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label7.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(137, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 76);
            this.label6.TabIndex = 5;
            this.label6.Text = "\\";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 76);
            this.label5.TabIndex = 4;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label5.Click += new System.EventHandler(this.label_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(399, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 76);
            this.label4.TabIndex = 3;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label4.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(268, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 76);
            this.label3.TabIndex = 2;
            this.label3.Text = "\\";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(137, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "\\";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TextAlignChanged += new System.EventHandler(this.pictureBox1_Click);
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label17.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(612, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 44);
            this.label17.TabIndex = 2;
            this.label17.Text = "Skor:";
            // 
            // pBarSkor
            // 
            this.pBarSkor.BackColor = System.Drawing.SystemColors.Control;
            this.pBarSkor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pBarSkor.Location = new System.Drawing.Point(41, 43);
            this.pBarSkor.Name = "pBarSkor";
            this.pBarSkor.Size = new System.Drawing.Size(527, 21);
            this.pBarSkor.TabIndex = 3;
            this.pBarSkor.Value = 100;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.Location = new System.Drawing.Point(744, 36);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(37, 44);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "0";
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(261, 9);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(66, 32);
            this.lblSayac.TabIndex = 5;
            this.lblSayac.Text = "100";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.pBarSkor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ProgressBar pBarSkor;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Timer timer2;
    }
}
