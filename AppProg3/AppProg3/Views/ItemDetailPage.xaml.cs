using AppProg3.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppProg3.Views
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