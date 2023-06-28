﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Funcionario
    {
       public int IdFuncionario { get; set; }
       public string Nome { get; set; }
       public DateTime DataAdmissao { get; set; }
       public decimal Salario { get; set; }

        #region Relacionamentos

        public Endereco Endereco { get; set; }
        #endregion

    }
}
