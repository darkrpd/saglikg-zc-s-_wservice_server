using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaglikGozcusuWebService
{
    public class Maddeler
    {
        private string _MaddeAdi;
       
        private string _MaddeAciklamasi;

        public string MaddeAdi { get { return _MaddeAdi; } set { _MaddeAdi = value; } }
        public string MaddeAciklamasi { get { return _MaddeAciklamasi; } set { _MaddeAciklamasi = value; } }
        
    }

  
}