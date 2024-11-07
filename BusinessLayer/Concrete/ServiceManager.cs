using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
		IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}
		public void TAdd(Services t)
		{
			_serviceDal.Insert(t);
		}

		public void TDelete(Services t)
		{
			_serviceDal.Delete(t);
		}

		public Services TGetByID(int id)
		{
			return _serviceDal.GetByID(id);
		}

		public List<Services> TGetList()
		{
			return _serviceDal.GetList();
		}

        public List<Services> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Services t)
		{
			_serviceDal.Update(t);
		}
	}
}
