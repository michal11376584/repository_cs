using API_03_06_2023.Models.Hurtownia;
using API_03_06_2023.Repositories.Abstraction;
using API_03_06_2023.Services.Abstraction;

namespace API_03_06_2023.Services.Implementation
{
    public class HurtowniaService : IHutrowniaService
    {
        private IHurtowniaRepo _hurtowniaRepo;

        public HurtowniaService(IHurtowniaRepo hurtowniaRepo)
        {
            _hurtowniaRepo = hurtowniaRepo;
        }

        public async Task<List<Client>> GetClientsAsync() => await _hurtowniaRepo.GetClientsAsync();
    }
}
