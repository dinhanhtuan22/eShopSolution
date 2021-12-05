using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
    public interface ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
