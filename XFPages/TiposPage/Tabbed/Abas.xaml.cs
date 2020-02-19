using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPages.TiposPage.Tabbed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Abas : TabbedPage
    {
		public Abas ()
		{
			InitializeComponent ();
            Children.Add(new NavigationPage(new TiposPage.Navigation.Page1()) { Title = "Aba 1" });

            Children.Add(new NavigationPage(new TiposPage.Navigation.Page1()) { Title = "Aba 2" });

            Children.Add(new NavigationPage(new TiposPage.Navigation.Page1()) { Title = "Aba 3" });
		}
	}
}