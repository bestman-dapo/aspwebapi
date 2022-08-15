using System;
using System.Collections.Generic;

namespace aspwebapi.Data
{
    public partial class Students
    {
        public Students()
        {
            UsersMeta = new HashSet<UsersMeta>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<UsersMeta> UsersMeta { get; set; }
    }
}
