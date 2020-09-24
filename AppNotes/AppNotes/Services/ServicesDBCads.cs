using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using AppNotes.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace AppNotes.Services
{
    public class ServicesDBCads
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }
        public ServicesDBCads(string dbPath)
        {
            if (dbPath == "") dbPath = App.DbPath;
            conn = new SQLiteConnection(dbPath); //Define o banco
            conn.CreateTable<ModelCads>(); // Cria a tabela notas
        }

        public void Inserir(ModelCads cads)
        { 
            try
            {
                if (string.IsNullOrEmpty(cads.Nome))
                    throw new Exception(this.StatusMessage = string.Format("O nome não informado"));             
                if (string.IsNullOrEmpty(cads.Sexo))
                    throw new Exception(this.StatusMessage = string.Format("Sexo não informado"));
                if (string.IsNullOrEmpty(cads.NomeMae))
                    throw new Exception(this.StatusMessage = string.Format("O nome da mãe não informado"));
                if (string.IsNullOrEmpty(cads.Endereco))
                    throw new Exception(this.StatusMessage = string.Format("Endereço não informado"));
                if (string.IsNullOrEmpty(cads.Estado))
                    throw new Exception(this.StatusMessage = string.Format("Estado não informado"));
                int result = conn.Insert(cads);
                if (result != 0)
                {   
                    this.StatusMessage = string.Format("Cadastro realizado com sucesso!"); 
                        // DateTime.Now.ToString() para pegar a data e hora
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ModelCads> Listar()
        {
            List<ModelCads> lista = new List<ModelCads>();
            try
            {
                lista = conn.Table<ModelCads>().ToList();
                this.StatusMessage = "Listagem dos Cadastros";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lista;
        }

        public void AlterarCadastro(ModelCads cads)
        {
            try
            {
                if (string.IsNullOrEmpty(cads.Nome))
                    throw new Exception("Nome não informado");
                if (string.IsNullOrEmpty(cads.NomeMae))
                    throw new Exception("Nome da mãe não informado");
                if (string.IsNullOrEmpty(cads.Sexo))
                    throw new Exception("Sexo não informado");
                if (string.IsNullOrEmpty(cads.Endereco))
                    throw new Exception("Endereço não informado");
                if (string.IsNullOrEmpty(cads.Estado))
                    throw new Exception("Estado não informado");
                    conn.Update(cads);
                    StatusMessage = "Cadastro alterado com sucesso!";
            }
            catch(Exception ex)
            {
                throw new Exception(string.Format("Erro: {0}", ex.Message));
            }
        }

        public void DeletarCadastro(int id)
        {
            try
            {
                int result = conn.Table<ModelCads>().Delete(r => r.Id == id);
                StatusMessage = "Cadastro deletado com sucesso.";
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro: {0}", ex.Message));
            }
        }

        public List<ModelCads> Localizar(string Nome)
        {
            List<ModelCads> lista = new List<ModelCads>();
            try
            {
                var resp = from p in conn.Table<ModelCads>()
                           where p.Nome.ToLower().Contains(Nome.ToLower())
                           select p;
                lista = resp.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(string.Format("Error: {0}", ex.Message));
            }
            return lista;
        }


        public ModelCads PegaCads(int id)
        {
            ModelCads m = new ModelCads();
            try
            {
                m = conn.Table<ModelCads>().First(n => n.Id == id);
                StatusMessage = "Encontrei o cadastro";
            }
            catch(Exception ex)
            {
                throw new Exception(string.Format("Erro: {0}", ex.Message));
            }
            return m;
        }
    }
}
