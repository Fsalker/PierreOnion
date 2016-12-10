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
           
            myListView.ItemTapped += async (sender1,e1)=>
            {
                int i = (myListView.ItemsSource as List<Recipes>).IndexOf(myListView.SelectedItem as Recipes);
                
                await Navigation.PushModalAsync(new DetailsPage(i));
            } ;
            


        }




    }
}
