using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fido2016
{
    class Spielausfuehrung
    {
        public bool PaschErkennen(int AugenzahlOben, int AugenzalUnten)
        {
            Boolean Token;
            if (AugenzahlOben == AugenzalUnten)
            {
                Token = true;
            }
            else
            {
                Token = false;
            }

            return Token;

        }
    }
}
