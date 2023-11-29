using Project2.DTOs.PostDTOs;
using Project2.Model.Helpers;
namespace Project2.Repository.Interfaces
{
    public abstract class IPostServices
    {
        public abstract ApiResponse ViewPostForMarketer(int userId);
        public abstract ApiResponse ViewPostForCustomer(int userId);
        public abstract ApiResponse allPosts(int userId);
        public abstract ApiResponse ShowPostDetails(int postId);
        public abstract Task<ApiResponse> AddPost(int marketerId , AddPostViewModel postViewModel);
        public abstract ApiResponse DeletePost(int marketerId ,int postId);
        public abstract ApiResponse UpdatePost(int marketerId ,int postId , UpdatePostViewModel postViewModel);
        public abstract ApiResponse InteractionOnPost(int userId , int postId);
        public abstract ApiResponse RemoveInteraction(int userId ,int postId);
        public abstract ApiResponse SetPrivate(int userId, int postId);

    }
}
