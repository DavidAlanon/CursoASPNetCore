using System;
using System.Collections.Generic;

namespace acoplamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrdersRepository repository = new OrdersRepository();

            var service = new OrdersService(repository);

            var pedidos = service.GetOrders();
            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
        }
    }


    public class OrdersService
    {
        OrdersRepository _ordersRepository;
        public OrdersService(OrdersRepository repository)
        {
            _ordersRepository= repository;
        }

        public List<string> GetOrders()
        {
            var orders = _ordersRepository.GetOrdersFromDB();
            return orders;
        }
    }


    public interface IOrdersRepository
    {
        List<string> GetOrdersFromDB();
    }

    public class OrdersRepository
    {
        public List<string> GetOrdersFromDB()
        {
            var orders= new List<string>()
            {
            "Pedido desde api 1",
            "Pedido desde api 2",
            "Pedido desde api 3"
            };
            
        return orders;

        }

    }
}
