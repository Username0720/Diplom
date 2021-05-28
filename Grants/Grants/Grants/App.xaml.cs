using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using Grants.Models;

namespace Grants
{
    public partial class App : Application
    {
        public const string DBFILENAME = "test2.db";
        public App()
        {
            InitializeComponent();
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DBFILENAME);
            using (var db = new ApplicationContext(dbPath))
            {
            }
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
