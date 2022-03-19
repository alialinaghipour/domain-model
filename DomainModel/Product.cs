namespace DomainModel
{
    public class Product
    {
        private int Id { get; set; }
        private string? Name { get; set; }
        private string? Description { get; set; }

        public Product(int id, string? name, string? description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public static Product Create(int id,string name,string description)
        {
            return new Product(id,name,description);
        }
    }
}