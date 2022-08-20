using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteFST2;

namespace TestMSTest
{
    [TestClass]
    public class TesteCalculadoraMSTest
    {
        [TestMethod]
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
            Assert.AreEqual(SomaEsp, resultado);
        }

        //Para executar v�rios casos de teste de uma s� vez
        [DataTestMethod] //m�todo que utiliza dados embutidos
        [DataRow(2, 3, 5)]
        [DataRow(2, 4, 6)]
        [DataRow(2, 5, 7)]
        public void TesteSomarDoisNumerosLista(double PrimeiroNum, double SegundoNum, double SomaEsp)
        {
            //Act
            var resultado = Calculadora.Somar(PrimeiroNum, SegundoNum);

            //Assert
            Assert.AreEqual(SomaEsp, resultado);
        }



        //TESTE REFERENTE AO IMC

        //CASO DE TESTE 1
        [TestMethod]
        public void TesteCalcularIMC()
        {
            //Arrange - Prepara��o
            double peso = 70;
            double altura = 1.85;
            double IMC = 20.45;

            //Act - A��o
            var resultado = CalculadoraIMC.ValordoIMC(peso, altura).ToString("F");

            //Assert - Verifica��o
            Assert.AreEqual(IMC.ToString("F"), resultado);
        }

        //OS DEMAIS CASOS DE TESTE
        [DataTestMethod]
        [DataRow(90, 1.60, 35.16)]
        [DataRow(95, 1.90, 26.32)]
        [DataRow(100, 1.75, 32.65)]
        public void TesteCalcularIMC(double peso, double altura, double IMC)
        {
            var resultado = CalculadoraIMC.ValordoIMC(peso, altura).ToString("F");
            Assert.AreEqual(IMC.ToString("F"), resultado);
        }

        //CLASSIFICA��O DO IMC

        //CASO DE TESTE 1
        [TestMethod]
        public void TesteClassificarIMC()
        {
            //Arrange - Prepara��o
            double IMC = 20.45;
            string classificacao = "Peso normal";
            //Act - A��o
            var resultado = ClassificacaoIMC.Categoria(IMC);
            //Assert - Verifica��o
            Assert.AreEqual(classificacao, resultado);
        }

        //DEMAIS CASOS DE TESTE
        [DataTestMethod]
        [DataRow(35.16, "Obesidade grau II")]
        [DataRow(26.32, "Sobrepeso")]
        [DataRow(32.65, "Obesidade grau I")]
        [TestMethod]
        public void TesteClassificarIMC(double IMC, string classificacao)
        {
            var resultado = ClassificacaoIMC.Categoria(IMC);
            Assert.AreEqual(classificacao, resultado);
        }
    }
}