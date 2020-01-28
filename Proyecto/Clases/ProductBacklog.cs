using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Clases
{
    class ProductBacklog
    {
        private List<SprintBacklog> _sprints;
        public ProductBacklog()
        {
            _sprints = new List<SprintBacklog>();
        }
        public void AgregarSprint(SprintBacklog value)
        {
            _sprints.Add(value);
        }
        public void BorrarSprint(SprintBacklog value)
        {
            _sprints.Remove(value);
        }
        public float CalcularHorasProyecto()
        {
            float total = 0F;
            foreach (var sprint in _sprints)
            {
                total += sprint.CalcularHorasSprint();
            }
            return total;
        }
    }
}
