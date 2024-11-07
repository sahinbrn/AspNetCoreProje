using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMedyaManager : ISocialMedyaService
    {
        ISocialMedyaDal _socialMedyaDal;

        public SocialMedyaManager(ISocialMedyaDal socialMedyaDal)
        {
            _socialMedyaDal = socialMedyaDal;
        }

        public void TAdd(SocialMedya t)
        {
            _socialMedyaDal.Insert(t);
        }

        public void TDelete(SocialMedya t)
        {
            _socialMedyaDal.Delete(t);
        }

        public SocialMedya TGetByID(int id)
        {
            return _socialMedyaDal.GetByID(id);
        }

        public List<SocialMedya> TGetList()
        {
            return _socialMedyaDal.GetList();
        }

        public List<SocialMedya> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedya t)
        {
          _socialMedyaDal.Update(t);
        }
    }
}
