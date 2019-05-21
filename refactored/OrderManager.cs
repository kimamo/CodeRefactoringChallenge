using System;
using System.Collections.Generic;

namespace refactoring.refactored {

	public class OrderManager {
		private readonly IOrderStore orderStore;
		public OrderManager (IOrderStore orderStore) {
			this.orderStore = orderStore;
		}
		public void WriteOutSmallOrders () {
			var orders = orderStore.GetOrders ();
			SmallOrderFilter filter = new SmallOrderFilter (orders); 
		}
		public void WriteOutLargeOrders () {
			var orders = orderStore.GetOrders ();
			LargeOrderFilter filter = new LargeOrderFilter ( orders); 
		}
	}
}