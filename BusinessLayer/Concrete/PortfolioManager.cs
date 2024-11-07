using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLater.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class PortfolioManager : IPortfolioService
	{

		IPortfolioDal _portfolioDal;

		public PortfolioManager(IPortfolioDal portfolioDal)
		{
			_portfolioDal = portfolioDal;
		}

		public void TAdd(Portfolios t)
		{
		 _portfolioDal.Insert(t);
		}

		public void TDelete(Portfolios t)
		{
			_portfolioDal.Delete(t);
		}

		public Portfolios TGetByID(int id)
		{
			return _portfolioDal.GetByID(id);
		}

		public List<Portfolios> TGetList()
		{
			return _portfolioDal.GetList();
		}

        public List<Portfolios> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolios t)
		{
			_portfolioDal.Update(t);
		}
	}
}
