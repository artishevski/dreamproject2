using System.Collections.Generic;
using System.Linq;

namespace Lab2_TP
{
    internal class Store
    {
        private Dictionary<int, Item> allItems;
        private Dictionary<int, Buyer> allBuyers;
        private Dictionary<int, Seller> allSellers;
        private SortedSet<int> allIds;
        private int idGenerator = 1;

        public void addSeller(string name, int phoneNumber, int? userId, int budget = 0)
        {
            if (userId == null)
                userId = idGenerator++;
            if (!allIds.Contains((int)userId))
                allSellers.Add((int)userId, new Seller((int)userId, budget, name, phoneNumber));
        }

        public void addBuyer(string name, int? userId, int budget = 0)
        {
            if (userId == null)
            {
                while(allIds.Contains(idGenerator))
                    idGenerator++;
                userId = idGenerator++;
            }
            if (!allIds.Contains((int)userId))
                allBuyers.Add((int)userId, new Buyer((int)userId, budget, name));
        }

        public void addItem(Item item)
        {
            allItems.Add(item.ItemId, item);
        }
        public int removeItem(int itemId)
        {
            int price = allItems[itemId].price;
            allItems.Remove(itemId);
            allIds.Remove(itemId);
            return price;
        }

        public int buyItem(int itemId)
        {
            Item item = allItems[itemId];
            allSellers[item.sellerId].sellItem(item.price);
            allIds.Remove(itemId);
            return item.price;
        }

        public string getSellerContact(int itemId)
        {
            Seller seller = allSellers[allItems[itemId].sellerId];
            return seller.getContact();
        }

        public List<Item> getCatalog() => allItems.Values.ToList();
    }
}
