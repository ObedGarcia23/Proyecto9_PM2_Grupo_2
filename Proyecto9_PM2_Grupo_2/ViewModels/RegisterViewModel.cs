using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Firebase.Auth;


namespace Proyecto9_PM2_Grupo_2.ViewModels
{
    internal class RegisterViewModel : INotifyPropertyChanged
    {
        public string webApiKey = "AIzaSyD_Hav114FT7qKDzXaGZwJqVyhTq-TJEiA"; // Asegúrate de reemplazar esto con tu clave API real

        private INavigation _navigation;
        private string email;
        private string password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Email
        {
            get => email;
            set
            {
                email = value;
                RaisePropertyChanged("Email");
            }
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                RaisePropertyChanged("Password");
            }
        }

        public Command RegisterUser { get; }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public RegisterViewModel(INavigation navigation)
        {
            this._navigation = navigation;
            RegisterUser = new Command(async () => await RegisterUserTappedAsync());
        }

        private async Task RegisterUserTappedAsync()
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(Email, Password);
                string token = auth.FirebaseToken;
                if (token != null)
                    await App.Current.MainPage.DisplayAlert("Alert", "Usuario registrado correctamente", "OK");

                // Envía un correo de verificación
                var user = auth.User;
                if (user != null && !user.IsEmailVerified)
                {
                    await authProvider.SendEmailVerificationAsync(token);
                    await App.Current.MainPage.DisplayAlert("Alert", "Se ha enviado un correo de verificación a su dirección de correo electrónico. Por favor, verifique su correo antes de iniciar sesión.", "OK");
                }

                await this._navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
        }
    }
}
