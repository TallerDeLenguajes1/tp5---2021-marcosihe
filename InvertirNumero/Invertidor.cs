namespace Inverter
{
    public class Invertidor
    {
        private int numero;

        public int Numero { get => numero; set => numero = value; }

        public int Invertir(){
            int resto, invertido = 0;

            while (numero > 0)
            {
                resto = numero % 10;
                invertido = invertido * 10 + resto;
                numero /= 10;
            }
            return invertido;
        }
    }
}