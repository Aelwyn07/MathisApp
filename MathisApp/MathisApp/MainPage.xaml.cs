using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace MathisApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void gifButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
        private void OnDarkModeButtonClicked(object sender, EventArgs e)
        {
            if (App.Current.RequestedTheme == AppTheme.Dark)
            {
                // Si le thème actuel est sombre, passer au thème clair
                App.Current.UserAppTheme = AppTheme.Light;
                themeModeButton.Text = "Activer le mode sombre";
            }
            else
            {
                // Sinon, passer au thème sombre
                App.Current.UserAppTheme = AppTheme.Dark;
                themeModeButton.Text = "Désactiver le mode sombre";
            }
        }
    }

}
