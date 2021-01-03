using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeItTeste.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
