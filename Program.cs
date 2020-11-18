using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagementLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the product review management program");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ productID = 1, userID = 1, rating = 5, review = "Excellent", isLike = true },
                new ProductReview(){ productID = 2, userID = 2, rating = 3, review = "Average", isLike = true },
                new ProductReview(){ productID = 3, userID = 3, rating = 2, review = "Bad", isLike = false },
                new ProductReview(){ productID = 4, userID = 4, rating = 1, review = "Worst", isLike = false },
                new ProductReview(){ productID = 5, userID = 5, rating = 3, review = "Average", isLike = true },
                new ProductReview(){ productID = 6, userID = 6, rating = 5, review = "Excellent", isLike = true },
                new ProductReview(){ productID = 7, userID = 7, rating = 3, review = "Average", isLike = true },
                new ProductReview(){ productID = 8, userID = 8, rating = 4, review = "Good", isLike = true },
                new ProductReview(){ productID = 9, userID = 9, rating = 5, review = "Excellent", isLike = true },
                new ProductReview(){ productID = 10, userID = 10, rating = 2, review = "Bad", isLike = false },
                new ProductReview(){ productID = 11, userID = 1, rating = 2, review = "Bad", isLike = false },
                new ProductReview(){ productID = 12, userID = 6, rating = 1, review = "Worst", isLike = false },
                new ProductReview(){ productID = 13, userID = 5, rating = 5, review = "Excellent", isLike = true },
                new ProductReview(){ productID = 14, userID = 4, rating = 2, review = "Bad", isLike = false },
                new ProductReview(){ productID = 15, userID = 3, rating = 4, review = "Good", isLike = true },
                new ProductReview(){ productID = 16, userID = 2, rating = 3, review = "Average", isLike = true },
            };
            Management call = new Management();
            //call.TopRecords(productReviewList);
            call.SelectRecords(productReviewList);
        }
    }
}
