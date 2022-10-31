using App1.Models;
using App1.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostView : ContentPage
    {
        public PostView()
        {
            InitializeComponent();
        }

        public UsersService userService = new UsersService();

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