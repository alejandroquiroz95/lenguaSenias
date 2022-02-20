using lenguaSenias.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lenguaSenias.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}