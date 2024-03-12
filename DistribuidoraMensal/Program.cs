using DistribuidoraMensal;
using TestaException;

TryCatch.FazTryCatch(FazLogicoFaturamentoMensal, Mock.arrayFaturamentoDistribuidoraMensal);
static void FazLogicoFaturamentoMensal(DistribuidoraFaturamentoMensal[] array)
{
    DistribuidoraFaturamentoMensal.CalculaPercentualMensalPorEstado(array);
}