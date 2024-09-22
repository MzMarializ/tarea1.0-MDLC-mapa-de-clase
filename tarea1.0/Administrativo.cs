using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Administrativo : Empleado
    {
        public string Departamento { get; set; }

        public Administrativo(int id, string nombre, string apellido, string email, string cargo, string departamento)
            : base(id, nombre, apellido, email, cargo)
        {
            Departamento = departamento;
        }
    }
}
