using System;
using System.Collections.Generic;
using SpeakersX.Model;
using SpeakersX.ViewModel;
using Xamarin.Forms;

namespace SpeakersX.View
{
	public partial class SpeakersPage : ContentPage
	{
		SpeakersViewModel vm;
		public SpeakersPage()
		{
			InitializeComponent();
			vm = new SpeakersViewModel();
			BindingContext = vm;
			ListViewSpeakers.ItemSelected += ListViewSpeakers_ItemSelected;

		}

		private async void ListViewSpeakers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var speaker = e.SelectedItem as Speaker;
			if (speaker == null)
				return;
            await this.Navigation.PushModalAsync(new DetailsPage(speaker));
			//await Navigation.PushAsync(new DetailsPage());
			ListViewSpeakers.SelectedItem = null;
		}
	}
}
