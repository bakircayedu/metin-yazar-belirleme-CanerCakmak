using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    public class Node
    {
        public object Word;
        public Node Next;

        public Node(object Word)
        {
            this.Word = Word;
            Next = null;

        }


    }
}
