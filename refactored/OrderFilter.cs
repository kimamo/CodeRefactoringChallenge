using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace refactoring.refactored {

	public abstract class OrderFilter {
		//private IOrderWriter orderWriter;
		private List<Order> orders;
		public OrderFilter (List<Order> orders) {
			//	this.orderWriter = orderWriter;
			this.orders = orders;
		}

		protected abstract int FilterSize { get; }

		public void WriteOutFilteredAndPriceSortedOrders (IOrderWriter writer) {
			List<Order> filteredOrders = this.FilterOrdersSmallerThan (orders, FilterSize);

			filteredOrders = filteredOrders.OrderBy (o => o.Price).ToList ();
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