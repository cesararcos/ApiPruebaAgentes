using ApiPruebaAgentes.Application.Contracts;
using System.Text;

namespace ApiPruebaAgentes.Application
{
    public class GetStairAppService : IGetStairAppService
    {
        public async Task<StringBuilder> GetStair(int n)
        {
            return await Task.Run(() =>
            {
                StringBuilder sb = new();

                for (int i = 0; i < n; i++)
                {
                    sb.Append(' ', n - (i + 1));
                    sb.Append('#', i + 1);
                    sb.Append(Environment.NewLine);
                }

                return sb;
            });
        }
    }
}
