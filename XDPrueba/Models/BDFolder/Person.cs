using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XDPrueba.Models.BDFolder
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneOne { get; set; }
        public string PhoneTwo { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
