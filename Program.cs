using System;
using System.Collections;

namespace HolaMundo
{
    public class Program
    {
        public static void Main()
        {
            Review review1 = new Review(1, "Horrible");
            Review review2 = new Review(2, "Malo");
            Review review3 = new Review(3, "Meh");
            Review review4 = new Review(4, "Bueno");
            Review review5 = new Review(5, "Excelente");

            Product product1 = new Product("Manzanas", 50F);

            product1.AddReview(review1);
            product1.AddReview(review1);
            product1.AddReview(review1);
            product1.AddReview(review2);

            //Printer.ListPrinter(product1.reviewList);
            //for (int i = 0; i < product1.reviewList.Count; i++)
            //{
            //    Console.WriteLine($"Rating:{product1.reviewList[i].stars} - Comentario:{product1.reviewList[i].comment}");
            //
            Printer.ReviewPrinter(product1);
        }
    }
}