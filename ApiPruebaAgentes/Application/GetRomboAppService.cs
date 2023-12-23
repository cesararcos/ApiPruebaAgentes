using ApiPruebaAgentes.Application.Contracts;
using System.Text;

namespace ApiPruebaAgentes.Application
{
    public class GetRomboAppService : IGetRomboAppService
    {
        public async Task<StringBuilder> GetRombo(int n)
        {
            return await Task.Run(() =>
            {
                StringBuilder sb = new();

                for (int i = -(n - 1); i < n; i++)
                {
                    for (int j = 1; j <= Math.Abs(i); j++)
                    {
                        sb.Append(' ');
                    }

                    for (int t = 1; t <= n - Math.Abs(i); t++)
                    {
                        sb.Append("# ");
                    }

                    sb.Append(Environment.NewLine);
                }

                return sb;
            });
        }
    }
}
