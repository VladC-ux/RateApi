using Exchange.Data.Entity;
using Exchange.Repository;
using RateApi.Contracts.ApiModel;

namespace RateApi.Contracts.IService
{
    public interface IExchangeProvaidorService
    {
        void Add(ExchangeProvidorApiModel exchange);
        ExchangeProvidor Update(ExchangeProvidorApiModel exchange);
        void Delete(ExchangeProvidorApiModel id);
        List<ExchangeProvidorApiModel> GetAll();
        ExchangeProvidorApiModel GetById(int id);
    }
}
