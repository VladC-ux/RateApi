using Exchange.Data.Entity;
using Exchange.Data;
using Exchange.Repository.IRepositoryInterface;

namespace Exchange.Repository
{
    public class RateRepository : IReightRepository
    {
        private readonly DBContextExchange _context;


        public RateRepository(DBContextExchange context)
        {
            _context = context;
        }
        public void Add(Rate reight)
        {
            _context.Reights.Add(reight);
            _context.SaveChanges();

        }

        public Rate Update(Rate reight)
        {

            var entity = _context.Reights.FirstOrDefault(p => p.Id == reight.Id);
            entity.Sell = reight.Sell;
            entity.Buy = reight.Buy;
            entity.Currecny = reight.Currecny;
            _context.Reights.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var querry = _context.ExchangeProvadiors.Find(id);
            if (querry != null)
            {
                _context.ExchangeProvadiors.Remove(querry);
            }

        }



        public List<Rate> GetAll()
        {
            return _context.Reights.ToList();
        }

        public Rate GetById(int id)
        {
            return _context.Reights.FirstOrDefault(r => r.Id == id);
        }
    }
}
