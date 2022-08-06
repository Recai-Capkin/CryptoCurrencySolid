using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Services.Interfaces
{
    public interface IMining
    {
        //todo Liskov Substitution gerçekleştirildi bu metot base class içerisinde kullanılamaz çünkü her coin mine edilemez
        //bu kodlar base class içinde olunca diğerleri de erişebiliyordu bu sebepten ötürü bunları buraya çektik
        public void MiningStart();
        public void MiningStop();
    }
}
