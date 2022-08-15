using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract.Currency
{
    public class Ripple : BaseCurrency, ICurrencySendWithTag, IStake
    {
        public override string CurrencyBuy(decimal amount, string coinId, decimal buyingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında" + buyingPrice + "fiyatından alım gerçekleşti.");
        }

        public override string CurrencySell(decimal amount, string coinId, decimal sellingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında+" + sellingPrice + " fiyatından satış gerçekleşti.");
        }

        public string CurrencySendWithTag(string tag, string adress, string coinId, decimal sendingFee, decimal sendingAmount)
        {
            return String.Concat(adress + " adrese " + tag + " tagı ile" + coinId + " coini " + (sendingAmount - sendingFee) + " miktarında gönderildi.");
        }

        public override string GetCurrencyAlgorithm()
        {
            return "Custom Consensus";
        }

        public override string GetCurrencyCode()
        {
            return "XRP";
        }

        public override decimal GetCurrencyCurrentSupply()
        {
            return 49100000000;
        }

        public override string GetCurrencyDescription()
        {
            return "Bence çöp bir coin zamanıda iyi fiyatlandı. Para göndermekten başka bir halta yaradığı yok.";
        }

        public override decimal GetCurrencyMarketCap()
        {
            return 18600000000;
        }

        public override string GetCurrencyName()
        {
            return "ripple";
        }

        public override decimal GetCurrencyPrice(string moneyRate)
        {
            if (moneyRate != "Ethereum" && moneyRate == "Dollar")
            {
                return (GetCurrencyMarketCap() / GetCurrencyCurrentSupply());
            }
            else
            {
                return 0;
            }
        }

        public void StakeStart()
        {
            throw new NotImplementedException();
        }

        public void StakeStop()
        {
            throw new NotImplementedException();
        }
    }
}
