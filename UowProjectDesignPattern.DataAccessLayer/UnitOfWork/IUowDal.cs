﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowProjectDesignPattern.DataAccessLayer.UnitOfWork
{
    public interface IUowDal
    {
        void Save();
    }
}
