using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {

    public double Area(double lado)
    {
        return lado * lado;
    }

    public double Perimetro(double lado)
    {
        return 4 * lado;
    }

    public double Volumen(double lado)
    {
        return lado * lado * lado;
    }
 }
}
