using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraBasica
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return 0;
        }

        public int Dividir(int a, int b)
        {
            return 0;
        }

        public List<int> Historico()
        {
            return new List<int>();
        }
    }
}