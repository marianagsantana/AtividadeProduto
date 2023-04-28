using Microsoft.EntityFrameworkCore;


namespace Repository {
    public class Context : DbContext {
        public DbSet<Models.Produto> Produtos { get; set; }
        public DbSet<Models.Armazem> Armazens { get; set; }
        public DbSet<Models.Saldo> Saldos { get; set; }
        public string connection = "Server=localhost;User Id=root;Database=Atividade";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(connection, ServerVersion.AutoDetect(connection));
    }
}