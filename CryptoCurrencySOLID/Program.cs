using CryptoCurrencySOLID.Abstract;


new ExchangeOperation(new Binance()).Add(new Holochain().ToString());

Mina Mina = new Mina();
Mina.StakeStart();


BaseCurrency baseCurrency = new Tether();
Console.WriteLine(baseCurrency.CurrencyBuy(15000, baseCurrency.GetCurrencyCode(),24000));