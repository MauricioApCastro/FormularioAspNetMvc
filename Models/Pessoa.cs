using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioAspNetMvc.Models
{
    public class Pessoa
    {
        public int CPF { get; set; }
        public int Nome { get; set; }
        public int DataNascimento { get; set; }
        public int Sexo { get; set; }
        public int EstadoCivil { get; set; }
        public int Estado { get; set; }
        public int Cidade { get; set; }
        public int Logradouro { get; set; }
        public int NumeroEndereco { get; set; }
        public int ComplementoEndereco { get; set; }
        public int Renda { get; set; }
    }
}