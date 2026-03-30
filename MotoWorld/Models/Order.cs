namespace MotoWorld.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Clients { get; set; }
        public int MotoId { get; set; }
        public  Moto Motos { get; set; }
        public int Quantity { get; set; }
        public DateTime RegisteredOn { get; set; }
    }
}
