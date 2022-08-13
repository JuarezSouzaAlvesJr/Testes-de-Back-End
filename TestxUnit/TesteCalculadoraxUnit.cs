using ProjetoTesteFST2;
using Xunit;

namespace TestxUnit
{
    public class TesteCalculadoraxUnit
    {
        [Fact]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double PrimeiroNum = 2;
            double SegundoNum = 3;
            double SomaEsp = 5;

            //Act - A��o
            //armazenar o m�todo SOMAR numa vari�vel
            var resultado = Calculadora.Somar(PrimeiroNum, SegundoNum);

            //Assert - Verifica��o
            Assert.Equal(SomaEsp, resultado);
        }

        [Theory] //m�todo equivalente ao DataTestMethod, do MSTest
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 4, 7)]
        public void TesteSomarDoisNumerosLista(double PrimeiroNum, double SegundoNum, double SomaEsp)
        {
            //Act
            var resultado = Calculadora.Somar(PrimeiroNum, SegundoNum);

            //Assert
            Assert.Equal(SomaEsp, resultado);
        }
    }
}