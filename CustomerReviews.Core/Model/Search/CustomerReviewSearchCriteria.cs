using VirtoCommerce.Domain.Commerce.Model.Search;

namespace CustomerReviews.Core.Model.Search
{
    public class CustomerReviewSearchCriteria : SearchCriteriaBase
    {
        public string[] ProductIds { get; set; }
        public bool? IsActive { get; set; }
    }
}
