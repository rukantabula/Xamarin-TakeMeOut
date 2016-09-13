﻿using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TakeMeOut
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
            
        }

        private async void CategoryButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryPage());
        }

        private void TellButton_OnClicked(object sender, EventArgs e)
        {
            //CrossShare.Current.Share("Hey!! Check out this cool app!     http://goo.gl/hbhsm4e", "Title");
            //CrossShare.Current.ShareLink(" http://goo.gl/hbhsm4e");
            Device.OpenUri(new Uri("https://play.google.com/store/apps/developer?id=KABE%20Collective&hl=en"));
        }


    }
}