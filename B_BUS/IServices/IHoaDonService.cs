﻿using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(HoaDonViewModel obj);
        string Update(HoaDonViewModel obj);
        string Delete(HoaDonViewModel obj);
        List<HoaDonViewModel>? GetAll();
        HoaDonViewModel? GetByID(Guid id);
    }
}