using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVW
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnguardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alertita", "No", "Hola");

        }
    }
}
