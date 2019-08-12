using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Models
{
    public abstract class Persona
    {
        public static int ContadorPersonas { get; set; }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public String Apellido { get; set; }

        public short Edad { get; set; }

        public string Telefono { get; set; }
        public virtual string NombreCompleto
        {
            get
            {
                //return string.Format("{0} {1}", Nombre, Apellido);
                return $"{Nombre} {Apellido}";
            }
        }

        public Persona()
        {
            ContadorPersonas++;
        }


        public abstract string ConstruirResumen();
    }
}
