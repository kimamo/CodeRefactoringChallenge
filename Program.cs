using System;

namespace refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
             var storeOrder = new OrderStore();
			var orders = storeOrder.GetOrders();
        }
    }
}
