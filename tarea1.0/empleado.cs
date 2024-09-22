using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Empleado : Miembrodelacomunidad
    {
        public string ElCargo { get; set; }

        public Empleado(int id, string nombre, string apellido, string email, string cargo)
            : base(id, nombre, apellido, email)
        {
            ElCargo = cargo;
        }
    }
}