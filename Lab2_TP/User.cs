namespace Lab2_TP
{
    internal class User
    {
        public static Store store;
        public int userId;
        protected int budget;
        protected string name;

        public User(int userId, int budget, string name)
        {
            this.userId = userId;
            this.budget = budget;
            this.name = name;
        }
    }
}
