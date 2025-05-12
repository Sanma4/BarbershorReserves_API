using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Repository.IRepository
{
    public interface IBookingDetails : IRepository<BookingDetails>
    {
        void Update();
    }
}
