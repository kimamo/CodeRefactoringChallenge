using System;
using System.Collections.Generic; 

namespace refactoring {
	public interface IOrderStore {
		List<Order> GetOrders ();
	}

}