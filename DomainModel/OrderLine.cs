namespace DomainModel;

public class OrderLine
{
    public OrderLine(int id, int productId)
    {
        Id = id;
        ProductId = productId;
    }

    private int Id { get; set; }
    private int ProductId { get; set; }
}