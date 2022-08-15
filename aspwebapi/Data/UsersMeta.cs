using System;
using System.Collections.Generic;

namespace aspwebapi.Data
{
    public partial class UsersMeta
    {
        public int Id { get; set; }
        public string MetaName { get; set; }
        public string MetaValue { get; set; }
        public long UserId { get; set; }

        public virtual Students User { get; set; }
    }
}
