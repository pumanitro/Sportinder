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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Sportinder
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            HamburgerButton.Visibility = Visibility.Visible;
            MySplitView.Visibility = Visibility.Visible;
            MyFrame.Navigate(typeof(HomePage));
            PageName.Text = "Home Page";
            HomePage.IsSelected = true;

        }




        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                HomePage.IsSelected = true;
                MySplitView.IsPaneOpen = false;
            }
        }

        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (HomePage.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(HomePage));
                PageName.Text = "Home Page";
                MySplitView.IsPaneOpen = false;
            }
            else if (Settings.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Settings));
                PageName.Text = "Settings";
                MySplitView.IsPaneOpen = false;
            }
            else if (EventsAttended.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(EventsAttended));
                PageName.Text = "My Events";
                MySplitView.IsPaneOpen = false;
            }
            else if (EventsCreated.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(EventsCreated));
                PageName.Text = "Events Created";
                MySplitView.IsPaneOpen = false;
            }
            else if (Logout.IsSelected)
            {
                var dialog = new MessageDialog("Are you sure ?");

                dialog.Commands.Add(new UICommand("Yes"));
                dialog.Commands.Add(new UICommand("No"));

                var result = await dialog.ShowAsync();
                if (result.Label.Equals("Yes"))
                {
                    BackButton.Visibility = Visibility.Collapsed;
                    PageName.Text = "";
                    MySplitView.IsPaneOpen = false;
                    MySplitView.Visibility = Visibility.Collapsed;
                    HamburgerButton.Visibility = Visibility.Collapsed;
                    Frame.Navigate(typeof(Login));
                }
                else
                {
                    MyFrame.GoBack();
                }

            }
            MyList.SelectedIndex = -1;
        }
    }
}
