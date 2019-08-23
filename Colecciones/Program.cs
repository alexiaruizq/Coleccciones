using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas = new Grupo("Matematicas", "ARGP89");

            Grupo historia = new Grupo("Historia", "GPAR98");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno Aileen = new Alumno("Aileen", "189127");
            Alumno Fatima = new Alumno("Fatima", "189064");
            Alumno Gabriel = new Alumno("Gabriel", "169789");
            Alumno Rodo = new Alumno("Rodo", "178456");
            Alumno Yovana = new Alumno("Yovana", "169123");

            historia.Alumnos.Add(Aileen);
            historia.Alumnos.Add(Fatima);
            historia.Alumnos.Add(Yovana);

            matematicas.Alumnos.Add(Gabriel);
            matematicas.Alumnos.Add(Rodo);
            matematicas.Alumnos.Add(Aileen);
            matematicas.Alumnos.Add(Fatima);
            matematicas.Alumnos.Add(Yovana);

            foreach (Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " + grupo.Codigo);
                Console.WriteLine("Materia " + grupo.Materia);
                Console.WriteLine("Lista de alumnos:");
                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                }
            }

            Console.Read(); 
            
        }
    }
}
