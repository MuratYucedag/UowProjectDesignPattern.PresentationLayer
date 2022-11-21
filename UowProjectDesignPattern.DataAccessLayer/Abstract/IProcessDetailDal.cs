using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowProjectDesignPattern.EntityLayer.Concrete;

namespace UowProjectDesignPattern.DataAccessLayer.Abstract
{
    public interface IProcessDetailDal : IGenericDal<ProcessDetail>
    {
    }
}
