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
    public partial class web : PhoneApplicationPage
    {
        public web()
        {
            InitializeComponent();
            Uri targetUri = new Uri("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=KYKFUYKHJKK3G");
            web1.Navigate(targetUri);
        }
    }
}