namespace Visitor
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(Impressora impressora);
    }
}
