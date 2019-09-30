using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracticaApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StackLayoutDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayoutDemo());

            };
            GridDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GridDemo());
            };
            HierchicalNavigation.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new HierchicalNavigation());

            };
            TabbedPage.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage());

            };
            DataForm.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DataForm());

            };
            DatepickerDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DatepickerDemo());

            };

        }
    }
}
