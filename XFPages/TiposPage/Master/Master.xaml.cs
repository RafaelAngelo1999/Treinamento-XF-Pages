using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPages.TiposPage.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void MudarPage1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Navigation.Page1());
        }
        private void MudarPage2(object sender, EventArgs e)
        {
            Detail = new Navigation.Page2();
        }
        private void MudarPage3(object sender, EventArgs e)
        {
            Detail = new Conteudo();
        }
    }
}