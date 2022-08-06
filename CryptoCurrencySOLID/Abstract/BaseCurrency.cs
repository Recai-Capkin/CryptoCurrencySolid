using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    public abstract class BaseCurrency
    {
        public abstract string GetCurrencyName();
        public abstract string GetCurrencyCode();
        public abstract string GetCurrencyDescription();

        //todo Open Close Principle sağlandı böylelikle değişken para birimlerinin olabileceği durumlar için farklı pariteler eklendi
        public abstract string GetCurrencyPrice(int price,string moneyRate);
        public abstract string GetCurrencyMarketCap();

        public abstract string GetCurrencyAlgorithm();
        public abstract string CurrencySell();
        public abstract string CurrencyBuy();

        //todo (Yanlış örnek) Burada mesela her coin arzı arttırılamaz bu sebepten ötürü burada Single Responsibility ihlal edildi(Yanlış örnek göstermek amacıyla yapıldı)
        public void CurrencySupplyIncrease(int supplyIncreaseAmount)
        {
            Console.WriteLine(supplyIncreaseAmount + "Supply Arttırıldı.");
        }

        //todo Single Responsibility Her coin isteğe bağlı bir şekilde burn edilebilir bu sebepten ötürü bunu her coin içerisinde tutmaya gerek yok
        public void CurrencySupplyBurn(int supplyIncreaseAmount)
        {
            Console.WriteLine(supplyIncreaseAmount + "Supply Arttırıldı.");
        }

        //Single Responsibility Bir coin herhangi bir exchange üzerinde işlem görebilir veya görmeyebilir
        public List<string> GetCurrencyExchangeList(List<string> exchangeList)
        {
            return exchangeList;
        }







    }
}
