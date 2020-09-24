using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNotes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : MasterDetailPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
            btnHome_Clicked(new object(), new EventArgs());
        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageHome());
            IsPresented = false;
        }

        private void btnCadastro_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageCadastrar());
            IsPresented = false;
        }

        private void btnListar_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageListar());
            IsPresented = false;
        }

        private void btnSobre_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageSobre());
            IsPresented = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageHome());
            IsPresented = false;
        }
    }
}