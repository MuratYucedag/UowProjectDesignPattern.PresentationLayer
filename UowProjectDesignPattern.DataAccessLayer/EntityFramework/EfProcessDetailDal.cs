using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowProjectDesignPattern.DataAccessLayer.Abstract;
using UowProjectDesignPattern.DataAccessLayer.Concrete;
using UowProjectDesignPattern.DataAccessLayer.Repository;
using UowProjectDesignPattern.EntityLayer.Concrete;

namespace UowProjectDesignPattern.DataAccessLayer.EntityFramework
{
    public class EfProcessDetailDal : GenericRepository<ProcessDetail>, IProcessDetailDal
    {
        public EfProcessDetailDal(Context context) : base(context)
        {

        }
    }
}
