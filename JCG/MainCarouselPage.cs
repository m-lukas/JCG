using System;

using Xamarin.Forms;

namespace JCG
{
	public class MainCarouselPage : CarouselPage
	{

		public MainCarouselPage ()
		{
			this.Children.Add (new TimeTablePage());
			this.Children.Add (new EventsPage());
			this.Children.Add (new SettingsPage());

			CurrentPage = this.Children [1];

			this.BackgroundColor = Color.FromHex ("#F5F5F5");
		}

		protected override void OnCurrentPageChanged()
		{	
			base.OnCurrentPageChanged();
			System.Diagnostics.Debug.WriteLine(CurrentPage.Title);
			Title = CurrentPage.Title;
			ToolbarItems.Clear ();
			NavigationPage.SetTitleIcon (this, "logo.png");

			if (Title.Equals ("Stundenplan")) {

				this.ToolbarItems.Add (new ToolbarItem ("pageindicator", "pageindicator_left.png", () => {

					CurrentPage = this.Children [1];

				},ToolbarItemOrder.Default,2));

			} else if(Title.Equals("Events")){

				this.ToolbarItems.Add(new ToolbarItem("pageindicator", "pageindicator_middle.png", () =>{

					CurrentPage = this.Children [2];

					}));

			} else if(Title.Equals("Einstellungen")){

				this.ToolbarItems.Add(new ToolbarItem("pageindicator", "pageindicator_right.png", () =>{

					CurrentPage = this.Children [0];

					}));

			}
		
		}



	}
}
