﻿using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
