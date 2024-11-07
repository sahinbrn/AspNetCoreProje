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
	public class TestimonialManager : ITestimonialService
	{
		ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}
		public void TAdd(Testimonials t)
		{
			_testimonialDal.Insert(t);
		}

		public void TDelete(Testimonials t)
		{
			_testimonialDal.Delete(t);	
		}

		public Testimonials TGetByID(int id)
		{
			return _testimonialDal.GetByID(id);
		}

		public List<Testimonials> TGetList()
		{
			return _testimonialDal.GetList();
		}

        public List<Testimonials> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonials t)
		{
			_testimonialDal.Update(t);
		}
	}
}
