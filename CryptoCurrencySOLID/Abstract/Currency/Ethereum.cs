using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    internal class Ethereum : BaseCurrency, IMining
    {
        public override string CurrencyBuy()
        {
            throw new NotImplementedException();
        }

        public override string CurrencySell()
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
            return "etherium";
        }

        public override string GetCurrencyPrice(int price, string moneyRate)
        {
            throw new NotImplementedException();
        }

        public void MiningStart()
        {
            throw new NotImplementedException();
        }

        public void MiningStop()
        {
            throw new NotImplementedException();
        }
    }
}
