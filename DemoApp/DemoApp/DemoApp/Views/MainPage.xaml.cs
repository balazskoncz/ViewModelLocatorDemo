using DemoApp.Views;
using System;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void PlanetsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PlanetPage());
        }

        private void PersonButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PersonPage());
        }

        private void StarShipButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StarShipPage());
        }
    }
}
