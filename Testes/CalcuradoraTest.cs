

using Calculadora;

namespace Testes;

public class CalculadoraTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, 4, 9)]
    public void DeveRetornarASomaCorreta(int n1, int n2, int resultadoEsperado)
    {
        CalculadoraBasica calc = new CalculadoraBasica();

        var resultado = calc.Soma(n1, n2);

        Assert.Equal(resultadoEsperado, resultado);
    }
}