using Repository;

namespace Models 
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }
        public static void CadastrarProduto(Produto produto)
        {
            try {
                using(Context context = new Context()) {
                    context.Produtos.Add(produto);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }
        public static List<Produto> ListarProdutos()
        {
            try {
                using(Context context = new Context()) {
                    return context.Produtos.ToList();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static List<Produto> ListarProduto(int id) {
            try {
                using(Context context = new Context()) {
                    return context.Produtos.Where(p => p.id == id).ToList();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }
        public static void RemoverProduto(int id)
        {
            try {
                using(Context context = new Context()) {
                    Produto produto = context.Produtos.Find(id);
                    context.Produtos.Remove(produto);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }
        public static void EditarProduto(Produto produto)
        {
            try {
                using(Context context = new Context()) {
                    context.Produtos.Update(produto);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
            
        }
    }
}