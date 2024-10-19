﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfVisaCategoryDal: EfEntityRepositoryBase<VisaCategory, KonsoloslukTakipContext>,IVisaCategoryDal
    {
    }
}