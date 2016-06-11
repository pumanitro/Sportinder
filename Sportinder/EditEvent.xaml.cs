using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class EditEvent : Page
    {
        public EditEvent()
        {
            this.InitializeComponent();

            Esport_combobox.Visibility = Visibility.Collapsed;
            Sport_combobox.Visibility = Visibility.Collapsed;

            MapControl.MapServiceToken = "oMADUfTSiLaojzkDGgXy~02WPiIv88dqoZzPw5yv3Bg~Ain5V0MC0xHzGMY9MPyi - q4SiOxUoiREP1gURjZQNM86CEzNyMYVivpay1q - FcVc";
            Geopoint myPoint = new Geopoint(new BasicGeoposition() { Latitude = MapControl.Center.Position.Latitude, Longitude = MapControl.Center.Position.Longitude });
            MapIcon myIcon = new MapIcon { Location = myPoint, NormalizedAnchorPoint = new Point(1.0, 1.0), Title = "My position", ZIndex = 0 };
            MapControl.MapElements.Add(myIcon);
            myIcon.Location = myPoint;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EsportOrSport_combobox_Esport_click(object sender, RoutedEventArgs e)
        {
            Esport_combobox.Visibility = Visibility.Visible;
            Sport_combobox.Visibility = Visibility.Collapsed;
        }

        private void EsportOrSport_combobox_Sport_click(object sender, RoutedEventArgs e)
        {
            Esport_combobox.Visibility = Visibility.Collapsed;
            Sport_combobox.Visibility = Visibility.Visible;
        }

        private void LocalisationAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

        }

        private void LocalisationAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private void LocalisationAutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {

        }

        private void MapControl_MapHolding(MapControl sender, MapInputEventArgs args)
        {
            MapControl.MapElements.Clear();
            MapIcon myIcon = new MapIcon { Location = args.Location, NormalizedAnchorPoint = new Point(1.0, 1.0), Title = "Event localisation", ZIndex = 0 };
            MapControl.MapElements.Add(myIcon);
        }

        private void Reduce_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var currentValue = int.Parse(content.Text);

            if (currentValue == 0)
            {
                return;
            }
            content.Text = (currentValue - 1).ToString();
        }

        private void Increase_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var currentValue = int.Parse(content.Text);
            content.Text = (currentValue + 1).ToString();
        }
    }
}
