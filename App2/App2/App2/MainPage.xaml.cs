using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#FFDAB9");


        }



        private async void On_Appearing(object sender, EventArgs e)
        {

            Request request = new Request();
            myListView.ItemsSource = await request.GetRecipes();



        }
        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            await Navigation.PushModalAsync(new DetailsPage());
        }
    }
}
