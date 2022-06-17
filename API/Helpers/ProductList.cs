using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class ProductList<T> where T : class
    {
        public ProductList(IReadOnlyList<T> data)
        {
            Data = data;
        }

        public IReadOnlyList<T> Data { get; set; }
    }
}