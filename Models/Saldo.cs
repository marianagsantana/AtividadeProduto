using Repository;

namespace Models 
{
    public class Saldo
    {
        public int id { get; set; }
        public int id_produto { get; set; }
        public int id_almoxerifado { get; set; }
        public int quantidade { get; set; }
        
        public Saldo(int id, int id_produto, int id_almoxerifado, int quantidade)
        {
            this.id = id;
            this.id_produto = id_produto;
            this.id_almoxerifado = id_almoxerifado;
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