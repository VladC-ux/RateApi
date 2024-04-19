using Exchange.Data;
using Exchange.Data.Entity;
using Exchange.Repository.IRepositoryInterface;

namespace Exchange.Repository
{
    public class ExchangeProvaidorRepository:IExchangeProvaidorRepository
    {
        private readonly DBContextExchange _context;


        public ExchangeProvaidorRepository (DBContextExchange context)
        {
            _context = context;
        }
        public void Add(ExchangeProvaidor exchange )
        {
            _context.ExchangeProvadiors.Add(exchange );
            _context.SaveChanges();
        }

        public ExchangeProvaidor Update(ExchangeProvaidor exchange )
        {

            var entity = _context.ExchangeProvadiors.FirstOrDefault(p => p.Id == exchange.Id);

            entity.Name = exchange.Name;
            entity.Types = exchange.Types;
            entity.Update = exchange.Update;
            _context.ExchangeProvadiors.Update(entity);
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
            _context.SaveChanges();
        }

        public List<ExchangeProvaidor> GetAll()
        {
            return _context.ExchangeProvadiors.ToList();
        }

        public ExchangeProvaidor GetById(int id)
        {
            return _context.ExchangeProvadiors.FirstOrDefault(e => e.Id == id);
        }







    }
}
