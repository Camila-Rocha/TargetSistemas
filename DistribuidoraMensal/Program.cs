using DistribuidoraMensal;
using TestaException;

TryCatch.FazTryCatch(FazLogicaFaturamentoMensal, Mock.arrayFaturamentoDistribuidoraMensal);
static void FazLogicaFaturamentoMensal(DistribuidoraFaturamentoMensal[] array)
{
    DistribuidoraFaturamentoMensal.CalculaPercentualMensalPorEstado(array);
}