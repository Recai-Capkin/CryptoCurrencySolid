using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    public class Holochain:BaseCurrency, ICurrencySendWithAdress
    {
        public override string CurrencyBuy()
        {
            throw new NotImplementedException();
        }

        public override string CurrencySell()
        {
            throw new NotImplementedException();
        }

        public string CurrencySendWithAdress(string adress, string currencyType, float sendingFee)
        {
            throw new NotImplementedException();
        }

        public override string GetCurrencyAlgorithm()
        {
            throw new NotImplementedException();
        }

        public override string GetCurrencyCode()
        {
            throw new NotImplementedException();
        }

        public override string GetCurrencyDescription()
        {
            throw new NotImplementedException();
        }

        public override string GetCurrencyMarketCap()
        {
            throw new NotImplementedException();
        }

        public override string GetCurrencyName()
        {
            return "holochain";
        }

        public override string GetCurrencyPrice(int price, string moneyRate)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return GetCurrencyName();
        }
    }
}
