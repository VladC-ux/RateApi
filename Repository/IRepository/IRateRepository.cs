using Exchange.Data.Entity;
using RateApi;

namespace Exchange.Repository.IRepositoryInterface
{
    public interface IRateRepository
    {
        void Add(Rate exchange);
        Rate Update(Rate exchange);
        void Delete(int id);
        List<Rate> GetAll();
        Rate GetById(int id);
        
    }

}
