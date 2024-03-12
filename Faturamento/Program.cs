using Newtonsoft.Json;
using TestaException;

string caminhoJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\dados.json");


TryCatch.FazTryCatch(FazLogicaFaturamentoDia, caminhoJson);

static void FazLogicaFaturamentoDia(string caminho)
{
    using (StreamReader leitor = new(caminho))
    {
        var json = leitor.ReadToEnd();
        var listaFaturamentoDiario = JsonConvert.DeserializeObject<List<FaturamentoDistribuidoraDiario>>(json);
        decimal menorFaturamento = FaturamentoDistribuidoraDiario.DescobreMenorFaturamentoDiaDoMes(listaFaturamentoDiario!);
        decimal maiorFaturamento = FaturamentoDistribuidoraDiario.DescobreMaiorFaturamentoDiaDoMes(listaFaturamentoDiario!);
        int diasComfaturamentoAcimaMedia = FaturamentoDistribuidoraDiario.DescobreQtdDiasAcimaMediaMensal(listaFaturamentoDiario!);

        Console.WriteLine($"Menor faturamento do mês avaliado: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento do mês avaliado: {maiorFaturamento}");
        Console.WriteLine($"Quantidade de dias em que o faturamento foi maior que a média mensal: {diasComfaturamentoAcimaMedia}");
    }
}
