namespace ApiPruebaAgentes.Application.Contracts
{
    public interface IGetMediaAppService
    {
        Task<int> GetMedia(List<int> n);
    }
}
