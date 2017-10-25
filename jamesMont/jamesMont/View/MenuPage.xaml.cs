﻿using jamesMont.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jamesMont.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        
        public MenuPage(string Name)
        {
            InitializeComponent();
            
            HiLabel.Text = "Hi, "+Name;
        }
        async void MakeABooking(object sender, System.EventArgs e)
        {
            try
            {
                 await Navigation.PushAsync(new CategoriesPage());
            }
            catch (System.Exception er)
            {
                await DisplayAlert("Alert", "da error: "+er, "Ok");
            }
           
        }
        async void EditABooking(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "Edit A Booking", "Ok");
        }

        async void Shop(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "Shop", "Ok");
        }

        async void logOut(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}