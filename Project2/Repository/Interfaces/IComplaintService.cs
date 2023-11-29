using Project2.DTOs.ComplaintDTOs;
using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IComplaintService
    {
      public abstract ApiResponse AddComplaint(int userId, int postId, ComplaintViewModel complaintViewModel);
      public abstract ApiResponse ViewComplaint(int complaintId);
    }
}
