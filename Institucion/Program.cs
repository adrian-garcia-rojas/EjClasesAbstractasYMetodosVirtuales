using Institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APLICACION DE INSTITUCION");


            Persona[] lista = new Persona[3];

            lista [0] = new Alumno("Adrian", "Garcia")
            {
                Id = 1,
                Edad = 21,
                Telefono = "202302332",
                Email ="adrian@platzi.com"
            };

            lista [1] = new Profesor()
            {
                Id = 2, Nombre = "elizabeth",
                Apellido = "munoz",
                Edad = 23,
                Telefono = "83493412",
                Catedra ="Cocina Internacional"
            };

            lista[2] = new Profesor()
            {
                Id = 3,
                Nombre = "freddy",
                Apellido = "vega",
                Edad = 32,
                Telefono = "83493747",
                Catedra = "Programacion"
            };

            Console.WriteLine("Total de personas registras: " + Persona.ContadorPersonas);

            Console.WriteLine("Resumenes");

            foreach(Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine(p.ConstruirResumen());
            }

            Console.ReadLine();

        }
    }
}
