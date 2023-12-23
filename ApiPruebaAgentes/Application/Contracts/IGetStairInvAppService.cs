using System.Text;

namespace ApiPruebaAgentes.Application.Contracts
{
    public interface IGetStairInvAppService
    {
        Task<StringBuilder> GetStairInv(int n);
    }
}
