using System;

namespace FuncionesEspeciales
{
    public class OperacionesEspeciales
    {
        private double num1;
        private double num2;

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 {get => num2; set => num2 = value; }

        public OperacionesEspeciales(){
            num1 = 0;
            num2 = 0;
        }

        public OperacionesEspeciales(double num1, double num2){
            this.num1 = num1;
            this.num2 = num2;
        }

        public void MostrarFuncionesEspeciales(double num){
            Console.WriteLine($"\nValor absoluto de {num} = {Math.Abs(num)}");
            Console.WriteLine($"\nCuadrado de {num} = {Math.Pow(num, 2)}");
            Console.WriteLine($"\nRaiz cuadrada de {num} = {Math.Sqrt(num)}");
            Console.WriteLine($"\nSeno de {num} = {Math.Sin(num)}");
            Console.WriteLine($"\nCoseno de {num} = {Math.Cos(num)}");
            Console.WriteLine($"\nParte entera de {num} = {Math.Truncate(num)}");
        }
        public void DeterminarMaximo(double num1, double num2){
            if (num1 > num2)
            {
                Console.WriteLine($"\nEl valor máximo es: {num1}");
            }else if (num2 > num1)
            {
                Console.WriteLine($"\nEl valor máximo es: {num2}");
            }else
            {
                Console.WriteLine("\nAmbos valores son iguales");
            }
        }

        public void DeterminarMinimo(double num1, double num2){
            if (num1 < num2)
            {
                Console.WriteLine($"\nEl valor mínimo es: {num1}");
            }else if (num2 < num1)
            {
                Console.WriteLine($"\nEl valor mínimo es: {num2}");
            }else
            {
                Console.WriteLine("\nAmbos valores son iguales");
            }
        }
    }
}