using System;

namespace MensajesCS
{
    public class MensajesDeCalculadora
    {
        public void Saludar(){
            Console.WriteLine("*** Bienvenido a Calculadora ***");
        }

        public void SeleccionarOperaciones(){
            Console.WriteLine("\nIngrese '1', '2', '3' o '4' según la operación que desee efectuar: ");
            Console.WriteLine("\n1. Suma\n2. Resta\n3. Multiplicación\n4. División");
        }

        public void SeleccionarFunciones(){
            Console.WriteLine("\nIngrese '1'o '2' según la operación que desee efectuar: ");
            Console.WriteLine("\n1. Operaciones básicas\n2. Funciones especiales");
        }

        public void SalirOContinuar(){
            Console.WriteLine("\n¿Salir de Calculadora Básica?\n(Debe ingresar 0 o 1 según corresponda)\n\n0. Salir.\n1. Continuar operando.");
        }

        public void MostrarErrorDivision(){
            Console.WriteLine("\n¡Error! No se puede dividir por cero.");
        }

        public void MostrarErrorDeIngreso(){
            Console.WriteLine("\nLa opción ingresada no es correcta.");
        }

        public void IngresarPrimerValor(){
            Console.WriteLine("\nIngrese el primer número: ");
        }

        public void IngresarSegundoValor(){
            Console.WriteLine("\nIngrese el segundo número: ");
        }

        public void IngresarValor(){
            Console.WriteLine("\nIngrese un número: ");
        }

        public void SepararMensajes(){
            Console.WriteLine("------------------------------------------");
        }
    }
}