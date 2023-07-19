namespace PizzaOrderingSystem.Pizzas
{
    public class VegetarianForm : PizzaOrderForm
    {
        public override string[] CrustTypes
        {
            get
            {
                return new string[] { "Thin Crust", "Regular" };
            }
        }

        public override string[] Toppings
        {
            get
            {
                return new string[] { "Bell Peppers", "Black Olives", "Tomato Sauce", "Mozzarella Cheese", "Tofu" };
            }
        }
    }
}
