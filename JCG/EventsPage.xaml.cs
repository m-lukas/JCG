using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace JCG
{
	public partial class EventsPage : ContentPage
	{

		ObservableCollection<Event> events = new ObservableCollection<Event>();

		public EventsPage ()
		{
			InitializeComponent ();
			this.BackgroundColor = Color.FromHex ("#F5F5F5");
			Title = "Events";

			EventsList.ItemsSource = events;

			events.Add (new Event{ id="1", displayName="Curiewoche", type="E", imageUrl="flag.png", dateString="1.MÄR 2016"});
			events.Add (new Event{ id="2", displayName="Schülerdisko am 30.April", type="E", imageUrl="flag.png", dateString="24.APR 2016"});
			events.Add (new Event{ id="3", displayName="Sportfest am 22.Mai 2016", type="W", imageUrl="megaphone.png", dateString="1.MAI 2016"});
			events.Add (new Event{ id="4", displayName="Schöne Sommerferien!", type="A", imageUrl="megaphone.png", dateString="20.JUN 2016"});
			events.Add (new Event{ id="5", displayName="Am 7.März gibt es keine Schulspeisung", type="W", imageUrl="caution.png", dateString="5.MÄR 2017"});
			events.Add (new Event{ id="6", displayName="Abgabe der Jahresarbeiten bis zum 20.März im Sekreteriat", type="E", imageUrl="flag.png", dateString="6.MÄR 2017"});
			events.Add (new Event{ id="7", displayName="Anderslauf 2017", type="E", imageUrl="flag.png", dateString="22.APR 2017"});
			events.Add (new Event{ id="8", displayName="Anderslauf 2017 - Anmeldung", type="A", imageUrl="megaphone.png", dateString="29.APR 2017"});
			events.Add (new Event{ id="9", displayName="Letzter Schultag - ", type="A", imageUrl="megaphone.png", dateString="1.JUN 2017"});

		}

		public async void ItemTapped(object sender, EventArgs args){

			await Navigation.PushAsync (new EventsDetailPage ());

		}

	}
}

