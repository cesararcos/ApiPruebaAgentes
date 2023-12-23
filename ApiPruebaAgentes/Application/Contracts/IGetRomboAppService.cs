using System.Text;

namespace ApiPruebaAgentes.Application.Contracts
{
    public interface IGetRomboAppService
    {
        Task<StringBuilder> GetRombo(int n);
    }
}
