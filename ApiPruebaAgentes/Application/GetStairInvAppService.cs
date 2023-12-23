using ApiPruebaAgentes.Application.Contracts;
using System.Text;

namespace ApiPruebaAgentes.Application
{
    public class GetStairInvAppService : IGetStairInvAppService
    {
        public async Task<StringBuilder> GetStairInv(int n)
        {
            return await Task.Run(() =>
            {
                StringBuilder sb = new();

                for (int i = 0; i < n; i++)
                {
                    sb.Append(' ', i);
                    sb.Append('#', n - i);
                    sb.Append(Environment.NewLine);
                }

                return sb;
            });
        }
    }
}
