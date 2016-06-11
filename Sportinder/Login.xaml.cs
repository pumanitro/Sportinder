using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sportinder
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text.Equals("devrace") && PasswordBox.Password.Equals("devrace"))
            {
                Frame.Navigate(typeof(MainPage));
            }
            else if(LoginBox.Text.Equals(""))
            {
                var dialog = new MessageDialog("Please enter login");
                await dialog.ShowAsync();
            }
            else if (PasswordBox.Password.Equals(""))
            {
                var dialog = new MessageDialog("Please enter password");
                await dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog("The entered login and/or password is incorrect!\nPlease try again :)");
                await dialog.ShowAsync();
            }

        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Register));
        }

        private void PasswordBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                Button_Click_1(null, null);
            }
        }
    }
}
