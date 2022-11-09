using App1.Views;
using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void postViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PostView());
        }

        private async void getAllButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllView());

        }

        private async void putButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PutView());

        }

        private async void deleteButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteView());

        }

        private async void getOneButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetOneView());

        }
    }
}
