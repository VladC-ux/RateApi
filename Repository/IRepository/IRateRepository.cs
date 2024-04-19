using Exchange.Data.Entity;

namespace Exchange.Repository.IRepositoryInterface
{
    public interface IReightRepository
    {

        void Add(Rate exchange);

        Rate Update(Rate exchange);

        void Delete(int id);

        List<Rate> GetAll();
        Rate GetById(int id);
    }
}
