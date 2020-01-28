using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Clases
{
    class Tarea
    {
        private int _estimacion;

        public Tarea()
        {
            _estimacion = 1;
        }
                
        public string Descripcion
        {
            get;
            set;
        }
        public int Estimacion
        {
            get 
            {
                return _estimacion;
            }
            set
            {
                if (!ComprobarFibo(_estimacion)) throw new ArgumentException("Estimacion no pertenece a la serie fibonacci");
                _estimacion = value;
            }
        }
        public Dificultad Dificultad
        {
            get;
            set;
        }

        public float CalcularEstimacionDesviada()
        {
            switch (Dificultad)
            {
                case Dificultad.facil:
                    return Estimacion;
                case Dificultad.complicada:
                    return Estimacion * 1.2F;
                case Dificultad.superComplicada:
                    return Estimacion * 1.5F;
                default:
                    return 0;
            }
        }

        public bool ComprobarFibo(int numero)
        {
            // excluye al 0 y a los negativos del fibonacci
            if (numero < 1) return false;
            if (numero == 1 || numero == 2) return true;
            // creo variables con las que se va a calcular la serie
            int anterior = 1, fibo = 2;
            do
            {
                if (numero == fibo) return true;
                fibo += anterior;
                anterior = fibo - anterior;
            } while (fibo <= numero);
            return false;
        }
    }
}
