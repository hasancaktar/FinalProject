﻿using Core.DataAccess;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{                                   //sen bir customer repositorysisin demek
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
