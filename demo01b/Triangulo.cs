using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01b
{
    internal class Triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalculaArea()
        {
            return (Base * Altura)/2;
        }

    }
}
