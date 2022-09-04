using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCarrera2.domino
{
    internal class Asignatura
    {
        public int CodAsignatura { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return "Asignatura: " + Nombre;
        }

    }
}
