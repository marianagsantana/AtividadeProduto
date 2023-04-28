using Repository;

namespace Models 
{
    public class Armazem
    {
        public int id { get; set; }
        public string nome { get; set; }

        public Armazem(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public static void CadastrarArmazem(Armazem armazem)
        {
            try {
                using(Context context = new Context()) {
                    context.Armazens.Add(armazem);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static List<Armazem> ListarArmazems()
        {
            try {
                using(Context context = new Context()) {
                    return context.Armazens.ToList();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static List<Armazem> ListarArmazem(int id)
        {
            try {
                using(Context context = new Context()) {
                    return context.Armazens.Where(a => a.id == id).ToList();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static void RemoverArmazem(int id)
        {
            try {
                using(Context context = new Context()) {
                    Armazem armazem = context.Armazens.Find(id);
                    context.Armazens.Remove(armazem);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }

        public static void EditarArmazem(Armazem armazem)
        {
            try {
                using(Context context = new Context()) {
                    context.Armazens.Update(armazem);
                    context.SaveChanges();
                }
            } catch (System.Exception e) {
                throw new System.Exception(e.Message);
            }
        }
        
    }
}