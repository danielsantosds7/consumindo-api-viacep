using System.Threading.Tasks;
using Refit;

namespace MinhaApi
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);        
    }
}
