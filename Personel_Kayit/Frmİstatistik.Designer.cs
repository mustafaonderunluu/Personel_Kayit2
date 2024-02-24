namespace Personel_Kayit
{
    partial class Frmİstatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblToplamPersonel = new System.Windows.Forms.Label();
            this.LblEvliPersonel = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.LblBekarPersonel = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.LblSehirSayısı = new System.Windows.Forms.Label();
            this.LblOrtMaas = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.LblToplamMaas = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı :";
            // 
            // LblToplamPersonel
            // 
            this.LblToplamPersonel.AutoSize = true;
            this.LblToplamPersonel.Location = new System.Drawing.Point(281, 38);
            this.LblToplamPersonel.Name = "LblToplamPersonel";
            this.LblToplamPersonel.Size = new System.Drawing.Size(24, 28);
            this.LblToplamPersonel.TabIndex = 1;
            this.LblToplamPersonel.Text = "0";
            // 
            // LblEvliPersonel
            // 
            this.LblEvliPersonel.AutoSize = true;
            this.LblEvliPersonel.Location = new System.Drawing.Point(281, 79);
            this.LblEvliPersonel.Name = "LblEvliPersonel";
            this.LblEvliPersonel.Size = new System.Drawing.Size(24, 28);
            this.LblEvliPersonel.TabIndex = 2;
            this.LblEvliPersonel.Text = "0";
            this.LblEvliPersonel.Click += new System.EventHandler(this.LblEvliPersonel_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(75, 79);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(200, 28);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Evli Personel Sayısı :";
            this.lbl2.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(54, 126);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(221, 28);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Bekar Personel Sayısı :";
            // 
            // LblBekarPersonel
            // 
            this.LblBekarPersonel.AutoSize = true;
            this.LblBekarPersonel.Location = new System.Drawing.Point(281, 126);
            this.LblBekarPersonel.Name = "LblBekarPersonel";
            this.LblBekarPersonel.Size = new System.Drawing.Size(24, 28);
            this.LblBekarPersonel.TabIndex = 5;
            this.LblBekarPersonel.Text = "0";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(145, 171);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(130, 28);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Şehir Sayısı :";
            // 
            // LblSehirSayısı
            // 
            this.LblSehirSayısı.AutoSize = true;
            this.LblSehirSayısı.Location = new System.Drawing.Point(281, 171);
            this.LblSehirSayısı.Name = "LblSehirSayısı";
            this.LblSehirSayısı.Size = new System.Drawing.Size(24, 28);
            this.LblSehirSayısı.TabIndex = 7;
            this.LblSehirSayısı.Text = "0";
            // 
            // LblOrtMaas
            // 
            this.LblOrtMaas.AutoSize = true;
            this.LblOrtMaas.Location = new System.Drawing.Point(281, 263);
            this.LblOrtMaas.Name = "LblOrtMaas";
            this.LblOrtMaas.Size = new System.Drawing.Size(24, 28);
            this.LblOrtMaas.TabIndex = 11;
            this.LblOrtMaas.Text = "0";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(107, 263);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(168, 28);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "Ortalama Maaş :";
            // 
            // LblToplamMaas
            // 
            this.LblToplamMaas.AutoSize = true;
            this.LblToplamMaas.Location = new System.Drawing.Point(281, 218);
            this.LblToplamMaas.Name = "LblToplamMaas";
            this.LblToplamMaas.Size = new System.Drawing.Size(24, 28);
            this.LblToplamMaas.TabIndex = 9;
            this.LblToplamMaas.Text = "0";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(126, 218);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(149, 28);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Toplam Maaş :";
            // 
            // Frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 314);
            this.Controls.Add(this.LblOrtMaas);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.LblToplamMaas);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.LblSehirSayısı);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.LblBekarPersonel);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.LblEvliPersonel);
            this.Controls.Add(this.LblToplamPersonel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmİstatistik";
            this.Text = "Frmİstatistik";
            this.Load += new System.EventHandler(this.Frmİstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblToplamPersonel;
        private System.Windows.Forms.Label LblEvliPersonel;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label LblBekarPersonel;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label LblSehirSayısı;
        private System.Windows.Forms.Label LblOrtMaas;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label LblToplamMaas;
        private System.Windows.Forms.Label lbl5;
    }
}