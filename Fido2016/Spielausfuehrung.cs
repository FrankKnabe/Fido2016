using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fido2016
{
    class Spielausfuehrung
    {
        List<Anlegeposition> anlegepositionen = new List<Anlegeposition>();
        List<DominoStein> dominosteine = new List<DominoStein>();
        List<DominoHalbstein> dominohalbsteineOben = new List<DominoHalbstein>();
        List<DominoHalbstein> dominohalbsteineUnten = new List<DominoHalbstein>();
        SolidColorBrush oFarbe = System.Windows.Media.Brushes.Red;
        SolidColorBrush uFarbe = System.Windows.Media.Brushes.Black;
        int anzahlAnfangssteine;
        Boolean aktiverSpieler;
        int zufallszahl;
        Random rnd = new Random();

        public SpielTisch SpielTisch
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
        //Anzahl der Dominosteine ermitteln
        public int AnzahlDominosteineErmitteln(int player)
        {
                    switch (player)
            {
                case 2:
                    anzahlAnfangssteine = 15;
                    break;
                case 3:
                    anzahlAnfangssteine = 13;
                    break;

                case 4:
                    anzahlAnfangssteine = 11;
                    break;
            }

                    return anzahlAnfangssteine;
        }

        //Dominosteine generieren
        public List<DominoStein> DominoSteineErzeugen(SolidColorBrush oFarbe, SolidColorBrush uFarbe)
        {
            for (int a = 0; a < 10; a++)
            {
                for(int b = 0; b > (a + 1); b++)
                {
                    DominoStein Spielstein = new DominoStein(new DominoHalbstein(a, oFarbe), new DominoHalbstein(b, uFarbe));
                    dominosteine.Add(Spielstein);
                }
            }
            
            return dominosteine;
        }

        public void SteinAnlegen()
        {

        }

        //Vergleicht, ob ein Pasch vorhanden ist, oder nicht
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
