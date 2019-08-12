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

            var alumno1 = new Alumno("Adrian", "Garcia")
            {
                Id = 1,
                Edad = 21,
                Telefono = "202302332",
                Email ="adrian@platzi.com"
            };

            var profesor1 = new Profesor()
            {
                Id = 1, Nombre = "freddy",
                Apellido = "vega",
                Edad = 32,
                Telefono = "83493747",
                Catedra ="Programacion"
            };

            Console.WriteLine("Total de personas registras: " + Persona.ContadorPersonas);

            Console.WriteLine("Resumenes");

            Console.WriteLine(alumno1.ConstruirResumen());
            Console.WriteLine(profesor1.ConstruirResumen());

            Console.ReadLine();

        }
    }
}
