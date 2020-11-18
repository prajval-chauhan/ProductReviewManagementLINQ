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
        /// <summary>
        /// UC2: Retrieves the 3 top rated review
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview orderby productReviews.rating descending select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: {0}\tUserID: {1}\tRating: {2}\tReview: {3}\tisLike: {4}",
                    list.productID, list.userID, list.rating, list.review, list.isLike);
            }
        }
        /// <summary>
        /// UC3: Retrieving the records having rating more than 3 and having userID 1/4/9
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void SelectRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                where (productReviews.productID == 1 || productReviews.productID == 4 || productReviews.productID == 9) && productReviews.rating > 3
                                select productReviews);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: {0}\tUserID: {1}\tRating: {2}\tReview: {3}\tisLike: {4}",
                    list.productID, list.userID, list.rating, list.review, list.isLike);
            }
        }
    }
}
