using AppleStore.Models;
using System.Collections.Generic;

namespace AppleStore.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetCart();
    }
}
