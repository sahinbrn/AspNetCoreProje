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
	public class ExperienceManager : IExperienceService
	{
		IExperienceDal _experienceDal;

		public ExperienceManager(IExperienceDal experienceDal)
		{
			_experienceDal = experienceDal;
		}
		public void TAdd(Experiences t)
		{
			_experienceDal.Insert(t);
		}

		public void TDelete(Experiences t)
		{
			_experienceDal.Delete(t);
		}

		public Experiences TGetByID(int id)
		{
			return _experienceDal.GetByID(id);
		}

		public List<Experiences> TGetList()
		{
			return _experienceDal.GetList();
		}

        public List<Experiences> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experiences t)
		{
			_experienceDal.Update(t);
		}
	}
}
