using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    internal class Mina : BaseCurrency,IStake,ICurrencySendWithTag
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
            return String.Concat(adress + " adrese "+ tag + " tagı ile" + coinId + " coini " + (sendingAmount - sendingFee) + " miktarında gönderildi.");
        }

        public override string GetCurrencyAlgorithm()
        {
            throw new NotImplementedException();
        }

        public override string GetCurrencyCode()
        {
            throw new NotImplementedException();
        }

        public override decimal GetCurrencyCurrentSupply()
        {
            return 632000000;
        }

        public override string GetCurrencyDescription()
        {
            throw new NotImplementedException();
        }

        public override decimal GetCurrencyMarketCap()
        {
            return 571000000;
        }

        public override string GetCurrencyName()
        {
            return "MINA";
        }

        public override decimal GetCurrencyPrice( string moneyRate)
        {
            Ethereum eth = new Ethereum();
            if (moneyRate != "MINA" && moneyRate == "Vitalik")
            {
                return (GetCurrencyMarketCap() / GetCurrencyCurrentSupply()) / eth.GetCurrencyPrice("Dollar");
            }
            else
            {
                return 0;
            }
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
