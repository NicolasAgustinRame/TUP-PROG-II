using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCarrera2.domino
{
    internal class DetalleCarrera
    {
        public int AnioCursado { get; set; }

        public int Cuatrimestre { get; set; }

        public Asignatura Materia { get; set; }

        public DetalleCarrera(int anioCursado, int cuatrimestre, Asignatura materia)
        {
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }

        public override string ToString()
        {
            return "Año Cursado: " + AnioCursado + " - Cuatrimestre: " + Cuatrimestre + " - Materia: " + Materia.ToString();
        }
    }
}
