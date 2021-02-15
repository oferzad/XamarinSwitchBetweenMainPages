using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicUIBuilder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnotherPage : ContentPage
    {
        
        public AnotherPage()
        {
            InitializeComponent();
           
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = ((App) App.Current).Initial;
        }
    }
}