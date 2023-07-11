using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesEx
{
    internal class Student
    {
        public Student(int x)
        {
            this.XNumber = x;
        }
        private int Id { get; set; }

        public string Name { get; set; }
        public int XNumber
        {
            get
            {
                return this.Id + 200; ;
            }
            set
            {
                this.Id = 200;
            }
        }
        public int YNumber
        {
            get
            {
                return this.Id;
            } 
            set
            {
                this.Id = value;
            }
        }
    }
}
