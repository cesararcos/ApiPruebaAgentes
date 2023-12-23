using ApiPruebaAgentes.Application.Contracts;

namespace ApiPruebaAgentes.Application
{
    public class GetMediaAppService : IGetMediaAppService
    {
        public async Task<int> GetMedia(List<int> n)
        {
            return await Task.Run(() =>
            {
                int sum = new();

                foreach (int item in n)
                {
                    sum += item;
                }

                int result = sum / n.Count;

                return result;
            });

            
        }
    }
}
