using Models;

namespace Controllers
{
    public class Produto 
    {
        public static void CadastrarProduto(Models.Produto produto)
        {
            Models.Produto.CadastrarProduto(produto);
        }
        public static List<Models.Produto> ListarProdutos()
        {
            return Models.Produto.ListarProdutos();
        }

        public static List<Models.Produto> ListarProduto(int id)
        {
            return Models.Produto.ListarProduto(id);
        }
        public static void RemoverProduto(int id)
        {
            Models.Produto.RemoverProduto(id);
        }
        public static void EditarProduto(Models.Produto produto)
        {
            Models.Produto.EditarProduto(produto);
        }
    }
}