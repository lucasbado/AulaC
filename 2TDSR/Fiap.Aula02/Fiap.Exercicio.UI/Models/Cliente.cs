using Fiap.Exercicio.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.UI.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int Cpf { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}