using TurmaOiAplicTestes;

namespace TesteMstest
{
    [TestClass]
    public class TesteCalcMsTest
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - A��o
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);

        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 7)]

        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //AA
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(rNum, resultado);
        }
    }
}