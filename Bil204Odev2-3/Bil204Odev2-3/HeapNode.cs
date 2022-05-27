using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    public class HeapNode
    {
        
        public Word Word { get; set; }
        public HeapNode Sag { get;  set; }
        public HeapNode Sol { get; set; }

        public HeapNode()
        {

        }
        public HeapNode(Word word)
        {
            Word = word;
            Sag = null;
            Sol = null;
        }
    }
}
