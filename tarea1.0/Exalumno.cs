using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Exalumno : Miembrodelacomunidad
    {
        public string gradcarr { get; set; }

        public Exalumno(int id, string nombre, string apellido, string email, string Carreracursada)
            : base(id, nombre, apellido, email)
        {
            gradcarr = Carreracursada;
        }
    }
}
