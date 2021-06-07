using System;

namespace Operaciones
{
    public class OperacionesBasicas
    {
        private double num1;
        private double num2;

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

        public OperacionesBasicas(){
            num1 = 0;
            num2 = 1;
        }

        public OperacionesBasicas(double num1, double num2){
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Sumar(){
            return num1 + num2;
        }

        public double Restar(){
            return num1 - num2;
        }

        public double Multiplicar(){
            return num1 * num2;
        }

        public double Dividir(){
            return num1 / num2;
        }
    }
}