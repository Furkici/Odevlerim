using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Doktor:Brans
    {
        public string DoktorAd { get; set; }
        
        public override string ToString()
        {
            return DoktorAd;
        }
    }
}
