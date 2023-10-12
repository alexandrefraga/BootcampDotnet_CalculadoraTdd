using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{

    public class CalculadoraBasica
    {
        private List<string> _historico;
        public CalculadoraBasica() => _historico = new List<string>();

        private void AddHistorico(string texto)
        {
            _historico.Add(texto);
            _historico.RemoveRange(0, _historico.Count > 3 ? _historico.Count - 3 : 0);
        }

        public int Soma(int a, int b)
        {
            var result = a + b;
            AddHistorico($"{a} + {b} = {result}");
            return result;
        }

        public int Subtrair(int a, int b)
        {
            var result = a - b;
            AddHistorico($"{a} - {b} = {result}");
            return result;
        }

        public int Multiplicar(int a, int b)
        {
            var result = a * b;
            AddHistorico($"{a} * {b} = {result}");
            return result;
        }

        public int Dividir(int a, int b)
        {
            var result = a / b;
            AddHistorico($"{a} / {b} = {result}");
            return result;
        }

        public List<string> Historico()
        {
            return _historico;
        }
    }
}