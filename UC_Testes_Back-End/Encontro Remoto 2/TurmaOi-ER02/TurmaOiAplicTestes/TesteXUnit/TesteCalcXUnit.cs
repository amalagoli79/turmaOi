using TurmaOiAplicTestes;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;

            //Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.Equal(rNum, resultado);  

        }


        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(4, 4, 8)]
        [InlineData(7, 2, 9)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert 
            Assert.Equal(rNum, resultado);
        }

    }
}