using ProjetoTesteFST2;
using Xunit;

namespace TestxUnit
{
    public class TesteCalculadoraxUnit
    {
        [Fact]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Preparação
            double PrimeiroNum = 2;
            double SegundoNum = 3;
            double SomaEsp = 5;

            //Act - Ação
            //armazenar o método SOMAR numa variável
            var resultado = Calculadora.Somar(PrimeiroNum, SegundoNum);

            //Assert - Verificação
            Assert.Equal(SomaEsp, resultado);
        }

        [Theory] //método equivalente ao DataTestMethod, do MSTest
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



        //TESTE REFERENTE AO IMC

        //OS CASOS DE TESTE
        [Theory]
        [InlineData(70, 1.85, 20.45)]
        [InlineData(90, 1.60, 35.16)]
        [InlineData(95, 1.90, 26.32)]
        [InlineData(100, 1.75, 32.65)]
        public void TesteCalcularIMC(double peso, double altura, double IMC)
        {
            var resultado = CalculadoraIMC.ValordoIMC(peso, altura).ToString("F");
            Assert.Equal(IMC.ToString("F"), resultado);
        }

        //CLASSIFICAÇÃO DO IMC

        //OS CASOS DE TESTE
        [Theory]
        [InlineData(20.45, "Peso normal")]
        [InlineData(35.16, "Obesidade grau II")]
        [InlineData(26.32, "Sobrepeso")]
        [InlineData(32.65, "Obesidade grau I")]
        public void TesteClassificarIMC(double IMC, string classificacao)
        {
            var resultado = ClassificacaoIMC.Categoria(IMC);
            Assert.Equal(classificacao, resultado);
        }
    }
}