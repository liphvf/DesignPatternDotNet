namespace Strategy.Fretes
{
    public class Correios
    {

        public decimal CalculaFrete(int distancia, IFrete frete)
        {
            return frete.CalculaFrete(distancia);
        }
    }
}
