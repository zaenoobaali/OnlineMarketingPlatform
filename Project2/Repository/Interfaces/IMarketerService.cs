using Project2.DTOs.MarketerDTOs;
using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IMarketerService
    {
        //public abstract ApiResponse GetAllMarketers(ComplexFilter Filter);
        public abstract ApiResponse AddPoint(int userId , AddPointViewModel points);
        public abstract ApiResponse AllMarketers();
    }
}
