using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp1
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
            
        }

        private void aid(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/aid.xaml", UriKind.RelativeOrAbsolute));
        }
        private void america(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/america.xaml", UriKind.RelativeOrAbsolute));
        }

        private void assistance(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/assistance.xaml", UriKind.RelativeOrAbsolute));
        }
        private void youth(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/youth.xaml", UriKind.RelativeOrAbsolute));
        }
        private void departed(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/departed.xaml", UriKind.RelativeOrAbsolute));
        }

        private void detachment(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/detachment.xaml", UriKind.RelativeOrAbsolute));
        }

        private void evening(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/evening.xaml", UriKind.RelativeOrAbsolute));
        }

        private void families(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/families.xaml", UriKind.RelativeOrAbsolute));
        }

        private void covenant(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/covenant.xaml", UriKind.RelativeOrAbsolute));
        }

        private void forgiveness(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/forgiveness.xaml", UriKind.RelativeOrAbsolute));
        }
        private void fund(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/fund.xaml", UriKind.RelativeOrAbsolute));
        }

        private void healing(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/healing.xaml", UriKind.RelativeOrAbsolute));
        }

        private void mankind(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/mankind.xaml", UriKind.RelativeOrAbsolute));
        }

        private void marriage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/marriage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void meetings(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/meeting.xaml", UriKind.RelativeOrAbsolute));
        }

        private void morning(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/morning.xaml", UriKind.RelativeOrAbsolute));
        }

        private void praise(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/praise.xaml", UriKind.RelativeOrAbsolute));
        }

        private void protection(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/protection.xaml", UriKind.RelativeOrAbsolute));
        }


        private void assembly(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/assembly.xaml", UriKind.RelativeOrAbsolute));
        }
        private void qualities(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/qualities.xaml", UriKind.RelativeOrAbsolute));
        }

        private void steadfastness(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/steadfastness.xaml", UriKind.RelativeOrAbsolute));
        }

        private void teaching(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/teaching.xaml", UriKind.RelativeOrAbsolute));
        }

        private void tests(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tests.xaml", UriKind.RelativeOrAbsolute));
        }

        private void triumph(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/triumph.xaml", UriKind.RelativeOrAbsolute));
        }

        private void unity(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/page7.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}