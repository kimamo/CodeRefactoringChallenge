using System;
using System.Collections.Generic;

namespace refactoring {

	public interface IOrderWriter {
		void WriteOrders (IEnumerable<Order> orders);
	}
}