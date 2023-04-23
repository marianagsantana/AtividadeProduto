using Models;

namespace Controllers
{
    public class Saldo 
    {
        public static void CadastrarSaldo(Models.Saldo saldo)
        {
            Models.Saldo.CadastrarSaldo(saldo);
        }

        public static List<Models.Saldo> ListarSaldos()
        {
            return Models.Saldo.ListarSaldos();
        }

        public static void RemoverSaldo(int id)
        {
            Models.Saldo.RemoverSaldo(id);
        }

        public static void EditarSaldo(Models.Saldo saldo)
        {
            Models.Saldo.EditarSaldo(saldo);
        }


    }
}