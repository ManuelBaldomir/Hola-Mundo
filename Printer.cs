namespace HolaMundo
{
    public class Printer
    {
        public static void ReviewPrinter(Product reviewedProduct)
        {
            Console.WriteLine($"--------{reviewedProduct.name}:--------");
            for (int i = 0; i < reviewedProduct.reviewList.Count; i++)
            {
                
                Console.WriteLine($"Estrellas:{reviewedProduct.reviewList[i].stars} - Comentario:{reviewedProduct.reviewList[i].comment}");
            }
            
        }
    }
}