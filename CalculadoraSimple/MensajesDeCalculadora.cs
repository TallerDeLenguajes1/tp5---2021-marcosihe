using System;

namespace MensajesCS
{
    public class MensajesDeCalculadora
    {
        public void Bienvenida(){
            Console.WriteLine("*** Bienvenido a Calculadora Básica ***");
        }

        public void SeleccionarOperaciones(){
            Console.WriteLine("\nIngrese '1', '2', '3' o '4' según la operación que desee efectuar: ");
            Console.WriteLine("\n1. Suma\n2. Resta\n3. Multiplicación\n4. División");
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
            Console.WriteLine("\nIngrese el primer valor: ");
        }

        public void IngresarSegundoValor(){
            Console.WriteLine("\nIngrese el segundo valor: ");
        }
        public void SepararMensajes(){
            Console.WriteLine("------------------------------------------");
        }
    }
}