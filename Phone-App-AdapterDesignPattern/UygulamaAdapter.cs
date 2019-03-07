using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_App_AdapterDesignPattern
{
    class UygulamaAdapter : IUygulamaAcabilen
    {
        IModernUygulamaAcabilen modernUygulamaAcan;
        public UygulamaAdapter(string uygulamaAdi)
        {
            if (uygulamaAdi=="twitter")
            {
                modernUygulamaAcan = new Twitter();
            }
            else if (uygulamaAdi=="instagram")
            {
                modernUygulamaAcan = new Instagram();
            }
        }
        public void UygulamaAc(string UygulamaAdi)
        {
            if (UygulamaAdi=="twitter")
            {
                modernUygulamaAcan.AcTwitter();
            }
            else if (UygulamaAdi=="instagram")
            {
                modernUygulamaAcan.AcInstagram();
            }
        }
    }
}
