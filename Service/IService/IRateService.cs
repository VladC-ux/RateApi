using Exchange.ApiModel;
using Exchange.Data.Entity;
using Exchange.Repository;

namespace Exchange.Service.IServiceInterface
{
    public interface IRateService
    {
        void Add(RateApiModel exchange);

        Rate Update(RateApiModel exchange);

        void Delete(RateApiModel id);

        List<RateApiModel> GetAll();

        RateApiModel GetById(int id);


    }
}
