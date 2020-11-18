using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementLINQ
{
    /// <summary>
    /// UC2: Retrieve top 3 records from the list who's rating is high
    /// </summary>
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview orderby productReviews.rating descending select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: {0}\tUserID: {1}\tRating: {2}\tReview: {3}\tisLike: {4}",
                    list.productID, list.userID, list.rating, list.review, list.isLike);
            }
        }
    }
}
