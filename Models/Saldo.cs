using Repository;

namespace Models 
{
    public class Saldo
    {
        public int id { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId{ get; set; }
        public Armazem Armazem { get; set; }
        public int ArmazemId { get; set; }
        public int quantidade { get; set; }
        
        public Saldo(int id, int produtoId, int armazemId, int quantidade)
        {
            this.id = id;
            this.ProdutoId = produtoId;
            this.ArmazemId = armazemId;
            this.quantidade = quantidade;
        }

        public static void CadastrarSaldo(Saldo saldo)
        {
            try {
                using(Context context = new Context()) {
                    context.Saldos.Add(saldo);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static List<Saldo> ListarSaldos()
        {
            try {
                using(Context context = new Context()) {
                    return context.Saldos.ToList();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static void RemoverSaldo(int id)
        {
            try {
                using(Context context = new Context()) {
                    Saldo saldo = context.Saldos.Find(id);
                    context.Saldos.Remove(saldo);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static void EditarSaldo(Saldo saldo)
        {
            try {
                using(Context context = new Context()) {
                    context.Saldos.Update(saldo);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
            
        }


        
    }
}