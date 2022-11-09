using Domain.Users;
using Services.Users;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetAllView : ContentPage
    {
        private readonly UsersService _userService;
        public GetAllView()
        {
            InitializeComponent();
            _userService = new UsersService();
            User[] users = _userService.GetUsers();
            allUsers.ItemsSource = users;
        }
    }
}