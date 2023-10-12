

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

    [Theory]
    [InlineData(8, 4, 2)]
    [InlineData(15, 3, 5)]
    public void DeveRetornarADivisaoCorreta(int n1, int n2, int resultadoEsperado)
    {
        CalculadoraBasica calc = new CalculadoraBasica();

        var resultado = calc.Dividir(n1, n2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornarListaNoHistorico()
    {
        CalculadoraBasica calc = new CalculadoraBasica();
        var defaultList = calc.Historico();
        Assert.IsType<List<string>>(defaultList);
        Assert.True(defaultList.Count == 0);
        Assert.Empty(defaultList);
    }

    [Fact]
    public void DeveRetornarHistoricoDeAte3Operacoes()
    {
        CalculadoraBasica calc = new CalculadoraBasica();
        calc.Soma(1, 8);
        var h1 = calc.Historico();
        Assert.True(h1.Count == 1);

        calc.Multiplicar(3, 7);
        calc.Soma(5, 4);
        Assert.True(h1.Count == 3);

        calc.Subtrair(9, 2);
        Assert.True(h1.Count == 3);
    }
}