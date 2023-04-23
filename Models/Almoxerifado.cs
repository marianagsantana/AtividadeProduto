using Repository;

namespace Models 
{
    public class Almoxerifado
    {
        public int id { get; set; }
        public string nome { get; set; }

        public Almoxerifado(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public static void CadastrarAlmoxerifado(Almoxerifado almoxerifado)
        {
            try {
                using(Context context = new Context()) {
                    context.Almoxerifados.Add(almoxerifado);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static List<Almoxerifado> ListarAlmoxerifados()
        {
            try {
                using(Context context = new Context()) {
                    return context.Almoxerifados.ToList();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static List<Almoxerifado> ListarAlmoxerifado(int id)
        {
            try {
                using(Context context = new Context()) {
                    return context.Almoxerifados.Where(a => a.id == id).ToList();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static void RemoverAlmoxerifado(int id)
        {
            try {
                using(Context context = new Context()) {
                    Almoxerifado almoxerifado = context.Almoxerifados.Find(id);
                    context.Almoxerifados.Remove(almoxerifado);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static void EditarAlmoxerifado(Almoxerifado almoxerifado)
        {
            try {
                using(Context context = new Context()) {
                    context.Almoxerifados.Update(almoxerifado);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }
        
    }
}