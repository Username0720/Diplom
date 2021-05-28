using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using Grants.Views;

namespace Grants.ViewModels
{
    class GrantListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<GrantViewModel> Grants { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand BackCommand { protected set; get; }
        GrantViewModel selectedGrant;

        public INavigation Navigation { get; set; }

        public GrantListViewModel()
        {
            Grants = new ObservableCollection<GrantViewModel>();
            BackCommand = new Command(Back);
        }

        public GrantViewModel SelectedGrant
        {
            get { return selectedGrant; }
            set
            {
                if (selectedGrant != value)
                {
                    GrantViewModel tempGrant = value;
                    selectedGrant = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new GrantPage());
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        
        private void Back()
        {
            Navigation.PopAsync();
        }
    }
}
