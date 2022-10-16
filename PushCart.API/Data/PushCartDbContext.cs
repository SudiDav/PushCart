using Microsoft.EntityFrameworkCore;
using PushCart.API.Models;

namespace PushCart.API.Data;

public class PushCartDbContext: DbContext
{
	public PushCartDbContext(DbContextOptions<PushCartDbContext> options): base(options)
	{

	}

	public DbSet<Cart> Cart { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Cart>().HasData(
                new Cart
                {
                    Id = 1,
                    ItemName = "Chilli Powder",
                    IsPickedUp = true,
                    Quantity = 1
                },
                new Cart
                {
                    Id = 2,
                    ItemName = "Garlic Powder",
                    IsPickedUp = false,
                    Quantity = 2
                },
                new Cart
                {
                    Id = 3,
                    ItemName = "Tooth Brush",
                    IsPickedUp = true,
                    Quantity = 3
                }
            );
    }
}
