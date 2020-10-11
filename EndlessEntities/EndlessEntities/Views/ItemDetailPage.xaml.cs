using System.ComponentModel;
using Xamarin.Forms;
using EndlessEntities.ViewModels;

namespace EndlessEntities.Views
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