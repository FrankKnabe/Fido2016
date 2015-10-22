using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fido2016
{
    class Rand : System.Windows.Controls.Border
    {
        DominoStein _domino;
        int _posx;
        int _posy;
        String _himmelsrichtung;
        int _punktzahl;

        public Rand()
        {

        }

        public Rand(DominoStein ds)
        {
            domino = ds;
        }

        public DominoStein domino
        {
            get { return _domino; }
            set { _domino = value; }
        }

        public int posx
        {
            get { return _posx; }
            set { _posx = value; }
        }

        public int posy
        {
            get { return _posy; }
            set { _posy = value; }
        }

        public int punktzahl
        {
            get { return _punktzahl; }
            set { _punktzahl = value; }
        }

        public String himmelsrichtung
        {
            get { return _himmelsrichtung; }
            set { _himmelsrichtung = value; }
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
