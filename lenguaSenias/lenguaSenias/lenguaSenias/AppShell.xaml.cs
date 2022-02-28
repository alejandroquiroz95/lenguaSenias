using lenguaSenias.ViewModels;
using lenguaSenias.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace lenguaSenias
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(TipsPage), typeof(TipsPage));
            Routing.RegisterRoute(nameof(LessonsListPage), typeof(LessonsListPage));
            Routing.RegisterRoute("LessonsPage", typeof(LessonsPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
