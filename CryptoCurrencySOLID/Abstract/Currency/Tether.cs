using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    internal class Tether : BaseCurrency, ICurrencySendWithAdress
    {
        public override string CurrencyBuy(decimal amount, string coinId, decimal buyingPrice)
        {
            return String.Concat("Kodu "+coinId+" olan coinden " + amount+ " $ tutarında" + buyingPrice + "fiyatından alım gerçekleşti.");
        }

        public override string CurrencySell(decimal amount, string coinId, decimal sellingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında+" + sellingPrice + " fiyatından satış gerçekleşti.");
        }

        public string CurrencySendWithAdress(string adress, string coinId, decimal sendingFee, decimal sendingAmount)
        {
            return String.Concat(adress + " adrese " + coinId + " coini " + (sendingAmount - sendingFee) + " miktarında gönderildi.");
        }

        public override string GetCurrencyAlgorithm()
        {
            return "POR";
        }

        public override string GetCurrencyCode()
        {
            return "USDT";
        }

        public override decimal GetCurrencyCurrentSupply()
        {
            return 66300000000;
        }

        public override string GetCurrencyDescription()
        {
            return "1-1 dolar eşliği sağlamaya çalışan bir kripto stabil coin türüdür.";
        }

        public override decimal GetCurrencyMarketCap()
        {
            return 66300000000;
        }

        public override string GetCurrencyName()
        {
            return "tether";
        }

        public override decimal GetCurrencyPrice(string moneyRate)
        {
            return 1;
        }
    }
}
