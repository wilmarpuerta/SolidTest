
using Microsoft.EntityFrameworkCore;
using SolidTest.Models;

namespace SolidTest.Data;

public class BaseContext : DbContext
{
     public BaseContext(DbContextOptions<BaseContext> options): base(options){
            
        }
        public DbSet<Company> Companies { get; set; }
        
}