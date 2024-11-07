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
    public class FeatureManager : IGenericService<Features>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Features t)
        {
           _featureDal.Insert(t);
        }

        public void TDelete(Features t)
        {
            _featureDal.Delete(t);
        }


        public List<Features> TGetList()
        {
            return _featureDal.GetList();
        }
        public Features TGetByID(int id)
        {
           return  _featureDal.GetByID(id);
        }

        public void TUpdate(Features t)
        {
            _featureDal.Update(t);
        }

        public List<Features> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
