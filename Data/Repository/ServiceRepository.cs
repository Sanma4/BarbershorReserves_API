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
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        private readonly ApplicationDbContext _context;
        public ServiceRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async void Update(Service service)
        {
            var objFromDb = await _context.Services.FirstOrDefaultAsync(s => s.Id == service.Id);
            objFromDb.Name = service.Name;
            objFromDb.Description = service.Description;
            objFromDb.Price = service.Price;
            objFromDb.Duration = service.Duration;
            objFromDb.ServiceCategoryId = service.ServiceCategoryId;
        }
    }
}
