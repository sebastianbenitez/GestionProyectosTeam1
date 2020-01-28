using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Clases
{
    class SprintBacklog
    {
        private List<Tarea> _tareas;
        public SprintBacklog()
        {
            _tareas = new List<Tarea>();
        }

        public void AgregarTarea(Tarea value)
        {
            _tareas.Add(value);
        }
        public void BorrarTarea(Tarea value)
        {
            _tareas.Remove(value);
        }
        public float CalcularHorasSprint()
        {
            float total = 0F;
            foreach (var tarea in _tareas)
            {
                total += tarea.CalcularEstimacionDesviada();
            }
            return total;
        }
    }
}
