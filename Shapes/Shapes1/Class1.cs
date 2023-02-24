using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes1
{
    internal class Class1
    {
        private int size;

        public Class1()
        {
            size = 8;
        }
        public Class1(int s)
        {
            SetSize(s);
        }
        public void SetSize(int n)
        {
            if((n>0) && (n < 40))
            {
                size = n;
            }
            else
            {
                Console.WriteLine("Error wrong size" + n);
            }
        }
        public int GetSize() { return size; }   
    }
}
