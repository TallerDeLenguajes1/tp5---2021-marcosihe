using System;
using Inverter;


namespace InvertirNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            Console.WriteLine("Ingrese un numero entero positivo: ");
            numeroIngresado = Int32.Parse(Console.ReadLine());
            if (numeroIngresado > 0)
            {
                Invertidor numeroInvertido1 = new Invertidor();
                numeroInvertido1.Numero = numeroIngresado;
                Console.WriteLine("Numero dado: " + numeroInvertido1.Numero);
                Console.WriteLine("El número invertido es: " + numeroInvertido1.Invertir());
            }else
            {
                Console.WriteLine("El número ingresado no es positivo. Fin del programa.");
            }
        }
    }
}
