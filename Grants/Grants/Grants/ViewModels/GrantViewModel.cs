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

        public Data Data { get; private set; }

        public GrantViewModel()
        {
            Data = new Data();
        }
        
        public string Text
        {
            get { return Data.text; }
            set
            {
                if (Data.text != value)
                {
                    Data.text = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Href
        {
            get { return Data.ahref; }
            set
            {
                if (Data.ahref != value)
                {
                    Data.ahref = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Text.Trim())) ||
                    (!string.IsNullOrEmpty(Href.Trim())));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
