using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    public class Word
    {
        public string Kelime { get; set; } //kelimenin kendisi
        public int Sıklık { get; set; } //Kaç defa Kullanılmış
        
        public int KelimeSiraNo { get; set; }//Dosya içinde kaçıncı kelime

        public int CumleSiraNo { get; set; } //cümle içerisinde kaçıncı kelime

        public int CumledekiKelimeSiraNo { get; set; }
        public Word()
        {

        }
        public Word(string Kelime, int Sıklık, int KelimeSiraNo,int CumledekiKelimeSiraNo ,int CumleSiraNo)
        {
            this.Kelime = Kelime;
            this.Sıklık = Sıklık;
            this.KelimeSiraNo = KelimeSiraNo;
            this.CumledekiKelimeSiraNo = CumledekiKelimeSiraNo;
            this.CumleSiraNo = CumleSiraNo;
        }

    }
}
