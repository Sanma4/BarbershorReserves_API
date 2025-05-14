using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string ProfileImg { get; set; }
        public string Status { get; set; } //Ocupado, Disponible, Suspendido
        public string Availability { get; set; } //Dia disponible. Lunes, martes, etc.
        public int EmployeeCategoryId { get; set; }
        public EmployeeCategory EmployeeCategory { get; set; }
        public Adress Adress { get; set; }
        public bool Active { get; set; }
    }
}
