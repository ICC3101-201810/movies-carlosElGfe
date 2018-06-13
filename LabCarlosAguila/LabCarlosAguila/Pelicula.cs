using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCarlosAguila
{
    [Serializable]

    public class Pelicula
    {
        public string nombre;
        public Persona director;
        public int fecha;
        public string descripcion;
        public Estudio estudio;
        public int presupuesto;
        public Pelicula(string MiNombre,Persona MiDirector,int Mifecha, string Midescripcion, Estudio MiEstudio, int MiPresupuesto)
        {
            nombre = MiNombre;
            director = MiDirector;
            fecha = Mifecha;
            descripcion = Midescripcion;
            presupuesto = MiPresupuesto;
            estudio = MiEstudio;
        }

    }
}
