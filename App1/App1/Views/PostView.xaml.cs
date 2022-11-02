using Domain.Users;
using Services.Users;
using System;  
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostView : ContentPage
    {
        private readonly UsersService _userService;
        public PostView()
        {
            InitializeComponent();
            _userService = new UsersService();
        }


        private void sendBtn_Clicked(object sender, EventArgs e)
        {
            UserBlank userBlank = new UserBlank(null, nameTbx.Text, famTbx.Text); 
            string result = _userService.SaveUser(userBlank);
            DisplayAlert("У вас 1 непрочитанная открытка", result, "Нихачу >.<");
        }
    }
}