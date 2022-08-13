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
            //Arrange - Preparação
            double PrimeiroNum = 2;
            double SegundoNum = 3;
            double SomaEsp = 5;

            //Act - Ação
            //armazenar o método SOMAR numa variável
            var resultado = Calculadora.Somar(PrimeiroNum, SegundoNum);

            //Assert - Verificação
            Assert.AreEqual(SomaEsp, resultado);
        }

        //Para executar vários casos de teste de uma só vez
        [DataTestMethod] //método que utiliza dados embutidos
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