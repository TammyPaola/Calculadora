using System;

namespace Calculadora
{
    public class Matematicas
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
        public int Restar(int sumando1, int sumando2)
        {
            return sumando1 - sumando2;
        }
        public int Multiplicar(int sumando1, int sumando2)
        {
            return sumando1 * sumando2;
        }
        public int Division(int sumando1, int sumando2)
        {
            return sumando1 / sumando2;
        }
        public int Potencia(int sumando1, int sumando2)
        {
            return sumando1 ^ sumando2;
        }
        public double Inversa(double sumando1)
        {
            return 1 / sumando1;
        }
        public double Raiz(double sumando1)
        {
             return Math.Sqrt(sumando1);
        }
    }
}
