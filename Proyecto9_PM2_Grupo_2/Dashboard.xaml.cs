using Newtonsoft.Json;
using Firebase.Auth;


namespace Proyecto9_PM2_Grupo_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            //GetProfileInfo();
        }

        //private void GetProfileInfo()
        //{
        //    var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FreshFirebaseToken", ""));
        //    UserEmail.Text = userInfo.User.Email;
        //}
    }
}