using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Models
{
    class Alumno : Persona
    {
        public string Email { get; set; }
        public string NickName { get;  set; }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ConstruirResumen()
        {
            return $"{NombreCompleto}, {NickName}, {Telefono}";
        }

        public override string NombreCompleto => base.NombreCompleto.ToUpper(); // esto se puede hacer por que en la clase padre estamos realizando un metodo virtual
        //public override string NombreCompleto {   //esto tambien esquivalente con la funcionalidad de arriba y podemos hacer cosas diferentes como enviar mensajes de que la informacion existe pero esta bloqueada, esto ya es mas cuestion del modelo del negocio que se este implementando

        //    get
        //    {
        //        return "INFORMACION BLEQUEADA";
        //    }
            
        //}
    }
}
