using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCarlosAguila
{
    [Serializable]
    public class Base_de_datos
    {
        public List<Persona> personas = new List<Persona>();
        public List<Estudio> estudios = new List<Estudio>();
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<PeliculaActor> peliculas_actores = new List<PeliculaActor>();
        public List<PeliculaProductor> peliculas_productores = new List<PeliculaProductor>();
        public Base_de_datos(List<Persona>perso,List<Estudio> estu,List<Pelicula> pelis, List<PeliculaActor> peliacto, List<PeliculaProductor> peliprodu)
        {
            perso = personas;
            estu = estudios;
            pelis = peliculas;
            peliacto = peliculas_actores;
            peliculas_productores = peliprodu;
        }
    }
}
