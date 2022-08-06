using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    public class ExchangeOperation
    {
        //todo Dependency Inversion Principle ile todo 5 hatası giderildi
        public ICurrencyExchangeOperation currencyExchangeOperation;
        public ExchangeOperation(ICurrencyExchangeOperation currencyExchangeOperation)
        {
            this.currencyExchangeOperation = currencyExchangeOperation;
        }
        public void Add(string currencyName)
        {
            currencyExchangeOperation.Add(currencyName);
        }
        public void Remove(string currencyName)
        {
            currencyExchangeOperation.Remove(currencyName);
        }

        //todo 5 Dependecy Inversion gerekli olan durum burası çünkü her borsa eklendiğinde ayrı ayrı işlemleri de
        //buraya eklememiz gerekiyor bu da bağlılığı arttırıyor alt classların üst classları yönetmesine izin vermemeliyiz
        //bunu düzenlemek lazım bu sebepten ötürü bunu interface aracılığı ile classı tanıtacağız

        //public void CurrencyAddBinance(string currencyName)
        //{
        //    new Binance().CurrencyAddBinance(currencyName);
        //}
        //public void CurrencyRemoveBinance(string currencyName)
        //{
        //    new Binance().CurrencyRemoveBinance(currencyName);
        //}
    }
    public class Binance:ICurrencyExchangeOperation
    {


        //todo 5 Mesela eski kullanımda ayrı ayrı add ve remove metotları tanımlıyorduk
        //public void CurrencyAddBinance(string currencyName)
        //{
        //    Console.WriteLine("Kripto para binance borsasına eklendi.");
        //}
        //public void CurrencyRemoveBinance(string currencyName)
        //{
        //    Console.WriteLine("Kripto para binance borsasından kaldırıldı.");
        //}

        public void Add(string currencyName)
        {
            Console.WriteLine(currencyName + " Binance borsasına eklendi.");
        }
        public void Remove(string currencyName)
        {
            Console.WriteLine(currencyName+ " Binance borsasından kaldırıldı");
        }
    }
    public class Bitfinex : ICurrencyExchangeOperation
    {
        public void Add(string currencyName)
        {
            Console.WriteLine(currencyName + " Bitfinex borsasına eklendi");
        }

        public void Remove(string currencyName)
        {
            Console.WriteLine(currencyName+" Bitfinex borsasından kaldırıldı");
        }
    }
}
