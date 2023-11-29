using Project2.DTOs.PopularizationDTOs;
using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IPopularizationService
    {
      public abstract ApiResponse CreatePopularization(int userId , AddPopularizationViewModel addPopularization);
      public abstract ApiResponse PopularizationDetails(int PopularizationId);
      public abstract ApiResponse GetPopularization(int userId);
    }
}
