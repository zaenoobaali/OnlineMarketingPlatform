using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IDeliverService
    {
       public abstract ApiResponse AllDeliver();
       public abstract ApiResponse ShowDeliverName();
       public abstract ApiResponse AcceptToContract(int deliverId, int marketerId);
       public abstract ApiResponse UnAcceptToContract(int deliverId, int marketerId);
    }
}
