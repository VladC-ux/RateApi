using Exchange.Data.Entity;

namespace RateApi.Contracts.IRepository
{
    public interface IExchangeProvaidorRepository
    {
        void Add(ExchangeProvaidor exchange);
        ExchangeProvaidor Update(ExchangeProvaidor exchange);
        void Delete(int id);
        List<ExchangeProvaidor> GetAll();
        ExchangeProvaidor GetById(int id);
    }
}
