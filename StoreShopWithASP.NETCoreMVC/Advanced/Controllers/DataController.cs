using Advanced.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Advanced.Controllers
{
    [ApiController]
    [Route("/api/people")]
    [Authorize(AuthenticationSchemes = "Identity.Application,Bearer")]
    public class DataController : ControllerBase
    {
        private DataContext Context;
        public DataController(DataContext ctx) => Context = ctx;
        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            IEnumerable<Person> people = Context.People.Include(p => p.Department).Include(p => p.Location);
            foreach(Person p in people)
            {
                p.Department.People = null;
                p.Location.People = null;
            }
            return people;
        }
        [HttpGet("{id}")]
        public async Task<Person> GetDetails(long id)
        {
            Person p = await Context.People.Include(p => p.Department).Include(p => p.Location).FirstAsync(p => p.PersonId == id);
            p.Department.People = null;
            p.Location.People = null;
            return p;
        }
        [HttpPost]
        public async Task Save([FromBody] Person p)
        {
            await Context.People.AddAsync(p);
            await Context.SaveChangesAsync();
        }
        [HttpPut]
        public async Task Update([FromBody] Person p)
        {
            Context.Update(p);
            await Context.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            Context.People.Remove(new Person() { PersonId = id });
            await Context.SaveChangesAsync();
        }
        [HttpGet("/api/locations")]
        public IAsyncEnumerable<Location> GetLocations() => Context.Locations;
        [HttpGet("/api/departments")]
        public IAsyncEnumerable<Department> GetDepts() => Context.Departments;
    }

    
}
