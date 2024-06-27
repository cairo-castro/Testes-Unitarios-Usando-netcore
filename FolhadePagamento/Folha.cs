using System.Runtime.InteropServices;

namespace FolhadePagamento
{
    public class Folha
    {
        // Atributos
        public double SalarioBrutoHora { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double PorcentagemImpostos { get; set; }
        public double DeducoesTotais { get; set; }

        // Métodos
        public double SalarioBrutoTotal
        {
            get
            {
                return SalarioBrutoHora * HorasTrabalhadas;
            }
        }

        public double Impostos
        {
            get
            {
                return (PorcentagemImpostos / 100) * SalarioBrutoTotal;
            }
        }

        public double SalarioLiquido
        {
            get
            {
                return SalarioBrutoTotal - Impostos - DeducoesTotais;
            }
        }

        // Construtor
        public Folha(double salarioBrutoHora, double horasTrabalhadas, double porcentagemImpostos, double deducoesTotais)
        {
            SalarioBrutoHora = salarioBrutoHora;
            HorasTrabalhadas = horasTrabalhadas;
            PorcentagemImpostos = porcentagemImpostos;
            DeducoesTotais = deducoesTotais;
        }


    }
}
