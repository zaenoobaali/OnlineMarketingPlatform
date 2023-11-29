using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project2.DTOs.MarketerDTOs;
using Project2.DTOs.ProductDTOs;
using Project2.Model;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.Reflection;

namespace Project2.Repository.Services
{
    public class ProductService : IProductService
    {
        public AppDbContext _DbContext { get; set; }
        private IMapper _Mapper;

        public ProductService(AppDbContext DbContext, IMapper Mapper)
        {
            _DbContext = DbContext;
            _Mapper = Mapper;
        }
        public override ApiResponse GetAllProducts(ComplexFilter Filter)
        {
            List<ProductViewModel> Products = _Mapper.Map<List<ProductViewModel>>(_DbContext.Products
                .Where(x => (!string.IsNullOrEmpty(Filter.SearchQuery) ?
                    x.Name.ToLower().StartsWith(Filter.SearchQuery) : true)).ToList());

            int Count = Products.Count();

            if (!string.IsNullOrEmpty(Filter.Sort))
            {
                PropertyInfo? SortProperty = typeof(ProductViewModel).GetProperty(Filter.Sort);

                if (SortProperty != null && Filter.Order == "asc")
                    Products = Products.OrderBy(x => SortProperty.GetValue(x)).ToList();

                else if (SortProperty != null && Filter.Order == "desc")
                    Products = Products.OrderByDescending(x => SortProperty.GetValue(x)).ToList();

                Products = Products.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();
            }
            else
                Products = Products.Skip((Filter.PageIndex - 1) * Filter.PageSize)
                    .Take(Filter.PageSize).ToList();

            return new ApiResponse(Products, "Succeed", Count);
        }

        public override ApiResponse AllProducts(int userId)
        {
            var Product = from mark in _DbContext.Marketers
                               join post in _DbContext.Posts on mark.Id equals post.marketerId
                               join prod in _DbContext.Products on post.productId equals prod.id
                               where mark.userId == userId
                               select new
                               {
                                   prod.Name,
                                   post.Id
                               };
            var marketerProd = Product.ToList();

            return new ApiResponse(marketerProd, "Success", Product.Count());
        }

        public override ApiResponse PopularProduct()
        {
            var poppost = (from pos in _DbContext.Posts
                           join prod in _DbContext.Products on pos.productId equals prod.id
                           join mar in _DbContext.Marketers on pos.marketerId equals mar.Id
                           orderby pos.counter descending
                           select new
                           {
                               ProductName = prod.Name,
                               ProductPhoto = prod.photo,
                               MarketerName = mar.Name,
                               InteractionsCount = pos.reactioncount,
                               PostId = pos.Id
                           }).Take(10);

            //var posts = _DbContext.Posts
            //        .OrderByDescending(p => p.counter)  // الرتبة التنازلية حسب قيمة العداد
            //        .Take(10)  // اختيار أول 10 منشورات بأكبر قيمة للعداد
            //        .Select(p => new
            //        {
            //            ProductName = p.Product.Name,
            //            ProductPhoto = p.Product.photo,
            //            MarketerName = p.Marketer.Name,
            //            InteractionsCount = p.reactioncount,
            //            PostId = p.Id
            //        })
            //        .ToList();

            return new ApiResponse(poppost.ToList(), "Success", poppost.Count());
        }
    }
}
