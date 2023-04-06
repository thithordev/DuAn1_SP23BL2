using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class BaseModel : IEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
