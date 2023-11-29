using Project2.DTOs.OrderDTOs;
using Project2.DTOs.ProductDTOs;
using Project2.Model.Helpers;
namespace Project2.Repository.Interfaces
{
    public abstract class IOrderService
    {
        public abstract ApiResponse AddOrderToBag(int customerId, int postId ,ProductOrderViewModel productOrder);
        public abstract Task<ApiResponse> AddOrder(int customerId,int marketerId);
        public abstract ApiResponse SendOrder(int customerId , int orderId , AddOrderVM orderViewModel);
        public abstract ApiResponse SendOrder(int customerId, int userId, int orderId, AddOrderVM orderViewModel);
        public abstract ApiResponse UpdateDetails(int customerId,int productorderId);
        public abstract ApiResponse UpdateOrder(int customerId , int productorderId , ProductOrderViewModel productOrder);
        public abstract ApiResponse DeleteOrder(int customerId, int productorderId);       
        public abstract ApiResponse AccepteOrder(int marketerId , int orderId);
        public abstract ApiResponse UnAccepteOrder(int marketerId, int orderId);
        public abstract ApiResponse AccepetDeliverOrder(int deliverId , int orderId);
        public abstract ApiResponse DeliveredToDelivery(int marketerId, int orderId);
        public abstract ApiResponse ReceivedFromMarketer(int deliverId, int orderId);
        public abstract ApiResponse Delivered(int deliverId, int orderId);
        public abstract ApiResponse Received(int customerId, int orderId);
        public abstract ApiResponse ViewBag(int customerId,int marketerId);
        public abstract ApiResponse ViewCustomerOrder(int customerId);
        public abstract ApiResponse RemoveCustomerOrder(int customerId , int custOrderId);
        public abstract ApiResponse ViewMarketerSales(int marketerId);
        public abstract ApiResponse RemoveMarketerSales(int marketerId , int markSaleId);
        public abstract ApiResponse ViewDeliverOrder(int deliverId);
        public abstract ApiResponse RemoveDeliverOrder(int deliverId , int delivOrderId);

    }
}
