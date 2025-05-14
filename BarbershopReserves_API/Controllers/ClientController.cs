using System.Collections;
using Data.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BarbershopReserves_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientController(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork; 
        }

        [HttpGet]
        public async Task<IEnumerable<Client>> Get()
        {
           return await _unitOfWork.Client.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var client = await _unitOfWork.Client.FirstOrDefaultAsyn(c => c.Id == id);

            if (client == null) 
                return NotFound();

            return Ok(client);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Client client)
        {
            await _unitOfWork.Client.AddAsync(client);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("Post", client.Id, client);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Client client)
        {
            _unitOfWork.Client.Update(client);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Client client)
        {

            if (client == null) return NotFound();
            _unitOfWork.Client.Remove(client);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }
    }
}
