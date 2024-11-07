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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;


        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skills t)
        {
           _skillDal.Insert(t);
        }

        public void TDelete(Skills t)
        {
            _skillDal.Delete(t);
        }

        public Skills TGetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public List<Skills> TGetList()
        {
           return _skillDal.GetList();
        }

        public List<Skills> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skills t)
        {
            _skillDal.Update(t);
        }
    }
}
