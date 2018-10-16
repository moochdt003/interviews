using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Realmdigital_Interview.Services;

namespace Realmdigital_Interview.Tests.Services
{
    [TestClass]
    public class ProductsServiceTest
    {
        private readonly ProductsService _productsService;

        public ProductsServiceTest(ProductsService productsService)
        {
            _productsService = productsService;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
