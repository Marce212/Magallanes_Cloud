using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcProduct.Models
{
    public class ProductTypeViewModel
    {
        public List<Product> Products;
        public SelectList Type;
        public string ProductType { get; set; }
        public string SearchString { get; set; }
    }
}