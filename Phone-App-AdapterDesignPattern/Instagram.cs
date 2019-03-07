using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_App_AdapterDesignPattern
{
    class Instagram : IModernUygulamaAcabilen
    {
        public void AcInstagram()
        {
            Console.WriteLine("İnstagram açıldı");
        }

        public void AcTwitter()
        {
            throw new NotImplementedException();
        }
    }
}
