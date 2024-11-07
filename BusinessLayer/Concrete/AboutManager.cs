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
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TAdd(Abouts t)
		{
			_aboutDal.Insert(t);
		}

		public void TDelete(Abouts t)
		{
			_aboutDal.Delete(t);
		}

		public List<Abouts> TGetList()
		{
			return _aboutDal.GetList();
		}

		public Abouts TGetByID(int id)
		{
		 return _aboutDal.GetByID(id);
		}

		public void TUpdate(Abouts t)
		{
		_aboutDal.Update(t);
		}

        public List<Abouts> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
