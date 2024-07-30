using Microsoft.EntityFrameworkCore;
using MODEL.EMPLOYEE.SECTION;


namespace DATA.CONTEXT
{
    public class ApplicationDataContext : DbContext 
    {
       public ApplicationDataContext(DbContextOptions<ApplicationDataContext> option) : base(option) { }
       public DbSet<Employee> Employee { get;set; } 
       public DbSet<Department> Department { get;set; } 
       public DbSet<Designation> Designation { get;set; } 

    }
}
