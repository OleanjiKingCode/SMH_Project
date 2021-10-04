using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMH_Project.Models
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateOn { get; set; }
        public string UpdateBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
