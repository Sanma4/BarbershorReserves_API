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
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        private readonly ApplicationDbContext _context;
        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async void Update(Booking booking)
        {
            var objFromDb = await _context.Bookings.FirstOrDefaultAsync(b => b.Id == booking.Id);
            objFromDb.BookingDate = booking.BookingDate;
            objFromDb.ClientId = booking.ClientId;
            objFromDb.BookingDetails = booking.BookingDetails;
                
        }
    }
}
