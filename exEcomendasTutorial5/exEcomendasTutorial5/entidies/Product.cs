using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exEcomendasTutorial5.entidies
{
    internal class Product
    {
        public string Name { get;private set; }
        private double prince;

        public Product(string name, double prince)
        {
            this.Name = name;
            this.prince = prince;
        }


        public override string ToString()
        {
            return $"\nDados do produto: {Name} preco (PVP) {prince:f2}";

        }
    }
}
