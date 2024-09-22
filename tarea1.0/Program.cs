using System;

namespace tarea1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiante = new Estudiante(1, "Marializ", "Disla", "20231098@itla.edu.do", "Ingeniería");
            var docente = new Docente(2, "Katniss", "Evergreen", "ljdh@gmail.com", "Profesor", "Educacion Fisica");
            var exalumno = new Exalumno(3, "Pedrito", "Martínez", "vivelavida@gmail.com", "Ingeniería Civil");
            var administrativo = new Administrativo(4, "Sebastian", "Ruiz", "S.ruiz@gmail.com", "Secretario", "Administración");
            var administrador = new Administrador(5, "Marta", "de los angeles", "martadelosangeles@gmail.com", "Coordinador", "Química", "Administración Académica");
            var maestro = new Maestro(6, "Luna", "Creciente", "L.Creciente@gmail.com", "Maestro", "Arte", true);

            Console.WriteLine("Detalles:");
          

            Console.WriteLine($"Estudiante: {estudiante.Nombre} {estudiante.Apellido} - Carrera: {estudiante.Carrera} - Email: {estudiante.Email}");
            Console.WriteLine($"Docente: {docente.Nombre} {docente.Apellido} - Materia: {docente.Materia} - Cargo: {docente.ElCargo} - Email: {docente.Email}");
            Console.WriteLine($"Exalumno: {exalumno.Nombre} {exalumno.Apellido} - Carrera Cursada: {exalumno.gradcarr} - Email: {exalumno.Email}");
            Console.WriteLine($"Administrativo: {administrativo.Nombre} {administrativo.Apellido} - Departamento: {administrativo.Departamento} - Cargo: {administrativo.ElCargo} - Email: {administrativo.Email}");
            Console.WriteLine($"Administrador: {administrador.Nombre} {administrador.Apellido} - Materia: {administrador.Materia} - Cargo: {administrador.ElCargo} - Departamento: {administrador.Departamento} - Email: {administrador.Email}");
            Console.WriteLine($"Maestro: {maestro.Nombre} - Materia: {maestro.Materia} - Imparte: {(maestro.Imparte ? "Sí" : "No")}");

            Console.WriteLine("\nPresione enter");
            Console.ReadKey();
        }
    }
}