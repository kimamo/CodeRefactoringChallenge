using System;
using System.Collections.Generic;

namespace refactoring.refactored {

	public class SmallOrderFilter : OrderFilter {
		public SmallOrderFilter (List<Order> orders) : base (orders) { } 
		protected override int FilterSize => 10;
	}
}