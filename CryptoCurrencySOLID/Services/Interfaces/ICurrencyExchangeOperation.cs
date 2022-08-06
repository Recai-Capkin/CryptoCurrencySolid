using CryptoCurrencySOLID.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Services.Interfaces
{
    public interface ICurrencyExchangeOperation
    {
        public void Add(string currencyName);
        public void Remove(string currencyName);
    }
}
