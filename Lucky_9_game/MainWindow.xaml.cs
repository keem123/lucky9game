using CardGameData;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lucky_9_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CardSets cardset = new CardSets();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async  void DrawCardBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Effect = new BlurEffect() { KernelType = KernelType.Gaussian, Radius = 10, RenderingBias = RenderingBias.Quality };
            int instances1 = 0;
            var firstNumber = 0;
            int instances2 = 0;
            var SecondNumber = 0;

            Random rand = new Random();
            do
            {
                await Task.Delay(10);
                if(instances1 == 10)
                {
                    break;
                }
                firstNumber = rand.Next(1, 53);
                instances1++;
            }
            while (true);
            

            do
            {
                await Task.Delay(10);
                if (instances2 == 10)
                {
                    break;
                }
                SecondNumber = rand.Next(1, 53);
                instances2++;
            }
            while (true);
            

            FirstCard.Background = Brushes.Gainsboro;
            Secondcard.Background = Brushes.Gainsboro;


            var currentFirstCard = cardset.Deck[firstNumber - 1];

            var currentSecondCard = cardset.Deck[SecondNumber - 1];

            FirstCard.DataContext = currentFirstCard;
            Secondcard.DataContext = currentSecondCard;

            int firstvalue = 0;
            int secondvalue = 0;

            switch (currentFirstCard.CardName)
            {
                case "A":
                    firstvalue = 1;
                    break;

                case "2":
                    firstvalue = 2;
                    break;

                case "3":
                    firstvalue = 3;
                    break;
                case "4":
                    firstvalue = 4;
                    break;
                case "5":
                    firstvalue = 5;

                    break;
                case "6":
                    firstvalue = 6;
                    break;
                case "7":
                    firstvalue = 7;

                    break;
                case "8":
                    firstvalue = 8;
                    break;

                case "9":
                    firstvalue = 9;
                    break;
                case "10":
                    firstvalue = 10;
                    break;
                case "J":
                    firstvalue = 11;
                    break;
                case "Q":
                    firstvalue = 12;
                    break;
                case "K":
                    firstvalue = 13;
                    break;
            }


            switch (currentSecondCard.CardName)
            {
                case "A":
                    secondvalue = 1;
                    break;

                case "2":
                    secondvalue = 2;
                    break;

                case "3":
                    secondvalue = 3;
                    break;
                case "4":
                    secondvalue = 4;
                    break;
                case "5":
                    secondvalue = 5;

                    break;
                case "6":
                    secondvalue = 6;
                    break;
                case "7":
                    secondvalue = 7;

                    break;
                case "8":
                    secondvalue = 8;
                    break;

                case "9":
                    secondvalue = 9;
                    break;
                case "10":
                    secondvalue = 10;
                    break;
                case "J":
                    secondvalue = 11;
                    break;
                case "Q":
                    secondvalue = 12;
                    break;
                case "K":
                    secondvalue = 13;
                    break;
            }

            int total = firstvalue + secondvalue;

            int final = total % 10;
            
            ResultTextBlock.Text = final.ToString();
            this.Effect = new BlurEffect() { KernelType = KernelType.Gaussian, Radius = 0, RenderingBias = RenderingBias.Quality };
        }
    }
}
