using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetail()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from o in context.Orders
                             join p in context.Products on o.OrderId equals p.ProductId

                             select new OrderDetailDto
                             {
                                 ProductName = p.ProductName,
                                 OrderDate = o.OrderDate,
                                 ShipCity = o.ShipCity,

                             };
                return result.ToList();
                             
            }
        }
    }
        
}

