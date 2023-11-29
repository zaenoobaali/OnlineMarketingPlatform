using Microsoft.EntityFrameworkCore;
using Project2.DTOs.PostDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class PostServices : IPostServices
    {
        public AppDbContext _dbContext { get; set; }

        public PostServices(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }
        public override async Task<ApiResponse> AddPost(int marketerId,AddPostViewModel postViewModel)
        {
            var marketre = _dbContext.Marketers.Include(m => m.Posts)
                .FirstOrDefault(m => m.userId == marketerId);
            if (marketre == null)
                return new ApiResponse(false,"not found");
            
            var newProduct = new Product
            {
                Name = postViewModel.productViewModel.Name,
                productType = postViewModel.productViewModel.productType,
                photo = postViewModel.productViewModel.photo,
                Price = postViewModel.productViewModel.Price,
                point = postViewModel.productViewModel.point,
                sizes = new List<ProductSize>(),
                colors = new List<ProductColor>(),
                CreatedDate = DateTime.Now
            };

            
            await _dbContext.Products.AddAsync(newProduct);
            await _dbContext.SaveChangesAsync();

           
            var ps = postViewModel.productViewModel.productstatus;
            if (ps.Equals(Data.Enum.ProductStatus.None.ToString()))
            {
                newProduct.ProductStatus = Data.Enum.ProductStatus.None;
            }
            else if (ps.Equals(Data.Enum.ProductStatus.Offer.ToString()))
            {
                newProduct.ProductStatus = Data.Enum.ProductStatus.Offer;
            }
            else if (ps.Equals(Data.Enum.ProductStatus.Discount.ToString()))
            {
                newProduct.ProductStatus = Data.Enum.ProductStatus.Discount;
            }

            foreach (var color in postViewModel.productViewModel.colors)
            {
                var newColor = new ProductColor { color = color, productId = newProduct.id, Product = newProduct };
                newProduct.colors.Add(newColor);
                await _dbContext.ProductColors.AddAsync(newColor);
            }

            foreach (var size in postViewModel.productViewModel.sizes)
            {
                var newSize = new ProductSize { size = size,productId = newProduct.id, Product = newProduct };
                newProduct.sizes.Add(newSize);
                await _dbContext.ProductSizes.AddAsync(newSize);
            }
           

            var newPost = new Post
            {
                Description = postViewModel.Description,
                marketerId = marketre.Id,
                productId = newProduct.id,
                counter = 0,
                Product = newProduct,
                CreatedDate = DateTime.Now
            };
           
            marketre.Posts.Add(newPost);
            await _dbContext.Posts.AddAsync(newPost);
            await _dbContext.SaveChangesAsync();


            return new ApiResponse(true, "Success");        
        }

        public override ApiResponse DeletePost(int marketerId ,int postId)
        {
            var marketre = _dbContext.Marketers.Include(m => m.Posts)
                .FirstOrDefault(m => m.userId == marketerId);
            if (marketre == null)
                return new ApiResponse(false, "not found");

            var post = _dbContext.Posts
                .FirstOrDefault(p => p.Id == postId && p.marketerId == marketre.Id);
            if (post == null)
                return new ApiResponse(false, "not found");

            _dbContext.Posts.Remove(post);
            _dbContext.SaveChanges();

            return new ApiResponse(true , "Success");
        }

        public override ApiResponse InteractionOnPost(int userId, int postId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            var post = _dbContext.Posts.FirstOrDefault(p => p.Id == postId);
            if (user == null) return new ApiResponse(false , "user not found");
            if (post == null) return new ApiResponse(false, "post not found");

            var reciver = _dbContext.Marketers.FirstOrDefault(m => m.Id == post.marketerId);
            if (reciver == null) return new ApiResponse(false, "marketer not found");
            var prod = _dbContext.Products.FirstOrDefault(p => p.id == post.productId);
            if (prod == null) return new ApiResponse(false, "not found");

            bool isExisting = _dbContext.ReactionOnPosts
              .Any(r => r.postId == post.Id && r.userId == user.UID);

            if (isExisting) return new ApiResponse(false, "You are reaction on this post !");

            post.reactioncount = post.reactioncount + 1;

            var reaction = new ReactionOnPost
            {
                postId = post.Id,
                userId = user.UID
            };

            _dbContext.ReactionOnPosts.Add(reaction);

            var notify = new Notification
            {
                Body = $"{user.Name} reaction on your post {prod.Name}." ,
                RecieverId = reciver.userId,
                SenderId = userId,
                notifyType = Data.Enum.NotifyType.Normal,
                CreatedDate = DateTime.Now
            };
            _dbContext.Notifications.Add(notify);
            _dbContext.SaveChanges();
            var notifypost = new
            {
                notifaction = notify.Body,
                postId = post.Id
            };


            return new ApiResponse(true, "Success");
        }

        public override ApiResponse RemoveInteraction(int userId, int postId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            var post = _dbContext.Posts.FirstOrDefault(p => p.Id == postId);
            if (user == null) return new ApiResponse(false, "user not found");
            if (post == null) return new ApiResponse(false, "post not found");
           
            var react = _dbContext.ReactionOnPosts
             .FirstOrDefault(r => r.postId == post.Id && r.userId == user.UID);
            if (react == null) return new ApiResponse(false, "You didn't reaction on this post !");

            post.reactioncount = post.reactioncount - 1;

            _dbContext.ReactionOnPosts.Remove(react);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        //public ApiResponse ShowPostDetails(int postId )
        //{
        //    var pos = _dbContext.Posts.FirstOrDefault(p => p.Id == postId);
        //    if (pos == null) return new ApiResponse();
        //    var prod = _dbContext.Products.FirstOrDefault(p => p.id == pos.productId);
        //    if (prod == null) return new ApiResponse();
        //    var size =from s in _dbContext.ProductSizes
        //              where prod.id == s.productId 
        //              select new
        //              {
        //                  s.size
        //              };
        //    var color = from c in _dbContext.ProductColors
        //                where prod.id == c.productId
        //                select new
        //                {
        //                    c.color
        //                };
        //    var post = from po in _dbContext.Posts
        //               join mar in _dbContext.Marketers on po.marketerId equals mar.Id
        //               join pro in _dbContext.Products on po.productId equals pro.id
        //               where po.Id == postId
        //               select new
        //               {
        //                   marketerName = mar.Name,
        //                   pro.Name,
        //                   pro.photo,
        //                   pro.Price,
        //                   colors = color.ToList(),
        //                   sizes = size.ToList(),
        //                   po.Description,
        //                   po.CreatedDate
        //               };
        //    var posts = post.ToList();

        //    pos.counter++;
        //    _dbContext.SaveChanges();

        //    return new ApiResponse(posts , "Seccess");
        //}
        public override ApiResponse ShowPostDetails(int postId)
        {
            var postDetails = _dbContext.Posts
                .Where(p => p.Id == postId)
                .Include(p => p.Product)
                .Include(p => p.Marketer)
                .Select(p => new
                {
                    marketerName = p.Marketer.Name,
                    productName = p.Product.Name,
                    productPhoto = p.Product.photo,
                    productPrice = p.Product.Price,
                    productPoint = p.Product.point,
                    Status = p.Product.ProductStatus.ToString(),
                    colors = _dbContext.ProductColors
                        .Where(c => c.productId == p.Product.id)
                        .Select(c => new { c.color })
                        .ToList(),
                    sizes = _dbContext.ProductSizes
                        .Where(s => s.productId == p.Product.id)
                        .Select(s => new { s.size })
                        .ToList(),
                    p.Description,
                    p.CreatedDate,
                    p.Marketer.userId
                })
                .FirstOrDefault();

            if (postDetails == null)
                return new ApiResponse();

            // تحديث عداد العرض
            var post = _dbContext.Posts.FirstOrDefault(p => p.Id == postId);
            if (post != null)
            {
                post.counter++;
                _dbContext.SaveChanges();
            }

            return new ApiResponse(postDetails, "Success");
        }

        public override ApiResponse UpdatePost(int marketerId, int postId ,UpdatePostViewModel postViewModel)
        {
            var marketre = _dbContext.Marketers
                .FirstOrDefault(m => m.userId == marketerId);
            if (marketre == null)
                return new ApiResponse(false, "not found");

            var post = _dbContext.Posts
                .FirstOrDefault(p => p.Id == postId && p.marketerId == marketre.Id);
            
            if (post == null)
                return new ApiResponse(false , "not found");
            var prro = _dbContext.Products.FirstOrDefault(p => p.id == post.productId);

            if (prro == null)
                return new ApiResponse(false, "not found");
            var prodcolors = _dbContext.ProductColors.Where(c => c.productId == prro.id).ToList();
            var prodsizes = _dbContext.ProductSizes.Where(s => s.productId == prro.id).ToList();
            
            foreach(var pc in prodcolors)
                _dbContext.ProductColors.Remove(pc);
            foreach (var ps in prodsizes)
                _dbContext.ProductSizes.Remove(ps);
            _dbContext.SaveChanges();

            List<ProductSize> sizes = new List<ProductSize>();
            foreach (var size in postViewModel.Product.sizes)
            {
                var newSize = new ProductSize {productId = prro.id , size = size , Product = prro };
                sizes.Add(newSize);
                _dbContext.ProductSizes.Add(newSize);
            }
            List<ProductColor> colors = new List<ProductColor>();
            foreach (var color in postViewModel.Product.colors)
            {
                var newColor = new ProductColor {productId = prro.id , color = color , Product = prro };
                colors.Add(newColor);
                _dbContext.ProductColors.Add(newColor);
            }

            prro.Name = postViewModel.Product.Name;
            prro.productType = postViewModel.Product.productType;
            prro.photo = postViewModel.Product.photo;
            prro.Price = postViewModel.Product.Price;
            prro.sizes = sizes;
            prro.colors = colors;
            prro.ProductStatus = postViewModel.Product.ProductStatus;
            prro.CreatedDate = DateTime.Now;

         
            post.Product = prro;
            post.Description = postViewModel.Description;

            _dbContext.SaveChanges();

            return new ApiResponse(true , "Success");
        }
        //friends
        public override ApiResponse ViewPostForCustomer(int userId)
        {
            var friendPost = from cust in _dbContext.Customers
                             join friend in _dbContext.Friends on cust.Id equals friend.friendId
                             join custpost in _dbContext.CustPosts on cust.Id equals custpost.CustomerId
                             join prod in _dbContext.ProductOrders on custpost.ProductOrderId equals prod.Id
                             join mark in _dbContext.Marketers on custpost.MarketerId equals mark.Id
                             where friend.userId == userId
                             select new
                             {
                                 productPhoto = prod.photo,
                                 productName = prod.name,
                                 InteractionsCount = custpost.reactioncounter,
                                 marketerName = mark.Name,
                                 postId = custpost.PostId,
                                 customerId = userId
                             };

            if (friendPost.Count() == 0)
                return new ApiResponse(false, "customer friends' posts not found");

            return new ApiResponse(friendPost, "Success",friendPost.Count());

        }
        //following page
        public override ApiResponse ViewPostForMarketer(int userId)
        {
            var pagePost = from mark in _dbContext.Marketers
                           join pages in _dbContext.FollowingPages on mark.Id equals pages.pageId
                           join post in _dbContext.Posts on mark.Id equals post.marketerId
                           join prod in _dbContext.Products on post.productId equals prod.id
                           where pages.userId == userId
                           select new
                           {
                               productPhoto = prod.photo,
                               productName = prod.Name,
                               PostId = post.Id,
                               InteractionsCount = post.reactioncount,
                               marketerName = mark.Name
                           };
            
            var marketerpost = pagePost.ToList();
            if (marketerpost == null)
                return new ApiResponse(false, "marketer's posts not found");


            return new ApiResponse(marketerpost, "Success");
        }

        public override ApiResponse allPosts(int userId)
        {
            var friendPost = from cust in _dbContext.Customers
                             join friend in _dbContext.Friends on cust.Id equals friend.friendId
                             join custpost in _dbContext.CustPosts on cust.Id equals custpost.CustomerId
                             join prod in _dbContext.ProductOrders on custpost.ProductOrderId equals prod.Id
                             join mark in _dbContext.Marketers on custpost.MarketerId equals mark.Id
                             where friend.userId == userId
                             select new
                             {
                                 productPhoto = prod.photo,
                                 productName = prod.name,
                                 InteractionsCount = custpost.reactioncounter,
                                 marketerName = mark.Name,
                                 postId = custpost.PostId,
                                 customerId = userId
                             };

            var pagePost = from mark in _dbContext.Marketers
                           join pages in _dbContext.FollowingPages on mark.Id equals pages.pageId
                           join post in _dbContext.Posts on mark.Id equals post.marketerId
                           join prod in _dbContext.Products on post.productId equals prod.id
                           where pages.userId == userId
                           select new
                           {
                               productPhoto = prod.photo,
                               productName = prod.Name,
                               PostId = post.Id,
                               InteractionsCount = post.reactioncount,
                               marketerName = mark.Name
                           };

            var allposts = new
            {
               customerfrindspost = friendPost.ToList(),
               marketerpost = pagePost.ToList()
            };
            return new ApiResponse(allposts , "Success");
        }

        public override ApiResponse SetPrivate(int userId, int postId)
        {
            var user = _dbContext.Customers.FirstOrDefault(u => u.userId == userId);
            var post = _dbContext.Posts.FirstOrDefault(p => p.Id == postId);
           
            if (user == null) return new ApiResponse(false, "user not found");
            if (post == null) return new ApiResponse(false, "post not found");
            var custPost = _dbContext.CustPosts.FirstOrDefault(c => c.PostId == post.Id && c.CustomerId == user.Id);

            if (custPost == null) return new ApiResponse(false, "you dont have this post");
            if (custPost.status.Equals(Data.Enum.PostStatus.Public)) {
                custPost.status = Data.Enum.PostStatus.Private;
                _dbContext.SaveChanges();
                return new ApiResponse(true, "");
            }
            else
            {
                return new ApiResponse(false, "its alrady private");
            }

        }
    }
}
