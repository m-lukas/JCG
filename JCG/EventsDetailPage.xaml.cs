using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JCG
{
	public partial class EventsDetailPage : ContentPage
	{
		public EventsDetailPage ()
		{
			InitializeComponent ();
			BackgroundColor = Color.Aqua;
			NavigationPage.SetHasNavigationBar (this, true);
			NavigationPage.SetHasBackButton (this, false);
		}
	}
}

