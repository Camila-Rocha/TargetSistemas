using System.Globalization;

namespace DistribuidoraMensal
{
    internal class DistribuidoraFaturamentoMensal
    {
        public string? Estado { get; set; }
        public decimal ValorMensal { get; set; }

        public DistribuidoraFaturamentoMensal(string estado, decimal valorMensal) 
        {
            Estado = estado;
            ValorMensal = valorMensal;
        }

        public static void CalculaPercentualMensalPorEstado(DistribuidoraFaturamentoMensal[] array)
        {
            decimal soma = 0;
            decimal percentual;

            if (array != null)
            {
                foreach (var obj in array)
                {
                    soma += obj.ValorMensal;
                }

                foreach (var obj in array)
                {
                    percentual = (obj.ValorMensal / soma) * 100;
                    Console.WriteLine($"Percentual de faturamento representado por {obj.Estado}: {percentual.ToString("0.00", CultureInfo.InvariantCulture)}%");
                }
            }
        }
    }
}
