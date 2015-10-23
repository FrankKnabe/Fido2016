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
    /// Interaction logic for SpielTisch.xaml
    /// </summary>
    public partial class SpielTisch : Window
    {
        int _AnzahlSpieler;
        List<Spieler> spieler = new List<Spieler>();

        public SpielTisch()
        {
            InitializeComponent();
        }
        public SpielTisch(int player)
        {
            InitializeComponent();
            AnzahlSpieler = player;
            Spielausfuehrung.AnzahlDominosteineErmitteln(AnzahlSpieler);

        }

        //Spielerinstanzen werden erstellt und in einer Liste gespeichert
        public void spielerhinzufügen(string spielername)
        {
            spieler.Add(new Spieler(spielername));

        }

        public int AnzahlSpieler
        {
            get { return _AnzahlSpieler; }
            set { _AnzahlSpieler = value; }
        }

        internal Spielausfuehrung Spielausfuehrung
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
