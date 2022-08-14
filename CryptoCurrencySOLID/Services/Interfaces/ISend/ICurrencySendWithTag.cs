using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Services.Interfaces
{
    public interface ICurrencySendWithTag
    {
        public string CurrencySendWithTag(string tag, string adress, string coinId, decimal sendingFee, decimal sendingAmount);
    }
}
