using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetailObject> GetOrderDetailByOrderID(int id) => OrderDetailDAO.Instance.GetOrderDetailByOrderID(id);
        public void AddOrderDetails(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.AddOrderDetails(orderDetail);
        public void UpdateOrderDetails(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetails(orderDetail);
    }
}
