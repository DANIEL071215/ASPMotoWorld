namespace MotoWorld.Models
{
    public class Moto
    {
        public int Id { get; set; }
        public string CatalogNum { get; set; }
        public string Name { get; set; }
        public int TypeMotoId { get; set; }
        public TypeMoto TypeMotos { get; set; }
        public int HorsePower { get; set; }
        public string Description { get; set; }
        public string Accessories { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime RegisteredOn { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
