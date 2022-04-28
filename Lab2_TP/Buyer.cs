using System.Collections.Generic;

namespace Lab2_TP
{
    internal class Buyer : User
    {
        private List<int> cart;
        public Buyer(int userId, int budget, string name) : base(userId, budget, name) 
        {
            cart = new List<int>();
        }

        private void buyItem(int itemId)
        {
            budget -= store.buyItem(itemId);
        }

        private List<Item> getCatalog() => store.getCatalog();

        private void addToCart(int itemId)
        {
            cart.Add(itemId);
        }
        private void removeFromCart(int itemId)
        {
            cart.Remove(itemId);
        }

        private string getSellerContact(int itemId)
        {
            return store.getSellerContact(itemId);
        }
    }
}
