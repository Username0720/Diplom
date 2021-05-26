using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grants.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingInUp : ContentPage
    {
        public SingInUp()
        {
            InitializeComponent();
        }
        public void Button_a_Clicked(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}