using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Maestro : Docente
    {
        public bool Imparte { get; set; }

        public Maestro(int id, string nombre, string apellido, string email,
                       string cargo, string materia, bool impartema)
            : base(id, nombre, apellido, email, cargo, materia)
        {
            Imparte = impartema;
        }
    }
}
