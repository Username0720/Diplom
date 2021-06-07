﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Grants.Views;

namespace Grants
{
    public partial class MainPage : ContentPage
    {
        ApplicationViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new ApplicationViewModel() { Navigation = this.Navigation };
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            await viewModel.GetData();
            base.OnAppearing();
        }
    }
}