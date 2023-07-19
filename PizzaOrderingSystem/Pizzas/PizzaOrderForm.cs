namespace PizzaOrderingSystem.Pizzas
{
    public abstract class PizzaOrderForm
    {
        public abstract string[] CrustTypes { get; }
        public string[] Size = new string[] { "Small", "Medium", "Large", "Extra Large" };
        public abstract string[] Toppings { get; }
    }
}
