using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fido2016
{
    class Spielausfuehrung
    {
        List<Spieler> spieler = new List<Spieler>();
        List<Anlegeposition> anlegepositionen = new List<Anlegeposition>();
        List<DominoStein> dominosteine;
        int anzahlAnfangssteine;
        int aktiverSpieler;
        int zufallszahl;
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
