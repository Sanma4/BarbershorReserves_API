using Data.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BarbershopReserves_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _unitOfWork.Employee.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var employee = _unitOfWork.Employee.FirstOrDefaultAsyn(e => e.Id == id);

            if (employee == null) NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Employee employee)
        {
            await _unitOfWork.Employee.AddAsync(employee);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("Post", employee.Id, employee);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Employee employee)
        {
            _unitOfWork.Employee.Update(employee);
            _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Employee employee)
        {
            if (employee == null) NotFound();

            _unitOfWork.Employee.Remove(employee);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }
    }
}
