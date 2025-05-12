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
    public class ServiceCategoryRepository : Repository<ServiceCategory>, IServiceCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public ServiceCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async void Update(ServiceCategory serviceCategory)
        {
            var objFromDb = await _context.ServiceCategories.FirstOrDefaultAsync(sc => sc.Id == serviceCategory.Id);
            objFromDb.Name = serviceCategory.Name;
        }
    }
}
