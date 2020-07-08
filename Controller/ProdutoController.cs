using System.Collections.Generic;
using Aula34MVCConsole.Model;
using Aula34MVCConsole.Views;

namespace Aula34MVCConsole.Controller
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoViews produtoViews = new ProdutoViews();

        public void Listar(){
            produtoViews.MostrarNoConsole(produtoModel.Ler());
        }

        public void Buscar(float _preco){
            List<Produto> busca = produtoModel.Ler().FindAll(x => x.Preco == _preco);
            produtoViews.MostrarNoConsole( busca );
        }
    }
}