using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCarlosAguila
{
    [Serializable]

    public class Persona
    {
        public string nombre;
        public string apellido;
        public string bibbliografia;
        public int AnoNacimiento;
        public string tipo;

        public Persona(string MiNombre,string MiApellido , string MiBibliografia,int MiAnoNacimiento,string MiTipo)
        {
            nombre = MiNombre;
            apellido = MiApellido;
            bibbliografia = MiBibliografia;
            AnoNacimiento = MiAnoNacimiento;
            tipo = MiTipo;
        }
    }
}
