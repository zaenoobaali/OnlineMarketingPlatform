using Project2.DTOs.NotifyDTOs;
using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class ISearchService
    {
       public abstract ApiResponse ViewSearchList(int userId);
       public abstract ApiResponse AddSearch(int userId, AddSearchViewModel addSearch);
       public abstract ApiResponse DeleteSearch(int userId, int searchId);
    }
}
