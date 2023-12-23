using ApiPruebaAgentes.Application.Contracts;

namespace ApiPruebaAgentes.Application
{
    public class GetMedianaAppService : IGetMedianaAppService
    {
        public async Task<int> GetMediana(List<int> n)
        {
            return await Task.Run(() =>
            {
                int med = new();
                int tamano = n.Count;
                int mitad = tamano / 2;
                n = n.OrderBy(x => x).ToList();

                if (tamano % 2 == 0)
                {
                    med = (n[mitad - 1] + n[mitad]) / tamano;
                }
                else
                {
                    med = n[mitad];
                }

                return med;
            });
        }
    }
}
