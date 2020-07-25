using AppleStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace AppleStore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        Cart _cart;

        public ProductRepository(Cart cart)
        {
            _cart = cart;
        }

        public IEnumerable<Product> GetCart()
        {
            return _cart.CartList.ToList();
        }
    }
}
