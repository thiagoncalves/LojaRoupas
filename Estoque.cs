using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas
{
    public class Estoque
    {
        public int CodigoMaterial { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int EstoqueMinimo { get; set; }

        public void CadastrarMaterial() { }
        public void AtualizarMaterial() { }
        public void DeletarMaterial() { }
        public void PrecoTotal() { }
        public int SaldoMinimoEstoque() { return 10; }
    }
}
