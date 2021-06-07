using System;
using MensajesCS;
using Operaciones;

namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciación de los objetos necesarios
            MensajesDeCalculadora mensaje = new MensajesDeCalculadora();

            // Declaración de variables
            int variableDeControl = 1;
            int opcionDeMenu;
            double primerValor;
            double segundoValor;
            //double resultado;
        
            // Inicio del programa Calculadora
            mensaje.SepararMensajes();
            mensaje.Bienvenida();
            do
            {
                mensaje.SepararMensajes();
                mensaje.SeleccionarOperaciones();
                mensaje.SepararMensajes();
                opcionDeMenu = Convert.ToInt32(Console.ReadLine());
                if (ControlarOpcionesDeMenu(opcionDeMenu))
                {
                    mensaje.IngresarPrimerValor();
                    primerValor = Convert.ToDouble(Console.ReadLine());
                    mensaje.IngresarSegundoValor();
                    segundoValor = Convert.ToDouble(Console.ReadLine());
                    
                    OperacionesBasicas operacion = new OperacionesBasicas(primerValor, segundoValor);

                    switch (opcionDeMenu)
                    {
                        case 1:
                            mensaje.SepararMensajes();
                            Console.WriteLine(primerValor +  " + " + segundoValor + " = " + operacion.Sumar());
                            mensaje.SepararMensajes();
                            break;
                        case 2:
                            mensaje.SepararMensajes();
                            Console.WriteLine(primerValor + " - " + segundoValor + " = " + operacion.Restar());
                            mensaje.SepararMensajes();
                            break;
                        case 3:
                            mensaje.SepararMensajes();
                            Console.WriteLine(primerValor + " x " + segundoValor + " = " + operacion.Multiplicar());
                            mensaje.SepararMensajes();
                            break;
                         case 4:
                         if (segundoValor == 0)
                         {
                             mensaje.SepararMensajes();
                             Console.WriteLine("¡Error! No se puede dividir por cero.");
                             mensaje.SepararMensajes();
                         }else{
                             mensaje.SepararMensajes();
                             Console.WriteLine(primerValor + " / " + segundoValor + " = " + operacion.Dividir());
                             mensaje.SepararMensajes();
                         }
                            break;
                        default:
                            break;
                    } 
                    mensaje.SalirOContinuar();
                    variableDeControl = Int32.Parse(Console.ReadLine());
                }else{
                    mensaje.SepararMensajes();
                    mensaje.MostrarErrorDeIngreso();
                    mensaje.SepararMensajes();
                    mensaje.SalirOContinuar();
                    mensaje.SepararMensajes();
                    variableDeControl = Int32.Parse(Console.ReadLine());
                }
            } while (variableDeControl != 0);
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

        public static bool ControlarOpcionesDeMenu(double numero){
            if (numero == 1 || numero == 2 || numero == 3 || numero == 4)
            {
                return true;
            }else{
                return false;
            }
        }
    }
}
