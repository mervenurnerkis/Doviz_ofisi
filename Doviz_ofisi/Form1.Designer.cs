
namespace Doviz_ofisi
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
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.BtnSatisYap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDolarAlis.Location = new System.Drawing.Point(155, 31);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(22, 24);
            this.LblDolarAlis.TabIndex = 1;
            this.LblDolarAlis.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(44, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(50, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Euro Satış:";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEuroAlis.Location = new System.Drawing.Point(161, 150);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(22, 24);
            this.LblEuroAlis.TabIndex = 4;
            this.LblEuroAlis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(50, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Euro Alış:";
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDolarSatis.Location = new System.Drawing.Point(155, 83);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(22, 24);
            this.LblDolarSatis.TabIndex = 6;
            this.LblDolarSatis.Text = "0";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEuroSatis.Location = new System.Drawing.Point(161, 202);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(22, 24);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(33, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kur:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnSatisYap2);
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(378, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 264);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(80, 46);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(277, 30);
            this.TxtKur.TabIndex = 9;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(80, 82);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(277, 30);
            this.TxtMiktar.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Miktar:";
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Location = new System.Drawing.Point(244, 19);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(47, 36);
            this.BtnDolarAl.TabIndex = 10;
            this.BtnDolarAl.Text = "...";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Location = new System.Drawing.Point(244, 71);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(47, 36);
            this.BtnDolarSat.TabIndex = 11;
            this.BtnDolarSat.Text = "...";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Location = new System.Drawing.Point(244, 144);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(47, 36);
            this.BtnEuroAl.TabIndex = 12;
            this.BtnEuroAl.Text = "...";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            this.BtnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Location = new System.Drawing.Point(244, 196);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(47, 36);
            this.BtnEuroSat.TabIndex = 13;
            this.BtnEuroSat.Text = "...";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(80, 119);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(277, 30);
            this.TxtTutar.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(18, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tutar:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(80, 155);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(277, 30);
            this.TxtKalan.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(18, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Kalan:";
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Location = new System.Drawing.Point(80, 191);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(108, 46);
            this.BtnSatisYap.TabIndex = 16;
            this.BtnSatisYap.Text = "İşlem 1";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // BtnSatisYap2
            // 
            this.BtnSatisYap2.Location = new System.Drawing.Point(222, 191);
            this.BtnSatisYap2.Name = "BtnSatisYap2";
            this.BtnSatisYap2.Size = new System.Drawing.Size(135, 46);
            this.BtnSatisYap2.TabIndex = 17;
            this.BtnSatisYap2.Text = "İşlem 2";
            this.BtnSatisYap2.UseVisualStyleBackColor = true;
            this.BtnSatisYap2.Click += new System.EventHandler(this.BtnSatisYap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 555);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DÖVİZ BÜROSU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnEuroSat;
        private System.Windows.Forms.Button BtnSatisYap2;
    }
}

