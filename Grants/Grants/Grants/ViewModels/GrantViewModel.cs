using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Grants.Models;

namespace Grants.ViewModels
{
    public class GrantViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Data_ Data_ { get; private set; }

        public GrantViewModel()
        {
            Data_ = new Data_();
        }
        
        public string Konkurs
        {
            get { return Data_.konkurs_name; }
            set
            {
                if (Data_.konkurs_name != value)
                {
                    Data_.konkurs_name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Href
        {
            get { return Data_.href; }
            set
            {
                if (Data_.href != value)
                {
                    Data_.href = value;
                    OnPropertyChanged("href");
                }
            }
        }

        public string Organization
        {
            get { return Data_.organization; }
            set
            {
                if (Data_.konkurs_name != value)
                {
                    Data_.konkurs_name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Location_
        {
            get { return Data_.location_; }
            set
            {
                if (Data_.location_ != value)
                {
                    Data_.location_ = value;
                    OnPropertyChanged("location");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Konkurs.Trim())) ||
                    (!string.IsNullOrEmpty(Href.Trim())) ||
                    (!string.IsNullOrEmpty(Organization.Trim())) ||
                    (!string.IsNullOrEmpty(Location_.Trim())));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
