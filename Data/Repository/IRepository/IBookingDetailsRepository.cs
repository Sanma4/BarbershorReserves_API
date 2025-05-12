using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Repository.IRepository
{
    public interface IBookingDetailsRepository : IRepository<BookingDetails>
    {
        void Update(BookingDetails bookingDetails);
    }
}
