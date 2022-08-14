using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    internal class Bitcoin : BaseCurrency, ICurrencySendWithAdress
    {
        public override string CurrencyBuy(decimal amount, string coinId, decimal buyingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında"+ buyingPrice+" fiyatından alım gerçekleşti.");
        }

        public override string CurrencySell(decimal amount, string coinId, decimal sellingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında+"+sellingPrice+" fiyatından satış gerçekleşti.");
        }

        public string CurrencySendWithAdress(string adress, string coinId, decimal sendingFee, decimal sendingAmount)
        {
            return String.Concat(adress + " adrese " + coinId + " coini " + (sendingAmount - sendingFee) + " miktarında gönderildi.");
        }

        public override string GetCurrencyAlgorithm()
        {
            return "POW";
        }

        public override string GetCurrencyCode()
        {
            return "BTC";
        }

        public override decimal GetCurrencyCurrentSupply()
        {
            return 19121000;
        }

        public override string GetCurrencyDescription()
        {
            return "First cryptocurrency world wide created by Satoshi Nakamoto";
        }

        public override decimal GetCurrencyMarketCap()
        {
            return 465000000000;
        }

        public override string GetCurrencyName()
        {
            return "Bitcoin";
        }

        public override decimal GetCurrencyPrice(string moneyRate)
        {
            if (moneyRate != "Bitcoin" && moneyRate == "Dollar")
            {
                return (GetCurrencyMarketCap() / GetCurrencyCurrentSupply());
            }
            else
            {
                return 0;
            }
            
        }
        public override string ToString()
        {
            return GetCurrencyName();
        }
    }
}
