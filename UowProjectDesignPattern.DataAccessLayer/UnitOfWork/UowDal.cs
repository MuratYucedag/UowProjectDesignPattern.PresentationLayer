using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowProjectDesignPattern.DataAccessLayer.Concrete;

namespace UowProjectDesignPattern.DataAccessLayer.UnitOfWork
{
    public class UowDal : IUowDal
    {
        Context _context = new Context();

        public UowDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
