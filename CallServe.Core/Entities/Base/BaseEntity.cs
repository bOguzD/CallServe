using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallServe.Core.Entities.Base
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public long? CreatedUserId { get; set; }

        public long? UpdatedUserId { get; set; }
    }
}
