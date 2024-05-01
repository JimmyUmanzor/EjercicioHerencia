using EjercicioHerencia;
using System;
public class Program
{
    static void Main(string[] args)
    {
            double numeroCalculos = 0;

            Console.Write("Ingrese un número para cálculos: ");
            numeroCalculos = double.Parse(Console.ReadLine());

            Matematicas Matematicas = new Matematicas();

            double calcularArea = Matematicas.Area(numeroCalculos);
            Matematicas.Imprimir("Area:",calcularArea);

            double calcularPerimetro = Matematicas.Perimetro(numeroCalculos);
            Matematicas.Imprimir("Perímetro:",calcularPerimetro);

            double calcularVolumen = Matematicas.Volumen(numeroCalculos);
            Matematicas.Imprimir("Volumen:",calcularVolumen);
    }
}
