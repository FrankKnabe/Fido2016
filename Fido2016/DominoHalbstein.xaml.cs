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
    /// Interaction logic for DominoHalbstein.xaml
    /// </summary>
    //Die Klasse eines Halbsteines, aus dem ein kompletter Dominostein erstellt wird 
    public partial class DominoHalbstein : Window
    {
        int _Augenzahl = 0;
        SolidColorBrush _Farbe;
        public DominoHalbstein()
        {
            InitializeComponent();
        }

        public DominoHalbstein(int az, SolidColorBrush f)
        {
            Augenzahl = az;
            Farbe = f;

            InitializeComponent();

            InitDominoHalbstein(Augenzahl, Farbe);
        }

        public void InitDominoHalbstein(int Augenzahl, SolidColorBrush Farbe)
        {
            //Der Rahmen des halben Spielsteines
            Border BorderHalbstein = new Border();
            BorderHalbstein.HorizontalAlignment = HorizontalAlignment.Left;
            BorderHalbstein.Height = 40;
            BorderHalbstein.VerticalAlignment = VerticalAlignment.Top;
            BorderHalbstein.Width = 40;
            BorderHalbstein.BorderBrush = Farbe;
            BorderHalbstein.BorderThickness = new Thickness(2);
            BorderHalbstein.Margin = new Thickness(0, 0, 0, 0);

            //Erstellung der Gitterfelder für die Punkte, die die Augenzahlen repräsentieren
            Grid GridHalbstein = new Grid();
            GridHalbstein.Height = 35;
            GridHalbstein.Width = 35;
            GridHalbstein.Background = System.Windows.Media.Brushes.Transparent;
            //Die Reihen und Zeilen, die ein 3x3 Gitterfeld erzeugen
            ColumnDefinition[] colDef = new ColumnDefinition[3];
            RowDefinition[] rowDef = new RowDefinition[3];

            for (int i = 0; i < 3; i++)
            {
                colDef[i] = new ColumnDefinition();
                rowDef[i] = new RowDefinition();
                GridHalbstein.ColumnDefinitions.Add(colDef[i]);
                GridHalbstein.RowDefinitions.Add(rowDef[i]);

            }

            //Switch-Case-Anweisung für dynamische Erzeugung der Augenzahl, die der Klasse aus der
            //Liste der Dominosteine zugewiesen wird. Die Punkte bekommen eine Position im Gitterfeld
            //und werden dann dem Grid hinzugefügt
            switch (Augenzahl)
            {
                case 1:
                    setCell(GridHalbstein, 1, 1, createEllipse(Farbe));
                    break;
                case 2:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    break;
                case 3:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    break;
                case 4:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 2, createEllipse(Farbe));
                    break;
                case 5:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 1, createEllipse(Farbe));
                    break;
                case 6:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 1, createEllipse(Farbe));
                    break;
                case 7:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 1, createEllipse(Farbe));
                    break;
                case 8:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 0, createEllipse(Farbe));
                    break;
                case 9:
                    setCell(GridHalbstein, 0, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 2, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 0, 1, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 2, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 0, createEllipse(Farbe));
                    setCell(GridHalbstein, 1, 1, createEllipse(Farbe));
                    break;
            }


            //Das Gitterfeld wird dem Rahmen zugefügt und der Rahmen dem Spielstein    
            BorderHalbstein.Child = GridHalbstein;
            Halbstein.Children.Add(BorderHalbstein);

        }

        private static void setCell(Grid grid, int column, int row, Ellipse ellipse)
        {
            Grid.SetColumn(ellipse, column);
            Grid.SetRow(ellipse, row);

            grid.Children.Add(ellipse);
        }

        //Erstellung eines Punktes, der die Augenzahl repräsentieren soll

        private static Ellipse createEllipse(SolidColorBrush farbe)
        {
            Ellipse ellipse = new Ellipse();

            ellipse.Fill = farbe;
            ellipse.HorizontalAlignment = HorizontalAlignment.Center;
            ellipse.Height = 5;
            ellipse.Stroke = farbe;
            ellipse.VerticalAlignment = VerticalAlignment.Center;
            ellipse.Width = 5;
            return ellipse;
        }
        public int Augenzahl
        {
            get { return _Augenzahl; }
            set { _Augenzahl = value; }
        }

        public SolidColorBrush Farbe
        {
            get { return _Farbe; }
            set { _Farbe = value; }
        }

        public DominoStein DominoStein
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
