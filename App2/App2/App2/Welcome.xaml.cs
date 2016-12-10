using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            BackgroundColor = Color.FromHex("#FFDAB9");

            InitializeComponent();
        }

            private async void Button_OnClick(object sender, EventArgs e)
           {
             await Navigation.PushModalAsync(new MainPage());
            }

        }
    }

