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
    }
}