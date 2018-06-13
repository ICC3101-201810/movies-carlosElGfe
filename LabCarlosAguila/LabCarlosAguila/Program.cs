using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabCarlosAguila
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<Persona> personas = new List<Persona>();
            List<Estudio> estudios = new List<Estudio>();
            List<Pelicula> peliculas = new List<Pelicula>();
            List<PeliculaActor> peliculas_actores = new List<PeliculaActor>();
            List<PeliculaProductor> peliculas_productores = new List<PeliculaProductor>();
            Base_de_datos BD = new Base_de_datos(personas, estudios, peliculas, peliculas_actores, peliculas_productores);
            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);
            BinaryFormatter re = new BinaryFormatter();
            re.Serialize(fs, BD);
            fs.Close();
            Application.Run(new Form1());

        }
    }
}
