
using Proyecto9_PM2_Grupo_2.ViewModels;

namespace Proyecto9_PM2_Grupo_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(Navigation);
        }

    //    private void InitializeComponent()
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}