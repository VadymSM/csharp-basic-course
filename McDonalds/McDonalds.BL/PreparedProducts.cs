using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.BL.Products;

namespace McDonalds.BL
{
    class PreparedProducts
    {
        private List<Product> _products;

        public delegate void ProductAddedHandler(Product product);

        public event ProductAddedHandler ProductAdded;

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

            if (ProductAdded != null)
            {
                ProductAdded(product);
            }
        }

        public void RemoveByType(IEnumerable<Product> product)
        {
            // [T] Remove from the collection of products passed products by type,
            //
            //  Note: if any product can't be find. you should generate a custom Exception
            //  (you dshould create custom Exception with name ProductNotFoundException )

            // [T] Cover by unit tests
            
        }

        public void RemoveByType(Product product, int count = 1)
        {
            // [T] Remove from the collection passed product
            //
            //  Note: if any product can't be find. you should generate a custom Exception
            //  (you dshould create custom Exception with name ProductNotFoundException )

            // [T] Cover by unit tests
            
            
        }

#endregion
    }
}
