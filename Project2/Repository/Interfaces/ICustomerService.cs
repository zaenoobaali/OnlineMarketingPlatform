using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class ICustomerService
    {
       public abstract ApiResponse ViewAllCustomers();
       public abstract ApiResponse AcceptToBeAgent(int custmerId , int marketerId);
       public abstract ApiResponse UnAcceptToBeAgent(int custmerId, int marketerId);
       public abstract ApiResponse CustomersFollowMarketers(int markterId);
    }
}
