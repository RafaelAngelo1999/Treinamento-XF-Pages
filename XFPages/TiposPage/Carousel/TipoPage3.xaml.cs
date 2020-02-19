using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPages.TiposPage.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPage3 : ContentPage
	{
		public TipoPage3 ()
		{
			InitializeComponent ();
		}

        private void MudarPage(object sender, EventArgs args)
        {

            //App.Current.MainPage = new NavigationPage(new Navigation.Page1()) {BarBackgroundColor = Color.CadetBlue, BarTextColor = Color.White};
            App.Current.MainPage = new Tabbed.Abas();
        }   
    }
}