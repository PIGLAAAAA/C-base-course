using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators2
{
    public class Apple : Product
    {
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)
        {//

        }

        public static Apple Add (Apple apple1, Apple appel2)
        {
            int calories = (int)Math.Round((apple1.Calorie + appel2.Calorie) / 2.0);
            var volume = apple1.Volume + appel2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }

        //перегрузка оператора
        public static Apple operator + (Apple apple1, Apple appel2)
        {
            int calories = (int)Math.Round((apple1.Calorie + appel2.Calorie) / 2.0);
            var volume = apple1.Volume + appel2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }
    }
}
