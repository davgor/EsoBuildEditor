using System.ComponentModel;
using Xamarin.Forms;
using EsoBuildEditor.ViewModels;

namespace EsoBuildEditor.Views
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