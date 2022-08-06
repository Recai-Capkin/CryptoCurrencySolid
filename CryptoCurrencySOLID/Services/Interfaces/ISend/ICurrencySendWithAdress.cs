using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Services.Interfaces
{
    public interface ICurrencySendWithAdress
    {
        //todo Interface segregation yöntemi kullanıldı. Çünkü gönderim yapılırken kimisi adress ile kimisi adres ve tag ile gönderim yaptı
        public string CurrencySendWithAdress(string adress, string currencyType, float sendingFee);
    }
}
