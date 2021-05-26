using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Grants.Parser;
using Grants.Parser.na_konferencii;
using AngleSharp.Html.Dom;
using System.Net;
using System.Text.RegularExpressions;
using Grants.ViewModels;

namespace Grants
{
    public partial class MainPage : ContentPage
    {
        ParserWorker<string[]> parser;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new GrantListViewModel() { Navigation = this.Navigation };
            parser = new ParserWorker<string[]>(
                    new Parser_konferencii()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }
        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            grants.Text += arg2;
        }

        private void Parser_OnCompleted(object obj)
        {
            DisplayAlert("", "All works done!", "OK");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //parser.Settings = new Settings_konferencii(1, 5);
            parser.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //parser.Start();
        }
    }
}
