using Microsoft.EntityFrameworkCore;

namespace PushCart.API.Data;

public class PushCartDbContext: DbContext
{
	public PushCartDbContext(DbContextOptions<PushCartDbContext> options): base(options)
	{

	}

	public DbSet<Cart> Cart { get; set; }
}
