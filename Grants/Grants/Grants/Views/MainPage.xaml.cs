using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Grants.Models;
using Grants.Views;

namespace Grants
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
            using (ApplicationContext db = new ApplicationContext(dbPath))
            {
                GrantsList.ItemsSource = db.Datas.ToList();
            }
            base.OnAppearing();
        }

        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Data_ selectedGrant = (Data_)e.SelectedItem;
            GrantPage grantPage = new GrantPage();
            grantPage.BindingContext = selectedGrant;
            await Navigation.PushAsync(grantPage);
        }
    }
}
