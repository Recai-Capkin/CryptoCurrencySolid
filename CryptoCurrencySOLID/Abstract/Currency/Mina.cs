using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    internal class Mina : BaseCurrency,IStake
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
            return "mina";
        }

        public override string GetCurrencyPrice(int price, string moneyRate)
        {
            throw new NotImplementedException();
        }

        public void StakeStart()
        {
            Console.WriteLine("Stake Başladı");
        }

        public void StakeStop()
        {
            Console.WriteLine("Stake Durdu");
        }
    }
}
