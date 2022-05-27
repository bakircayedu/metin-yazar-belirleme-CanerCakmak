using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    public class StackYapisi : IStack
    {
        public Node Top;

        public StackYapisi()
        {
            Top = null;
        }

        public object Pop()
        {
            if (Top ==null)
            {
                return null;
            }
            else
            {
                object Data = Top.Word;
                Top = Top.Next;
                return Data ;
            }
        }

        public void Push(object data)
        {
            Node eleman = new Node(data);
            if (Top == null)
            {
                Top = eleman;
            }
            else
            {
                eleman.Next = Top;
                Top = eleman;
            }
        }

        public object Peek()
        {
            if (Top == null)
            {
                return null;
            }
            return Top.Word;
        }

        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }








    }
}
