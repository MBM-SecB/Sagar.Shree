using Microsoft.EntityFrameworkCore;
public class EMSContext: DbContext
namespace  EmployeeManagement.Data
{
    {
    public EMSContext (DbContextOptions<EMSContext> options): base(optons){

    }
    {
        public DbSet<Employee> Employees { get; set; }
        
    }

}
}

