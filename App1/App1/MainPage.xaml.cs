using App1.Views;
using Domain.Users;
using Services.Users;
using System;
using System.Linq;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private readonly UsersService _userService;
        User[] Users = new User[] {};
        public MainPage()
        {
            InitializeComponent();
            _userService = new UsersService();
            Users = _userService.GetUsers();
            allUsers.ItemsSource = Users;
        }

        private async void postViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PostView());
        }

        private async void allUsers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedUser = (User)allUsers.SelectedItem;
            User user = Users.FirstOrDefault(u => u.Id == selectedUser.Id);
            bool result = await DisplayAlert("Удалить", "Вы действительно хотите удалить пользователя?", "Да", "Нет");
            if (result)
                _userService.DeleteUser(user);
        }
    }
}
