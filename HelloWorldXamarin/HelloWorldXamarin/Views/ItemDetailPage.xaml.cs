using HelloWorldXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HelloWorldXamarin.Views
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