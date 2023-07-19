using Moq;
using PizzaOrderingSystem.Data;
using PizzaOrderingSystem.Factory;
using PizzaOrderingSystem.Form;
using PizzaOrderingSystem.PizzaFacade;
using PizzaOrderingSystem.Pizzas;
using PizzaOrderingSystem.Prompts;
using PizzaOrderingSystem.User;

namespace PizzaTests
{
    [TestClass]
    public class PizzaTests
    {
        [TestMethod]
        public void CreatePizzaOrderForm_Test()
        {
            // Arrange
            PepperoniForm pf = new PepperoniForm();
            Mock<IUserInput> userInputMock = new Mock<IUserInput>();
            userInputMock.SetupSequence(u => u.ReadUserInput(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(1)
                .Returns(2);

            userInputMock.Setup(u => u.ReadUserInputMultiple(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(new List<int> { 1, 3 });

            PizzaForm pizzaForm = new PizzaForm(userInputMock.Object);

            // Act
            string[][] result = pizzaForm.CreatePizzaOrderForm(pf);

            // Assert
            Assert.AreEqual("Small", result[0][0]);
            Assert.AreEqual("Regular Crust", result[1][0]);
            Assert.AreEqual("Pepperoni", result[2][0]);
            Assert.AreEqual("Tomato Sauce", result[2][1]);
        }

        [TestMethod]
        public void CreatingPizzaOrder_Test()
        {
            //arrange
            Mock<IPrompts> mockPrompts = new Mock<IPrompts>();
            Mock<IUserInput> mockUserInput = new Mock<IUserInput>();
            Mock<IPizzaForm> mockPizzaForm = new Mock<IPizzaForm>();
            Mock<IPizzaFactory> mockPizzaFactory = new Mock<IPizzaFactory>();
            Mock<IPizza> mockPizza = new Mock<IPizza>();
            Mock<IOrder> mockOrder = new Mock<IOrder>();

            PizzaFacade pf = new PizzaFacade(mockPrompts.Object,
                mockUserInput.Object,
                mockPizzaForm.Object,
                mockPizzaFactory.Object,
                mockPizza.Object,
                mockOrder.Object);

            //act
            mockPrompts.Setup(x => x.PizzaSelectionPrompt()).Verifiable();
            mockPrompts.Setup(x => x.ListOfPizzas()).Verifiable();
            mockPizza.Setup(x => x.ReturnMinMax(It.IsAny<List<Pizza>>())).Returns(new int[] { 1, 5 });
            mockUserInput.Setup(x => x.ReadUserInput(It.IsAny<int>(), It.IsAny<int>())).Returns(1);
            mockPizzaFactory.Setup(x => x.CreatePizzaOrderForm(1)).Returns(new PepperoniForm());
            mockPizzaForm.Setup(x => x.CreatePizzaOrderForm(new PepperoniForm()))
                .Returns(new string[3][] { new string[] { "a" }, new string[] { "b" }, new string[] { "1", "2", "3" } });
            mockOrder.Setup(x =>
                x.DisplayOrder(new string[3][] { new string[] { "" }, new string[] { "" }, new string[] { "", "", "" } }))
                .Verifiable();
            mockPizzaForm.Setup(x => x.CreatePizzaOrderForm(It.IsAny<PizzaOrderForm>()))
                .Returns(new string[3][] { new string[] { "a" }, new string[] { "b" }, new string[] { "c" } });

            pf.CreatingPizzaOrder();

            //assert
            mockPrompts.Verify(x => x.PizzaSelectionPrompt(), Times.Once);
            mockPrompts.Verify(x => x.ListOfPizzas(), Times.Once);
            mockPizza.Verify(x => x.ReturnMinMax(It.IsAny<List<Pizza>>()), Times.Once);
            mockUserInput.Verify(x => x.ReadUserInput(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
            mockOrder.Verify(x => x.DisplayOrder(It.IsAny<string[][]>()));
        }
    }
}