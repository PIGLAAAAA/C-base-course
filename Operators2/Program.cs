using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("красное яблоко", 100, 100);
            Apple apple2 = new Apple("зеленое яблоко", 90, 110);


            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2;
        }
    }
}
