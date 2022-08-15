using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    internal class Ethereum : BaseCurrency, IMining, ICurrencySendWithAdress
    {
        public override string CurrencyBuy(decimal amount, string coinId, decimal buyingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında" + buyingPrice + "fiyatından alım gerçekleşti.");
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
            return "POW";
        }

        public override string GetCurrencyCode()
        {
            return "ETH";
        }

        public override decimal GetCurrencyCurrentSupply()
        {
            return 121970000;
        }

        public override string GetCurrencyDescription()
        {
            return "Bir protokol olarak tanımlanmıştır. " +
                "Kendine ağına ait bir kripto parası vardır. Ve Dağıtık çalışan uygulamalar için altyapı sağlar.";
        }

        public override decimal GetCurrencyMarketCap()
        {
            return 237000000000;
        }

        public override string GetCurrencyName()
        {
            return "Ethereum";
        }

        public override decimal GetCurrencyPrice(string moneyRate)
        {
            if (moneyRate != "Ethereum" && moneyRate=="Dollar")
            {
                return (GetCurrencyMarketCap() / GetCurrencyCurrentSupply());
            }
            else
            {
                return 0;
            }
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
