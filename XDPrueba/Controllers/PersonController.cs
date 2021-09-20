using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XDPrueba.Models;
using XDPrueba.Models.BDFolder;

namespace XDPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Get()
        {
            List<Person> lista = new List<Person>();
            try
            {
                if (_context.Person.Any())
                {
                    lista = (from person in _context.Person
                             select new Person()
                             {
                                 Id = person.Id,
                                 FirstName = person.FirstName,
                                 LastName = person.LastName,
                                 CompanyName = person.CompanyName,
                                 Address = person.Address,
                                 City = person.City,
                                 State = person.State,
                                 Zip = person.Zip,
                                 PhoneOne = person.PhoneOne,
                                 PhoneTwo = person.PhoneTwo,
                                 Email = person.Email,
                                 Departments = (from deparments in _context.Department
                                                join persondepartment in _context.PersonDepartment on deparments.DepartmentId equals persondepartment.DepartmentId
                                                where persondepartment.PersonId == person.Id
                                                select new Department()
                                                {
                                                    DepartmentId = deparments.DepartmentId,
                                                    Description = deparments.Description
                                                }).ToList()
                             }).ToList();
                }

                return Ok(lista);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
