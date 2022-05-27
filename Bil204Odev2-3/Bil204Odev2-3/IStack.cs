using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    interface IStack
    {
        object Pop();
        void Push(object data);
        object Peek();
        bool IsEmpty();
    }
}
