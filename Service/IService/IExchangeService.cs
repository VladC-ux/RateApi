using Exchange.ApiModel;
using Exchange.Data.Entity;
using Exchange.Repository;

namespace Exchange.Service.IServiceInterface
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
