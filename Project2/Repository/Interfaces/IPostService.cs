using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IPostService
    {
       public abstract ApiResponse GetAllPosts();
       public abstract ApiResponse GetAllFriendsPosts(int UserId, ComplexFilter Filter);
       public abstract ApiResponse GetAllFollowingPagesPosts(int UserId, ComplexFilter Filter);
       public abstract ApiResponse GetFriendPostByFriendId(int FriendId, ComplexFilter Filter);
    }
}
