using ExamCommon.Interfaces;
using ExamCommon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientManager _clientManager;
        public ClientController(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }
        [HttpGet]
        public async Task<IActionResult> Clients()
        {
            try
            {
                return Ok(await _clientManager.GetAllClients());
            }
            catch (System.Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewItem(Client client)
        {
            try
            {
                return Ok(_clientManager.AddClient(client));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Client client)
        {
            try
            {
                return Ok(_clientManager.UpdateClient(client));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(Client client)
        {
            try
            {
                return Ok(_clientManager.DeleteClient(client));
            }
            catch (System.Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
