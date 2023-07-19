namespace PizzaOrderingSystem.Data
{
    public class Pizza : IPizza
    {
        public int Number;
        public string Name;
        private static List<Pizza> pizzaList = new List<Pizza>
        {
            new Pizza(){ Number = 1, Name = "Pepperoni" },
            new Pizza(){ Number = 2, Name = "Margherita" },
            new Pizza(){ Number = 3, Name = "Vegetarian" },
            new Pizza(){ Number = 4, Name = "Hawaiian" }
        };

        public int[] ReturnMinMax(List<Pizza> Pizzas)
        {
            return new int[] { 1, Pizzas.Count };
        }

        public List<Pizza> GetPizzaList()
        {
            return pizzaList;
        }
    }
}
