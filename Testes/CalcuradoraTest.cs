

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

    [Theory]
    [InlineData(8, 2, 6)]
    [InlineData(15, 4, 11)]
    public void DeveRetornarASubtracaoCorreta(int n1, int n2, int resultadoEsperado)
    {
        CalculadoraBasica calc = new CalculadoraBasica();

        var resultado = calc.Subtrair(n1, n2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(8, 3, 24)]
    [InlineData(15, 4, 60)]
    public void DeveRetornarAMultiplicacaoCorreta(int n1, int n2, int resultadoEsperado)
    {
        CalculadoraBasica calc = new CalculadoraBasica();

        var resultado = calc.Multiplicar(n1, n2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveLancarErroNaDivisaoPorZero()
    {
        CalculadoraBasica calc = new CalculadoraBasica();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }
}