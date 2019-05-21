using System;
using System.Collections.Generic;

namespace refactoring.refactored {
	public class LargeOrderFilter : OrderFilter {
		public LargeOrderFilter (List<Order> orders) : base (orders) { } 
		protected override int FilterSize => 100;
	}

}