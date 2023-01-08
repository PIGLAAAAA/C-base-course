using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators2
{
    public abstract   class Product
    {
        public string Name { get; set; }
        public int Calorie { get; set; }
        public int Volume { get; set; }
        public double Energy
        {
            get
            {
               return Volume*Calorie/100.0;
            }
        }
        public Product(string name, int calorie, int volume)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if(calorie < 0)
            {
                throw new ArgumentNullException(nameof(calorie));
            }
            if(volume <= 0)
            {
                throw new ArgumentNullException(nameof(volume));
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
