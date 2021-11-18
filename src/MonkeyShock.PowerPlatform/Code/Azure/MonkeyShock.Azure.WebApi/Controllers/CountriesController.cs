using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Linq; 

namespace MonkeyShock.Azure.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ODataController
    {
        private readonly CountryAppContext _db;

        private readonly ILogger<CountriesController> _logger;

        public CountriesController(CountryAppContext dbContext, ILogger<CountriesController> logger)
        {
            _logger = logger;
            _db = dbContext;
        }

        [EnableQuery(PageSize = 15)]
        public IQueryable<Country> Get()
        {
            return _db.Countries;
        }

        [EnableQuery]
        public SingleResult<Country> Get([FromODataUri] int key)
        {
            var result = _db.Countries.Where(c => c.Id == key);
            return SingleResult.Create(result);
        }

        [EnableQuery]
        public async Task<IActionResult> Post([FromBody] Country country)
        {
            _db.Countries.Add(country);
            await _db.SaveChangesAsync();
            return Created(country);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, Delta<Country> country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existingCountry = await _db.Countries.FindAsync(key);
            if (existingCountry == null)
            {
                return NotFound();
            }

            country.Patch(existingCountry);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(existingCountry);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            Country existingCountry = await _db.Countries.FindAsync(key);
            if (existingCountry == null)
            {
                return NotFound();
            }

            _db.Countries.Remove(existingCountry);
            await _db.SaveChangesAsync();
            return StatusCode(StatusCodes.Status204NoContent);
        }

        private bool CountryExists(int key)
        {
            return _db.Countries.Any(p => p.Id == key);
        }
    }
}