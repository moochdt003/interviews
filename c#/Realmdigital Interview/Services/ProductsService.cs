using System.Collections.Generic;
using System.Linq;
using Realmdigital_Interview.Models;
using Realmdigital_Interview.Repositories;

namespace Realmdigital_Interview.Services
{
    public class ProductsService
    {
        private readonly Repository _repository;

        public ProductsService(Repository repository)
        {
            _repository = repository;
        }

        public Product GetProductById(string productId)
        {
            var productsResponseObject = _repository.GetProductById(productId).ToList();

            return productsResponseObject.Select(product => new Product
            {
                BarCode = product.BarCode,
                ItemName = product.BarCode,
                PriceRecords = product.PriceRecords.Select(price => new Price
                {
                    CurrencyCode = price.CurrencyCode,
                    SellingPrice = price.SellingPrice
                })
            }).ToList().FirstOrDefault();
        }

        public List<Product> GetProductsByName(string productName)
        {
            var productsResponseObject = _repository.GetProductsByName(productName).ToList();

            return productsResponseObject.Select(product => new Product
            {
                BarCode = product.BarCode,
                ItemName = product.BarCode,
                PriceRecords = product.PriceRecords.Where(x => x.CurrencyCode == "ZAR").Select(price => new Price
                {
                    CurrencyCode = price.CurrencyCode,
                    SellingPrice = price.SellingPrice
                })
            }).ToList();
        }
    }
}