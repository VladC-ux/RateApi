using Exchange.Data.Entity;
using Exchange.Repository;
using RateApi;
using RateApi.Contracts.ApiModel;

namespace RateApi.Contracts.IService
{
    public interface IRateService
    {
        void Add(RateApiModel exchange);
        Rate Update(RateApiModel exchange);
        void Delete(RateApiModel id);
        List<RateApiModel> GetAll();
        RateApiModel GetById(int id);
        List<Item> ShowRates();
    }
}
