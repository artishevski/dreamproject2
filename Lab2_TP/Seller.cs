namespace Lab2_TP
{
    internal class Seller : User
    {
        public int phoneNumber;

        public Seller(int userId, int budget, string name, int phoneNumber): base(userId, budget, name)
        {
            this.phoneNumber = phoneNumber;
        }

        public void sellItem(int sum)
        {
            budget += sum;
        }

        public string getContact()
        {
            return $"{name}, number: {phoneNumber}";
        }
        private void addItem(Item item)
        {
            store.addItem(item);
        }

        private void removeItem(int itemId)
        {
            store.removeItem(itemId);
        }
    }
}
