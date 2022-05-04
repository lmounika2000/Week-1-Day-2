using DataAcessLayertb;
using DomainLayertb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayertb
{
    public class CountryOrderBusiness : ICountryOrderBusiness
    {
        private readonly IOrderData _orderData;
        public CountryOrderBusiness(IOrderData orderData)
        {
            _orderData = orderData;
        }
        public async Task DeleteAmazonCountry(int ID)
        {
            await _orderData.DeleteAmazonCountry(ID);
        }

        public async Task<List<CountryOrder>> GetAllAmazonCountries()
        {
            return await _orderData.GetAllAmazonCountries();
        }

        public async Task InsertAmazonCountry(CountryOrder countryOrder)
        {
            await _orderData.InsertAmazonCountry(countryOrder);
        }
    }
}
