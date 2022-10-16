namespace PushCart.API.Models;

public class Cart
{
    public int Id { get; set; }
    public string? ItemName { get; set; }
    public double Quantity { get; set; }
    public bool IsPickedUp { get; set; }
}
