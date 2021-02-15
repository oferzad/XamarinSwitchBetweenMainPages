using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicUIBuilder
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Label lbl;
        public MainPage()
        {
            InitializeComponent();
            this.lbl = new Label();
            lbl.Text = "Added Dynamically!";
            lbl.VerticalOptions= LayoutOptions.CenterAndExpand;
            lbl.HorizontalTextAlignment = TextAlignment.Center;
            stck.Children.Add(lbl);
            
        }

        protected override void OnAppearing()
        {
            lbl.Text += $"\n{DateTime.Now.ToString()}: Appearing()";
        }

        protected override void OnDisappearing()
        {
            lbl.Text += $"\n{DateTime.Now.ToString()}: Disappearing()";
        }

        private  void btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = ((App)App.Current).Another; 
        }
    }
}
