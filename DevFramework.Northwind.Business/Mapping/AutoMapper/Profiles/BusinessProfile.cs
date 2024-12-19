﻿using AutoMapper;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.Mapping.AutoMapper.Profiles
{
    public class BusinessProfile :Profile
    {
        public BusinessProfile()
        {
            CreateMap<Product, Product>();
        }
    }
}
