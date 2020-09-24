using AppNotes.Models;
using AppNotes.Services; 
using AppNotes.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNotes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCadastrar : ContentPage
    {
        public PageCadastrar()
        {
            InitializeComponent();
            
        }

        public PageCadastrar(ModelCads cads)
        {
            InitializeComponent();
            btnCads.Text = "Alterar";
            btnCads.BackgroundColor = Color.Gray;
            btnExcluir.BackgroundColor = Color.Gray;
            btnVoltar.BackgroundColor = Color.Gray;
            lblTitulo.Text = "Alterando Cadastro";
            btnExcluir.IsVisible = true;
            btnVoltar.IsVisible = true;
            lblId.IsVisible = true;
            txtId.IsVisible = true;

            txtId.Text = cads.Id.ToString();
            txtNome.Text = cads.Nome;
            txtSexo.Text = cads.Sexo;
            txtNomeMae.Text = cads.NomeMae;
            txtEnd.Text = cads.Endereco;
            txtEst.Text = cads.Estado;

        }


        private void btnCads_Clicked(object sender, EventArgs e)
        {
            try
            {
                ModelCads cads = new ModelCads();
                //Pegando Dados
                cads.Nome = txtNome.Text;
                cads.Sexo = txtSexo.Text;
                cads.NomeMae = txtNomeMae.Text;
                cads.Endereco = txtEnd.Text;
                cads.Estado = txtEst.Text;
                //Pegando caminho do DB
                ServicesDBCads dbCads = new ServicesDBCads(App.DbPath);
                
                if (btnCads.Text == "Cadastrar")
                {
                    dbCads.Inserir(cads);
                    DisplayAlert("Resultado da operação: ", dbCads.StatusMessage, "OK");
                    MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
                    p.Detail = new NavigationPage(new PageHome());
                }
                else
                {
                    if (btnCads.Text == "Alterar")
                    {
                        cads.Id = Convert.ToInt32(txtId.Text);
                        dbCads.AlterarCadastro(cads);
                        DisplayAlert("Resultado da operação: ", dbCads.StatusMessage, "OK");
                        MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
                        p.Detail = new NavigationPage(new PageListar());
                    }
                }

                //Deixando campos vazios
                txtNome.Text = String.Empty;
                txtSexo.Text = String.Empty;
                txtNomeMae.Text = String.Empty;
                txtEnd.Text = String.Empty;
                txtEst.Text = String.Empty;
                //Redirecionando página
                

            }
            catch(Exception ex)
            {
                DisplayAlert("Erro ", ex.Message, "OK");
            }

;        }

        private async void btnExcluir_Clicked(object sender, EventArgs e)
        {
            bool resp = await DisplayAlert("Excluido Cadastro", "Deseja realmente excluir o cadastro atual?", "Sim", "Não");
            if(resp == true)
            {
                ServicesDBCads dbCads = new ServicesDBCads(App.DbPath);
                int id = Convert.ToInt32(txtId.Text);
                dbCads.DeletarCadastro(id);
               // DisplayAlert("Resultado da operação: ", dbCads.StatusMessage, "OK");
                MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
                p.Detail = new NavigationPage(new PageListar());
            }
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new PageListar());
        }
    }
}