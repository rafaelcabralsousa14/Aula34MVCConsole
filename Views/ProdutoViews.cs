using System.Collections.Generic;
using Aula34MVCConsole.Model;

namespace Aula34MVCConsole.Views
{
    public class ProdutoViews
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach (Produto item in lista){
                System.Console.WriteLine($"R${item.Preco} \n Nome:{item.Nome}"); 
            }
              
        }
    }
}