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
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly ApplicationDbContext _context;
        public ClientRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async void Update(Client client)
        {
            var objFromDb = await _context.Clients.FirstOrDefaultAsync(c => c.Id == client.Id);
            objFromDb.Email = client.Email;
            objFromDb.Adress = client.Adress;
            objFromDb.PhoneNumber = client.PhoneNumber;
            objFromDb.FullName = client.FullName;
            objFromDb.IsValued = client.IsValued;
        }
    }
}
