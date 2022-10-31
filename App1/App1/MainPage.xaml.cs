using Domain.Users;
using Services.Users;
using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {  
        private readonly UsersService _userService;

        public MainPage()
        {
            InitializeComponent();
            
            _userService = new UsersService();

            this.BindingContext = this;
        }

        private void sendBtn_Clicked(object sender, EventArgs e)
        {
            UserBlank userBlank = new UserBlank(null, nameTbx.Text, famTbx.Text);  
            string result = _userService.SaveUser(userBlank);
            DisplayAlert("У вас 1 непрочитанная открытка", result, "Нихачу >.<");
        }

    }
}
