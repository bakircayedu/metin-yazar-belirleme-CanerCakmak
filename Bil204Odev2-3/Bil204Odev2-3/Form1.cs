using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil204Odev2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Fonksiyon classımı tanımladım
        Func Func = new Func();

        //Cümle için ayrı kelimler için ayrı stack tanımladım.
        StackYapisi Stack_Lines = new StackYapisi();
        StackYapisi Stack_Words = new StackYapisi();

        
        Heap Heap = new Heap(1000);

        
        HashTable HashTable = new HashTable(20);

        bool StackeAktarimBasarisi = false; //Stacke atılmadan heap ağacına verileri aktarılmaması gerektiği için bir bool değişkeni oluşturdum
        bool AgacaAktarimBasarisi = false; // Heap ağacına atılmadan hash tablosuna veriler aktarılamayacağı için konrol amaçlı bir ğeişken oluşturdum


        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            //Dosya okuma işlemleri
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog.FileName;
                txt_FilePath.Text = filePath;
                txtAllFile.Text = File.ReadAllText(filePath);
            }

        }

        private void btn_ClearFile_Click(object sender, EventArgs e)
        {
            //Ekran temizleme İşlemleri
            txtAllFile.Clear();
            txt_FilePath.Clear();
            lst_LineList.Items.Clear();
            lv_WordInfo.Items.Clear();
            txt_EnCokKullanilanKelimeler.Clear();
            dgw_EnCokKullanilanKelimeler.DataSource = null;
            dgw_EnCokKullanilanKelimeler.Refresh();

        }

        private void btn_CreateWordList_Click(object sender, EventArgs e)
        {
            

            //Eklenen dosyadaki cümleler nokta ile ayrıldı.
            string allLines = txtAllFile.Text;
            string[] linesArray = allLines.Split('\n');


            int avgWords = 0; //Kelime Sayısını bulmak için atanan değişken

            //Bir yandan cümleleri listboxa yazarken bir yandan stacke ekledim.
            foreach (var line in linesArray)
            {
                Stack_Lines.Push(line);

                string[] lineWordsArray = line.Split(' ');
                string Item = line + "======> Cümle " + lineWordsArray.Count()  + " kelimeden oluşmaktadır.";
                lst_LineList.Items.Add(Item);
                //Cümlelerdeki kelimlerin toplamını bulma.
                avgWords += lineWordsArray.Count();
            }
            txt_ToplamKelime.Text = (avgWords.ToString()); //Toplam kelime sayısını yazdırma
            txt_CumleSayisi.Text = (linesArray.Count().ToString()) ; //Toplam cümle sayısını yazdırma
            txt_OrtalamaKelime.Text = (Func.OrtalamaKelime(avgWords, linesArray.Count())); // Kelimelerin ortalamasını başka fonksiyonda hesaplayıp yazdırma.

            StackeAktarimBasarisi = true;


            //Kelime Sıklığı Bulma
            List<Word> WordCounter = new List<Word>();

            int CumleSirasi = 0;
            int CumledekiKelimeSirasi = 0;
            int KelimeSirasi = 0;

            foreach (string line in linesArray)
            {
                CumledekiKelimeSirasi = 0;
                CumleSirasi++;

                string[] CumleninKelimeleri = line.Split(' '); //orijinal kelimeler bu arrayde tutulur.

                CumleninKelimeleri = CumleninKelimeleri.Select(s => s.ToLowerInvariant()).ToArray(); //Harfleri küçültme işlemi


                foreach (var k in Func.EkleriSil(CumleninKelimeleri)) //Ekleri ve noktalama işaretlerini çıkartarak stack içerisine atma işlemi
                {
                    
                    CumledekiKelimeSirasi++;
                    KelimeSirasi++;
                    

                    Word OlanKelime = WordCounter.Find(x => x.Kelime == k); //Küçük bir fonksiyon ile kelimenin liste içinde olup olmadığını belirleme işlemi
                    if (OlanKelime == null) 
                    {
                        //Eğer kelime listede yok ise ekleme işlemi : https://www.youtube.com/watch?v=bb5YjQEWVCg&t=980s
                        Word EklenenKelime = new Word(k, 1, KelimeSirasi, CumledekiKelimeSirasi, CumleSirasi);
                        WordCounter.Add(EklenenKelime);
                        Stack_Words.Push(EklenenKelime);
                    }
                    else
                    {
                        //Eğer kelime listede var ise sıklık arttırma işlemi
                        OlanKelime.Sıklık++;
                    }
                    

                }
            }

            //Kelime sıklık tablosunun sütünlarını düzenleme işlemi
            lv_WordInfo.Columns.Add("Kelime", 100);
            lv_WordInfo.Columns.Add("Sıklık", 50);
            lv_WordInfo.Columns.Add("Cümle Sırası", 75);
            lv_WordInfo.Columns.Add("Cümledeki Kelime Sırası", 140);
            lv_WordInfo.Columns.Add("Kelime Sırası", 75);
            lv_WordInfo.View = View.Details;
            lv_WordInfo.GridLines = true;
            lv_WordInfo.FullRowSelect = true;

            //Kelimeleri tüm özellikleriyle yazdırma
            foreach (Word w in WordCounter)
            {
                string[] Satir = new string[] { w.Kelime, w.Sıklık.ToString(), w.CumleSiraNo.ToString(), w.CumledekiKelimeSiraNo.ToString(), w.KelimeSiraNo.ToString() };
                lv_WordInfo.Items.Add(new ListViewItem(Satir));
                
            }    
        }

        //Ağaca Ekleme İşlemi
        private void btn_AgacaTasi_Click(object sender, EventArgs e)
        {
            //stacke aktarılmadan ağaca ekleme işlemi yapılırsa hata mesajı verdirme
            if (StackeAktarimBasarisi == true)
            {
                while (Stack_Words.IsEmpty() == false)
                {
                    
                    Word word = (Word)Stack_Words.Pop(); //stackten çıkartma
                    Heap.Insert(word); // Heap ağacına ekleme
                }
                AgacaAktarimBasarisi = true;
            }

            else
            {
                MessageBox.Show("Kelimeler öncelikli olarak stack yapısına aktarılmalı");
            }

        }
        //hash işlemleri
        private void bnt_Hashle_Click(object sender, EventArgs e)
        {
            if (StackeAktarimBasarisi == true && AgacaAktarimBasarisi == true)
            {
                for (int i = 0; i < Heap.currentSize; i++)
                {
                    Word word = Heap.heapArray[i].Word; //heap ağacında dönerek hash tablosuna aktarma
                    HashTable.TabloyaEkle(word.KelimeSiraNo, word); //Tabloya Ekleme Foksiyonu
                }
            }
            else
            {
                MessageBox.Show("Kelimeler öncelikli olarak stack yapısına ve heap ağacına aktarılmalı");
            }

        }

        //En sık kullanılan kelimeleri gösterme işlemi
        private void btn_EnCokKullanilan_Click(object sender, EventArgs e)
        {
            //texte girilen değişkenin inte dönüşebildiğini kontrol etme
            try
            {
                int.Parse(txt_EnCokKullanilanKelimeler.Text);
            }
            catch (Exception)
            {
                throw;
            }

            int kelimeSayisi = Convert.ToInt32(txt_EnCokKullanilanKelimeler.Text); //texte yazılanı inte dönüştüme
            dgw_EnCokKullanilanKelimeler.DataSource = Func.EnCokKullanilanKelimeleriYazdır(Heap, kelimeSayisi); //En çok kullanılan kelimeleri bulma fonksiyonu


        }
    }
}
