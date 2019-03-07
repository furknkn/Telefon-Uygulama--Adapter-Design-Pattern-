using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_App_AdapterDesignPattern
{
    class UygulamaAcan:IUygulamaAcabilen
    {
        UygulamaAdapter uygulamaAdapter;

        public void UygulamaAc(string UygulamaAdi)
        {
            //rehber ve ayarlar varsayılan uygulamalar
            if (UygulamaAdi=="rehber")
            {
                Console.WriteLine("rehber açıldı");
            }
            else if (UygulamaAdi=="ayarlar")
            {
                Console.WriteLine("ayarlar açıldı");
            }
            else if (UygulamaAdi=="twitter"||UygulamaAdi=="instagram")
            {
                uygulamaAdapter = new UygulamaAdapter(UygulamaAdi);
                uygulamaAdapter.UygulamaAc(UygulamaAdi);
            }
            else
            {
                Console.WriteLine("uygulama telefonda mevcut değil");
            }
        }
    }
}
