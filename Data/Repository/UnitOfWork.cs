using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.IRepository;

namespace Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Adress = new AdressRepository(_context);
            Booking = new BookingRepository(_context);
            BookingDetails = new BookingDetailsRepository(_context);
            Client = new ClientRepository(_context);
            Employee = new EmployeeRepository(_context);
            EmployeeCategory = new EmployeeCategoryRepository(_context);
            Service = new ServiceRepository(_context);
            ServiceCategory = new ServiceCategoryRepository(_context);
        }
        public IAdressRepository Adress { get; private set; }

        public IBookingRepository Booking { get; private set; }

        public IBookingDetailsRepository BookingDetails { get; private set; }

        public IClientRepository Client { get; private set; }

        public IEmployeeRepository Employee { get; private set; }

        public IEmployeeCategoryRepository EmployeeCategory { get; private set; }

        public IPromotionRepository Promotion { get; private set; }

        public IReviewRepository Review { get; private set; }

        public IScheduleRepository Schedule { get; private set; }

        public IServiceRepository Service { get; private set; }

        public IServiceCategoryRepository ServiceCategory { get; private set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
