using Segundatentativa.Shared;
using Microsoft.EntityFrameworkCore;

namespace Segundatentativa.Server
{
     public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            

        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<PedidoProduto> PedidosProdutos { get; set; }

        public DbSet<Cupom> Cupons { get; set; }


        protected override void OnModelCreating(ModelBuilder model)
        {

            
            model.Entity<Cupom>()
               .HasKey(x => x.Cupom_Id);
            model.Entity<Pedido>()
                .HasKey(x => x.Pedido_Id);
            model.Entity<Usuario>()
                .HasKey(x => x.Usuario_Id);
    ///////////////////////////////////////////////////////   
            model.Entity<PedidoProduto>()
                .HasKey(x => new { x.Pedido_Id, x.Produto_Id });         
            model.Entity<Produto>()
                .HasKey(x => x.Produto_Id);
            model.Entity<PedidoProduto>()
                .HasOne(x => x.Pedido)
                .WithMany(y => y.PedidoProduto)
                .HasForeignKey(z => z.Pedido_Id);
            model.Entity<PedidoProduto>()
                .HasOne(x => x.Produto)
                .WithMany(y =>y.PedidoProduto)
                .HasForeignKey(z => z.Produto_Id);
    ///////////////////////////////////////////////////////
            model.Entity<Usuario>()
                .HasMany(x => x.Pedidos)
                .WithOne(y => y.Usuario);
            model.Entity<Pedido>()
               .HasOne(x => x.Usuario)
      
                .WithMany(y => y.Pedidos);    
    ///////////////////////////////////////////////////////
   
            model.Entity<Pedido>()     
            .HasOne(x => x.Cupom)    
            .WithOne(y => y.Pedido)
            .HasForeignKey<Cupom>(x => x.Cupom_Id);
    
            
        }
       
    }

}