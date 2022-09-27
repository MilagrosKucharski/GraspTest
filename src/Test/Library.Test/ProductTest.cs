using NUnit.Framework;
using Full_GRASP_And_SOLID;
using Full_GRASP_And_SOLID.Library

namespace Library.Test
{
    public class ProductTest
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void GetProductionCostTest() // Cambiá el nombre para indicar qué estás probando
        {
            const string expected = "290000";
            Recipe recipe = new Recipe();
            string productfinaltest= Product Recipe.FinalProduct.GetProduct("Café con leche");recipe.FinalProduct = GetProduct("Café con leche");

            Assert.AreEqual(productfinaltest , expected);
        }
    }
}