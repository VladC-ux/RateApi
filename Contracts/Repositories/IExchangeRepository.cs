using Exchange.Data.Entity;

namespace RateApi.Contracts.IRepository
{
    public interface IExchangeProvaidorRepository
    {
        void Add(ExchangeProvidor exchange);
        ExchangeProvidor Update(ExchangeProvidor exchange);
        void Delete(int id);
        List<ExchangeProvidor> GetAll();
        ExchangeProvidor GetById(int id);
    }
}
