using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Pessoas
    {
        public Pessoas() { }
        public Pessoas(long idPessoas, string? nome, string? sobrenome, int? idade)
        {
            IdPessoas = idPessoas;
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        public long IdPessoas { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int? Idade { get; set; }
    }
}
