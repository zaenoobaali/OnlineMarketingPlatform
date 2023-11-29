using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IProductService
    {
      public abstract ApiResponse GetAllProducts(ComplexFilter Filter);
      public abstract ApiResponse AllProducts(int userId);
      public abstract ApiResponse PopularProduct();
    }
}
