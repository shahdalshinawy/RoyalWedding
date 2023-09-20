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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Main
{
    /// <summary>
    /// Interaction logic for welcoming.xaml
    /// </summary>
    public partial class welcoming : Window
    {
        private DispatcherTimer timer;
        public welcoming()
        {
            InitializeComponent();
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = TimeSpan.FromSeconds(2);

            DoubleAnimationUsingKeyFrames moveAnimation = new DoubleAnimationUsingKeyFrames();
            moveAnimation.Duration = TimeSpan.FromSeconds(2);
            moveAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(-50, KeyTime.FromPercent(0)));
            moveAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(0, KeyTime.FromPercent(1)));

            Logo.BeginAnimation(Image.OpacityProperty, animation);
            Logo.RenderTransform.BeginAnimation(TranslateTransform.XProperty, moveAnimation);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            timer.Stop();
            MainWindow nextWindow = new MainWindow();
            nextWindow.Show();
            this.Close();
        }

    }
}


