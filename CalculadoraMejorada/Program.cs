using System;
using MensajesCS;
using Operaciones;
using FuncionesEspeciales;

namespace CalculadoraMejorada
{
    class Program
    {
        static void Main(string[] args){

            // Instanciación
            MensajesDeCalculadora mensaje = new MensajesDeCalculadora();
            
            // Declaración de variables 
            int controlDeFin = 1, opcionOperaciones, opcionMenu;
            double primerValor, segundoValor, num;

            // Inicio del programa o interfaz de la Calculadora
            //Bienvenida
            mensaje.Saludar();

            // Bloque do while
            do
            {
                // Elegir Operaciones Básicas o Funciones Especiales
                mensaje.SeleccionarFunciones();
                opcionMenu = Convert.ToInt32(Console.ReadLine());

                if (ControlarOpcionesDeMenu(opcionMenu))
                {
                    if (opcionMenu == 1)
                    {
                        // Elegir Operaciones Básicas
                        mensaje.SeleccionarOperaciones();
                        opcionOperaciones = Convert.ToInt32(Console.ReadLine());
                        if (ControlarOpcionesDeOperaciones(opcionOperaciones))
                        {
                            mensaje.IngresarPrimerValor();
                            primerValor = Convert.ToDouble(Console.ReadLine());
                            mensaje.IngresarSegundoValor();
                            segundoValor = Convert.ToDouble(Console.ReadLine());
                    
                            OperacionesBasicas operacion = new OperacionesBasicas(primerValor, segundoValor);

                            switch (opcionOperaciones)
                            {
                                case 1:
                                    Console.WriteLine($"{primerValor} + {segundoValor} = {operacion.Sumar()}");
                                    break;
                                case 2:
                                    Console.WriteLine($"{primerValor} + {segundoValor} = {operacion.Restar()}");
                                    break;
                                case 3:
                                    Console.WriteLine($"{primerValor} x {segundoValor} = {operacion.Multiplicar()}");
                                    break;
                                case 4:
                                    if (segundoValor == 0)
                                    {
                                        mensaje.MostrarErrorDivision();
                                    }else{
                                        Console.WriteLine($"{primerValor} / {segundoValor} = {operacion.Dividir()}");
                                    }
                                    break;
                                default:
                                    break;
                            }
                            mensaje.SalirOContinuar();
                            controlDeFin = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            mensaje.MostrarErrorDeIngreso();
                            mensaje.SalirOContinuar();
                            controlDeFin = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        // Solicitar número y mostrar funciones especiales
                        OperacionesEspeciales operacion1 = new OperacionesEspeciales();
                        mensaje.IngresarValor();
                        num = Convert.ToDouble(Console.ReadLine());
                        operacion1.MostrarFuncionesEspeciales(num);
                        OperacionesEspeciales operacion2 = new OperacionesEspeciales();
                        mensaje.IngresarPrimerValor();
                        primerValor = Convert.ToDouble(Console.ReadLine());
                        mensaje.IngresarSegundoValor();
                        segundoValor = Convert.ToDouble(Console.ReadLine());
                        operacion2.DeterminarMaximo(primerValor, segundoValor);
                        operacion2.DeterminarMinimo(primerValor, segundoValor);
                        mensaje.SalirOContinuar();
                        controlDeFin = Convert.ToInt32(Console.ReadLine());
                    }
                }else
                {
                    mensaje.MostrarErrorDeIngreso();
                    mensaje.SalirOContinuar();
                    controlDeFin = Convert.ToInt32(Console.ReadLine());
                }
            } while (controlDeFin == 1);
        }

        // Métodos
        public static bool ControlarCero(double numero){
            if (numero == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public static bool ControlarOpcionesDeOperaciones(int numero){
            if (numero == 1 || numero == 2 || numero == 3 || numero == 4)
            {
                return true;
            }else{
                return false;
            }
        }
        
        public static bool ControlarOpcionesDeMenu(int numero){
            if (numero == 1 || numero == 2)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}