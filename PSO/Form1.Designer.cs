namespace PSO
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.JenerasyonSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ParcacikSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxUygunluk = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JenerasyonSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParcacikSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Uygunluk Değeri:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 21;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHesapla.Location = new System.Drawing.Point(203, 221);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(117, 41);
            this.btnHesapla.TabIndex = 20;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(184, 175);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(161, 22);
            this.C2.TabIndex = 19;
            this.C2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.RosyBrown;
            this.label.Location = new System.Drawing.Point(137, 177);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 16);
            this.label.TabIndex = 18;
            this.label.Text = "C2 : ";
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(184, 132);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(161, 22);
            this.C1.TabIndex = 17;
            this.C1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(137, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "C1 : ";
            // 
            // JenerasyonSayisi
            // 
            this.JenerasyonSayisi.Location = new System.Drawing.Point(184, 88);
            this.JenerasyonSayisi.Name = "JenerasyonSayisi";
            this.JenerasyonSayisi.Size = new System.Drawing.Size(161, 22);
            this.JenerasyonSayisi.TabIndex = 15;
            this.JenerasyonSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Jenerasyon Sayısı :";
            // 
            // ParcacikSayisi
            // 
            this.ParcacikSayisi.Location = new System.Drawing.Point(184, 46);
            this.ParcacikSayisi.Name = "ParcacikSayisi";
            this.ParcacikSayisi.Size = new System.Drawing.Size(161, 22);
            this.ParcacikSayisi.TabIndex = 13;
            this.ParcacikSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Parçacık Sayısı :";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(487, 268);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Uygunluk";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(473, 290);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // listBoxUygunluk
            // 
            this.listBoxUygunluk.FormattingEnabled = true;
            this.listBoxUygunluk.ItemHeight = 16;
            this.listBoxUygunluk.Location = new System.Drawing.Point(487, 22);
            this.listBoxUygunluk.Name = "listBoxUygunluk";
            this.listBoxUygunluk.Size = new System.Drawing.Size(473, 228);
            this.listBoxUygunluk.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 603);
            this.Controls.Add(this.listBoxUygunluk);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JenerasyonSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParcacikSayisi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JenerasyonSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParcacikSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown C2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown C1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown JenerasyonSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ParcacikSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBoxUygunluk;
    }
}

