using Exchange.ApiModel;
using Exchange.Data.Entity;
using Exchange.Repository.IRepositoryInterface;
using Exchange.Service.IServiceInterface;

namespace Exchange.Service
{
    public class RateService : IRateService
    {
        private readonly IReightRepository _rate;
        public RateService(IReightRepository reight)
        {
            _rate = reight;

        }
        public void Add(RateApiModel model)
        {
            Rate change = new Rate
            {
                Buy = model.Buy,
                Sell = model.Sell,
                Currecny = model.Currecny

            };
            _rate.Add(change);

        }
        public void Delete(RateApiModel model)
        {

            _rate.Delete(model.Id);

        }
        public List<RateApiModel> GetAll()
        {
            var data = _rate.GetAll();
            List<RateApiModel> exchangeprovaidorapimodel = data.Select(change => new RateApiModel
            {
                Id = change.Id,
                Buy = change.Buy,
                Sell = change.Sell,
                Currecny = change.Currecny,


            }).ToList();
            return exchangeprovaidorapimodel;
        }
        public RateApiModel GetById(int reightid)
        {
            var changeid = _rate.GetById(reightid);
            return new RateApiModel
            {

                Id = changeid.Id,
                Sell = changeid.Sell,
                Buy = changeid.Buy,
                Currecny = changeid.Currecny


            };

        }
        public Rate Update(RateApiModel model)
        {
            Rate reight = new Rate
            {
                Id = model.Id,
                Sell = model.Sell,
                Buy = model.Buy,
                Currecny = model.Currecny,


            };
            _rate.Update(reight);
            return reight;
        }




    }
}
