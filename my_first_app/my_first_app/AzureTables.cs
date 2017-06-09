using System;

using Xamarin.Forms;

namespace my_first_app
{
    public class AzureTables : ContentPage
    {
        public AzureTables()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

