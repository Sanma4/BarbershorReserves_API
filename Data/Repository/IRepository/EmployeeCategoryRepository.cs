using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data.Repository.IRepository
{
    public class EmployeeCategoryRepository : Repository<EmployeeCategory>, IEmployeeCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async void Update(EmployeeCategory employeeCategory)
        {
            var objFromDb = await _context.EmployeeCategories.FirstOrDefaultAsync(ec => ec.Id == employeeCategory.Id);
            objFromDb.Name = employeeCategory.Name;
        }
    }
}
