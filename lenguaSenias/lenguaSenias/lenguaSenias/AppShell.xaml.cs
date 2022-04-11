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
            Routing.RegisterRoute("LessonsPage", typeof(LessonsPage));
            Routing.RegisterRoute("CorouselContentPage", typeof(CorouselContentPage));
            Routing.RegisterRoute("LessonsListPage", typeof(LessonsListPage));
            Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
        }

        private async void OnMenuItemTips(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CorouselContentPage");
        } 
        
        private async void OnMenuItemLessons(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("LessonsListPage");
        }
        
        private async void OnMenuItemProfile(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ProfilePage");
        }

        private async void OnMenuItemLogout(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
