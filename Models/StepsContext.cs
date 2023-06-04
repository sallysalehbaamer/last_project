using Microsoft.EntityFrameworkCore;
namespace my_final_project.Models
{
    public class StepsContext : DbContext
    {
        public StepsContext
        (DbContextOptions<StepsContext>options)
        :base(options)
        {
        }
       
    }
}
