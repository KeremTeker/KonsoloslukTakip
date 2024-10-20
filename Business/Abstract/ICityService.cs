﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface ICityService
    {
        List<City> GetAll();
        City GetById(int cityId);
    }
}
