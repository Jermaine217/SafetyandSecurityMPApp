using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafetyandSecurityMPApp.WelcomePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "LoginViewModel";

        }
        void Login(object sender, EventArgs e)
        {
            (sender as Button).Text = "WelcomeScreen";
        }

    }
}