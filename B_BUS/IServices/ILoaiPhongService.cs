using A_DAL.Models;
using B_BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ILoaiPhongService
    {
        bool Add(LoaiPhongViewModel obj);
        bool Update(LoaiPhongViewModel obj);
        bool Delete(Guid id);
        List<LoaiPhongViewModel>? GetAll();
        LoaiPhongViewModel? GetByID(Guid id);
    }
}