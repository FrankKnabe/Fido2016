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
    /// <summary>
    /// Interaction logic for DominoStein.xaml
    /// </summary>
    public partial class DominoStein : Window
    {
        //Die beiden Hälften, aus dem der Dominostein besteht
        DominoHalbstein HalbsteinOben = new DominoHalbstein();
        DominoHalbstein HalbsteinUnten = new DominoHalbstein();

        //Die Werte der beiden Hälften
        int AugenzahlOben = 0;
        int AugenzahlUnten = 0;

        //Definition der offen Enden
        bool _ObenOffen = true;
        bool _UntenOffen = true;
        bool _RechtsOffen = false;
        bool _LinksOffen = false;

        //Ist der Stein aktiv
        bool aktiverStein = false;

        public DominoStein()
        {
            InitializeComponent();
        }

        public DominoStein(DominoHalbstein o, DominoHalbstein u)
        {
            HalbsteinOben = o;
            HalbsteinUnten = u;
            AugenzahlOben = o.Augenzahl;
            AugenzahlUnten = u.Augenzahl;
            ObenOffen = true;
            UntenOffen = true;
            RechtsOffen = false;
            LinksOffen = false;
            aktiverStein = false;

            InitializeComponent();
        }

        public bool ObenOffen
        {
            get { return _ObenOffen; }
            set { _ObenOffen = value; }
        }

        public bool UntenOffen
        {
            get { return _UntenOffen; }
            set { _UntenOffen = value; }
        }

        public bool RechtsOffen { get; set; }

        public bool LinksOffen { get; set; }

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
