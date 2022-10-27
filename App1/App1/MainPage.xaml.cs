using App1.Models;
using App1.UserService;
using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public User Model { get; private set; }

        public UsersService userService = new UsersService();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private void sendBtn_Clicked(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.Name = nameTbx.Text;
            newUser.Fam = famTbx.Text;
            newUser.Id = null;
            string result = userService.Add(newUser);
            DisplayAlert("У вас 1 непрочитанная открытка", result, "Нихачу >.<");
        }

    }
}
