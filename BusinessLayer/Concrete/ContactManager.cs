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
	public class ContactManager : IContactService
	{
		IContactDal _contactDal;
		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TAdd(Contacts t)
		{
			_contactDal.Insert(t);
		}

		public void TDelete(Contacts t)
		{
			_contactDal.Delete(t);
		}

		public Contacts TGetByID(int id)
		{
			return _contactDal.GetByID(id);
		}

		public List<Contacts> TGetList()
		{
			return _contactDal.GetList();
		}

        public List<Contacts> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contacts t)
		{
			_contactDal.Update(t);
		}
	}
}
