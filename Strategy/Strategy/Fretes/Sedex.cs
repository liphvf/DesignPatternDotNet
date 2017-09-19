namespace Strategy.Fretes
{
    public class Sedex : IFrete
    {

        public decimal CalculaFrete(int distancia)
        {
            return distancia * 3M;
        }
    }
}
