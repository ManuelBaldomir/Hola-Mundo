namespace HolaMundo
{
    public class Review
    {
        public Review(int stars, string comment)
        {
            this.stars = stars;
            this.comment = comment;            
        }
        public int stars {get; set;}
        public string comment {get; set;}
    }
}