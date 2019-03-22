using VirtoCommerce.Platform.Core.Common;

namespace CustomerReviews.Core.Model.Search
{
    public class CustomerReview : AuditableEntity
    {
        public string AuthorNickname { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
        public string ProductId { get; set; }
    }
}
