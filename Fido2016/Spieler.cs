using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fido2016
{
    class Spieler
    {
        String _name;
        bool _aktiv = false;
        int _punkte = 0;
        List<DominoStein> _hand = new List<DominoStein>();

        public Spieler()
        {

        }

        public Spieler(String n)
        {
            name = n;
        }

        public void SpielsteineZiehen(DominoStein Spielstein)
        {
            hand.Add(Spielstein);
        }
        public String name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool aktiv
        {
            get { return _aktiv; }
            set { _aktiv = value; }
        }

        public int punkte
        {
            get { return _punkte; }
            set { _punkte = value; }
        }

        public List<DominoStein> hand
        {
            get { return _hand; }
            set { _hand = value; }
        }

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
    }
}
