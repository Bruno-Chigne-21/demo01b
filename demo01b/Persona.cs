using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01b
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string NombresCompletos { get; set; }

        public string Mayor()
        {
            if (int.Parse(Edad) >= 18){
                return "Es mayor de edad";
            } else
            {
                return "Es menor de edad";
            }
        }

        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombre + " " + Apellido;
        }

    }
}
