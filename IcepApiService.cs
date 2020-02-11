

using Refit;
using System.Threading.Tasks;

namespace API_CEP
{
    interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
