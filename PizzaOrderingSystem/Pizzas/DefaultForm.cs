using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem.Pizzas
{
    public class DefaultForm : PizzaOrderForm
    {
        public override string[] CrustTypes => throw new NotImplementedException();

        public override string[] Toppings => throw new NotImplementedException();
    }
}
