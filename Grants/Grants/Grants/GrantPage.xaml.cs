using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Grants;
using Xamarin.Essentials;

namespace Grants
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GrantPage : ContentPage
    {
        public Data_ Model { get; private set; }
        public ApplicationViewModel ViewModel { get; private set; }
        public GrantPage(Data_ model, ApplicationViewModel viewModel)
        {
            InitializeComponent();
            Model = model;
            ViewModel = viewModel;
            this.BindingContext = this;
        }
        private async void Openlink(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri(href_link.Text), BrowserLaunchMode.SystemPreferred);
        }

        private async void Cancel(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}