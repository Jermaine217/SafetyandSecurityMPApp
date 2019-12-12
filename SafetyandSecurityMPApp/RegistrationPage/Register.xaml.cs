using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafetyandSecurityMPApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Register : ContentPage 
    {
        public Register()
        {
            InitializeComponent();
        }


        private void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Wel());
        }
    }
}
 
    
    public class LoginViewModel : INotifyPropertyChanged
    {
        

        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;

       
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
    void OnButtonClicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "Register";

    }

    

        public void OnSubmit()
        {
            if (email != "macoratti@yahoo.com" || password != "secret")
            {
                DisplayInvalidLoginPrompt();
            }
        }
    }
