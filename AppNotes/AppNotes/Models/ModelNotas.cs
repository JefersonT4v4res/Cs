using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppNotes.Models
{
    [Table("Cadastro")]
    public class ModelCads
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public String Nome { get; set; }
        [NotNull]
        public String Sexo { get; set; }
        [NotNull]
        public String NomeMae { get; set; }
        [NotNull]
        public String Estado { get; set; }
        [NotNull]
        public String Endereco { get; set; }


        public ModelCads()
        {
            this.Id = 0;
            this.Nome = "";
            this.Sexo = "";
            this.NomeMae = "";
            this.Endereco = "";
            this.Estado = "";
        }

    }
}
