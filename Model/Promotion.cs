using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int DiscountPercetange { get; set; }
        public DateTime ValidFrom { get; set; }
        public int PromotedServiceId { get; set; }
    }
}
