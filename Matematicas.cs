using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Matematicas : Operaciones
    {
        // Método para imprimir los resultados de las operaciones
        public void Imprimir(string tipoOperacion,double resultado)
        {
            Console.WriteLine($"El resultado de la operación {tipoOperacion} es: " + resultado);
        }
    }

}
