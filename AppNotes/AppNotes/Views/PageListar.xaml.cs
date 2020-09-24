using AppNotes.Models;
using AppNotes.Services;
using System;
using SQLite;
using AppNotes.Views;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNotes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListar : ContentPage
    {
        public PageListar()
        {
            InitializeComponent();
            AtualizaCadastro();
        }

        public void AtualizaCadastro()
        {
            ServicesDBCads dbCads = new ServicesDBCads(App.DbPath);
            ListandoCads.ItemsSource = dbCads.Listar();

        }


        private void ListandoCads_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ModelCads cads = (ModelCads)ListandoCads.SelectedItem;
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new PageCadastrar(cads));
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Localizar Cadastro", "Informe o nome a ser procurado");
                
               if(result != null)
            {
                ServicesDBCads dbCads = new ServicesDBCads(App.DbPath);
                ListandoCads.ItemsSource = dbCads.Localizar(result);
            }
            else
            {
                MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
                p.Detail = new NavigationPage(new PageListar());
            }

        }
    }
}