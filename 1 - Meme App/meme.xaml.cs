using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace PhoneApp1
{
    public partial class meme : PhoneApplicationPage
    {
        BitmapImage no = new BitmapImage(new Uri("/memes/no.png", UriKind.Relative));
        BitmapImage alone = new BitmapImage(new Uri("/memes/alone.png", UriKind.Relative));
        BitmapImage bad = new BitmapImage(new Uri("/memes/bad.png", UriKind.Relative));
        BitmapImage gusta = new BitmapImage(new Uri("/memes/gusta.png", UriKind.Relative));
        BitmapImage troll = new BitmapImage(new Uri("/memes/troll.png", UriKind.Relative));
        BitmapImage sir = new BitmapImage(new Uri("/memes/sir.png", UriKind.Relative));

        public meme()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            hello.Text = "Here's your meme for today, " + MainPage.data.name+"!";
            getmeme();
            
        }
        private void getmeme()
        {
            BitmapImage[] list = { no, alone, bad, gusta, troll, sir };

            Random rnd = new Random();
            image.Source = list[rnd.Next(list.Length)];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            getmeme();
        }
    }
}