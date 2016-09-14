using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinForms.Views;

namespace TakeMeOut
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void AreaButton_OnClicked(object sender, EventArgs e)
        {
            string area = await DisplayActionSheet("Choose Area",
                   "Stop",
                   "Proceed",
                   "Aarhus",
                   "Aalborg",
                   "Langå",
                   "CopenHagen");

            if (area == "Copenhagen")
            {

                await Navigation.PushAsync(new CategoryPage());

            }

            else if (area == "Aarhus")
            {

                await Navigation.PushAsync(new FoursquareViewPage());

            }
            //)
            //CrossShare.Current.ShareLink(" http://goo.gl/hbhsm4e");
            // Device.OpenUri(new Uri("https://play.google.com/store/apps/developer?id=KABE%20Collective&hl=en"));
        }

    }
}
