﻿using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IDichVuService
    {
        bool Add(DichVuViewModel obj);
        bool Update(DichVuViewModel obj);
        bool Delete(Guid id);
        List<DichVuViewModel>? GetAll();
        DichVuViewModel? GetByID(Guid id);
    }
}