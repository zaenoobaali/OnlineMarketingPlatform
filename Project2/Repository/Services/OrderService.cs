using Project2.DTOs.OrderDTOs;
using Project2.DTOs.ProductDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class OrderService : IOrderService
    {
        public AppDbContext _dbContext { get; set; }
        public OrderService(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }
      
        public override ApiResponse AddOrderToBag(int customerId, int postId, ProductOrderViewModel productOrder)
        {
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (cust == null)
                return new ApiResponse(false, "customer not found 😶");
            var post = _dbContext.Posts.FirstOrDefault(P => P.Id == postId);
            if (post == null)
                return new ApiResponse(postId, "post not found 😶");
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.Id == post.marketerId);
            if (marketer == null)
                return new ApiResponse(false , "marketer not found 😶");
            var pro = _dbContext.Products.FirstOrDefault(p => p.id == post.productId);
            if (pro == null)
                return new ApiResponse(false , "product not found 😶");

            var bag = _dbContext.MarketerBags
                .Where(b => b.customerId == cust.Id && b.marketerId == marketer.Id);
            if (bag.Count() == 10) 
                return new ApiResponse(false , "You can only have 10 products in your bag. 😊");

            var sizes = from size in _dbContext.ProductSizes
                        where size.productId == post.productId
                        select new
                        {
                            Size = size.size
                        };
            var colors = from col in _dbContext.ProductColors
                         where col.productId == post.productId
                         select new
                         {
                             Color = col.color
                         };
            int c = 0;
            var siz = sizes.ToList();
            foreach (var s in siz)
            {
                if(!(s.Size == productOrder.size)){
                    c++;
                }
            }
            if (sizes.ToArray().Length.Equals(c))
                return new ApiResponse(false,"this size \'"+ productOrder.size + "\' not available in this product ! 😐");

            int x = 0;
            var color = colors.ToList();
            foreach (var o in color)
            {
                if (!(o.Color == productOrder.color))
                {
                    x++;
                }
            }
            if (colors.ToArray().Length.Equals(x))
                return new ApiResponse(false, "this color \'"+ productOrder.color + "\' not available in this product ! 😐");

           if(productOrder.quantity <= 0)
                return new ApiResponse(false ,"quantity should not be zero ! 😐");

            var proOrder = new ProductOrder
            {
                name = pro.Name,
                productType = pro.productType,
                photo = pro.photo,
                prouductId = pro.id,
                size = productOrder.size,
                color = productOrder.color,
                quantity = productOrder.quantity,
                CreatedDate = DateTime.Now
            };

            _dbContext.ProductOrders.Add(proOrder);
            _dbContext.SaveChanges();

            

            var markterBag = new MarketerBag
            {
                customerId = cust.Id,
                ProductOrderId = proOrder.Id,
                marketerId = post.marketerId,
            };
            //_dbContext.OrderBags.Add(orderBag);
            //_dbContext.SaveChanges();

            _dbContext.MarketerBags.Add(markterBag);
            _dbContext.SaveChanges();

            var MID = new
            {
                MarketerId = marketer.userId
            };

            return new ApiResponse(MID  , "Success" , bag.Count());
        }
        
        public override async Task<ApiResponse> AddOrder(int customerId, int marketerId)
        {
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (cust == null)
                return new ApiResponse(false, "customer not found");
            var market = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (market == null)
                return new ApiResponse(false, "marketer not found");

            
            var bagm = _dbContext.MarketerBags
                .Where(b => b.marketerId == market.Id && b.customerId == cust.Id)
                .ToList();
            if (bagm == null)
                return new ApiResponse(false, "your bag is empty!");

            var order = new Order
            {
                payWay = Data.Enum.PayWay.None,
                deliverId = 1,
                Status = Data.Enum.OrderStatus.Unknown,
                CreatedDate = DateTime.Now
            };

           
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
            //var orderBag = new OrderBag{ };

            foreach (var m in bagm)
            {
                var orderBag = new OrderBag {
                    customerId = m.customerId,
                    marketerId = m.marketerId,
                    ProductOrderId = m.ProductOrderId,
                    OrderId = order.Id
                 };
                await _dbContext.OrderBags.AddAsync(orderBag);
                await _dbContext.SaveChangesAsync();
            }

            _dbContext.SaveChanges();
            
            var OID = new
            {
                OrderId = order.Id
            };

            return new ApiResponse(OID, "Success");
        }
        
        public override ApiResponse SendOrder(int customerId,int orderId, AddOrderVM orderViewModel)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false , "user not found");
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == customer.userId);
            if (user == null) return new ApiResponse(false, "user not found");
            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
                return new ApiResponse(false , "order not found");
            
            var deliver = _dbContext.Delivers
                .FirstOrDefault(d => d.Name.ToLower() == orderViewModel.deliverName.ToLower());
            if (deliver == null)
                return new ApiResponse(false, "deliver not found");

            var orbag = _dbContext.OrderBags.FirstOrDefault(b => b.OrderId == orderId);
            if (orbag == null) return new ApiResponse();
            var prodor = _dbContext.ProductOrders.FirstOrDefault(p => p.Id == orbag.ProductOrderId);
            if (prodor == null) return new ApiResponse();
            var prod = _dbContext.Products.FirstOrDefault(p => p.id == prodor.prouductId);
            if (prod == null) return new ApiResponse();
            var mark = _dbContext.Marketers.FirstOrDefault(m => m.Id == orbag.marketerId);
            if (mark == null) return new ApiResponse();

            var pw = orderViewModel.payWay;
            if (pw.Equals(Data.Enum.PayWay.Cash.ToString()))
            {
                order.payWay = Data.Enum.PayWay.Cash;
            }
            else if (pw.Equals(Data.Enum.PayWay.Epayment.ToString()))
            {
                order.payWay = Data.Enum.PayWay.Epayment;
            }
            else if (pw.Equals(Data.Enum.PayWay.Points.ToString()))
            {
                order.payWay = Data.Enum.PayWay.Points;
            }

            order.deliverId = deliver.Id;

            if (order.payWay.Equals(Data.Enum.PayWay.Points))
            {
                int prodPoint = prod.Price / 100;
                if (customer.Point < prodPoint)
                    return new ApiResponse(false, "your points are not enough");

                //customer.Point = customer.Point - prodPoint;
                //mark.Point = mark.Point + prodPoint;
                //mark.Point += prodPoint;
            }
            else if (order.payWay.Equals(Data.Enum.PayWay.Epayment))
            {
                if(user.Billfold < prod.Price)
                    return new ApiResponse(false, "your money are not enough");
            }

            var custOrder = new CustOrder
            {
                CustomerId = customer.Id,
                OrderId = orderId,
                Status = Data.Enum.OrderStatus.WaitingForAccept,
                CreatedDate = DateTime.Now
            };

            _dbContext.CustOrders.Add(custOrder);
            _dbContext.SaveChanges();
            
            return new ApiResponse(true , "Success");
        }

        public override ApiResponse UpdateDetails(int customerId, int productorderId)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false, "customer not found");

            var details = from prodord in _dbContext.ProductOrders
                          join prod in _dbContext.Products on prodord.prouductId equals prod.id
                          join post in _dbContext.Posts on prod.id equals post.productId
                          join mark in _dbContext.Marketers on post.marketerId equals mark.Id
                          where prodord.Id == productorderId
                          select new
                          {
                              marketerName = mark.Name,
                              productName = prod.Name,
                              productPhoto = prod.photo,
                              productPrice = prod.Price,
                              productPoint = prod.point,
                              Status = prod.ProductStatus.ToString(),
                              colors = _dbContext.ProductColors
                                     .Where(c => c.productId == prod.id)
                                     .Select(c => new { c.color })
                                     .ToList(),
                              sizes = _dbContext.ProductSizes
                                     .Where(s => s.productId == prod.id)
                                     .Select(s => new { s.size })
                                     .ToList(),
                              post.Description,
                              marketerId = mark.userId,
                              productorderId = prodord.Id
                          };
            var updateDetails = details.ToList();

            return new ApiResponse(updateDetails, "Success", updateDetails.Count());
                
        }

        public override ApiResponse UpdateOrder(int customerId , int productorderId , ProductOrderViewModel productOrder)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false ,"customer not found");

            var prodorder = _dbContext.ProductOrders
                .FirstOrDefault(p => p.Id == productorderId);
            if (prodorder == null)
                return new ApiResponse(false ,"product you want edit not found");

            prodorder.color = productOrder.color;
            prodorder.size = productOrder.size;
            prodorder.quantity = productOrder.quantity;

            _dbContext.SaveChanges();
            return new ApiResponse(true, "Success");
        }

        public override ApiResponse AccepteOrder(int marketerId, int orderId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (marketer == null)
                return new ApiResponse(false, "marketer not found");
            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
                return new ApiResponse(false, "order not found");
            var custorder = _dbContext.CustOrders.FirstOrDefault(co => co.OrderId == orderId);
            if (custorder == null)
                return new ApiResponse(false, "customer order not found");
            var cust = _dbContext.Customers.FirstOrDefault(c => c.Id == custorder.CustomerId);
            if (cust == null)
                return new ApiResponse(false, "customer not found");
            
            if (order.Status.Equals(Data.Enum.OrderStatus.Unknown) 
                && custorder.Status.Equals(Data.Enum.OrderStatus.WaitingForAccept))
            {
                order.Status = Data.Enum.OrderStatus.Acceptance;
                custorder.Status = Data.Enum.OrderStatus.Acceptance;
                var deliverorder = new DelivOrder
                {
                    OrderId = orderId,
                    DeliverId = order.deliverId,
                    Status = Data.Enum.OrderStatus.Unknown,
                    CreatedDate = DateTime.Now
                };
                var notify = new Notification
                {
                    Body = "The marketer "+marketer.Name+" accepte your order",
                    SenderId = marketer.userId,
                    RecieverId = cust.userId ,
                    notifyType = Data.Enum.NotifyType.Normal,
                    CreatedDate = DateTime.Now 
                };
                _dbContext.DelivOrders.Add(deliverorder);
                _dbContext.Notifications.Add(notify);
               
                _dbContext.SaveChanges();

                return new ApiResponse(true , "Success");
            }

            return new ApiResponse(false ,"fail");
        }

        public override ApiResponse AccepetDeliverOrder(int deliverId , int orderId)
        {
            var deliverorder = _dbContext.DelivOrders.FirstOrDefault(d => d.OrderId == orderId);
            if (deliverorder == null)
                return new ApiResponse(false , "deliver order not found");

            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null)
                return new ApiResponse(false , "deliver not found");

            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
                return new ApiResponse(false, "order not found");
            var custorder = _dbContext.CustOrders.FirstOrDefault(co => co.OrderId == orderId);
            if (custorder == null)
                return new ApiResponse(false, "customer order not found");
            var cust = _dbContext.Customers.FirstOrDefault(c => c.Id == custorder.CustomerId);
            if (cust == null)
                return new ApiResponse(false, "customer not found");

            var bag = _dbContext.OrderBags
                .FirstOrDefault(b => b.customerId == custorder.CustomerId && b.OrderId == order.Id);
            if (bag == null) return new ApiResponse(false ,"bag not found");
            var custbag = _dbContext.MarketerBags.
                Where(o => o.customerId == custorder.CustomerId 
                && o.marketerId == bag.marketerId).ToList();
            
            if (custbag == null)
                return new ApiResponse();

            if (deliverorder.Status.Equals(Data.Enum.OrderStatus.Unknown))
            {
                deliverorder.Status = Data.Enum.OrderStatus.Acceptance;

                var notify = new Notification
                {
                    Body = "The Deliver " + deliver.Name + " accepted to deliver your order ",
                    SenderId = deliver.userId,
                    RecieverId = cust.userId,
                    notifyType = Data.Enum.NotifyType.Normal,
                    CreatedDate = DateTime.Now
                };

                foreach (var b in custbag)
                {
                    //order.Bags.Remove(b);
                    _dbContext.MarketerBags.Remove(b);
                }

                _dbContext.Notifications.Add(notify);
                _dbContext.SaveChanges();
                return new ApiResponse(true , "Success");

            }

            return new ApiResponse(false , "fail");
        }

        public override ApiResponse DeliveredToDelivery(int marketerId, int orderId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (marketer == null)
                return new ApiResponse(false, "marketer not found");
            var order = _dbContext.Orders
                .FirstOrDefault(o => o.Id == orderId);
            var bagg = _dbContext.OrderBags
                .FirstOrDefault(o => o.marketerId == marketer.Id && o.OrderId == orderId);
            if (order == null)
                return new ApiResponse(false, "order not found");
            
            if (order.Status.Equals(Data.Enum.OrderStatus.Acceptance))
            {
                order.Status = Data.Enum.OrderStatus.DeliveredToDeliver;
                _dbContext.SaveChanges();
                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "fail");
        }

        public override ApiResponse ReceivedFromMarketer(int deliverId, int orderId)
        {
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null)
                return new ApiResponse(false, "deliver not found");

            var deliverorder = _dbContext.DelivOrders
                .FirstOrDefault(d => d.OrderId == orderId && d.DeliverId == deliver.Id);
            if (deliverorder == null)
                return new ApiResponse(false, "deliver order not found");

            if (deliverorder.Status.Equals(Data.Enum.OrderStatus.Acceptance))
            {
                deliverorder.Status = Data.Enum.OrderStatus.ReceivedFromMarketer;
                _dbContext.SaveChanges();
                return new ApiResponse(true, "Success");
            }

            return new ApiResponse(false, "fail");
        }

        public override ApiResponse Delivered(int deliverId, int orderId)
        {
           
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null)
                return new ApiResponse(false, "deliver not found");

            var deliverorder = _dbContext.DelivOrders
                .FirstOrDefault(d => d.OrderId == orderId && d.DeliverId == deliver.Id);
            if (deliverorder == null)
                return new ApiResponse(false, "deliver order not found");

            if (deliverorder.Status.Equals(Data.Enum.OrderStatus.ReceivedFromMarketer))
            {
                deliverorder.Status = Data.Enum.OrderStatus.Delivered;
                _dbContext.SaveChanges();
                return new ApiResponse(true, "Success");
            }

            return new ApiResponse(false, "fail");
        }

        public override ApiResponse Received(int customerId, int orderId)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null) return new ApiResponse(false ,"customer not found ");
            var usercust = _dbContext.Users.FirstOrDefault(u => u.UID == customerId);
            if (usercust == null) return new ApiResponse(false, "user not found");
            var custorder = _dbContext.CustOrders
                .FirstOrDefault(c => c.OrderId == orderId && c.CustomerId == customer.Id);
            if (custorder == null) return new ApiResponse(false ,"customer order not found ");
            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) return new ApiResponse(false, "order not found ");

            var pror = _dbContext.OrderBags.FirstOrDefault(o => o.OrderId == orderId);
            if (pror == null) return new ApiResponse(false, "orderbag not found");
            var orpr = _dbContext.ProductOrders.FirstOrDefault(p => p.Id == pror.ProductOrderId);
            if (orpr == null)  return new ApiResponse(false, "product order not found");
            var prod = _dbContext.Products.FirstOrDefault(p => p.id == orpr.prouductId);
            if (prod == null) return new ApiResponse(false, "product not found");
            var post = _dbContext.Posts
                .FirstOrDefault(p => p.marketerId == pror.marketerId && p.productId == orpr.prouductId);
            if (post == null)   return new ApiResponse(false, "post not found");
            var mark = _dbContext.Marketers.FirstOrDefault(m => m.Id == pror.marketerId);
            if (mark == null) return new ApiResponse(false, "marketer not found ");
            var usermark = _dbContext.Users.FirstOrDefault(u => u.UID == mark.userId);
            if (usermark == null) return new ApiResponse(false, "user not found");

            
            if (custorder.Status.Equals(Data.Enum.OrderStatus.Acceptance) &&
                order.Status.Equals(Data.Enum.OrderStatus.DeliveredToDeliver))
            {
              
                custorder.Status = Data.Enum.OrderStatus.Received;
                order.Status = Data.Enum.OrderStatus.Delivered;
                if (order.payWay.Equals(Data.Enum.PayWay.Points))
                {
                    int prodPoint = prod.Price / 100;
                    //if (customer.Point < prodPoint)
                    //    return new ApiResponse(false, "your points are not enough");

                    customer.Point = customer.Point - prodPoint;
                    //mark.Point = mark.Point + prodPoint;
                    mark.Point += prodPoint;
                }
                else if (order.payWay.Equals(Data.Enum.PayWay.Epayment))
                {
                    //if(customer )
                    usercust.Billfold -= prod.Price;
                    usermark.Billfold += prod.Price;
                }

                var custpost = new CustPost
                {
                    CustomerId = customer.Id,
                    ProductOrderId = pror.ProductOrderId,
                    MarketerId = pror.marketerId,
                    PostId = post.Id,
                    CreatedDate = DateTime.Now
                };
                _dbContext.CustPosts.Add(custpost);
                //customer.CustPosts.Add(custpost);
                _dbContext.SaveChanges();
                return new ApiResponse(true , "Success");
            }
            return new ApiResponse(false , "fail");
        }

        public override ApiResponse DeleteOrder(int customerId, int productorderId)
        {
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (cust == null)
                return new ApiResponse(false, "customer not found");
            
            var prodorder = _dbContext.ProductOrders.FirstOrDefault(p => p.Id == productorderId);
            if (prodorder == null)
                return new ApiResponse(false , "product you want order not found");

            var bag = _dbContext.MarketerBags
                .FirstOrDefault(b => b.ProductOrderId == productorderId && b.customerId == cust.Id);
            if (bag == null)
                return new ApiResponse(false ,"ÿou dont have this product in your bag!");

            _dbContext.MarketerBags.Remove(bag);
            _dbContext.SaveChanges();
            return new ApiResponse(true , "Success");
        }

        public override ApiResponse UnAccepteOrder(int marketerId, int orderId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (marketer == null)
                return new ApiResponse(false, "marketer not found");
            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
                return new ApiResponse(false, "order not found");
            var custorder = _dbContext.CustOrders.FirstOrDefault(co => co.OrderId == orderId);
            if (custorder == null)
                return new ApiResponse(false, "customer order not found");
            var cust = _dbContext.Customers.FirstOrDefault(c => c.Id == custorder.CustomerId);
            if (cust == null)
                return new ApiResponse(false, "customer not found");


            if (order.Status.Equals(Data.Enum.OrderStatus.Unknown)
                && custorder.Status.Equals(Data.Enum.OrderStatus.WaitingForAccept))
            {
                order.Status = Data.Enum.OrderStatus.Unacceptable;
                custorder.Status = Data.Enum.OrderStatus.Unacceptable;

                var notify = new Notification
                {
                    Body = "The marketer " + marketer.Name + " unaccepte your order :(",
                    SenderId = marketer.userId,
                    RecieverId = cust.userId,
                    notifyType = Data.Enum.NotifyType.Normal,
                    CreatedDate = DateTime.Now
                };

                _dbContext.Notifications.Add(notify);

                _dbContext.SaveChanges();
                return new ApiResponse(true, "Success");
            }

            return new ApiResponse(false, "fail");
        }

        public override ApiResponse ViewBag(int customerId, int marketerId)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false,"customer not found");
            
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (marketer == null)
                return new ApiResponse(false ,"marketer not found");

            var bag = _dbContext.MarketerBags
                .Where(b => b.customerId == customer.Id && b.marketerId == marketer.Id)
                .ToList();

            if (bag.Count() == 0)
                return new ApiResponse(false, "your bag is empty ");

            var custbag = (
                        from b in bag
                        join orpro in _dbContext.ProductOrders on b.ProductOrderId equals orpro.Id
                        join pro in _dbContext.Products on orpro.prouductId equals pro.id
                        join post in _dbContext.Posts on pro.id equals post.productId 
                        where marketer.Id == post.marketerId
                        select new
                        {
                            Product = new
                            {
                                ProName = orpro.name,
                                ProPhoto = orpro.photo,
                                ProSize = orpro.size,
                                ProColor = orpro.color
                            },
                            price = pro.Price,
                            StoreName = marketer.Name,
                            Quantity = orpro.quantity,
                            Total = pro.Price * orpro.quantity,
                            productorderId = orpro.Id,
                            postId = post.Id
                        }
                    ).ToList();


            return new ApiResponse(custbag , "Success" , custbag.Count());
        }

        public override ApiResponse ViewCustomerOrder(int customerId)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false ,"customer not found");

            var custorder = _dbContext.CustOrders.Where(o => o.CustomerId == customer.Id)
                .ToList();

            if (custorder.Count() == 0)
                return new ApiResponse(false,"you don't have order");

            var custord = (
                from b in custorder
                let or = from orderbag in _dbContext.OrderBags
                         join prodord in _dbContext.ProductOrders on orderbag.ProductOrderId equals prodord.Id
                         join marketer in _dbContext.Marketers on orderbag.marketerId equals marketer.Id
                         where orderbag.OrderId == b.OrderId
                         select new
                         {
                             ProductName = prodord.name,
                             StoreName = marketer.Name
                         }
                select new
                {
                    OrderDetails = or.ToList(),
                    Status = b.Status.ToString(),
                    orderId = b.Id
                }
            ).ToList();


            return new ApiResponse(custord, "Success", custord.Count());
        }

        public override ApiResponse ViewMarketerSales(int marketerId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (marketer == null)
                return new ApiResponse(false,"marketer not found");

            var markorder = _dbContext.OrderBags
                .Where(o => o.marketerId == marketer.Id).ToList();
            if (markorder.Count() == 0 )
                return new ApiResponse(false , "you dont have salles yet");


            var marktsall = (
               from m in markorder
               join ordeer in _dbContext.Orders on m.OrderId equals ordeer.Id
               join prodorder in _dbContext.ProductOrders on m.ProductOrderId equals prodorder.Id
               join cust in _dbContext.Customers on m.customerId equals cust.Id
               select new
               {
                   ProductName = prodorder.name,
                   CustomerName = cust.FName + " " + cust.LName,
                   OrderStatus = ordeer.Status.ToString(),
                   orderId = ordeer.Id
               }
           ).ToList();
       
            return new ApiResponse(marktsall , "Success", marktsall.Count());
        }

        public override ApiResponse ViewDeliverOrder(int deliverId)
        {
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null)
                return new ApiResponse(false , "deliver not found");

            var delivorder = _dbContext.DelivOrders
                .Where(d => d.DeliverId == deliver.Id).ToList();
            if (delivorder.Count() == 0)
                return new ApiResponse(false ,"you dont have order to deliver it yet");

            var delorder = (
                    from d in delivorder
                    join orderbag in _dbContext.OrderBags on d.OrderId equals orderbag.OrderId
                    join cust in _dbContext.Customers on orderbag.customerId equals cust.Id
                    join markter in _dbContext.Marketers on orderbag.marketerId equals markter.Id
                    join prodorder in _dbContext.ProductOrders on orderbag.ProductOrderId equals prodorder.Id
                    select new
                    {
                        DeliverOrder = new
                        {
                            Store = markter.Name,
                            Customer = cust.FName + " " + cust.LName,
                            Product = prodorder.name,
                            CustomerCity = cust.city,
                            CustomerZone = cust.zone,
                            StoreCity = markter.city,
                            StoreZone = markter.zone
                        },
                        DeliveryDate = DateTime.Now,
                        Status = d.Status.ToString(),
                        orderId = d.Id
                    }
                ).ToList();


            return new ApiResponse(delorder , "Success", delorder.Count());
        }

        public override ApiResponse RemoveCustomerOrder(int customerId, int custOrderId)
        {
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (cust == null) return new ApiResponse(false, "customer not found ");
            var order = _dbContext.CustOrders
                .FirstOrDefault(c => c.Id == custOrderId && c.CustomerId == cust.Id);
            if (order == null) return new ApiResponse(false, "order not found");
            if (order.Status.Equals(Data.Enum.OrderStatus.Acceptance))
            {
                _dbContext.CustOrders.Remove(order);
                _dbContext.SaveChanges();
                return new ApiResponse(true, "");
            }
            return new ApiResponse(false, "You can't remove this order");
        }

        public override ApiResponse RemoveMarketerSales(int marketerId, int markSaleId)
        {
            var mark = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (mark == null) return new ApiResponse(false, "marketer not found");
            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == markSaleId);
            if (order == null) return new ApiResponse(false, "not found");
            var sale = _dbContext.OrderBags
                .FirstOrDefault(s => s.OrderId == order.Id && s.marketerId == mark.Id);
            throw new NotImplementedException();
        }

        public override ApiResponse RemoveDeliverOrder(int deliverId, int delivOrderId)
        {
            throw new NotImplementedException();
        }

        public override ApiResponse SendOrder(int customerId, int userId, int orderId, AddOrderVM orderViewModel)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
            if (customer == null) return new ApiResponse(false, "user not found");

            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) return new ApiResponse(false, "order not found");

            var deliver = _dbContext.Delivers
                .FirstOrDefault(d => d.Name.ToLower() == orderViewModel.deliverName.ToLower());
            if (deliver == null) return new ApiResponse(false, "deliver not found");
            
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (cust == null) return new ApiResponse(false,"");
            var orbag = _dbContext.OrderBags.FirstOrDefault(b => b.OrderId == orderId);
            if (orbag == null) return new ApiResponse();
            var prodor = _dbContext.ProductOrders.FirstOrDefault(p => p.Id == orbag.ProductOrderId);
            if (prodor == null) return new ApiResponse();
            var prod = _dbContext.Products.FirstOrDefault(p => p.id == prodor.prouductId);
            if (prod == null) return new ApiResponse();
            var mark = _dbContext.Marketers.FirstOrDefault(m => m.Id == orbag.marketerId);
            if (mark == null) return new ApiResponse();

            var pw = orderViewModel.payWay;
            if (pw.Equals(Data.Enum.PayWay.Cash.ToString()))
            {
                order.payWay = Data.Enum.PayWay.Cash;
            }
            else if (pw.Equals(Data.Enum.PayWay.Epayment.ToString()))
            {
                order.payWay = Data.Enum.PayWay.Epayment;
            }
            else if (pw.Equals(Data.Enum.PayWay.Points.ToString()))
            {
                order.payWay = Data.Enum.PayWay.Points;
            }
            order.deliverId = deliver.Id;
            
            if (mark.Point != 0)
            {
                cust.Point += prod.point;
                mark.Point -= prod.point;
            }
            
            var custOrder = new CustOrder
            {
                CustomerId = customer.Id,
                OrderId = orderId,
                Status = Data.Enum.OrderStatus.WaitingForAccept,
                CreatedDate = DateTime.Now
            };


            _dbContext.CustOrders.Add(custOrder);
            _dbContext.SaveChanges();


            return new ApiResponse(true, "Success");
        }
    }
}
