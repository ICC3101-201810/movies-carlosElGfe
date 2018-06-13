using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCarlosAguila
{
    [Serializable]

    public class PeliculaActor
    {
        public Persona actor;
        public Pelicula pelicula;
        public PeliculaActor(Persona Miactor, Pelicula Mipelicula)
        {
            actor = Miactor;
            pelicula = Mipelicula;
        }
    }
}
