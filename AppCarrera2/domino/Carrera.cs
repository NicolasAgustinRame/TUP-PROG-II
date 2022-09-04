using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCarrera2.domino
{
    internal class Carrera
    {
        private int codCarrera;
        private string nombreTitulo;
        private List<DetalleCarrera> detallesCarrera = new List<DetalleCarrera>();
       
        public int CodCarrera
        {
            get { return codCarrera; }
            set { codCarrera = value; }
        }

        public string NombreTitulo
        {
            get { return nombreTitulo; }
            set { nombreTitulo = value; }
        }

        public List<DetalleCarrera> DetallesCarreras
        {
            get { return detallesCarrera; }
            set { detallesCarrera = value;}
        }
        
        public override string ToString()
        {
            return "Nombre de la Carrera: " + NombreTitulo;
        }

        public void AgregarDetalle(DetalleCarrera detalle)
        {
            detallesCarrera.Add(detalle);
        }

        public void EliminarDetalle(int cod)
        {
            detallesCarrera.RemoveAt(cod);
        }

    }
}
