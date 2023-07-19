using System.Security.Cryptography;

namespace PizzaOrderingSystem.Pizzas
{
    public class MargheritaForm : PizzaOrderForm
    {
        public override string[] CrustTypes
        {
            get
            {
                return new string[] { "Thin Crust", "Regular Crust" };
            }
        }

        public override string[] Toppings
        {
            get
            {
                return new string[] { "Fresh Mozzarella", "Tomato Sauce", "Basil", "Olive Oil" };
            }
        }
    }
}
