using AutoMapper;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using Project2.DTOs.PostDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.Reflection;

namespace Project2.Repository.Services
{
    public class PostService : IPostService
    {
        public AppDbContext _DbContext { get; set; }
        private IMapper _Mapper;

        public PostService(AppDbContext DbContext, IMapper Mapper)
        {
            _DbContext = DbContext;
            _Mapper = Mapper;
        }
        public override ApiResponse GetAllPosts()
        {
            var Post = from post in _DbContext.Posts
                        select new
                        {
                            post.Id,
                            post.Description,
                            post.counter,
                            post.productId,
                            post.marketerId
                        };
            var Posts = Post.ToList();
            var Count = Posts.Count();

            return new ApiResponse(Posts, "Succeed", Count);
        }
        public override ApiResponse GetAllFriendsPosts(int UserId, ComplexFilter Filter)
        {
            List<int> CustomersIds = _DbContext.Friends
                .Where(x => x.userId == UserId)
                .Select(x => x.friendId).ToList();

            List<PostViewModel> Posts = _Mapper.Map<List<PostViewModel>>(_DbContext.CustPosts
                .Include(x => x.Post)
                .Where(x => CustomersIds.Contains(x.CustomerId))
                .Select(x => x.Post)
                .Include(x => x.Product)
                .Where(x => (!string.IsNullOrEmpty(Filter.SearchQuery) ?
                    x.Product.Name.ToLower().StartsWith(Filter.SearchQuery) : true)).ToList());

            int Count = Posts.Count();

            PropertyInfo? SortByCounter = typeof(PostViewModel).GetProperty("counter");
            Posts = Posts.OrderBy(x => SortByCounter.GetValue(x)).ToList();

            if (!string.IsNullOrEmpty(Filter.Sort))
            {
                PropertyInfo? SortProperty = typeof(PostViewModel).GetProperty(Filter.Sort);

                if (SortProperty != null && Filter.Order == "asc")
                    Posts = Posts.OrderBy(x => SortProperty.GetValue(x)).ToList();

                else if (SortProperty != null && Filter.Order == "desc")
                    Posts = Posts.OrderByDescending(x => SortProperty.GetValue(x)).ToList();

                Posts = Posts.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();
            }
            else
                Posts = Posts.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();

            return new ApiResponse(Posts, "Succeed", Count);
        }
        public override ApiResponse GetAllFollowingPagesPosts(int UserId, ComplexFilter Filter)
        {
            List<int> CustomersIds = _DbContext.FollowingPages
                .Where(x => x.userId == UserId)
                .Select(x => x.pageId).ToList();

            List<PostViewModel> Posts = _Mapper.Map<List<PostViewModel>>(_DbContext.Posts
                .Where(x => CustomersIds.Contains(x.marketerId))
                .Include(x => x.Product)
                .Where(x => (!string.IsNullOrEmpty(Filter.SearchQuery) ?
                    x.Product.Name.ToLower().StartsWith(Filter.SearchQuery) : true)).ToList());

            int Count = Posts.Count();

            PropertyInfo? SortByCounter = typeof(PostViewModel).GetProperty("counter");
            Posts = Posts.OrderBy(x => SortByCounter.GetValue(x)).ToList();

            if (!string.IsNullOrEmpty(Filter.Sort))
            {
                PropertyInfo? SortProperty = typeof(PostViewModel).GetProperty(Filter.Sort);

                if (SortProperty != null && Filter.Order == "asc")
                    Posts = Posts.OrderBy(x => SortProperty.GetValue(x)).ToList();

                else if (SortProperty != null && Filter.Order == "desc")
                    Posts = Posts.OrderByDescending(x => SortProperty.GetValue(x)).ToList();

                Posts = Posts.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();
            }
            else
                Posts = Posts.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();

            return new ApiResponse(Posts, "Succeed", Count);
        }
        public override ApiResponse GetFriendPostByFriendId(int FriendId, ComplexFilter Filter)
        {
            Friend? CustomersEntity = _DbContext.Friends
                .FirstOrDefault(x => x.friendId == FriendId);

            if (CustomersEntity == null)
                return new ApiResponse(false, $"No Customer Found With This Id: ({FriendId})");

            List<PostViewModel> Posts = _Mapper.Map<List<PostViewModel>>(_DbContext.CustPosts
                .Include(x => x.Post)
                .Where(x => x.CustomerId == CustomersEntity.Id)
                .Select(x => x.Post)
                .Include(x => x.Product)
                .Where(x => (!string.IsNullOrEmpty(Filter.SearchQuery) ?
                    x.Product.Name.ToLower().StartsWith(Filter.SearchQuery) : true)).ToList());

            int Count = Posts.Count();

            PropertyInfo? SortByCounter = typeof(PostViewModel).GetProperty("counter");
            Posts = Posts.OrderBy(x => SortByCounter.GetValue(x)).ToList();

            if (!string.IsNullOrEmpty(Filter.Sort))
            {
                PropertyInfo? SortProperty = typeof(PostViewModel).GetProperty(Filter.Sort);

                if (SortProperty != null && Filter.Order == "asc")
                    Posts = Posts.OrderBy(x => SortProperty.GetValue(x)).ToList();

                else if (SortProperty != null && Filter.Order == "desc")
                    Posts = Posts.OrderByDescending(x => SortProperty.GetValue(x)).ToList();

                Posts = Posts.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();
            }
            else
                Posts = Posts.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();

            return new ApiResponse(Posts, "Succeed", Count);
        }

    }
}
