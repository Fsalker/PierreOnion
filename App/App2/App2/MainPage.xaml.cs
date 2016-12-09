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

            myListView.ItemsSource = new List<Recipes>
            {
                new App2.Recipes("something","https://developer.xamarin.com/guides/xamarin-forms/working-with/images/Images/Local-sml.png"),
        };

        }


    }
}
