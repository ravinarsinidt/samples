using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEx
{
    internal class AudreeStack
    {
        private int[] data = new int[5];
        private int top = -1;
        
        public void Push(int value)
        {
            if (this.top < data.Length - 1)
            {
                this.top++;
                this.data[top] = value;
            }
        }

        public int? Pop()
        {
            int? value = null;
            if (this.top > -1)
            {
                value = this.data[top];
                this.top--;
                return value;
            }
            return value;
        }

        public int GetCount() 
        {
            return this.top + 1;
        }
    }
}
