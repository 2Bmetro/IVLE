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

namespace mockup
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // if credential is memorized before
            // load credentials
        }

        // log in event by pressing the log in button
        private void login_Click(object sender, RoutedEventArgs e)
        {
            // authentication using username, password and domain

            // establish https connection

            // retrieve token and store properly


            // start preloading data


            // check whether to memorize user credentials 

            // perform page navigation
            NavigationService.Navigate(new Uri(("/MenuPage.xaml"), UriKind.Relative));
        }
    }
}