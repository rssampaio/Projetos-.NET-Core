using PedidoVenda.Entities;
using PedidoVenda.Entities.Enums;
using System;

namespace PedidoVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txtStatus = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txtStatus);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
