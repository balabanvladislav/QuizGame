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
using System.Windows.Threading;

namespace QuizGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6};
        int qNum = 0;
        int i;
        int score;
        DateTime initTime = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent(); 
            StartGame();
            NextQuestion();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = "Timpul: " +  DateTime.Now.Subtract(initTime).Seconds;
        }
        private void NextQuestion()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            
            timer.Start();
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                // if we have done below the number of questions we have available then we will restart the game
                FinalResult();
            }

            // below we are running a foreach loop where will check for each button inside of the canvas and when we find them we will set their tag to 0 and background to dakr salmon colour
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkMagenta;
            }

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Ce joc este reprezentat in imagine?"; // this the question for the quiz

                    ans1.Content = "TES V:Skyrim"; // each of the buttons can have their own answers in this game
                    ans2.Content = "The Witchter 3";
                    ans3.Content = "GTA V";
                    ans4.Content = "Civilization";

                    ans2.Tag = "1"; 
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg")); // here we will load the 1st image inside of the qimage 

                    break;

                case 2:

                    txtQuestion.Text = "Ce joc este reprezentat in imagine?";

                    ans1.Content = "AC Vallhalla";
                    ans2.Content = "The Witchter 3";
                    ans3.Content = "Viking";
                    ans4.Content = "God of War 2";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));

                    break;

                case 3:

                    txtQuestion.Text = "Ce joc este reprezentat in imagine?";

                    ans1.Content = "AC Vallhalla";
                    ans2.Content = "Maffia";
                    ans3.Content = "TES V: Skyrim";
                    ans4.Content = "Oblivion";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));

                    break;

                case 4:

                    txtQuestion.Text = "Ce joc este reprezentat in imagine?";

                    ans1.Content = "Mafia";
                    ans2.Content = "Far cry 5";
                    ans3.Content = "GTA San Andreas";
                    ans4.Content = "Half Life 2";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));

                    break;

                case 5:

                    txtQuestion.Text = "Ce joc este reprezentat in imagine?";

                    ans1.Content = "Detroit Become Human";
                    ans2.Content = "Mafia III";
                    ans3.Content = "GTA V";
                    ans4.Content = "Death Stranding";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));

                    break;
                case 6:

                    txtQuestion.Text = "Ce joc este reprezentat in imagine?";

                    ans1.Content = "GTA V";
                    ans2.Content = "Hard West";
                    ans3.Content = "RDR 2";
                    ans4.Content = "Mafi III";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));

                    break;
            }
        }
        private void FinalResult(){
            timer.Stop();
            txtQuestion.Text = "Scorul filal:" + score + "/" + questionNumbers.Count + "\n" + lblTime.Content + " secunde.";
            ans1.Content = null; // each of the buttons can have their own answers in this game
            ans2.Content = null;
            ans3.Content = null;
            ans4.Content = "Incearca din nou.";

            ans2.Tag = "1"; 
            qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/main.png")); // here we will load the 1st image inside of the qimage 
            RestartGame(); // run the start game function
        }
        private void RestartGame()
        {
            score = 0; // set score to 0
            qNum = -1; // set qnum to -1
            i = 0; // set i to 0
            StartGame(); // run the start game function
        }
        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumbers = randomList;
            initTime = DateTime.Now;
        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {

            Button senderButton = sender as Button; 
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Scorul: " + score + "/" + questionNumbers.Count;

            NextQuestion();

        }
    }
}
