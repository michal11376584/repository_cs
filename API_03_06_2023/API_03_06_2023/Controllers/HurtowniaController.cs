using API_03_06_2023.Models;
using API_03_06_2023.Models.Hurtownia;
using API_03_06_2023.Models.Responses;
using API_03_06_2023.Services.Abstraction;
using API_03_06_2023.Services.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace API_03_06_2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HurtowniaController : Controller
    {
        private IHutrowniaService _hurtowniaService;

        public HurtowniaController(IHutrowniaService hurtowniaService)
        {
            _hurtowniaService = hurtowniaService;
        }

        /// <summary>
        /// Metoda zwracająca liste klientów hurtownii.
        /// </summary>
        [HttpGet("GetClientsAsync")]
        public async Task<ActionResult<NormalResponse<List<Client>>>> GetClientsAsync()
        { 
            NormalResponse<List<Client>> response = new();
            try
            {
                response.ServerResponse = await _hurtowniaService.GetClientsAsync();
                response.ServerInfo.Status = "Success";
                return Ok(response);
            }
            catch(Exception ex)
            {
                response.ServerInfo.Status = "Failed";
                response.ServerInfo.ErrorDescription = ex.Message;
            }
            return Ok(response);
        }
    }
}
