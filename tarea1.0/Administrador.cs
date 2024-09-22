using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Administrador : Docente
    {
        public string Departamento { get; set; }

        public Administrador(int id, string nombre, string apellido, string email,
                             string cargo, string materia, string departamento)
            : base(id, nombre, apellido, email, cargo, materia)
        {
            Departamento = departamento;
        }
    }
}
