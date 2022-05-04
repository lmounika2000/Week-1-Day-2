using BusinessLayertb;
using DomainLayertb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderByCountriesWebapiCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AmazonController : ControllerBase
    {

        private readonly ILogger<AmazonController> _logger;
        private readonly ICountryOrderBusiness _countryOrderBusiness;

        public AmazonController(ILogger<AmazonController> logger, ICountryOrderBusiness countryOrderBusiness)
        {
            _logger = logger;
            _countryOrderBusiness = countryOrderBusiness;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json", Type = typeof(IEnumerable<CountryOrder>))]
        [Route("get-all")]
        public async Task<ActionResult<IEnumerable<CountryOrder>>> GetAll()
        {
            try
            {
                var resp = await _countryOrderBusiness.GetAllAmazonCountries();

                if (resp == null || resp.Count == 0)
                {
                    return StatusCode(404, "No Data available.");
                }
                return Ok(resp);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("insert-CountryOrder")]
        public async Task<ActionResult> InsertEmployee([FromBody] CountryOrder countryOrder)
        {
            try
            {
                await _countryOrderBusiness.InsertAmazonCountry(countryOrder);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("delete-CountryOrder")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            try
            {
                await _countryOrderBusiness.DeleteAmazonCountry(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}

        
