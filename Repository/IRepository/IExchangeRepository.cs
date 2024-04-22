using Exchange.Data.Entity;

namespace Exchange.Repository.IRepositoryInterface
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
