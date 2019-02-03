using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public  class A
    {
        private int Age { get; set; }

        public string Name { get; }

        public A(string name)
        {
            Name = name;
        }
    }
}
