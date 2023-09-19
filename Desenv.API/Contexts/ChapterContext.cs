using Microsoft.EntityFrameworkCore;
using Desenv_API.Models;
using System.Security.Cryptography.X509Certificates;

namespace Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options): base(options) {}
        //vamos utilizar esse metodo para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured) {
                //cada provedor tem sua sintaxe
                optionsBuilder.UserSqlServer("Data Source = DESKTOP-F2ABGDE\\SQLEXPRESS"; initial catalog = Chapter; Integrated Security = true; TrustServerCertificate = true);

                //Data source = Caminho do Banco.
                //Initial catalog = Nome do banco de dados que voce vai usar.
                //Integrated security = Usando o login padrão ou com senha e ID. Ou User Id=usuario; Password=senha;
                //Trust server certificate = Fazendo o C# confiar na conexão.

            }
        }
        //Entidade que vamos usar:
        public DbSet<Livro> Livros { get; set; }
    }
}