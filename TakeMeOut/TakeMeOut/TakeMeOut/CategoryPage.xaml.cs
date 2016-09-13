using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinForms.Views;

namespace TakeMeOut
{
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
            MainListView.ItemsSource = new List<CategoryList>
            {
                new CategoryList
                {
                    Category = "Restaurant",
                    Description = "this is cool",
                    ImageUrl = "b1.jp"

                },
                    new CategoryList
                {
                    Category = "Restaurant",
                    Description = "this is cool",
                    ImageUrl = "b2.jp"

                },
                        new CategoryList
                {
                    Category = "Restaurant",
                    Description = "this is cool",
                    ImageUrl = "b1.jp"
                    
                },
                    new CategoryList
                {
                    Category = "Restaurant",
                    Description = "this is cool",
                    ImageUrl = "b1.jp"
                    

                }

            };
             
    }

        private async void ListButton_OnTapped(object sender, EventArgs e)
        {

           
                await Navigation.PushAsync(new FoursquareViewPage());
           
            }
           
    }
}
