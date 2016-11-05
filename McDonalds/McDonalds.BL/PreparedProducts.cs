using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL
{
    class PreparedProducts
    {
        private List<Product> _products;

#region ctors
        public PreparedProducts()
        {
            _products = new List<Product>();
        }
#endregion

#region properties
        public IEnumerable<Product> Products
        {
            get {return _products; }
        }
#endregion

#region methods
        public void Add(Product product)
        {
            _products.Add(product);
        }
#endregion
    }
}
