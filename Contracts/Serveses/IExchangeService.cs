using Exchange.Data.Entity;
using Exchange.Repository;
using RateApi.Contracts.ApiModel;

namespace RateApi.Contracts.IService
{
    public interface IExchangeProvaidorService
    {
        void Add(ExchangeProvaidorApiModel exchange);
        ExchangeProvaidor Update(ExchangeProvaidorApiModel exchange);
        void Delete(ExchangeProvaidorApiModel id);
        List<ExchangeProvaidorApiModel> GetAll();
        ExchangeProvaidorApiModel GetById(int id);
    }
}
