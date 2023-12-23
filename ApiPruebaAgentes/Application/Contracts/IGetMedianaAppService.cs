namespace ApiPruebaAgentes.Application.Contracts
{
    public interface IGetMedianaAppService
    {
        Task<int> GetMediana(List<int> n);
    }
}
