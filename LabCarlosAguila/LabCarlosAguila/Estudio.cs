using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCarlosAguila
{
    [Serializable]

    public class Estudio
    {
        public string nombre;
        public string direccion;
        public int fechaApertura;
        public Estudio(string MiNombre,string MiDireccion,int MifechaApertura)
        {
            nombre = MiNombre;
            direccion = MiDireccion;
            fechaApertura = MifechaApertura;
        }
    }
}
