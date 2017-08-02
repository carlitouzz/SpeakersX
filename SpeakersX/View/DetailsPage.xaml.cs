using System;
using System.Collections.Generic;
using SpeakersX.Model;
using Xamarin.Forms;

namespace SpeakersX.View
{
    public partial class DetailsPage : ContentPage
    {
        void goBack(object sender, System.EventArgs e)
        {
             this.Navigation.PushModalAsync(new SpeakersPage());
        }
        Speaker item2;
        public DetailsPage(Speaker item)
        {
            item2 = item;
            InitializeComponent();
            BindingContext = item;
           ButtonWebsite.Clicked += ButtonWebsite_Clicked;
        }
		private void ButtonWebsite_Clicked(object sender, EventArgs e)
		{
			if (item2.Website.StartsWith("http"))
                Device.OpenUri(new Uri(item2.Website));
		}
		
    }
}
