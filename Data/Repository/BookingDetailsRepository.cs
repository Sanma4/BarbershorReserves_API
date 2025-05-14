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
    public class BookingDetailsRepository : Repository<BookingDetails>, IBookingDetailsRepository
    {
        private readonly ApplicationDbContext _context;

        public BookingDetailsRepository(ApplicationDbContext context) :base(context) 
        {
            _context = context;
        }
        public async void Update(BookingDetails bookingDetails)
        {
            var objFromDb = await _context.BookingDetails.FirstOrDefaultAsync(bd => bd.Id == bookingDetails.Id);
            objFromDb.BookingId = bookingDetails.BookingId;
            objFromDb.ServiceId = bookingDetails.ServiceId;
        }
    }
}
