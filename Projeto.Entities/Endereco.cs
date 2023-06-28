using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Endereco
    {
        public int IdEndereço { get; set; }
        public string Lougradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        #region Relacionamentos
        public Funcionario Funcionario { get; set; }

        #endregion


    }
}
