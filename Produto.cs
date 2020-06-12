using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas
{
    public class Produto
    {
        public string Nome { get; set; }
        public string TipoMaterial { get; set; }
        public string Tamanho { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int CodigoMaterial { get; set; }

        public void CadastrarProduto() { }
        public void AtualizarProduto() { }
        public void DeletarProduto() { }
        public int PegarModeloProduto() { return 10; }
        public int PegarCorPruduto() { return 20; }
    }
}
