namespace Models 
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public static List<Produto> listaProdutos = new List<Produto>();
        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }
        public static void CadastrarProduto(Produto produto)
        {
            listaProdutos.Add(produto);
        }
        public static List<Produto> ListarProdutos()
        {
            return listaProdutos;
        }
        public static void RemoverProduto(int id)
        {
            listaProdutos.RemoveAll(produto => produto.id == id);
        }
        public static void EditarProduto(Produto produto)
        {
            List<Produto> produtos = PesquisarProdutoPorId(produto.id);
            if (produtos.Count > 0)
            {
                produtos[0].nome = produto.nome;
                produtos[0].preco = produto.preco;
            }
            
        }
        public static List<Produto> PesquisarProdutoPorId(int id)
        {
            return listaProdutos.Where(produto => produto.id == id).ToList();
        }
    }
}