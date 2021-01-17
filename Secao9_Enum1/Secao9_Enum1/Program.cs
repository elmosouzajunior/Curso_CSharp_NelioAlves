using System;
using Secao9_Enum1.Entities;
using Secao9_Enum1.Entities.Enums;

namespace Secao9_Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };

            Console.WriteLine(order);
        }
    }
}
