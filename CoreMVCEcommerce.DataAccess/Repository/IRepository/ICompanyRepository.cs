﻿using System;
using System.Collections.Generic;
using System.Text;
using CoreMVCEcommerce.Models;


namespace CoreMVCEcommerce.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company company);

    }
}
