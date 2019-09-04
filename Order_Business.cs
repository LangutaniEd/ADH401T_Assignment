using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p.data;
using KFP.DATA;
namespace KFP.BUSINESS
{
   public class Order_Business
    {
        private KFG_Db db = new KFG_Db();
        /// 
        /// customer orders
        /// 
        public List<Order> cust_all()
        {
            return db.Orders.ToList();
        }
        public List<Order> cust_find_by_status(string status)
        {
            return db.Orders.Where(p => p.status.ToLower() == status.ToLower()).ToList();
        }
        public Order cust_find_by_id(int? id)
        {
            return db.Orders.Find(id);
        }
        public List<Order_Item> cust_Order_items(int? id)
        {
            return cust_find_by_id(id).Order_Items.ToList();
        }

        public List<OrderTracking> get_tracking_report(int? id)
        {
            return db.OrderTracking.Where(x => x.order_ID == id).ToList();
        }
        public void mark_as_packed(int? id)
        {
            var order = cust_find_by_id(id);
            order.packed = true;
            if (db.OrderAddress.Where(p => p.Order_ID == id) != null)
            {
                order.status = "With courier";
                //order tracking
                db.OrderTracking.Add(new OrderTracking()
                {
                    order_ID = order.Order_ID,
                    date = DateTime.Now,
                    status = "Order Packed, Now with our courier",
                    Recipient = ""
                });
            }

            db.SaveChanges();
        }
        public void schedule_delivery(int? order_Id, DateTime date)
        {
            var order = cust_find_by_id(order_Id);
            order.status = "Scheduled for delivery";
            //order tracking
            db.OrderTracking.Add(new OrderTracking()
            {
                order_ID = order.Order_ID,
                date = DateTime.Now,
                status = "Scheduled for delivery on " + date.ToLongDateString(),
                Recipient = ""
            });
            db.SaveChanges();
        }
    }
}
