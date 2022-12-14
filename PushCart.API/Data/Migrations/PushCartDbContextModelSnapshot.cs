// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PushCart.API.Data;

#nullable disable

namespace PushCart.API.Data.Migrations
{
    [DbContext(typeof(PushCartDbContext))]
    partial class PushCartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("PushCart.API.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPickedUp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsPickedUp = true,
                            ItemName = "Chilli Powder",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = 2,
                            IsPickedUp = false,
                            ItemName = "Garlic Powder",
                            Quantity = 2.0
                        },
                        new
                        {
                            Id = 3,
                            IsPickedUp = true,
                            ItemName = "Tooth Brush",
                            Quantity = 3.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
