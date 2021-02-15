using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicUIBuilder
{
    public partial class App : Application
    {
        public  Page Another{get; set;}
        public Page Initial { get; set; }
        public App()
        {
            InitializeComponent();
            
            MainPage = new MainPage();
            Initial = MainPage;
            Another = new AnotherPage();
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
