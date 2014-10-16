using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AnimalToy
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public AnimalToy(string name)
        {
            this.name = name;
        }
    }
}
