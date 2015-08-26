using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ReviewPal.Core
{
    public abstract class ReviewRepository
    {
        /// <summary>
        /// Object holding the review results
        /// </summary>
        public CodeReview CodeReview;

        abstract public void Add(Review newReview);
        abstract public void Update(Review review);
        abstract public void Delete(Review review);
        abstract public void Clear();
        abstract public Review Get(int reviewId);

        /// <summary>
        /// Gets the count of review items.
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return CodeReview.Reviews.Count;
        }

        /// <summary>
        /// Gets the next review id.
        /// </summary>
        /// <returns></returns>
        public int GetNextReviewId()
        {
            return GetCount();
        }

        /// <summary>
        /// Adjusts the review id.
        /// </summary>
        public void AdjustReviewId()
        {
            for (int i = 0; i < GetCount(); i++)
            {
                CodeReview.Reviews[i].ReviewId = i;
            }
        }
    }
}