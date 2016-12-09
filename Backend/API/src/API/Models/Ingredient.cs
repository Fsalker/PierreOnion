namespace API.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(int id, string name, int quantity, string unit)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
