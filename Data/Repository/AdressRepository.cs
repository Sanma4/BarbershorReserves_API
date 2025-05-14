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
    public class AdressRepository : Repository<AdressRepository>, IAdressRepository
    {
        private readonly ApplicationDbContext _context;
        public AdressRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        public async void Update(Adress adress)
        {
            var objFromDb = await _context.Adresses.FirstOrDefaultAsync(a => a.Id == adress.Id);
            objFromDb.Street = adress.Street;
            objFromDb.Number = adress.Number;
            objFromDb.Location = adress.Location;
        }
    }
}
