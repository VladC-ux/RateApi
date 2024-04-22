using Exchange.Data;
using Exchange.Data.Entity;
using Exchange.Repository.IRepositoryInterface;

namespace Exchange.Repository
{
    public class ExchangeProvaidorRepository:IExchangeProvaidorRepository
    {
        private readonly ExchangeDBContext _context;
        public ExchangeProvaidorRepository (ExchangeDBContext context)
        {
            _context = context;
        }
        public void Add(ExchangeProvaidor exchange )
        {
            _context.ExchangeProvaidors.Add(exchange );
            _context.SaveChanges();
        }
        public ExchangeProvaidor Update(ExchangeProvaidor exchange )
        {
            var entity = _context.ExchangeProvaidors.FirstOrDefault(p => p.Id == exchange.Id);

            entity.Name = exchange.Name;
            entity.Type = exchange.Type;
            entity.Update = exchange.Update;
            _context.ExchangeProvaidors.Update(entity);
            _context.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            var querry = _context.ExchangeProvaidors.Find(id);
            if (querry != null)
            {
                _context.ExchangeProvaidors.Remove(querry);
            }
            _context.SaveChanges();
        }
        public List<ExchangeProvaidor> GetAll()
        {
            return _context.ExchangeProvaidors.ToList();
        }
        public ExchangeProvaidor GetById(int id)
        {
            return _context.ExchangeProvaidors.FirstOrDefault(e => e.Id == id);
        }

    }
}
