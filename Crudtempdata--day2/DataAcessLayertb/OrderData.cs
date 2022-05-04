using DomainLayertb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayertb
{
    public class OrderData : IOrderData
    {
        public async Task DeleteAmazonCountry(int ID)
        {
            TempData.Data = TempData.Data.Where(x => x.ID != ID).ToList();
        }

        public async  Task<List<CountryOrder>> GetAllAmazonCountries()
        {
            return TempData.Data;
        }
       
        public async Task InsertAmazonCountry(CountryOrder countryOrder)
        {
            TempData.Data.Add(countryOrder);
        }
    }
}
