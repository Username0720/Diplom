using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace Grants
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        bool initialized = false;   // была ли начальная инициализация
        Data_ selectedGrant;  // выбранный конкурс
        private bool isBusy;    // идет ли загрузка с сервера

        public ObservableCollection<Data_> Data_s { get; set; }
        Data_Service data_Service = new Data_Service();
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand BackCommand { protected set; get; }

        public INavigation Navigation { get; set; }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
                OnPropertyChanged("IsLoaded");
            }
        }
        public bool IsLoaded
        {
            get { return !isBusy; }
        }
        public ApplicationViewModel()
        {
            Data_s = new ObservableCollection<Data_>();
            IsBusy = false;
            BackCommand = new Command(Back);
        }
        public Data_ SelectedGrant
        {
            get { return selectedGrant; }
            set
            {
                if (selectedGrant != value)
                {
                    Data_ tempGrant = new Data_()
                    {
                        konkurs_name = value.konkurs_name,
                        href = value.href,
                        organization = value.organization,
                        date_begin = value.date_begin,
                        date_end = value.date_end,
                        date_ = value.date_,
                        location_ = value.location_
                    };
                    selectedGrant = null;
                    OnPropertyChanged("selectedGrant");
                    Navigation.PushAsync(new GrantPage(tempGrant, this));
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

        public async Task GetData()
        {
            if (initialized == true) return;
            IsBusy = true;
            IEnumerable<Data_> data_s = await data_Service.Get();

            // очищаем список
            //Data_s.Clear();
            while (Data_s.Any())
                Data_s.RemoveAt(Data_s.Count - 1);

            // добавляем загруженные данные
            foreach (Data_ f in data_s)
                Data_s.Add(f);
            IsBusy = false;
            initialized = true;
        }
    }
}
