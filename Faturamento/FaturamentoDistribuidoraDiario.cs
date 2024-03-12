
internal class FaturamentoDistribuidoraDiario 
{
    public decimal Valor { get; set; }
    public decimal Dia { get; set; }

    public static decimal DescobreMenorFaturamentoDiaDoMes(List<FaturamentoDistribuidoraDiario> faturamentos)
    {
        faturamentos.RemoveAll(p => p.Valor == 0);

        decimal menorFaturamento = faturamentos[0].Valor;

        foreach (FaturamentoDistribuidoraDiario obj in faturamentos)
        {              
            if(obj.Valor < menorFaturamento)
            {
                menorFaturamento = obj.Valor;
            }
        }

        return menorFaturamento;
    }

    public static decimal DescobreMaiorFaturamentoDiaDoMes(List<FaturamentoDistribuidoraDiario> faturamentos)
    {
        faturamentos.RemoveAll(p => p.Valor == 0);
        decimal maiorFaturamento = faturamentos[0].Valor;

        foreach(FaturamentoDistribuidoraDiario obj in faturamentos)
        {
            if(obj.Valor > maiorFaturamento)
            {
                maiorFaturamento = obj.Valor;
            }
        }

        return maiorFaturamento;
    }

    public static int DescobreQtdDiasAcimaMediaMensal(List<FaturamentoDistribuidoraDiario> faturamentos)
    {
        faturamentos.RemoveAll(p => p.Valor == 0);
        decimal SomaFaturamentoMes = 0, mediaFaturamentoMensal = 0;
        int contador = 0;

        foreach(FaturamentoDistribuidoraDiario obj in faturamentos)
        {
            SomaFaturamentoMes += obj.Valor;
        }

        mediaFaturamentoMensal = SomaFaturamentoMes / faturamentos.Count;

        foreach (FaturamentoDistribuidoraDiario obj in faturamentos)
        {
            if(obj.Valor > mediaFaturamentoMensal)
            {
                contador++;
            }
        }

        return contador;
    }
}
