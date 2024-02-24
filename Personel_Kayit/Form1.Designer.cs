namespace Personel_Kayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskmaas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.combosehir = new System.Windows.Forms.ComboBox();
            this.maskmeslek = new System.Windows.Forms.MaskedTextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personelMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.maskmaas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combosehir);
            this.groupBox1.Controls.Add(this.maskmeslek);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Maaş :";
            // 
            // maskmaas
            // 
            this.maskmaas.Location = new System.Drawing.Point(148, 226);
            this.maskmaas.Mask = "00000";
            this.maskmaas.Name = "maskmaas";
            this.maskmaas.Size = new System.Drawing.Size(225, 32);
            this.maskmaas.TabIndex = 5;
            this.maskmaas.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Durum :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(245, 280);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 28);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(159, 280);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 28);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Meslek :";
            // 
            // combosehir
            // 
            this.combosehir.FormattingEnabled = true;
            this.combosehir.Location = new System.Drawing.Point(148, 180);
            this.combosehir.Name = "combosehir";
            this.combosehir.Size = new System.Drawing.Size(225, 32);
            this.combosehir.TabIndex = 4;
            // 
            // maskmeslek
            // 
            this.maskmeslek.Location = new System.Drawing.Point(148, 321);
            this.maskmeslek.Name = "maskmeslek";
            this.maskmeslek.Size = new System.Drawing.Size(225, 32);
            this.maskmeslek.TabIndex = 6;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(148, 81);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(225, 32);
            this.txtad.TabIndex = 2;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(148, 128);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(225, 32);
            this.txtsoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(148, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(225, 32);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel İd :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.btngrafikler);
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btngüncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(559, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btngrafikler
            // 
            this.btngrafikler.Location = new System.Drawing.Point(34, 299);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(218, 36);
            this.btngrafikler.TabIndex = 6;
            this.btngrafikler.Text = "Grafikler";
            this.btngrafikler.UseVisualStyleBackColor = true;
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(34, 255);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(218, 39);
            this.btnistatistik.TabIndex = 5;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(31, 210);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(221, 39);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "Temizlik";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.button5_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(31, 164);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(218, 38);
            this.btngüncelle.TabIndex = 3;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(31, 117);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(218, 42);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(31, 71);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(218, 40);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(31, 29);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(218, 37);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(11, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perdDurumDataGridViewCheckBoxColumn,
            this.personelMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdDurumDataGridViewCheckBoxColumn
            // 
            this.perdDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerdDurum";
            this.perdDurumDataGridViewCheckBoxColumn.HeaderText = "PerdDurum";
            this.perdDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perdDurumDataGridViewCheckBoxColumn.Name = "perdDurumDataGridViewCheckBoxColumn";
            this.perdDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // personelMeslekDataGridViewTextBoxColumn
            // 
            this.personelMeslekDataGridViewTextBoxColumn.DataPropertyName = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.HeaderText = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelMeslekDataGridViewTextBoxColumn.Name = "personelMeslekDataGridViewTextBoxColumn";
            this.personelMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(855, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1018, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1147, 621);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combosehir;
        private System.Windows.Forms.MaskedTextBox maskmeslek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafikler;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskmaas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

