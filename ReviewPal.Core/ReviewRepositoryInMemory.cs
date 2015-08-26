using System.Collections.Generic;

namespace ReviewPal.Core
{
    /// <summary>
    /// In memory implementation of the ReviewRepository
    /// </summary>
    public class ReviewRepositoryInMemory : ReviewRepository
    {

        public ReviewRepositoryInMemory()
        {
            this.CodeReview = new CodeReview();
            CodeReview.Reviews = new List<Review>();
        }
        public override void Add(Review newReview)
        {
            CodeReview.Reviews.Add(newReview);
        }

        public override void Update(Review review)
        {
            CodeReview.Reviews[review.ReviewId] = review;
        }

        public override void Delete(Review review)
        {
            CodeReview.Reviews.Remove(review);
            AdjustReviewId();
        }

        public override void Clear()
        {
            CodeReview.Reviews.Clear();
        }

        public override Review Get(int reviewId)
        {
            return CodeReview.Reviews[reviewId];
        }
    }
}