using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;



namespace Launcers_Choosers
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask task = new PhoneCallTask();
            task.DisplayName = "Panagiotis";
            task.PhoneNumber = "1234567890";
            task.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SmsComposeTask task = new SmsComposeTask();
            task.Body = " kalispera";
            task.To = "1234567890";
            task.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WebBrowserTask task = new WebBrowserTask();
            task.Uri = new Uri("http://www.studentguru.gr", UriKind.Absolute);
            task.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask();
            task.Body = "studentguru appstart";
            task.Subject = "kathe paraskeui 2 me 5";
            task.To = "sgpatras@outlook.com";
            task.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SearchTask task = new SearchTask();
            task.SearchQuery = "studentguru";
            task.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SaveContactTask task = new SaveContactTask();
            task.FirstName = "panagiotis";
            task.LastName = "karagiannis";
            task.MobilePhone = "1234567890";
            task.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SaveEmailAddressTask task = new SaveEmailAddressTask();
            task.Email = "sgpatras@outlook.com";
            task.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SavePhoneNumberTask task = new SavePhoneNumberTask();
            task.PhoneNumber = "1234567890";
            task.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask task = new PhotoChooserTask();
            task.Completed += task_Completed;
            task.Show();
        }

        void task_Completed(object sender, PhotoResult e)
        {
            if (e.Error == null && e.TaskResult == TaskResult.OK)
            {
                BitmapImage image = new BitmapImage();
                image.SetSource(e.ChosenPhoto);
                picture.Source = image;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            CameraCaptureTask task2 = new CameraCaptureTask();
            task2.Completed += task2_Completed;
            task2.Show();
        }

        void task2_Completed(object sender, PhotoResult e)
        {
            if (e.Error == null && e.TaskResult == TaskResult.OK)
            {
                BitmapImage image = new BitmapImage();
                image.SetSource(e.ChosenPhoto);
                picture.Source = image;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            PhoneNumberChooserTask task4 = new PhoneNumberChooserTask();
            task4.Completed += task4_Completed;
            task4.Show();
        }

        void task4_Completed(object sender, PhoneNumberResult e)
        {
            if (e.Error == null && e.TaskResult == TaskResult.OK)
            {
                MessageBox.Show(e.DisplayName + " " + " selected");

            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            EmailAddressChooserTask task5 = new EmailAddressChooserTask();
            task5.Completed += task5_Completed;
            task5.Show();
        }

        void task5_Completed(object sender, EmailResult e)
        {
            if (e.Error==null && e.TaskResult==TaskResult.OK)
            {
                MessageBox.Show(e.Email + " " + "selected");

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            PhoneNumberChooserTask task11 = new PhoneNumberChooserTask();
            task11.Completed += task11_Completed;
            task11.Show();
        }

        void task11_Completed(object sender, PhoneNumberResult e)
        {
            if (e.Error==null && e.TaskResult==TaskResult.OK)
            {
                SmsComposeTask taskk = new SmsComposeTask();
                taskk.To = e.PhoneNumber;
                taskk.Body = "geia sou";
                taskk.Show();
            }

        }

    }
}