namespace HolaMundo
{
    public class Product
    {
        public List<Review> reviewList = new List<Review>();
        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public void AddReview(Review clientReview)
        {
            reviewList.Add(clientReview);
        }

        public string name {get; set;}
        public float price {get; set;}
    }
}