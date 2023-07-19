namespace PizzaOrderingSystem.Pizzas
{
    public class HawaiianForm : PizzaOrderForm
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
                return new string[] { "Ham", "Pineapple", "Tomato Sauce", "Mozzarella Cheese", "Bacon" };
            }
        }
    }
}
