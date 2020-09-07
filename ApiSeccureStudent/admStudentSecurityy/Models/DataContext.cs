namespace admStudentSecurityy.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admStudentSecurityy.Models.Student> Students { get; set; }
    }
}