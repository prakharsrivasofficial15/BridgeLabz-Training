using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Multilevel
{
    internal class Order
    {
        public int OrderId;
        public string OrderDate;

        public Order(int orderId, string orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }

    class ShippedOrder : Order
    {
        public string TrackingNumber;

        public ShippedOrder(int orderId, string orderDate, string trackingNumber)
            : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        public string DeliveryDate;

        public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }
    }

    class OrderTest
    {
        static void Main()
        {
            DeliveredOrder order = new DeliveredOrder(
                1001,
                "01-09-2025",
                "TRK12345",
                "05-09-2025"
            );

            Console.WriteLine("Order ID: " + order.OrderId);
            Console.WriteLine("Order Date: " + order.OrderDate);
            Console.WriteLine("Tracking Number: " + order.TrackingNumber);
            Console.WriteLine("Delivery Date: " + order.DeliveryDate);
            Console.WriteLine("Order Status: " + order.GetOrderStatus());
        }
    }
}
