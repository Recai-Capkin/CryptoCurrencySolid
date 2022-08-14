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
        //mesela bir para birimi dolar üzerinden değer dönebilir ya da bitcoin paritesi cinsinden dönebilir.
        //Bunun için ayrı bir interface oluşturulup farklı bir kontrol de sağlanabilirdi fakat fiyatın öğrenilmesi zorunlu
        //bir işlem olduğundan dolayı doğrudan abstract olarak tanımlandı. Para Kuru ile bir kontrol sağlandı
        //Bu yöntem ilerleyen zamanlarda daha farklı bir çözüm ile geliştirilebilir
        
        public abstract decimal GetCurrencyPrice(string moneyRate);
        public abstract decimal GetCurrencyMarketCap();
        public abstract decimal GetCurrencyCurrentSupply();

        public abstract string GetCurrencyAlgorithm();
        public abstract string CurrencySell(decimal amount, string coinId, decimal sellingPrice);
        public abstract string CurrencyBuy(decimal amount, string coinId, decimal buyingPrice);

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
