using System;
using System.Collections.Generic;

namespace refactoring {

	public class SmallOrderFilter : LargeOrderFilter {
		public SmallOrderFilter (IOrderWriter orderWriter, List<Order> orders) : base (orderWriter, orders) {
			filterSize = 10;
		}
	}
}