using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    class HashTable
    {
        public HashLinkedList[] hashTable;
        public HashTable(int size)
        {
            this.hashTable = new HashLinkedList[size];

        }

        public int KeyUret(int KelimeSiraNo)
        {
            int key = KelimeSiraNo;
            return key;
        }

        public void TabloyaEkle(int key, Word word)
        {
            HashLinkedList eklenenen = new HashLinkedList();
            eklenenen.Data = word;
            eklenenen.Key = KeyUret(word.KelimeSiraNo);

            int index = (key % 20);
            if (hashTable[index] == null)
            {

                eklenenen.Next = null;
                hashTable[index] = eklenenen;
            }
            else
            {

                HashLinkedList temp = hashTable[index];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = eklenenen;
                eklenenen.Next = null;
            }
        }

    }
}
