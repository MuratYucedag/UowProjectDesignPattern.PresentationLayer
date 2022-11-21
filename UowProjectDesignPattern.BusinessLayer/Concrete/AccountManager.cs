using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowProjectDesignPattern.BusinessLayer.Abstract;
using UowProjectDesignPattern.DataAccessLayer.Abstract;
using UowProjectDesignPattern.DataAccessLayer.UnitOfWork;
using UowProjectDesignPattern.EntityLayer.Concrete;

namespace UowProjectDesignPattern.BusinessLayer.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUowDal _uowDal;

        public AccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public void TDelete(Account t)
        {
            throw new NotImplementedException();
        }

        public Account TGetByID(int id)
        {
            return _accountDal.GetByID(id);
        }

        public List<Account> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Account t)
        {
            throw new NotImplementedException();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Account t)
        {
            throw new NotImplementedException();
        }
    }
}
