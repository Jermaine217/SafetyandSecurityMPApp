using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafetyandSecurityMPApp.PanicButton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmergencyButton : ContentPage
    {
        int clickTotal;
        public EmergencyButton()
        {
            InitializeComponent();
        }


        void OnImageButtonClicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = $"{clickTotal} ImageButton click{(clickTotal == 1 ? "" : "s")}";
        }


    }


}