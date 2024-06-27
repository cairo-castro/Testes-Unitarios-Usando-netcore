using FolhadePagamento;

namespace FolhadePagamentoTeste
{
    public class FolhaTeste
    {
        [Theory] 
        [InlineData(50.0, 160.0, 10.0, 200.0, 8000.0)]
        [InlineData(40.0, 150.0, 15.0, 100.0, 6000.0)]
        [InlineData(60.0, 170.0, 20.0, 300.0, 10200.0)]
        public void TestSalarioBrutoTotal(double salarioBrutoHora, double horasTrabalhadas, double porcentagemImpostos, double deducoesTotais, double salarioBrutoTotalEsperado)
        {
            // Arrange
            Folha folha = new Folha(salarioBrutoHora, horasTrabalhadas, porcentagemImpostos, deducoesTotais);

            // Act
            double salarioBrutoTotal = folha.SalarioBrutoTotal;

            // Assert
            Assert.Equal(salarioBrutoTotalEsperado, salarioBrutoTotal);
        }

        [Theory]
        [InlineData(50.0, 160.0, 10.0, 200.0, 800.0)]
        [InlineData(40.0, 150.0, 15.0, 100.0, 900.0)]
        [InlineData(60.0, 170.0, 20.0, 300.0, 2040.0)]
        public void TestImpostos(double salarioBrutoHora, double horasTrabalhadas, double porcentagemImpostos, double deducoesTotais, double impostosEsperados)
        {
            // Arrange
            Folha folha = new Folha(salarioBrutoHora, horasTrabalhadas, porcentagemImpostos, deducoesTotais);

            // Act
            double impostos = folha.Impostos;

            // Assert
            Assert.Equal(impostosEsperados, impostos);
        }

        [Fact]
        public void TestSalarioLiquidoFalhaProposital()
        {
            // Arrange
            double salarioBrutoHora = 50.0;
            double horasTrabalhadas = 160.0;
            double porcentagemImpostos = 10.0;
            double deducoesTotais = 200.0;
            Folha folha = new Folha(salarioBrutoHora, horasTrabalhadas, porcentagemImpostos, deducoesTotais);

            // Act
            double salarioLiquido = folha.SalarioLiquido;

            // Assert - Falha proposital
            Assert.Equal(6000.0, salarioLiquido);
        }

    }
}