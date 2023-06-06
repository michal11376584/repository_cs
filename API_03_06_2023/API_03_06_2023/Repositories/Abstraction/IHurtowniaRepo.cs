using API_03_06_2023.Models.Hurtownia;

namespace API_03_06_2023.Repositories.Abstraction
{
    public interface IHurtowniaRepo : IRepo
    {
        public Task<List<Client>> GetClientsAsync();
    }
}
