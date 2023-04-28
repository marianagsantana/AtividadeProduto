using Models;

namespace Controllers
{
    public class Armazem 
    {
        public static void CadastrarArmazem(Models.Armazem armazem)
        {
            Models.Armazem.CadastrarArmazem(armazem);
        }

        public static List<Models.Armazem> ListarArmazems()
        {
            return Models.Armazem.ListarArmazems();
        }

        public static List<Models.Armazem> ListarArmazem(int id)
        {
            return Models.Armazem.ListarArmazem(id);
        }

        public static void RemoverArmazem(int id)
        {
            Models.Armazem.RemoverArmazem(id);
        }

        public static void EditarArmazem(Models.Armazem armazem)
        {
            Models.Armazem.EditarArmazem(armazem);
        }
    }
}