using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //triangulo
            Triangulo triangulo = new Triangulo();

            triangulo.Altura = 4;
            triangulo.Base = 5;

            int resultado = triangulo.CalculaArea();

            Console.WriteLine("El resultado es " + resultado);

            //persona
            Persona persona = new Persona();

            persona.Nombre = "Bruno";
            persona.Apellido = "Chigne";
            persona.Edad = "19";
            persona.AsignarNombresCompletos();

            Console.WriteLine(persona.NombresCompletos);

            Persona persona1 = new Persona()
            {
                Nombre = "Estela",
                Apellido = "Melendez",
                Edad = "19"
            };

            esMayor = persona1.Mayor();

            Console.Read();
        }
    }
}
