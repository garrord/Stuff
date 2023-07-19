using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaOrderingSystem.Data;
using PizzaOrderingSystem.Factory;
using PizzaOrderingSystem.Form;
using PizzaOrderingSystem.PizzaFacade;
using PizzaOrderingSystem.Pizzas;
using PizzaOrderingSystem.Prompts;
using PizzaOrderingSystem.User;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddTransient<IPrompts, Prompts>();
        services.AddTransient<IUserInput, UserInput>();
        services.AddTransient<IPizzaForm, PizzaForm>();
        services.AddTransient<IPizzaFactory, PizzaFactory>();
        services.AddTransient<IPizza, Pizza>();
        services.AddTransient<IOrder, Order>();
    }).Build();
PizzaFacade pf = ActivatorUtilities.CreateInstance<PizzaFacade>(host.Services);
pf.CreatingPizzaOrder();
