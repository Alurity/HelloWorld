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
            var human = new A(25);

            Console.WriteLine(human.Age);

            Console.ReadLine();
        }
    }

    public class A
    {
        public int Age { get; }

        public A(int age)
        {
            Age = age;
        }
    }
}
