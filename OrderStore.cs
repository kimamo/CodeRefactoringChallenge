using System;
using System.Collections.Generic;

namespace refactoring {
	public class OrderStore : IOrderStore {
		public List<Order> GetOrders () {
			return new List<Order> {
				new Order {
					Price = 10,
						Size = 1,
						Symbol = "TShirt"
				},
				new Order {
					Price = 15,
						Size = 2,
						Symbol = "Sport Goods"
				}
			};
		}
	}

}