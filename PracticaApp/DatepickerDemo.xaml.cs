using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticaApp
{
    public partial class DatepickerDemo : ContentPage
    {
        public DatepickerDemo()
        {
            InitializeComponent();
            var stack = new StackLayout();

            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2019, 1, 1),
                MaximumDate = new DateTime(2019, 12, 31),
                Date = new DateTime(2019, 6, 21)
            };

            stack.Children.Add(datePicker);
            Content = datePicker;
        }
    }
}
