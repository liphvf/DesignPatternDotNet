namespace Strategy.Fretes
{
    public class Pac : IFrete
    {
        public decimal CalculaFrete(int distancia)
        {
            return distancia * 1.5M;
        }
    }
}
