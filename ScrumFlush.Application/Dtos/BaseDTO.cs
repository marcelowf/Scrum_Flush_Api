using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumFlush.Application.Dtos
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
