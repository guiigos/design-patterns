namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            CriadorDeNotaFiscal cn = new CriadorDeNotaFiscal();
            cn.ParaEmpresa("Guilherme Alves")
                .ComCnpj("00.000.000/0000-00")
                .ComItem(new ItemDaNota("item 01", 100.00))
                .ComItem(new ItemDaNota("item 02", 200.00))
                .ComObservacoes("Nota de teste")
                .NaDataAtual();

            cn.AdicionaAcao(new NotaFiscalDao());
            cn.AdicionaAcao(new EnviadorDeEmail());
            cn.AdicionaAcao(new EnviadorPorSms());

            NotaFiscal nf = cn.Constroi();
        }
    }
}
