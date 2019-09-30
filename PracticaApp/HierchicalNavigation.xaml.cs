using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticaApp
{
    public partial class HierchicalNavigation : ContentPage
    {
        public HierchicalNavigation()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };

        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HierchicalNavigation2());
        }

    }
}
