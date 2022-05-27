using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYProje
{
    public abstract class StackADT
    {
        public Node top;
        public StackADT()
        {
            top=null;
        }
        public abstract void Push(object item);
        public abstract void Pop();
        
        
    }
}
