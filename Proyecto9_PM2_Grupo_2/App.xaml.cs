using Microsoft.Maui.Controls;
namespace Proyecto9_PM2_Grupo_2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}