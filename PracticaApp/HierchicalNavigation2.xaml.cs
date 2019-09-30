using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticaApp
{
    public partial class HierchicalNavigation2 : ContentPage
    {
        public HierchicalNavigation2()
        {
            InitializeComponent();
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
