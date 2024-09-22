using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1._0
{
    public class Miembrodelacomunidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        

        public Miembrodelacomunidad(int id, string nombre, string apellido, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }
    }
}
