using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IYeuCauService
    {
        string Add(YeuCauViewModel obj);
        string Update(YeuCauViewModel obj);
        string Delete(YeuCauViewModel obj);
        List<YeuCauViewModel>? GetAll();
        YeuCauViewModel? GetByID(Guid id);
    }
}