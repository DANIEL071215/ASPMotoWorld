namespace MotoWorld.Models
{
    public class TypeMoto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegisteredOn { get; set; }
        public ICollection<Moto> Motos { get; set; }

    }

}
