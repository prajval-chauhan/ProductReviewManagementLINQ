using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagementLINQ
{
    public class ProductReview
    {
        public int productID { get; set; }
        public int userID { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
