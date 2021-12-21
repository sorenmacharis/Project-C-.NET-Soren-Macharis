using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Universe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var pageModel = new MainPageModel();
            BindingContext = pageModel;
        }
        async public void OpenNewItemsPage()
        {
            await App.Current.MainPage.PushAsync(new ItemPage());
        }

    }
}
