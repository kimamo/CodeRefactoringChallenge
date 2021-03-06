using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace refactoring {
	
	public class LargeOrderFilter {
		private IOrderWriter orderWriter;
		private List<Order> orders;
		public LargeOrderFilter (IOrderWriter orderWriter, List<Order> orders) {
			filterSize = 100;
			this.orderWriter = orderWriter;
			this.orders = orders;
		}
		protected int filterSize;
		public void WriteOutFiltrdAndPriceSortedOrders (IOrderWriter writer) {
			List<Order> filteredOrders = this.FilterOrdersSmallerThan (orders, filterSize);
			Enumerable.OrderBy (filteredOrders, o => o.Price);
			ObservableCollection<Order> observableCollection =
				new ObservableCollection<Order> ();
			foreach (Order o in filteredOrders) {
				observableCollection.Add (o);
			}
			writer.WriteOrders (observableCollection);
		}
		protected List<Order> FilterOrdersSmallerThan (List<Order> allOrders, int size) {
			List<Order> filtered = new List<Order> ();
			for (int i = 0; i <= allOrders.Count; i++) {
			//	int number = orders[i].toNumber (size);
				if (allOrders[i].Size <= size) {
					continue;
				} else {
					filtered.Add (orders[i]);
				}
			}
			return filtered;
		}
	}
}