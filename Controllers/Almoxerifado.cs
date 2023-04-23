using Models;

namespace Controllers
{
    public class Almoxerifado 
    {
        public static void CadastrarAlmoxerifado(Models.Almoxerifado almoxerifado)
        {
            Models.Almoxerifado.CadastrarAlmoxerifado(almoxerifado);
        }

        public static List<Models.Almoxerifado> ListarAlmoxerifados()
        {
            return Models.Almoxerifado.ListarAlmoxerifados();
        }

        public static List<Models.Almoxerifado> ListarAlmoxerifado(int id)
        {
            return Models.Almoxerifado.ListarAlmoxerifado(id);
        }

        public static void RemoverAlmoxerifado(int id)
        {
            Models.Almoxerifado.RemoverAlmoxerifado(id);
        }

        public static void EditarAlmoxerifado(Models.Almoxerifado almoxerifado)
        {
            Models.Almoxerifado.EditarAlmoxerifado(almoxerifado);
        }
    }
}