using System.Text;

namespace ApiPruebaAgentes.Application.Contracts
{
    public interface IGetStairAppService
    {
        Task<StringBuilder> GetStair(int n);
    }
}
