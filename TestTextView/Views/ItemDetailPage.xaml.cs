using System.ComponentModel;
using TestTextView.ViewModels;
using Xamarin.Forms;

namespace TestTextView.Views
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