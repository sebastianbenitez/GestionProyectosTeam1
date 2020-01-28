using System;
using Proyecto.Clases;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            var tarea1 = new Tarea();
            tarea1.Estimacion = 1;
            tarea1.Dificultad = Dificultad.complicada;
            Console.WriteLine("Cant estimacion: " + tarea1.Estimacion + ", dificultad: " + tarea1.Dificultad + ", estimacionConDesvio: " + tarea1.CalcularEstimacionDesviada());

            var tarea2 = new Tarea();
            tarea2.Estimacion = 13;
            tarea2.Dificultad = Dificultad.facil;
            Console.WriteLine("Cant estimacion: " + tarea2.Estimacion + ", dificultad: " + tarea2.Dificultad + ", estimacionConDesvio: " + tarea2.CalcularEstimacionDesviada());

            var tarea3 = new Tarea();
            tarea3.Estimacion = 5;
            tarea3.Dificultad = Dificultad.superComplicada;
            Console.WriteLine("Cant estimacion: " + tarea3.Estimacion + ", dificultad: " + tarea3.Dificultad + ", estimacionConDesvio: " + tarea3.CalcularEstimacionDesviada());

            var backlog = new SprintBacklog();
            backlog.AgregarTarea(tarea1);
            backlog.AgregarTarea(tarea2);
            backlog.AgregarTarea(tarea3);

            Console.WriteLine("Total de horas Sprint: " + backlog.CalcularHorasSprint());

            var proyecto = new ProductBacklog();
            proyecto.AgregarSprint(backlog);

            Console.WriteLine("Total de horas Proyecto: " + proyecto.CalcularHorasProyecto());
            Console.ReadKey();
        }
    }
}
