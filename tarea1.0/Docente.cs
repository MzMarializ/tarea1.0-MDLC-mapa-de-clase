using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Docente : Empleado
    {
        public string Materia { get; set; }

        public Docente(int id, string nombre, string apellido, string email,
                       string cargo, string materia)
            : base(id, nombre, apellido, email, cargo)
        {
            Materia = materia;
        }
    }
}