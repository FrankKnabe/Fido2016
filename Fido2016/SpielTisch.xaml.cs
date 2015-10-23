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
        List<Spieler> spieler = new List<Spieler>();
        SolidColorBrush oFarbe = System.Windows.Media.Brushes.Red;
        SolidColorBrush uFarbe = System.Windows.Media.Brushes.Black;
        int zufallszahl;
        Random rnd = new Random();
        StackPanel[] sp;
        ScrollViewer[] sv;

        public SpielTisch()
        {
            InitializeComponent();
        }
        public SpielTisch(int player)
        {
            InitializeComponent();
            int AnzahlSteine = Spielausfuehrung.AnzahlDominosteineErmitteln(player);
            List<DominoStein> SteinListe = Spielausfuehrung.DominoSteineErzeugen(oFarbe, uFarbe);
            //Spielerfelder mit Steinen befüllen
            for (int i = 0; i < player; i++ )
            {
                //StackPanel und ScrollViewer für den spezifischen Spieler erzeugen
                sp[i] = new StackPanel();
                sv[i] = new ScrollViewer();
                sp[i].Orientation = Orientation.Horizontal;
                sp[i].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                sp[i].VerticalAlignment = System.Windows.VerticalAlignment.Top;
                sp[i].Height = 80;
                sp[i].Width = 320;
                sv[i].Width = 320;
                sp[i].Visibility = Visibility.Hidden;
               
                //Label für den Namen des Spielers
                Label lblPlayer = new Label();
                lblPlayer.FontSize = 18;
                lblPlayer.Content = spieler[i].name;
                lblPlayer.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                lblPlayer.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                
                //Label in den StackPanel einfügen
                sp[i].Children.Add(lblPlayer);

                //Steine für den Spieler ziehen
                for(int j = 0;  j < AnzahlSteine; j++)
                {
                    zufallszahl = rnd.Next(0, SteinListe.Count);
                    spieler[i].SpielsteineZiehen(SteinListe[zufallszahl]);
                    sp[i].Children.Add(spieler[i].hand[j]);
                    SteinListe.RemoveAt(zufallszahl);
                }

            }

        }

        



        //Spielerinstanzen werden erstellt und in einer Liste gespeichert
        public void spielerhinzufügen(string spielername)
        {
            spieler.Add(new Spieler(spielername));
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
