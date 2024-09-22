using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Estudiante : Miembrodelacomunidad
    {
        public string Carrera { get; set; }

        public Estudiante(int id, string nombre, string apellido, string email, string carrera)
            : base(id, nombre, apellido, email)
        {
            Carrera = carrera;
        }
    }
}
