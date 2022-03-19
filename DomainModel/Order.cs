namespace DomainModel;

public class Order
{
    public ICollection<OrderLine> OrderLines { get; set; }

    public void AddProduct(int productId, int count)
    {
            
    }

    public void Remove(int productId)
    {
            
    }
}