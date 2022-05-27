
namespace Bil204Odev2_3
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
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.btn_ClearFile = new System.Windows.Forms.Button();
            this.txtAllFile = new System.Windows.Forms.TextBox();
            this.btn_CreateWordList = new System.Windows.Forms.Button();
            this.lst_LineList = new System.Windows.Forms.ListBox();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.lbl_AllFile = new System.Windows.Forms.Label();
            this.btn_AgacaTasi = new System.Windows.Forms.Button();
            this.bnt_Hashle = new System.Windows.Forms.Button();
            this.btn_EnCokKullanilan = new System.Windows.Forms.Button();
            this.txt_EnCokKullanilanKelimeler = new System.Windows.Forms.TextBox();
            this.dgw_EnCokKullanilanKelimeler = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ToplamKelime = new System.Windows.Forms.TextBox();
            this.txt_CumleSayisi = new System.Windows.Forms.TextBox();
            this.txt_OrtalamaKelime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_WordInfo = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_EnCokKullanilanKelimeler)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Location = new System.Drawing.Point(124, 13);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(91, 36);
            this.btn_LoadFile.TabIndex = 0;
            this.btn_LoadFile.Text = "Dosya Seç";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // btn_ClearFile
            // 
            this.btn_ClearFile.Location = new System.Drawing.Point(240, 13);
            this.btn_ClearFile.Name = "btn_ClearFile";
            this.btn_ClearFile.Size = new System.Drawing.Size(97, 36);
            this.btn_ClearFile.TabIndex = 4;
            this.btn_ClearFile.Text = "Temizle";
            this.btn_ClearFile.UseVisualStyleBackColor = true;
            this.btn_ClearFile.Click += new System.EventHandler(this.btn_ClearFile_Click);
            // 
            // txtAllFile
            // 
            this.txtAllFile.Location = new System.Drawing.Point(124, 94);
            this.txtAllFile.Multiline = true;
            this.txtAllFile.Name = "txtAllFile";
            this.txtAllFile.ReadOnly = true;
            this.txtAllFile.Size = new System.Drawing.Size(1032, 463);
            this.txtAllFile.TabIndex = 5;
            // 
            // btn_CreateWordList
            // 
            this.btn_CreateWordList.Location = new System.Drawing.Point(58, 47);
            this.btn_CreateWordList.Name = "btn_CreateWordList";
            this.btn_CreateWordList.Size = new System.Drawing.Size(121, 36);
            this.btn_CreateWordList.TabIndex = 8;
            this.btn_CreateWordList.Text = "Stack\'e Oku";
            this.btn_CreateWordList.UseVisualStyleBackColor = true;
            this.btn_CreateWordList.Click += new System.EventHandler(this.btn_CreateWordList_Click);
            // 
            // lst_LineList
            // 
            this.lst_LineList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_LineList.FormattingEnabled = true;
            this.lst_LineList.HorizontalScrollbar = true;
            this.lst_LineList.Location = new System.Drawing.Point(17, 98);
            this.lst_LineList.MultiColumn = true;
            this.lst_LineList.Name = "lst_LineList";
            this.lst_LineList.Size = new System.Drawing.Size(1162, 368);
            this.lst_LineList.TabIndex = 9;
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(124, 55);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(249, 20);
            this.txt_FilePath.TabIndex = 11;
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Location = new System.Drawing.Point(38, 58);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(67, 13);
            this.lbl_FilePath.TabIndex = 12;
            this.lbl_FilePath.Text = "Dosya Yolu :";
            // 
            // lbl_AllFile
            // 
            this.lbl_AllFile.AutoSize = true;
            this.lbl_AllFile.Location = new System.Drawing.Point(38, 97);
            this.lbl_AllFile.Name = "lbl_AllFile";
            this.lbl_AllFile.Size = new System.Drawing.Size(74, 13);
            this.lbl_AllFile.TabIndex = 13;
            this.lbl_AllFile.Text = "Dosya İçeriği :";
            // 
            // btn_AgacaTasi
            // 
            this.btn_AgacaTasi.Location = new System.Drawing.Point(226, 47);
            this.btn_AgacaTasi.Name = "btn_AgacaTasi";
            this.btn_AgacaTasi.Size = new System.Drawing.Size(101, 36);
            this.btn_AgacaTasi.TabIndex = 15;
            this.btn_AgacaTasi.Text = "Ağaca Taşı";
            this.btn_AgacaTasi.UseVisualStyleBackColor = true;
            this.btn_AgacaTasi.Click += new System.EventHandler(this.btn_AgacaTasi_Click);
            // 
            // bnt_Hashle
            // 
            this.bnt_Hashle.Location = new System.Drawing.Point(365, 47);
            this.bnt_Hashle.Name = "bnt_Hashle";
            this.bnt_Hashle.Size = new System.Drawing.Size(91, 36);
            this.bnt_Hashle.TabIndex = 16;
            this.bnt_Hashle.Text = "Hash İşlemi";
            this.bnt_Hashle.UseVisualStyleBackColor = true;
            this.bnt_Hashle.Click += new System.EventHandler(this.bnt_Hashle_Click);
            // 
            // btn_EnCokKullanilan
            // 
            this.btn_EnCokKullanilan.Location = new System.Drawing.Point(543, 214);
            this.btn_EnCokKullanilan.Name = "btn_EnCokKullanilan";
            this.btn_EnCokKullanilan.Size = new System.Drawing.Size(109, 65);
            this.btn_EnCokKullanilan.TabIndex = 17;
            this.btn_EnCokKullanilan.Text = "En Çok Kullanılan Kelimeleri Yazdır";
            this.btn_EnCokKullanilan.UseVisualStyleBackColor = true;
            this.btn_EnCokKullanilan.Click += new System.EventHandler(this.btn_EnCokKullanilan_Click);
            // 
            // txt_EnCokKullanilanKelimeler
            // 
            this.txt_EnCokKullanilanKelimeler.Location = new System.Drawing.Point(526, 188);
            this.txt_EnCokKullanilanKelimeler.Name = "txt_EnCokKullanilanKelimeler";
            this.txt_EnCokKullanilanKelimeler.Size = new System.Drawing.Size(139, 20);
            this.txt_EnCokKullanilanKelimeler.TabIndex = 19;
            // 
            // dgw_EnCokKullanilanKelimeler
            // 
            this.dgw_EnCokKullanilanKelimeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_EnCokKullanilanKelimeler.Location = new System.Drawing.Point(707, 27);
            this.dgw_EnCokKullanilanKelimeler.Name = "dgw_EnCokKullanilanKelimeler";
            this.dgw_EnCokKullanilanKelimeler.Size = new System.Drawing.Size(487, 560);
            this.dgw_EnCokKullanilanKelimeler.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 651);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_LoadFile);
            this.tabPage1.Controls.Add(this.txt_FilePath);
            this.tabPage1.Controls.Add(this.lbl_FilePath);
            this.tabPage1.Controls.Add(this.lbl_AllFile);
            this.tabPage1.Controls.Add(this.txtAllFile);
            this.tabPage1.Controls.Add(this.btn_ClearFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1221, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dosya Ekleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_OrtalamaKelime);
            this.tabPage2.Controls.Add(this.txt_CumleSayisi);
            this.tabPage2.Controls.Add(this.txt_ToplamKelime);
            this.tabPage2.Controls.Add(this.btn_CreateWordList);
            this.tabPage2.Controls.Add(this.bnt_Hashle);
            this.tabPage2.Controls.Add(this.lst_LineList);
            this.tabPage2.Controls.Add(this.btn_AgacaTasi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1221, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stack İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dgw_EnCokKullanilanKelimeler);
            this.tabPage3.Controls.Add(this.lv_WordInfo);
            this.tabPage3.Controls.Add(this.btn_EnCokKullanilan);
            this.tabPage3.Controls.Add(this.txt_EnCokKullanilanKelimeler);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1221, 625);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kelime İşlemleri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "İstenilen Kelime Adetini Giriniz";
            // 
            // txt_ToplamKelime
            // 
            this.txt_ToplamKelime.Location = new System.Drawing.Point(216, 503);
            this.txt_ToplamKelime.Name = "txt_ToplamKelime";
            this.txt_ToplamKelime.Size = new System.Drawing.Size(100, 20);
            this.txt_ToplamKelime.TabIndex = 17;
            // 
            // txt_CumleSayisi
            // 
            this.txt_CumleSayisi.Location = new System.Drawing.Point(520, 503);
            this.txt_CumleSayisi.Name = "txt_CumleSayisi";
            this.txt_CumleSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_CumleSayisi.TabIndex = 18;
            // 
            // txt_OrtalamaKelime
            // 
            this.txt_OrtalamaKelime.Location = new System.Drawing.Point(863, 503);
            this.txt_OrtalamaKelime.Name = "txt_OrtalamaKelime";
            this.txt_OrtalamaKelime.Size = new System.Drawing.Size(100, 20);
            this.txt_OrtalamaKelime.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Toplam Kelime Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Toplam Cümle Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ortalama Kelime Sayısı: ";
            // 
            // lv_WordInfo
            // 
            this.lv_WordInfo.HideSelection = false;
            this.lv_WordInfo.Location = new System.Drawing.Point(15, 27);
            this.lv_WordInfo.Name = "lv_WordInfo";
            this.lv_WordInfo.Size = new System.Drawing.Size(492, 560);
            this.lv_WordInfo.TabIndex = 14;
            this.lv_WordInfo.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 851);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_EnCokKullanilanKelimeler)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Button btn_ClearFile;
        private System.Windows.Forms.TextBox txtAllFile;
        private System.Windows.Forms.Button btn_CreateWordList;
        private System.Windows.Forms.ListBox lst_LineList;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.Label lbl_AllFile;
        private System.Windows.Forms.Button btn_AgacaTasi;
        private System.Windows.Forms.Button bnt_Hashle;
        private System.Windows.Forms.Button btn_EnCokKullanilan;
        private System.Windows.Forms.TextBox txt_EnCokKullanilanKelimeler;
        private System.Windows.Forms.DataGridView dgw_EnCokKullanilanKelimeler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OrtalamaKelime;
        private System.Windows.Forms.TextBox txt_CumleSayisi;
        private System.Windows.Forms.TextBox txt_ToplamKelime;
        private System.Windows.Forms.ListView lv_WordInfo;
    }
}

