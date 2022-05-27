using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    public class Func
    {
        //bütün kelime sayısını ve cümle sayısını parametre olarak olarak ortalama kelime hesabı yapan fonksiyon
        public string OrtalamaKelime(float avgwords, float size)
        {
            float avgWords = 0;
            avgWords = avgwords / size;
            return  avgWords.ToString("n2");
        }

        // Kelimeleri harf harf dolaşarak gerekli yerleri silme fonksiyonu  --https://www.tutorialspoint.com/char-ispunctuation-method-in-chash
        public string[] EkleriSil(string[] kelimeler)
        {
            for (int i = 0; i < kelimeler.Length; i++)
            {
                for (int j = 0; j < kelimeler[i].Length; j++)
                {
                    if (Char.IsPunctuation(kelimeler[i], j))
                    {
                        kelimeler[i] = kelimeler[i].Substring(0, j);
                        break;
                    }
                }
            }
            
            return kelimeler;
        }
        //Heap ağacını ve istenilen kelime sayısını parametre olarak alarak bunları heap içindeki sort fonksiyonuyla return eden fonksiyon
        public Word[] EnCokKullanilanKelimeleriYazdır(Heap heap, int kelimeSayisi)
        {
            Word[] enCokKelimeler = new Word[kelimeSayisi];
            for (int i = 0; i < kelimeSayisi; i++)
            {
                enCokKelimeler[i] = heap.heapArray[i].Word;
            }
            return heap.Sort(enCokKelimeler);
        }




    }
}
