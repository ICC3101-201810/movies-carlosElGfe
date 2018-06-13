using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCarlosAguila
{
    [Serializable]

    public class PeliculaProductor
    {
        public Persona productor;
        public Pelicula pelicula;
        public PeliculaProductor(Persona Miproductor,Pelicula Mipelicula)
        {
            productor = Miproductor;
            pelicula = Mipelicula;

        }
    }
}
