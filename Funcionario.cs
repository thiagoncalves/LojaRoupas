using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Funcao { get; set; }
        public DateTime DataAdmissao { get; set; }

        public void CadastrarFuncionario() { }
        public void DeletarFuncionario() { }
        public void DemitirFuncionario() { }
        public void AtualizarFuncionario() { }
        public void TransferirFuncionario() { }

        
    }

}
