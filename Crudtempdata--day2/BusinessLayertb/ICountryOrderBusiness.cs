using DomainLayertb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayertb
{
    public interface ICountryOrderBusiness
    {
        
        public Task<List<CountryOrder>> GetAllAmazonCountries();
      
        public Task InsertAmazonCountry(CountryOrder countryOrder);
       
        public Task DeleteAmazonCountry(int ID);
    }
}
