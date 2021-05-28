using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Grants.ViewModels;

namespace Grants.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GrantPage : ContentPage
    {
        string dbPath;
        public GrantPage()
        {
            InitializeComponent();
            dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
        }
    }
}