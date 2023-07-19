namespace PizzaOrderingSystem.Pizzas
{
    public class PepperoniForm : PizzaOrderForm
    {
        public override string[] CrustTypes
        {
            get
            {
                return new string[] { "Thin crust", "Regular Crust", "Deep Dish" };
            }
        }
        public override string[] Toppings
        {
            get
            {
                return new string[] { "Pepperoni", "Mozzarella Cheese", "Tomato Sauce", "Oregano" };
            }
        }
    }
}
