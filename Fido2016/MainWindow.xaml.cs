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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fido2016
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        private void cmdStart_Click(object sender, RoutedEventArgs e)
        {
            int player = Convert.ToInt32(numud.Child.Text);
            var newWindow = new SpielTisch(player);
            newWindow.Show();

            //Spielernamen zur Liste der Spieler hinzufügen
            for (int i = 1; i <= player; i++)
            {
                switch (i)
                {
                    case 1:
                        newWindow.spielerhinzufügen(player1.Text.ToString());
                        break;
                    case 2:
                        newWindow.spielerhinzufügen(player2.Text.ToString());
                        break;
                    case 3:
                        newWindow.spielerhinzufügen(player3.Text.ToString());
                        break;
                    case 4:
                        newWindow.spielerhinzufügen(player4.Text.ToString());
                        break;
                }
            }
        }
        //Die Eingabefelder, die zur Verfügung stehen, sind von der Anzahl der Spieler abhängig
        private void numud_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                switch (numud.Child.Text)
                {
                    case "3":
                        Spieler3.Visibility = Visibility.Visible;
                        player3.Visibility = Visibility.Visible;
                        Spieler4.Visibility = Visibility.Hidden;
                        player4.Visibility = Visibility.Hidden;
                        break;
                    case "4":
                        Spieler3.Visibility = Visibility.Visible;
                        player3.Visibility = Visibility.Visible;
                        Spieler4.Visibility = Visibility.Visible;
                        player4.Visibility = Visibility.Visible;
                        break;
                    default:
                        Spieler3.Visibility = Visibility.Hidden;
                        player3.Visibility = Visibility.Hidden;
                        Spieler4.Visibility = Visibility.Hidden;
                        player4.Visibility = Visibility.Hidden;
                        break;

                }

            }
             catch(NullReferenceException n)
            {
                //MessageBox.Show(n.Message);
            }


        }
    }
}
