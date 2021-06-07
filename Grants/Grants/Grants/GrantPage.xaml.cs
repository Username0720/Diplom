using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Grants;

namespace Grants
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GrantPage : ContentPage
    {
        public Data_ Model { get; private set; }
        public ApplicationViewModel ViewModel { get; private set; }
        public GrantPage(Data_ model, ApplicationViewModel viewModel)
        {
            //InitializeComponent();
            Model = model;
            ViewModel = viewModel;
            this.BindingContext = this;
        }
    }
}