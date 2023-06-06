using API_03_06_2023.Models.Hurtownia;

namespace API_03_06_2023.Services.Abstraction
{
    public interface IHutrowniaService : IService
    {
        public Task<List<Client>> GetClientsAsync();
    }
}
