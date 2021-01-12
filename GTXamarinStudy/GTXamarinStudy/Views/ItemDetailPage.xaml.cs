using GTXamarinStudy.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GTXamarinStudy.Views
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