namespace PizzaOrderingSystem.Pizzas
{
    internal class Order : IOrder
    {
        public void DisplayOrder(string[][] createdPizza)
        {
            Console.WriteLine("Pizza Order:");
            Console.WriteLine($"Size: {createdPizza[0][0]}");
            Console.WriteLine($"Crust: {createdPizza[1][0]}");
            Console.WriteLine("Toppings:");
            foreach (string topping in createdPizza[2])
            {
                Console.WriteLine(topping); 
            }
        }
    }
}
