using CustomerReviews.Core.Model.Common;
using CustomerReviews.Core.Model.Create;
using CustomerReviews.Core.Model.Read;
using CustomerReviews.Core.Model.Search;
using CustomerReviews.Core.Model.Update;

namespace CustomerReviews.Core.Services
{
    public interface ICustomerReviewService
    {
        CustomerReview[] GetByIds(string[] ids);

        IdentifierModel CreateCustomerReview(CustomerReviewCreateModel customerReviewCreateModel);

        void UpdateCustomerReview(CustomerReviewUpdateModel customerReviewUpdateModel);

        void DeleteCustomerReviews(string id);

        CustomerReviewResponseModel GetCustomerReviewById(string id);
        void SaveCustomerReviews(CustomerReview[] customerReview);
        void DeleteCustomerReviews(string[] v);
    }
}
