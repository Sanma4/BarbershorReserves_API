using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber  { get; set; }
        public Adress Adress { get; set; }
        public bool IsValued { get; set; }
    }
}
