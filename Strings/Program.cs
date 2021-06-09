using System;
using  System.Text;
using System.IO;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables locales
            //int inicio, fin;

            Console.WriteLine("Ingrese una frase de más de 10 caracteres");
            //StringBuilder text1 = new StringBuilder(Console.ReadLine());
            string text1 = Console.ReadLine();
            Console.WriteLine($"Cadena inrgesada: {text1}");

            // Obtener algunas letras que forman la cadena
            Console.WriteLine("\nSe muestra desde la posición 2 hasta la posición 8 de la frase ingresada:");
            Console.WriteLine(text1.Substring(2,8));

            // Longitud de la cadena ingresada
            Console.WriteLine($"Longitud de la cadena ingresada: {text1.Length} caracteres.");

            // Concatenar o unir dos cadenas distintas
            Console.WriteLine("Ingrese otra frase para unirla con la anterior");
            string text2 = Console.ReadLine();
            string text3 = text1 + text2;
            Console.WriteLine($"La frase concatenada es: {text3}");

            // Formateo de cadena de texto $""
            Console.WriteLine("Haciendo uso del formateo de cadenas de texto");
            Console.WriteLine("Ingrese un numero entero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero entero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            // Recorrer la cadena ingresada y mostrar por pantalla cada elemento
            Console.WriteLine("Recorrido de la cadena concatenada (usando Foreach)");
            foreach (var item in text3)
            {
                Console.WriteLine(item);
            }

            // Buscar coincidencia de una cadena o palabra que esté contenida en la cadena concatenada
            Console.WriteLine("Ingrese la palabra o frase a buscar");
            string text4 = Console.ReadLine();
            if (text3.Contains(text4))
            {
                Console.WriteLine($"'{text4}' está contenida dentro de '{text3}'");
            }else
            {
                Console.WriteLine($"La frase o palabra ingresada no está contenida en {text3}");
            }

            // Método ToUpper()
            Console.WriteLine($"Cadena en mayúsculas: {text3.ToUpper()}");

            // Método ToLower()
            Console.WriteLine($"Cadena en minúsculas: {text3.ToLower()}");

            // Comparar valores de dos cadenas
            Console.WriteLine("Ingrese una nueva frase");
            string text5 = Console.ReadLine();
            if (text3.Equals(text5))
            {
                Console.WriteLine($"Las cadenas '{text3}' y '{text5}' son iguales");
            }else
            {
                Console.WriteLine($"Las cadenas '{text3}' y '{text5}' no son iguales");
            }

            // Método Split()
            Console.WriteLine($"Aplicando el método Split() a la última cadena ingresada '{text5}'");
        }
    }
}
