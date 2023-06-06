using API_03_06_2023.Models.Database;
using API_03_06_2023.Models.Hurtownia;
using API_03_06_2023.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace API_03_06_2023.Repositories.Implementation
{
    public class HurtowniaRepo : IHurtowniaRepo
    {
        public async Task<List<Client>> GetClientsAsync()
        {

            using( HurtowniaDbContext dbContext = new() )
            {
                return await dbContext.klienci.ToListAsync();
            }
        }
    }
}
