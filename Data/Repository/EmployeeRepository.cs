using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        public async void Update(Employee employee)
        {
            var objFromDb = await _context.Employees.FirstOrDefaultAsync(e => e.Id == employee.Id);
            objFromDb.Active = employee.Active;
            objFromDb.EmployeeCategoryId = employee.EmployeeCategoryId;
            objFromDb.Adress = employee.Adress;
            objFromDb.FullName = employee.FullName;
            objFromDb.ProfileImg = employee.ProfileImg;
        }
    }
}
