using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathisApp
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        private void ReturnToHome(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}