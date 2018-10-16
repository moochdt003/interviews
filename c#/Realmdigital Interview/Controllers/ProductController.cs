using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json;
using Realmdigital_Interview.Models;
using Realmdigital_Interview.Services;

namespace Realmdigital_Interview.Controllers
{
    public class ProductController
    {
        private readonly ProductsService _productsService;

        public ProductController(ProductsService productsService)
        {
            _productsService = productsService;
        }

        [Route("product")]
        public Product GetProductById(string productId)
        {
            return _productsService.GetProductById(productId);
        }

        [Route("product/search")]
        public List<Product> GetProductsByName(string productName)
        {
            return _productsService.GetProductsByName(productName);
        }
    }

}